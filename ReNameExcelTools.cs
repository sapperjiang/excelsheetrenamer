using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeHelper;
using RegisterLib;
using NetOffice.ExcelApi;

using Microsoft.International.Converters.PinYinConverter;
using PinYinParse.Plan;
using System.IO;

namespace PinYinParse
{
    public partial class ReNameExcelTools : Form
    {
        public ReNameExcelTools()
        {
            InitializeComponent();
        }


        //new一个泛型字典来装载 英汉词典.txt里的内容(键值对)
        Dictionary<string, string> fieldsDic = new Dictionary<string, string>();
        //读取 英汉词典.txt的相对 路径
        string[] fieldsTxt;//= File.ReadAllLines(@"英汉词典.txt", Encoding.Default);

        //在窗体加载的时候自动运行
        private void Load_Dictionary()
        {
            this.fieldsTxt = File.ReadAllLines(@"字典.txt", Encoding.UTF8); 
            //TB_Dictionary.Lines = fieldDic;

            //遍历每一行 
            //每行有2个数 英文单词 和 中文翻译
            for (int i = 0; i < fieldsTxt.Length; i++)
            {
                //使用Split方法 移除空的单个字符
                string[] strArr1 = fieldsTxt[i].Split('|');//, StringSplitOptions.RemoveEmptyEntries);

                //如果 泛型字典的键key值里 不包含数组里strArr1第0个数
                //避免重复添加
                if (fieldsDic.ContainsKey(strArr1[0]) == false)
                {
                    //则将数组里的键(英文单词) 和值(中文翻译) 添加到泛型字典里
                    fieldsDic.Add(strArr1[0], strArr1[1]);
                    ////----------------------新增代码-------------------------------//
                    //lsSmart.Add(strArr1[0]);    //将每行 数组里的第0个元素 即英文单词 添加到泛型list中
                    ////----------------------新增代码-------------------------------//
                }
            }

            List<string> list = new List<string>();
            foreach (KeyValuePair<string, string> kvp in fieldsDic)
            {
               list.Add(string.Format("{0}|{1}", kvp.Key, kvp.Value));
            }
            TB_DIC.Lines = list.ToArray();
        }

