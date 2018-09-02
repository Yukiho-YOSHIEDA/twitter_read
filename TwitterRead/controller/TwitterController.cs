using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterRead.model;
using CoreTweet;
using CoreTweet.Core;
using static CoreTweet.OAuth;
using System.Windows.Forms;

namespace TwitterRead.controller
{
    /// <summary>
    /// Twitterに関連するクラスです。
    /// </summary>
    public class TwitterController
    {
        model.Setting setting = null;
        OAuthSession session = null;
        Tokens tokens = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TwitterController()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="setting"></param>
        public TwitterController(model.Setting setting)
        {
            this.setting = setting;
        }

        public void Authorize()
        {
            session = OAuth.Authorize(setting.ConsumerKey, setting.ConsumerSecret);
            System.Diagnostics.Process.Start(session.AuthorizeUri.AbsoluteUri);
        }

        public void GetToken(String pin)
        {
            tokens = session.GetTokens(pin);
        }

        /// <summary>
        /// テスト用
        /// </summary>
        public void GetTweet()
        {
            if(tokens != null)
            {
                String tweetComment = "";

                var tweets = tokens.Statuses.UserTimeline(tokens.UserId, 10);
                foreach(var tweet in tweets)
                {
                    tweetComment = tweet.Text;
                }

                MessageBox.Show(tweetComment, "結果", MessageBoxButtons.OK);
            }
        }
    }
}
