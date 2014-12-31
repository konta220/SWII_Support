using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace SWII_Creator
{
    class CreateFile
    {
        private const String header = "package lang.c.parse;\r\n\r\nimport java.io.PrintStream;\r\n\r\nimport lang.*;\r\nimport lang.c.*;";
        private String filePath;

        private ArrayList mBnfItem;

        public CreateFile(ArrayList bnfItem)
        {
            this.mBnfItem = bnfItem;
            filePath = @"./BNF_Java_" + DateTime.Now.ToString("MMdd_HHmmss");
        }


        public void createFile()
        {
            //フォルダを作る
            Directory.CreateDirectory(filePath);

            //BNFの個数分のファイルを作る
            foreach (String[] bnf in mBnfItem)
            {
                writeFile(bnf);
            }
            //エクスプローラーで開く
            openExplorer();
        }

        /// <summary>
        /// エクスプローラーで開く
        /// </summary>
        private void openExplorer()
        {
            // 相対パスから絶対パスを取得する
            string stFilePath = System.IO.Path.GetFullPath(filePath);
            //エクスプローラーで開く
            System.Diagnostics.Process.Start(stFilePath);
        }

        public String getFilePath()
        {
            return filePath;
        }

        /// <summary>
        /// 一行のBNFから一つのファイル生成
        /// </summary>
        /// <param name="bnf">BNFの構文</param>
        private void writeFile(String[] bnf)
        {
            if (bnf.Length != 3)//hoge ::= で3文字
            {
                return;
            }

            String title = char.ToUpper(bnf[0][0]) + bnf[0].Substring(1);//クラス名
            String message = bnf[2];
            String nodeMessage = replaceText(bnf[2]);

            System.Console.WriteLine(nodeMessage);

            String[] node = nodeMessage.Split(' ');


            // ファイルfile.txtを作成して開く
            using (FileStream stream = File.Create(filePath + "/" + title + ".java"))
            {
                // FileStreamに書き込むためのStreamWriterを作成
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writeJavaCodeGen(title, message, node, writer);
                }
            }
        }

        /// <summary>
        /// BNFを作る上での余分なテキストを除去する
        /// </summary>
        /// <param name="nodeMessage"></param>
        /// <returns></returns>

        private static string replaceText(String nodeMessage)
        {
            System.Text.RegularExpressions.Regex
            r = new System.Text.RegularExpressions.Regex(@"(\{|\})|(\[|\])|(\(|\))|(\|)");
            nodeMessage = r.Replace(nodeMessage, " ");
            r = new System.Text.RegularExpressions.Regex(@"(\s)+");
            nodeMessage = r.Replace(nodeMessage, " ");
            r = new System.Text.RegularExpressions.Regex(@"^(\s)+");
            nodeMessage = r.Replace(nodeMessage, "");
            return nodeMessage;
        }

        /// <summary>
        /// Javaのコードを生成する
        /// </summary>
        /// <param name="title">クラス名</param>
        /// <param name="message">BNFの定義</param>
        /// <param name="node">BNFの子ノード</param>
        /// <param name="writer">ファイル出力先</param>
        private static void writeJavaCodeGen(String title, String message, String[] node, StreamWriter writer)
        {
            // 文字列を書き込む

            //import編成
            writer.WriteLine(header);
            writer.WriteLine();

            //クラス文
            writer.WriteLine("public class " + title + " extends CParseRule {");
            writer.WriteLine("\t//" + title + " ::= " + message + "");

            //ローカル変数
            localValue_CParseRule(node, writer);

            //コンストラクタ生成
            writer.WriteLine("\tpublic " + title + "(CParseContext pcx) {");
            writer.WriteLine("\t}");

            //改行
            writer.WriteLine();

            //Fist集合
            isFirst_Code(node, writer);

            //改行
            writer.WriteLine();

            //構文解析
            parse_Code(node, writer);

            //改行
            writer.WriteLine();

            //型チェック
            semanticCheck_Code(node, writer);

            //改行
            writer.WriteLine();

            //コード生成部
            codeGen_Code(node, writer);

            //クラス閉じる" } "
            writer.WriteLine("}");
        }

        /// <summary>
        /// コード生成部
        /// </summary>
        /// <param name="node"></param>
        /// <param name="writer"></param>
        private static void codeGen_Code(String[] node, StreamWriter writer)
        {
            const String codeGen = "\tpublic void codeGen(CParseContext pcx) throws FatalErrorException {";
            writer.WriteLine(codeGen);
            foreach (String privateNode in node)
            {
                if (privateNode.Length <= 0)
                {
                    continue;
                }
                if (char.IsUpper(privateNode[0]) == false)
                {
                    writer.WriteLine("\t\tif(" + privateNode + " != null) {");
                    writer.WriteLine("\t\t\t" + privateNode + ".codeGen(pcx);");
                    writer.WriteLine("\t\t" + "}");
                }
            }
            writer.WriteLine("\t" + "}");
        }

        /// <summary>
        /// 型チェック
        /// </summary>
        /// <param name="node"></param>
        /// <param name="writer"></param>
        private static void semanticCheck_Code(String[] node, StreamWriter writer)
        {
            const String semanticCheck = "\tpublic void semanticCheck(CParseContext pcx) throws FatalErrorException {";
            writer.WriteLine(semanticCheck);
            foreach (String privateNode in node)
            {
                if (privateNode.Length <= 0)
                {
                    continue;
                }

                if (char.IsUpper(privateNode[0]) == false)
                {
                    writer.WriteLine("\t\tif(" + privateNode + " != null) {");
                    writer.WriteLine("\t\t\t" + privateNode + ".semanticCheck(pcx);");
                    writer.WriteLine("\t\t" + "}");
                }
            }
            writer.WriteLine("\t" + "}");
        }


        /// <summary>
        /// 構文解析
        /// </summary>
        /// <param name="node"></param>
        /// <param name="writer"></param>
        private static void parse_Code(String[] node, StreamWriter writer)
        {
            const String parse = "\tpublic void parse(CParseContext pcx) throws FatalErrorException {";
            writer.WriteLine(parse);

            writer.WriteLine("\t\t// ここにやってくるときは，必ずisFirst()が満たされている");
            writer.WriteLine("\t\tCTokenizer ct = pcx.getTokenizer();");
            writer.WriteLine("\t\tCToken tk = ct.getCurrentToken(pcx);");
            writer.WriteLine("\t\t");

            foreach (String privateNode in node)
            {
                if (privateNode.Length <= 0)
                {
                    continue;
                }
                if (char.IsUpper(privateNode[0]))
                {
                    writer.WriteLine("\t\tif(tk.getType() == CToken.TK_" + privateNode + ") {");
                    writer.WriteLine("\t\t\ttk = ct.getNextToken(pcx);");
                    writer.WriteLine("\t\t}else{");
                    writer.WriteLine("\t\t\tpcx.fatalError(tk.toExplainString());");
                    writer.WriteLine("\t\t}");

                    writer.WriteLine("\t\t");
                }
                else
                {
                    String firstNode = char.ToUpper(privateNode[0]) + privateNode.Substring(1);
                    writer.WriteLine("\t\tif(" + firstNode + ".isFirst(tk)) {");
                    writer.WriteLine("\t\t\t" + privateNode + " = new " + firstNode + "(pcx);");
                    writer.WriteLine("\t\t\t" + privateNode + ".parse(pcx);");
                    writer.WriteLine("\t\t" + "}else{");
                    writer.WriteLine("\t\t\t" + "pcx.fatalError(tk.toExplainString());");
                    writer.WriteLine("\t\t" + "}");

                    writer.WriteLine("\t\t");

                    writer.WriteLine("\t\ttk = ct.getCurrentToken(pcx);");
                }

            }
            writer.WriteLine("\t" + "}");
        }

        /// <summary>
        /// First集合
        /// </summary>
        /// <param name="node"></param>
        /// <param name="writer"></param>
        private static void isFirst_Code(String[] node, StreamWriter writer)
        {
            const String isFirst = "\tpublic static boolean isFirst(CToken tk) {";
            writer.WriteLine(isFirst);

            writer.Write("\t\treturn ");

            if (node.Length >= 1)
            {
                if (char.IsUpper(node[0][0]))
                {
                    writer.Write("tk.getType() == CToken.TK_" + node[0].ToUpper());
                }
                else
                {
                    writer.Write(char.ToUpper(node[0][0]) + node[0].Substring(1) + ".isFirst(tk)");
                }

                writer.WriteLine(";");
            }
            writer.WriteLine("\t" + "}");
        }

        /// <summary>
        /// ローカル変数生成部
        /// </summary>
        /// <param name="node"></param>
        /// <param name="writer"></param>
        private static void localValue_CParseRule(String[] node, StreamWriter writer)
        {
            foreach (String privateNode in node)
            {
                if (privateNode.Length <= 0)
                {
                    continue;
                }
                if (char.IsUpper(privateNode[0]) == false)
                {
                    writer.WriteLine("\tprivate CParseRule " + privateNode + ";");
                }
            }

            writer.WriteLine();
        }
    }
}
