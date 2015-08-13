using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace ERMUserControl
{
    public class Combobox
    {
        public string DisplayId;
        public int Value;
        public Combobox(string displayId, int value)
        {
            DisplayId = displayId;
            Value = value;
        }
    }

    public class GridWraper
    {
        public string TagCode;
        public string TagName;
        public string Content;
        public GridWraper(string tagCode, string tagName, string content)
        {
            TagCode = tagCode;
            TagName = tagName;
            Content = content;
        }
    }

    public class DataCreator
    {
        public static DataTable CreateTemplateData()
        {
            DataTable dt = new DataTable("Test");
            dt.Columns.Add("DisplayId", typeof(string));
            dt.Columns.Add("Value", typeof(int));
            dt.Rows.Add("All Template", 0);
            dt.Rows.Add("Template 1", 1);
            dt.Rows.Add("Template 2", 2);
            dt.Rows.Add("Template 3", 3);
            dt.Rows.Add("Template 4", 4);
            dt.Rows.Add("Template 5", 5);

            return dt;
        }

        public static Dictionary<string, string> DicConvertTag()
        {
            Dictionary<string, string> lstDicConvertTag = new Dictionary<string, string>();
            lstDicConvertTag.Add("S", "S");
            lstDicConvertTag.Add("AN", "既往歴");
            lstDicConvertTag.Add("FH", "家族歴");
            lstDicConvertTag.Add("LH", "生活歴");
            lstDicConvertTag.Add("O", "O");
            lstDicConvertTag.Add("A", "A");
            lstDicConvertTag.Add("MI", "#a");
            lstDicConvertTag.Add("MA", "#1");
            lstDicConvertTag.Add("P", "P");
            lstDicConvertTag.Add("Tx", "治療プラン");
            lstDicConvertTag.Add("Dx", "診断プラン");
            lstDicConvertTag.Add("Ex", "教育プラン");

            return lstDicConvertTag;
        }

        public static DataTable CboTagData()
        {
            DataTable dt = new DataTable("Test");
            dt.Columns.Add("DisplayId", typeof(string));
            dt.Columns.Add("Value", typeof(string));
            dt.Rows.Add("All Template", "0");
            dt.Rows.Add("S", "S");
            dt.Rows.Add("既往歴", "AN");
            dt.Rows.Add("家族歴", "FH");
            dt.Rows.Add("生活歴", "LH");
            dt.Rows.Add("O", "O");
            dt.Rows.Add("A", "A");
            dt.Rows.Add("#a", "MI");
            dt.Rows.Add("#1", "MA");
            dt.Rows.Add("P", "P");
            dt.Rows.Add("治療プラン", "Tx");
            dt.Rows.Add("診断プラン", "Dx");
            dt.Rows.Add("教育プラン", "Ex");

            return dt;
        }

        public static DataTable CreateDisplayTagData()
        {
            DataTable dtDi = new DataTable("TestdtDi");
            dtDi.Columns.Add("DisplayId", typeof(string));
            dtDi.Columns.Add("Value", typeof(int));
            dtDi.Rows.Add("両方表示", 0);
            dtDi.Rows.Add("タグコードの表示", 1);
            dtDi.Rows.Add("タグ名の表示", 2);

            return dtDi;
        }


        //public static DataColumn KeyField;
        public static DataTable CreateDataGrid(int rowCount)
        {
            DataTable tbl = new DataTable();
            //KeyField = tbl.Columns.Add("ID", typeof(string));
            //KeyField.ReadOnly = true;
            //KeyField.AutoIncrement = true;
            tbl.Columns.Add("TagCode", typeof(string));
            tbl.Columns.Add("TagName", typeof(string));
            tbl.Columns.Add("Content", typeof(string));
            tbl.Columns.Add("Image", typeof(Image));
            //for (int i = 0; i < rowCount; i++)
            //    tbl.Rows.Add(new object[] { null, String.Format("TagCode {0}", i), String.Format("TagName {0}", i), DateTime.Now.AddDays(i) });

            tbl.Rows.Add("S", "S", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("AN", "既往歴", "なし。3か月前の検診での胸部Xp正常と言われている");
            tbl.Rows.Add("FH", "家族歴", "叔父が肺癌，祖父が大腸癌。父が高血圧・心不全");
            tbl.Rows.Add("LH", "生活歴", "機会飲酒。喫煙20本／日×34年。パートでレジ打ち業務。56歳の夫");
            tbl.Rows.Add("O", "O", "重篤感なく，すっと歩いて入室し会話内容も明確だが，不安げで思");
            tbl.Rows.Add("A", "A", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("MI", "#a", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("MA", "#1", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("P", "P", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("Tx", "治療プラン", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("Dx", "診断プラン", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("Tx", "治療プラン", "咳がしつこい気がするので，レントゲンを撮ってほしい。先月亡くなった叔父の肺癌の初期症状と似ている");
            tbl.Rows.Add("Ex", "教育プラン", "診断とその根拠について丁寧に説明し，喫煙の影響や，経過次第で肺");

            return tbl;
        }
    }
}
