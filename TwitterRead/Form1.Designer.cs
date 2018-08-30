namespace TwitterRead
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutholize = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.btnGetToken = new System.Windows.Forms.Button();
            this.btnGetTweet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // btnAutholize
            // 
            this.btnAutholize.CausesValidation = false;
            this.btnAutholize.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAutholize.Location = new System.Drawing.Point(109, 104);
            this.btnAutholize.Name = "btnAutholize";
            this.btnAutholize.Size = new System.Drawing.Size(156, 74);
            this.btnAutholize.TabIndex = 1;
            this.btnAutholize.Text = "認証";
            this.btnAutholize.UseVisualStyleBackColor = true;
            this.btnAutholize.Click += new System.EventHandler(this.Autholize_Click);
            // 
            // tbPin
            // 
            this.tbPin.AccessibleDescription = "";
            this.tbPin.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPin.Location = new System.Drawing.Point(133, 55);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(304, 26);
            this.tbPin.TabIndex = 2;
            // 
            // btnGetToken
            // 
            this.btnGetToken.CausesValidation = false;
            this.btnGetToken.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGetToken.Location = new System.Drawing.Point(306, 104);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(156, 74);
            this.btnGetToken.TabIndex = 1;
            this.btnGetToken.Text = "Token取得";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.BtnGetToken_Click);
            // 
            // btnGetTweet
            // 
            this.btnGetTweet.CausesValidation = false;
            this.btnGetTweet.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGetTweet.Location = new System.Drawing.Point(208, 212);
            this.btnGetTweet.Name = "btnGetTweet";
            this.btnGetTweet.Size = new System.Drawing.Size(156, 74);
            this.btnGetTweet.TabIndex = 1;
            this.btnGetTweet.Text = "Tweet取得";
            this.btnGetTweet.UseVisualStyleBackColor = true;
            this.btnGetTweet.Click += new System.EventHandler(this.BtnGetTweet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.btnGetToken);
            this.Controls.Add(this.btnGetTweet);
            this.Controls.Add(this.btnAutholize);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.Button btnAutholize;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.Button btnGetTweet;
    }
}

