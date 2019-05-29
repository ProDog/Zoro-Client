using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoro;
using Zoro.Ledger;
using Zoro.Persistence.LevelDB;
using Zoro.Wallets;
using Zoro.Wallets.NEP6;
using Zoro_Client.Properties;

namespace Zoro_Client.UI
{
    public partial class MainForm : Form
    {
        private const string PeerStatePath = "peers.dat";

        private LevelDBStore store;
        private ZoroChainSystem system;
        private AppChainService appchainService;

        public MainForm()
        {
            InitializeComponent();
            appchainService = new AppChainService();
        }        

        private void 创建钱包数据库NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateWalletDialog dialog = new CreateWalletDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                NEP6Wallet wallet = new NEP6Wallet(dialog.WalletPath, null);
                wallet.Unlock(dialog.Password);
                WalletAccount account = wallet.CreateAccount();
                wallet.Save();               
                Settings.Default.LastWalletPath = dialog.WalletPath;
                Settings.Default.Save();

                Program.Wallet = wallet;
                ZoroChainSystem.Singleton.SetWallet(Program.Wallet);
            }

        }

        private static bool NoWallet()
        {
            if (Program.Wallet != null) return false;
            Console.WriteLine("You have to open the wallet first.");
            return true;
        }

        private void 打开钱包数据库OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenWalletDialog dialog = new OpenWalletDialog())
            {
                if (dialog.ShowDialog() != DialogResult.OK) return;
                string path = dialog.WalletPath;

                NEP6Wallet nep6wallet = new NEP6Wallet(dialog.WalletPath, null);
                try
                {
                    nep6wallet.Unlock(dialog.Password);
                }
                catch (CryptographicException)
                {
                    MessageBox.Show(Strings.PasswordIncorrect);
                    return;
                }
                Program.Wallet = nep6wallet;

                Settings.Default.LastWalletPath = path;
                Settings.Default.Save();

                ChangeWallet(Program.Wallet);
            }
        }

        private void ChangeWallet(Wallet wallet)
        {
            if (Program.Wallet != null)
            {
                foreach (WalletAccount account in Program.Wallet.GetAccounts().ToArray())
                {
                    AddAccount(account);
                }

                if (Program.Wallet is IDisposable disposable)
                    disposable.Dispose();
            }
            Program.Wallet = wallet;

            if (Program.Wallet != null)
            {
            }
        }

        private void AddAccount(WalletAccount account, bool selected = false)
        {
            AccountFrm accountFrm = new AccountFrm(account.Address);
            accountFrm.Parent = tabPage1;
            accountFrm.Dock = DockStyle.Top;
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void 修改密码CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //using (ChangePasswordDialog dialog = new ChangePasswordDialog())
            //{
            //    if (dialog.ShowDialog() != DialogResult.OK) return;
            //    if (((UserWallet)Program.CurrentWallet).ChangePassword(dialog.OldPassword, dialog.NewPassword))
            //        MessageBox.Show(Strings.ChangePasswordSuccessful);
            //    else
            //        MessageBox.Show(Strings.PasswordIncorrect);
            //}
        }
    }
}
