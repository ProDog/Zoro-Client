using System;
using System.Windows.Forms;
using Zoro;
using Zoro.Ledger;
using Neo.VM;
using Zoro.Network.RPC;
using Newtonsoft.Json.Linq;
using Zoro.Wallets;
using System.Runtime.InteropServices;
using Zoro_Client.Properties;
using System.Linq;
using Zoro.Wallets.NEP6;

namespace Zoro_Client.UI
{
    public partial class AccountFrm : UserControl
    {
        public string Address;
        public WalletAccount Account;
        private RpcHandler handler = new RpcHandler();
        public AccountFrm()
        {
            InitializeComponent();
        }
        public AccountFrm(WalletAccount account)
        {
            InitializeComponent();
            Account = account;
            lblAddress.Text = account.Address;
            Address = account.Address;
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

        private void 查看私钥VToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            using (ViewPrivateKeyDialog dialog = new ViewPrivateKeyDialog(Account))
            {
                dialog.ShowDialog();
            }
        }

        private void 复制到剪贴板CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(Address);
            }
            catch (ExternalException) { }
        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Strings.DeleteAddressConfirmationMessage, Strings.DeleteAddressConfirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            Program.Wallet.DeleteAccount(Account.ScriptHash);
            
            if (Program.Wallet is NEP6Wallet wallet)
                wallet.Save();
            this.Dispose();
        }
    }


}
