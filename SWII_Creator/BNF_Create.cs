using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; 

namespace SWII_Creator
{
    public partial class BNF_Create : Form
    {
        private String strBNF;
        public BNF_Create(String str)
        {
            strBNF=str;
            InitializeComponent();
        }

        private ArrayList mBNFItem;
  
        private void BNF_Create_Load(object sender, EventArgs e)
        {
            listViewBNF.View = View.Details;
            listViewBNF.Columns.Add("非終端記号");
            listViewBNF.Columns.Add(" ");
            listViewBNF.Columns.Add("定義");

            System.Text.RegularExpressions.Regex
            r = new System.Text.RegularExpressions.Regex("\r?\n");
            strBNF = r.Replace(strBNF, "\n");

            string[] lines = strBNF.Split('\n');

            mBNFItem = new ArrayList();

            foreach (String itemBNF in lines)
            {
                int index = itemBNF.IndexOf(" ::= ");
                if (index >= 0)
                {
                    String title = itemBNF.Substring(0, index);
                    String[] row = { title, "::=", itemBNF.Substring(index + " ::= ".Length) };
                    mBNFItem.Add(row);

                    listViewBNF.Items.Add(new ListViewItem(row));
                }
            }

            //すべての列を自動調節
            listViewBNF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if (mBNFItem.Count == 0) {
                codeGenbutton.Enabled = false;
                button1.Enabled = false;
            }else{
                listViewBNF.Items[0].Selected = true;
            }
    }


        private void codeGenbutton_Click(object sender, EventArgs e)
        {
            if (codeGenbutton.Enabled == false) {
                return;
            }
            codeGenbutton.Enabled = false;

            CompleteFile fin = new CompleteFile();
            fin.ShowDialog();
          
            CreateFile cf = new CreateFile(mBNFItem);
            cf.createFile();

        
            codeGenbutton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idx = 0;
            if (listViewBNF.SelectedItems.Count > 0)
            {

                idx = listViewBNF.SelectedItems[0].Index;

                String[] bnfStr = ((String[])mBNFItem[idx]);
                String bnfline = bnfStr[0] + " " + bnfStr[1] + " " + bnfStr[2];

                String regulexLine = "("+bnfStr[2].Replace(" ",")(")+")";

                regulexLine = regulexLine.Replace("([)", "(");
                regulexLine = regulexLine.Replace("(])", ")?");

                regulexLine = regulexLine.Replace("({)", "(");
                regulexLine = regulexLine.Replace("(})", ")*");

                regulexLine = regulexLine.Replace("(()", "(");
                regulexLine = regulexLine.Replace("())", ")");

                regulexLine = regulexLine.Replace("(|)", "|");
                regulexLine = regulexLine.Replace("()","");
                MessageBox.Show(
                    bnfline + "\nEBNFを正規表現で表した図解サイトへ飛びます.",
                   "正規表現をサイトで確認する",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );

                System.Diagnostics.Process.Start("http://jex.im/regulex/#!embed=false&flags=&re=" + regulexLine);
            }
            else {
                MessageBox.Show(
            "確認したいBNFをリストから選択してください.",
                 "BNFの選択",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.None
                  );
            }
        }
    }
}
