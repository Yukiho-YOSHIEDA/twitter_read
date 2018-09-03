using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TwitterRead.model
{
    /// <summary>
    /// 1つのツイートを管理するクラスです
    /// </summary>
    class Tweet
    {
        public DateTime CreateAt { get; set; }

        public String Name { get; set; }

        public String ScreenName { get; set; }

        public String TweetText { get; set; }

    }
}
