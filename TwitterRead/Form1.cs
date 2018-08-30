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

            settingController = new SettingController(new Setting());
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
    }
}
