namespace SWII_Creator
{
    partial class BNF_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BNF_Create));
            this.listViewBNF = new System.Windows.Forms.ListView();
            this.codeGenbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewBNF
            // 
            this.listViewBNF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBNF.Location = new System.Drawing.Point(13, 13);
            this.listViewBNF.Name = "listViewBNF";
            this.listViewBNF.Size = new System.Drawing.Size(469, 268);
            this.listViewBNF.TabIndex = 0;
            this.listViewBNF.UseCompatibleStateImageBehavior = false;
            // 
            // codeGenbutton
            // 
            this.codeGenbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.codeGenbutton.Location = new System.Drawing.Point(342, 296);
            this.codeGenbutton.Name = "codeGenbutton";
            this.codeGenbutton.Size = new System.Drawing.Size(139, 23);
            this.codeGenbutton.TabIndex = 1;
            this.codeGenbutton.Text = "大雑把にコード生成(&G)";
            this.codeGenbutton.UseVisualStyleBackColor = true;
            this.codeGenbutton.Click += new System.EventHandler(this.codeGenbutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(211, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "正規表現で解説(&A)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BNF_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeGenbutton);
            this.Controls.Add(this.listViewBNF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(510, 370);
            this.Name = "BNF_Create";
            this.Text = "BNFの確認";
            this.Load += new System.EventHandler(this.BNF_Create_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBNF;
        private System.Windows.Forms.Button codeGenbutton;
        private System.Windows.Forms.Button button1;
    }
}