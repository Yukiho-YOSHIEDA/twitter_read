using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitterRead.model
{
    /// <summary>
    /// 設定ファイルを読み込むためのクラスです
    /// </summary>
    [DataContract]
    public class Setting
    {
        [DataMember(Name = "consumer_key")]
        public String ConsumerKey { get; set; }

        [DataMember(Name = "consumer_secret")]
        public String ConsumerSecret { get; set; }
    }
}
