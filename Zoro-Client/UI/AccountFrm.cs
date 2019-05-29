using System;
using System.Windows.Forms;
using Zoro;
using Zoro.Ledger;
using Neo.VM;
using Zoro.Network.RPC;
using Newtonsoft.Json.Linq;

namespace Zoro_Client.UI
{
    public partial class AccountFrm : UserControl
    {
        public string Address;
        private RpcHandler handler = new RpcHandler();
        public AccountFrm()
        {
            InitializeComponent();
        }
        public AccountFrm(string address)
        {
            InitializeComponent();
            lblAddress.Text = address;
            Address = address;
        }

        private void LblAddress_TextChanged(object sender, EventArgs e)
        {
            Address = lblAddress.Text;
            GetBalance();
        }

        private void GetBalance()
        {
            UInt160 addressHash= ZoroHelper.GetPublicKeyHashFromAddress(Address);
            try
            {
                UInt160 bcpAssetId = Genesis.BcpContractAddress;
                UInt160 bctAssetId = Genesis.BctContractAddress;

                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "BalanceOf", bcpAssetId, addressHash);
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "Decimals", bcpAssetId);

                    var script = sb.ToArray().ToHexString();
                    Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                    _params.Add("");
                    _params.Add(script);

                    var info = handler.Process("invokescript", _params);
                    var value = GetBalanceFromJson(info.ToString());

                    lblBcp.Text = value;

                }

                using (ScriptBuilder sb = new ScriptBuilder())
                {
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "BalanceOf", bctAssetId, addressHash);
                    sb.EmitSysCall("Zoro.NativeNEP5.Call", "Decimals", bctAssetId);

                    var script = sb.ToArray().ToHexString();
                    Zoro.IO.Json.JArray _params = new Zoro.IO.Json.JArray();
                    _params.Add("");
                    _params.Add(script);

                    var info = handler.Process("invokescript", _params);
                    var value = GetBalanceFromJson(info.ToString());

                    lblBct.Text = value;

                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取余额出错！" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private string GetBalanceFromJson(string info)
        {
            string result = "";
            JObject json = JObject.Parse(info);

            if (json.ContainsKey("result"))
            {
                JObject json_result = json["result"] as JObject;
                JArray stack = json_result["stack"] as JArray;

                if (stack != null && stack.Count >= 2)
                {
                    string balance = ZoroHelper.GetJsonValue(stack[0] as JObject);
                    string decimals = ZoroHelper.GetJsonValue(stack[1] as JObject);

                    Decimal value = Decimal.Parse(balance) / new Decimal(Math.Pow(10, int.Parse(decimals)));
                    string fmt = "{0:N" + decimals + "}";
                    result = string.Format(fmt, value);
                }
            }
            else if (json.ContainsKey("error"))
            {
                JObject json_error_obj = json["error"] as JObject;
                result = json_error_obj.ToString();
            }

            return result;
        }
    }


}
