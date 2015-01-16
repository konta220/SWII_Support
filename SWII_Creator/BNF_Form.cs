using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWII_Creator
{
    public partial class BNF_Form : Form
    {
        public BNF_Form()
        {
            InitializeComponent();
        }

        private void eBNF_TextBox_TextChanged(object sender, EventArgs e)
        {
            String eBNFtext = eBNF_TextBox.Text;
            eBNF_Result_setText(parseText(eBNFtext));
        }

        private String parseText(String str) {

            str = str.Replace("\t"," ");
            str = str.Replace("　", " ");

            str = str.Replace("|", " | ");

            str = str.Replace("(", " ( ");
            str = str.Replace(")", " ) ");

            str = str.Replace("{", " { ");
            str = str.Replace("}", " } ");

            str = str.Replace("[", " [ ");
            str = str.Replace("]", " ] ");

            str = str.Replace("::=", " ::= ");


            System.Text.RegularExpressions.Regex 
                r = new System.Text.RegularExpressions.Regex(@"[ 　\t]+(?=\r?\n|$)");
            str = r.Replace(str, "");

            r = new System.Text.RegularExpressions.Regex("[ ]+");
            str = r.Replace(str, " ");
           
            r = new System.Text.RegularExpressions.Regex("\r?\n[\r?\n]+");
            str = r.Replace(str, "\r\n");

            return str;
        }

        private String strRawData;
        private void eBNF_Result_setText(String setStr)
        {
            eBNF_ResultTextBox.Text = (strRawData=setStr);
            
            groupResultBox.Enabled = true;
            compileMessage.Text = "解析結果が正しければBNF確認をクリック";
            compileMessage.Font = new Font(compileMessage.Font, FontStyle.Regular);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            eBNF_TextBox.Text = "";

            this.eBNF_TextBox.Focus();

            groupResultBox.Enabled = false;
            compileMessage.Text = "BNFを記述してください";
            compileMessage.Font= new Font(compileMessage.Font,FontStyle.Bold);
        }

        private void coronButton_Click(object sender, EventArgs e)
        {
            eBNF_TextBox.SelectedText = " ::= ";
            this.eBNF_TextBox.Focus();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            BNF_Create frm = new BNF_Create(strRawData);
            frm.Show();
        }

        private void BNF_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
