using System.Data.SqlClient;
using System.Xml;
using System;

namespace Global
{
    public partial class Global_parameter
    {
        //使用者名稱密碼
        public static int UserType = 0;
        public static string UserName = "";
        public static string UserPassword = "";
        public static string secureKey = "";

        //SQL_connection
        public static string sqlconn_string = "";
        public static SqlConnection sqlconn = new SqlConnection();

        //重組sqlConn_string
        public static void Rebuild_sqlconn_string()
        {
            sqlconn_string= "Data Source=" + New_WSC_DLL.Properties.Settings.Default.ServerName
                                            + ";Initial Catalog=" + New_WSC_DLL.Properties.Settings.Default.DefaultDB;
            if (UserType==0)
            {
                sqlconn_string += ";User ID="+UserName
                                + ";Password="+UserPassword;
            }
            else
            {
                sqlconn_string += ";Integrated Security=True";
            }
            sqlconn_string += ";Connect Timeout=5";
        }

        public static void Rebuild_Settings()
        {
            //專案Settings內的Application
            //針對內建精靈的連線字串變更
            XmlDocument doc = new XmlDocument();
            //获得配置文件的全路径
            string strFileName = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
            doc.Load(strFileName);
            //找出名称为“add”的所有元素
            XmlNodeList nodes = doc.GetElementsByTagName("add");
            //获得将当前元素的key属性
            Global_parameter.Rebuild_sqlconn_string();
            XmlAttribute att = nodes[0].Attributes["connectionString"];
            att.Value = Global_parameter.sqlconn_string;

            //修改預設元素(避免使用者誤解才修改,
            //實際設定應存在於Document and Settings\使用者\Local Settings\Application Data\)
            XmlNodeList nodes_settings = doc.GetElementsByTagName("setting");
            //修改連線目的地
            XmlAttribute att_node1 = nodes_settings[0].Attributes[0];
            XmlElement att_node1_element = att_node1.OwnerElement;
            att_node1_element.FirstChild.InnerText = New_WSC_DLL.Properties.Settings.Default.ServerName;
            //修改連線DB
            att_node1 = nodes_settings[1].Attributes[0];
            att_node1_element = att_node1.OwnerElement;
            att_node1_element.FirstChild.InnerText = New_WSC_DLL.Properties.Settings.Default.DefaultDB;

            //保存上面的修改
            doc.Save(strFileName);
        }
    }
}