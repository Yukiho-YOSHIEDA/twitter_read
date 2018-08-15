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

namespace TwitterRead
{
    public partial class Form1 : Form
    {
        private TcpClient tc = null;
        private NetworkStream ns = null;
        private BinaryWriter bw = null;

        public Form1()
        {
            InitializeComponent();

            btn_connect.Click += connect;
            btn_send.Click += playTest;
            btn_disconnect.Click += disconnect;

            btn_send.Enabled = false;
            btn_disconnect.Enabled = false;
        }

        private void connect(object sender, EventArgs e)
        {
            //棒読みちゃんのTCPサーバへ接続
            string sHost = "127.0.0.1"; //棒読みちゃんが動いているホスト
            int iPort = 50001;       //棒読みちゃんのTCPサーバのポート番号(デフォルト値)
            try
            {
                tc = new TcpClient(sHost, iPort);
                ns = tc.GetStream();
                bw = new BinaryWriter(ns);
            }
            catch (Exception)
            {
                Console.WriteLine("接続失敗");
            }

            btn_connect.Enabled = false;
            btn_send.Enabled = true;
            btn_disconnect.Enabled = true;
        }

        private void disconnect(object sender, EventArgs e)
        {
            if(tc != null)
            {
                //切断
                tc.Close();

                tc = null;

                btn_connect.Enabled = true;
                btn_send.Enabled = false;
                btn_disconnect.Enabled = false;
            }
        }

        private void playTest(object sender, EventArgs e)
        {
            string sMessage = "テストだよ";
            byte bCode = 0;
            Int16 iVoice = 1;
            Int16 iVolume = -1;
            Int16 iSpeed = -1;
            Int16 iTone = -1;
            Int16 iCommand = 0x0001;

            byte[] bMessage = Encoding.UTF8.GetBytes(sMessage);
            Int32 iLength = bMessage.Length;

            if (tc != null)
            {
                //メッセージ送信
                try
                {
                    bw.Write(iCommand); //コマンド（ 0:メッセージ読み上げ）
                    bw.Write(iSpeed);   //速度    （-1:棒読みちゃん画面上の設定）
                    bw.Write(iTone);    //音程    （-1:棒読みちゃん画面上の設定）
                    bw.Write(iVolume);  //音量    （-1:棒読みちゃん画面上の設定）
                    bw.Write(iVoice);   //声質    （ 0:棒読みちゃん画面上の設定、1:女性1、2:女性2、3:男性1、4:男性2、5:中性、6:ロボット、7:機械1、8:機械2、10001～:SAPI5）
                    bw.Write(bCode);    //文字列のbyte配列の文字コード(0:UTF-8, 1:Unicode, 2:Shift-JIS)
                    bw.Write(iLength);  //文字列のbyte配列の長さ
                    bw.Write(bMessage); //文字列のbyte配列
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
