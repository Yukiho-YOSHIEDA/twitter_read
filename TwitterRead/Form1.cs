using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterRead.controller;
using TwitterRead.model;

namespace TwitterRead
{
    public partial class Form1 : Form
    {

        private SettingController settingController;
        private TwitterController twitterController;

        public Form1()
        {
            InitializeComponent();

            settingController = new SettingController(new Setting(), new Users
            {
                UserNames = new List<string>()
            });
            settingController.Road();

            twitterController = new TwitterController(settingController.KeySetting);
        }

        private void Autholize_Click(object sender, EventArgs e)
        {
            twitterController.Authorize();
        }

        private void BtnGetToken_Click(object sender, EventArgs e)
        {
            twitterController.GetToken(tbPin.Text);
        }

        private void BtnGetTweet_Click(object sender, EventArgs e)
        {
            twitterController.GetTweet();
        }

        /// <summary>
        /// ツールバーの認証が押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsmiAthorize_Click(object sender, EventArgs e)
        {
            var result =  MessageBox.Show(
                "認証をするために既定のブラウザが起動します。\n"
                + "既定のブラウザでTwitterにログインしている場合は\n"
                + "ログアウトしてください。",
                "確認", MessageBoxButtons.OKCancel);

            // キャンセルが押されたときは
            if (result.Equals(DialogResult.Cancel))
            {
                return;
            }

            twitterController.Authorize();

        }
    }
}
