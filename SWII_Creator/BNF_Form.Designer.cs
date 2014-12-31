namespace SWII_Creator
{
    partial class BNF_Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BNF_Form));
            this.createButton = new System.Windows.Forms.Button();
            this.eBNF_ResultTextBox = new System.Windows.Forms.TextBox();
            this.groupResultBox = new System.Windows.Forms.GroupBox();
            this.compileMessage = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupEditBox = new System.Windows.Forms.GroupBox();
            this.coronButton = new System.Windows.Forms.Button();
            this.eBNF_TextBox = new System.Windows.Forms.TextBox();
            this.groupResultBox.SuspendLayout();
            this.groupEditBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.Location = new System.Drawing.Point(415, 169);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(125, 21);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "BNF確認";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // eBNF_ResultTextBox
            // 
            this.eBNF_ResultTextBox.AcceptsTab = true;
            this.eBNF_ResultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eBNF_ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBNF_ResultTextBox.Location = new System.Drawing.Point(6, 18);
            this.eBNF_ResultTextBox.Multiline = true;
            this.eBNF_ResultTextBox.Name = "eBNF_ResultTextBox";
            this.eBNF_ResultTextBox.ReadOnly = true;
            this.eBNF_ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.eBNF_ResultTextBox.Size = new System.Drawing.Size(534, 145);
            this.eBNF_ResultTextBox.TabIndex = 3;
            // 
            // groupResultBox
            // 
            this.groupResultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupResultBox.Controls.Add(this.eBNF_ResultTextBox);
            this.groupResultBox.Controls.Add(this.createButton);
            this.groupResultBox.Enabled = false;
            this.groupResultBox.Location = new System.Drawing.Point(15, 234);
            this.groupResultBox.Name = "groupResultBox";
            this.groupResultBox.Size = new System.Drawing.Size(557, 196);
            this.groupResultBox.TabIndex = 6;
            this.groupResultBox.TabStop = false;
            this.groupResultBox.Text = "構文解析結果(簡易)";
            // 
            // compileMessage
            // 
            this.compileMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compileMessage.AutoSize = true;
            this.compileMessage.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.compileMessage.Location = new System.Drawing.Point(7, 195);
            this.compileMessage.Name = "compileMessage";
            this.compileMessage.Size = new System.Drawing.Size(124, 12);
            this.compileMessage.TabIndex = 4;
            this.compileMessage.Text = "BNFを記述してください";
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(418, 191);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(125, 21);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "すべて消去";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupEditBox
            // 
            this.groupEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupEditBox.Controls.Add(this.compileMessage);
            this.groupEditBox.Controls.Add(this.coronButton);
            this.groupEditBox.Controls.Add(this.refreshButton);
            this.groupEditBox.Controls.Add(this.eBNF_TextBox);
            this.groupEditBox.Location = new System.Drawing.Point(12, 11);
            this.groupEditBox.Name = "groupEditBox";
            this.groupEditBox.Size = new System.Drawing.Size(557, 218);
            this.groupEditBox.TabIndex = 7;
            this.groupEditBox.TabStop = false;
            this.groupEditBox.Text = "EBNF記述";
            // 
            // coronButton
            // 
            this.coronButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.coronButton.Location = new System.Drawing.Point(287, 191);
            this.coronButton.Name = "coronButton";
            this.coronButton.Size = new System.Drawing.Size(125, 21);
            this.coronButton.TabIndex = 6;
            this.coronButton.Text = "『 ::= (定義)』を入力";
            this.coronButton.UseVisualStyleBackColor = true;
            this.coronButton.Click += new System.EventHandler(this.coronButton_Click);
            // 
            // eBNF_TextBox
            // 
            this.eBNF_TextBox.AcceptsTab = true;
            this.eBNF_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eBNF_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eBNF_TextBox.Location = new System.Drawing.Point(6, 18);
            this.eBNF_TextBox.Multiline = true;
            this.eBNF_TextBox.Name = "eBNF_TextBox";
            this.eBNF_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.eBNF_TextBox.Size = new System.Drawing.Size(534, 167);
            this.eBNF_TextBox.TabIndex = 3;
            this.eBNF_TextBox.TextChanged += new System.EventHandler(this.eBNF_TextBox_TextChanged);
            // 
            // BNF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.groupEditBox);
            this.Controls.Add(this.groupResultBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "BNF_Form";
            this.Text = "BNF記述";
            this.groupResultBox.ResumeLayout(false);
            this.groupResultBox.PerformLayout();
            this.groupEditBox.ResumeLayout(false);
            this.groupEditBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox eBNF_ResultTextBox;
        private System.Windows.Forms.GroupBox groupResultBox;
        private System.Windows.Forms.GroupBox groupEditBox;
        private System.Windows.Forms.TextBox eBNF_TextBox;
        private System.Windows.Forms.Label compileMessage;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button coronButton;
    }
}

