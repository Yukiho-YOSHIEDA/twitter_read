using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace TwitterRead.model
{
    /// <summary>
    /// アクセストークンを管理するクラスです
    /// </summary>
    [DataContract]
    class AccessTokens
    {
        [DataMember(Name = "access_token")]
        public String AccessToken { get; set; }

        [DataMember(Name = "access_token_secret")]
        public String AccessTokenSecret { get; set; }
    }
}