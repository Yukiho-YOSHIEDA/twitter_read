namespace TwitterRead.view
{
    partial class FormAthorize
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lPinCode = new System.Windows.Forms.Label();
            this.tbPinCode = new System.Windows.Forms.TextBox();
            this.bAuthorize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPinCode
            // 
            this.lPinCode.AutoSize = true;
            this.lPinCode.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lPinCode.Location = new System.Drawing.Point(46, 53);
            this.lPinCode.Name = "lPinCode";
            this.lPinCode.Size = new System.Drawing.Size(81, 19);
            this.lPinCode.TabIndex = 0;
            this.lPinCode.Text = "PINコード";
            // 
            // tbPinCode
            // 
            this.tbPinCode.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPinCode.Location = new System.Drawing.Point(50, 86);
            this.tbPinCode.Name = "tbPinCode";
            this.tbPinCode.Size = new System.Drawing.Size(181, 26);
            this.tbPinCode.TabIndex = 1;
            // 
            // bAuthorize
            // 
            this.bAuthorize.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bAuthorize.Location = new System.Drawing.Point(98, 161);
            this.bAuthorize.Name = "bAuthorize";
            this.bAuthorize.Size = new System.Drawing.Size(75, 29);
            this.bAuthorize.TabIndex = 2;
            this.bAuthorize.Text = "認証";
            this.bAuthorize.UseVisualStyleBackColor = true;
            this.bAuthorize.Click += new System.EventHandler(this.BAuthorize_Click);
            // 
            // FormAthorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bAuthorize);
            this.Controls.Add(this.tbPinCode);
            this.Controls.Add(this.lPinCode);
            this.Name = "FormAthorize";
            this.Text = "認証";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPinCode;
        private System.Windows.Forms.TextBox tbPinCode;
        private System.Windows.Forms.Button bAuthorize;
    }
}