        private void BT_OpenFile_Click(object sender, EventArgs e)
        {
  //Console.WriteLine("全拼音：" + String.Join(",", pingyins.TotalPingYin));
// Console.WriteLine("首音：" + String.Join(",", pingyins.FirstPingYin));

            List<string> sheetNames = new List<string>();
            List<string> newSheetNamesList = new List<string>();
            string strTabColName = string.Empty;

            string strNewSheetName = string.Empty;

            string strPinYinColName = string.Empty;

            if (openFile.ShowDialog() == DialogResult.OK)
            {

                RegisterLib.PrograssBar prgBar = new PrograssBar();
                prgBar.BarLength = 20;

                //pb.Max
                ExcelHelper helper = new ExcelHelper();
                Worksheet ws;
                foreach (var fileName in openFile.FileNames)
                {
                    helper.OpenFile(fileName);

                    prgBar.MaxValue = helper.Sheets.Count;

                    for (int i = 0; i < helper.Sheets.Count; i++)
                    {
                        ws = helper.Sheets[i + 1] as Worksheet;

                        //if (ws.Name.Contains("表名对照")==true)
                        //{
                        //    ws.Delete();
                        //}

                        sheetNames.Add(ws.Name);
                        LB_SheetNames.Items.Add(ws.Name);

                        LB_TotalProgress.Text = prgBar.ProgressMsg(string.Format("正在重命名sheet,第{0}个/总共{1}个", i+1, helper.Sheets.Count), i, helper.Sheets.Count);

                        ///获取新的sheet名称
                        var pingyins = PinYinConverterHelp.GetTotalPingYin(ws.Name);
                        strNewSheetName = pingyins.FirstPingYin.First<string>().ToUpper();
                        strNewSheetName = GetReNameRulsPrefix(ws.Name) + strNewSheetName;
                        if (newSheetNamesList.Contains(strNewSheetName))
                        {
                            strNewSheetName += i.ToString();
                        }
                        ws.Name = strNewSheetName;

                        newSheetNamesList.Add(ws.Name);
                        LB_NewSheetNames.Items.Add(ws.Name);
                        if (ws.Name.StartsWith("TB"))
                        {
                            ///修改每个sheet的表名称为汉语拼音
                            ReNameFields(ws);
                        }
                    }

                    //File.WriteAllLines("D:\\Dic.txt", fieldNames.ToArray());
                    ////将表明保存在excel中。
                    Worksheet newSheet = helper.Sheets.Add() as Worksheet;
                    try
                    {
                        if (newSheet != null)
                        {
                            newSheet.Name = "表名对照";
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("表名对照保存为："+newSheet.Name);
                    }
                 

                    for (int x = 1; x < sheetNames.Count; x++)
                    {
                        newSheet.Cells[x,1].Value = sheetNames[x - 1];
                        newSheet.Cells[x,2].Value = newSheetNamesList[x - 1];
                    }

                    string newFile = fileName.Replace(".", "_OK.");
                    helper.SaveAsNewFile(newFile);// (fileName);

                    helper.WorkBook.Close();
                    helper.Excel.Quit();

                    MessageBox.Show("文件"+fileName+"改名完成");
                    //string[] sheetNames = ExcelHelper.GetSheetNames(fileName);

                    //LB_SheetNames.DataSource = sheetNames;
                    //LB_ReNamedSheetNames.DataSource = sheetReNames;
                }
            }

            File.WriteAllLines(@"未翻译字段.txt", unTranslatedFields.ToArray(), Encoding.UTF8);
            File.WriteAllLines(@"字典.txt", TB_DIC.Lines,Encoding.UTF8);
        }

        List<string> unTranslatedFields = new List<string>();
        private void ReNameFields(Worksheet ws)
        {
            PrograssBar innerPbar = new PrograssBar();
            innerPbar.BarLength = 10;


            string strFieldEnglishTxt;
            string strFieldTxt;
            int iMax = 30;
            for (int j = 1; j < 100; j++)
            {
                ws.Cells[2, j].Value = ws.Cells[1, j].Value;

                strFieldTxt = ws.Cells[1, j].Value as string;
                if (strFieldTxt != null)
                {
                    strFieldTxt = strFieldTxt.Trim();
                    //fieldNames.Add(strFieldTxt);
                    if (fieldsDic.ContainsKey(strFieldTxt) == true)
                    {
                        fieldsDic.TryGetValue(strFieldTxt, out strFieldEnglishTxt);
                        ws.Cells[1, j].Value = strFieldEnglishTxt;
                    }
                    else
                    {
                        unTranslatedFields.Add(strFieldTxt);
                        //AddDic dc = new AddDic();
                        //dc.strHanzi = strFieldTxt;

                        //if (dc.ShowDialog()==DialogResult.OK)
                        //{
                        //    strFieldEnglishTxt = dc.strEnglisTxt;
                        //    ws.Cells[1, j].Value = strFieldEnglishTxt;
                        //    /// 添加到字典中
                        //    fieldsDic.Add(strFieldTxt, strFieldEnglishTxt);
                        //}
                        //else
                        //{
                        //    MessageBox.Show(ws.Name + "字段：" + strFieldTxt + "没有翻译，请检查");
                        //}
                    }
                    ////var strPinyinName = PinYinConverterHelp.GetTotalPingYin(strTabColName);
                    ////strPinYinColName = strPinyinName.TotalPingYin.First<string>().ToUpper();
                    //ws.Cells[2, j].Value = strEnglishColName;
                }
                else
                {
                    iMax = j;
                    break; }
                LB_TabColuProgress.Text = innerPbar.ProgressMsg("修改"+ws.Name+"表的字段", j, iMax);
            }
        }

        private  string GetReNameRulsPrefix(string oldName)
        {
            string strPrev = string.Empty;
            string strBack = string.Empty;
            string defaultBack = string.Empty;
            string[] temp;
            foreach (var rule in TB_RenameRules.Lines)
            {
                temp = rule.Split('|');
                strPrev = temp[0];
                strBack = temp[1];
                if (oldName.Contains(strPrev) == true)
                {
                    return strBack;// = "TB_SUBUJECT_";
                }
                if (strPrev.Contains("默认") == true)
                {
                    defaultBack = strBack;// = "TB_SUBUJECT_";
                }
            }

            return defaultBack; 
        }

        private void ReNameExcelTools_Load(object sender, EventArgs e)
        {
            this.Load_Dictionary();
        }


        private void BT_LoadDictionary_Click(object sender, EventArgs e)
        {
            this.Load_Dictionary();
        }

        // private void BT_CopySheetName_Click(object sender, EventArgs e)
        // {
        //     string CopyText = "";
        //     for (int i = 0; i < lbMessage.SelectedItems.Count; i++)
        //     {

        //         CopyText = CopyText + Environment.NewLine + lbMessage.SelectedItems[i].ToString();
        //     }
        //     Clipboard.SetText(CopyText);
        //}
    }
}
