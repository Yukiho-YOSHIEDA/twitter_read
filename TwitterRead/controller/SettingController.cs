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
        public Users Users { get; set; }

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
        public SettingController(Setting setting, Users users)
        {
            KeySetting = setting;
            Users = users;
        }

        /// <summary>
        /// 設定ファイルをロードします
        /// </summary>
        public void Road()
        {
            String tokenDirectoryPath = @".token";

            String settingFilePath = @"settings.json";
            String usersFilePath = @".token\users.json";

            try
            {
                // 必要なディレクトリチェック
                if (!Directory.Exists(tokenDirectoryPath))
                {
                    var info = Directory.CreateDirectory(tokenDirectoryPath);
                    // 隠し属性を追加
                    info.Attributes |= FileAttributes.Hidden;
                }

                if (!File.Exists(settingFilePath))
                {
                    InitFile<Setting>(settingFilePath);
                }

                if (!File.Exists(usersFilePath))
                {
                    InitFile<Users>(usersFilePath);
                }

                KeySetting = ParseJsonToModel<Setting>(settingFilePath);
                Users = ParseJsonToModel<Users>(usersFilePath);
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

        /// <summary>
        /// 設定ファイルを初期化します。
        /// </summary>
        private void InitFile<Type>(String filePath) where Type : new()
        {
            try
            {
                ParseModelToJson(filePath, new Type());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            
        }

        /// <summary>
        /// JSONファイルをmodelクラスにパースします
        /// </summary>
        /// <param name="parh"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        private Type ParseJsonToModel<Type>(String parh)
        {
            var fileStream = new FileStream(parh, FileMode.OpenOrCreate);

            var serializer = new DataContractJsonSerializer(typeof(Type));
            return (Type)serializer.ReadObject(fileStream);
        }

        /// <summary>
        /// modelクラスをJSONファイルにパースします
        /// </summary>
        /// <typeparam name="Type"></typeparam>
        /// <param name="path"></param>
        private void ParseModelToJson<Type>(String path, Type type) where Type : new()
        {
            var fileStream = new FileStream(path, FileMode.CreateNew);
            var serializer = new DataContractJsonSerializer(typeof(Type));
            serializer.WriteObject(fileStream, type);
            fileStream.Flush();

            fileStream.Dispose();
        }
    }
}
