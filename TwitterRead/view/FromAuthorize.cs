using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterRead.controller;
using System.Text.RegularExpressions;

namespace TwitterRead.view
{
    public partial class FormAthorize : Form
    {
        private TwitterController twitterController;

        public FormAthorize()
        {
            InitializeComponent();
        }

        public FormAthorize(TwitterController twitterController)
        {
            InitializeComponent();
            this.twitterController = twitterController;
        }

        private void BAuthorize_Click(object sender, EventArgs e)
        {
            var pinCode = tbPinCode.Text;

            // PINコードのValidation
            if (!Regex.IsMatch(pinCode, @"\d+"))
            {
                MessageBox.Show("不正なPINコードです", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            twitterController.GetToken(pinCode);

            this.Close();
        }
    }
}
