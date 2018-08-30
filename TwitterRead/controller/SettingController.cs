using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitterRead.model;

namespace TwitterRead.controller
{
    class SettingController
    {
        public Setting KeySetting { get; set; }

        String filePath = @"settings.json";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SettingController()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="setting"></param>
        public SettingController(Setting setting)
        {
            this.KeySetting = setting;
        }

        /// <summary>
        /// 設定ファイルをロードします
        /// </summary>
        public void Road()
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    InitSettingFile();
                }

                var fileStream = new FileStream(filePath, FileMode.OpenOrCreate);

                var serializer = new DataContractJsonSerializer(typeof(Setting));
                KeySetting = (Setting)serializer.ReadObject(fileStream);
            }
            catch (SerializationException)
            {
                MessageBox.Show("setting.iniが正しく読み込めませんでした。\n"
                    + "一度setting.iniを削除して再起動してください。",
                    "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private void InitSettingFile()
        {
            try
            {
                var setting = new Setting
                {
                    ConsumerKey = "",
                    ConsumerSecret = ""
                };

                var fileStream = new FileStream(filePath, FileMode.CreateNew);
                var serializer = new DataContractJsonSerializer(typeof(Setting));
                serializer.WriteObject(fileStream, setting);
                fileStream.Flush();

                fileStream.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

    }
}
