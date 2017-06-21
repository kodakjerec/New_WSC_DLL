using System.Windows.Forms;
using System.Data.SqlClient;
using Global;
using System;
using System.Reflection;

namespace New_WSC.WSC_Sample
{
    public partial class WSC_Submenu : Form
    {
        protected object FormLoadSample;    //Form的通用物件型態
        private string myFormType = "";     //告訴此表單是從哪個來源所產生的

        public WSC_Submenu()
        { InitializeComponent(); }

        #region Button顯示與啟用
        public void WSC_Submenu_set(string FormType)
        {
            //更新按鈕狀態
            byte[] Function_parameter;
            myFormType = FormType;
            int Fun_start_position = FormType.Length;

            //取得表單所有按鈕
            using (SqlCommand cmd = new SqlCommand("Select fun_ID,fun_name,fun_IsView,fun_IsEnable from WSC_M_menuTree where fun_parent='" + FormType + "' ", Global_parameter.sqlconn))
            {
                using (SqlDataReader myReader = cmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        //給定按鈕文字,顯示,隱藏 +ButtonSearchChange
                        Function_parameter = System.Text.Encoding.ASCII.GetBytes(myReader[0].ToString());
                        ButtonSearchChange(myReader, System.Convert.ToInt32(Function_parameter[Fun_start_position].ToString()) - 64, this, Fun_start_position);
                    }
                }
            }
            //表單重新調整大小
            ResizeForm.ResizeForm.WSC_Resize(this);
        }
        #region 給定按鈕文字,顯示,隱藏
        private void ButtonSearchChange(SqlDataReader myReader, int i, Form form, int Fun_start_position)
        {
            foreach (Button button in form.Controls)
            {
                if (button.Text == "Button" + i.ToString())
                {
                    button.Text = "".PadLeft(button.Width / 4) + myReader[0].ToString().Substring(Fun_start_position, 1) + ".  " + myReader[1].ToString();
                    if (myReader[2].ToString() == "True")
                        button.Visible = true;
                    if (myReader[3].ToString() == "True")
                    {
                        button.Enabled = true;
                        button.Click+=new EventHandler(Button_Click);
                        button.GotFocus+=new EventHandler(Button_GotFocus);
                        button.LostFocus+=new EventHandler(Button_LostFocus);
                        button.MouseEnter+=new EventHandler(Button_GotFocus);
                        button.MouseLeave+=new EventHandler(Button_LostFocus);
                    }
                    return;
                }
            }
        }
        #endregion
        #region 按鈕功能
        protected virtual void Button_Click(object sender, EventArgs e)
        {
            String frmName = "DP"+myFormType+((Button)sender).Text.Trim().Substring(0,1);
            String className = "New_WSC.WSC_Forms." + frmName;
            Type myType = Type.GetType(className);
            //if (myType == null) //Form尚未做好或不存在
            //{
            //    MessageBox.Show("很抱歉，" + frmName + "尚在製作中。", "未開放功能");
            //    return;
            //}
            //啟動指定名稱的Form
            FormLoadSample = Activator.CreateInstance(className);//myType);
            ResizeForm.ResizeForm.WSC_Resize((Form)FormLoadSample);
            ((Form)FormLoadSample).MdiParent = this.MdiParent;
            ((Form)FormLoadSample).Closed += new EventHandler(FormDispose);

            if (((Form)FormLoadSample).Name == "WSC_Submenu")
            {
                
            }
            else
            {
                foreach (Control con in this.MdiParent.Controls)
                {
                    if (con is MenuStrip | con is StatusStrip)
                    {
                        con.Hide();
                        con.Enabled = false;
                    }
                }
            }
            ((Form)FormLoadSample).Show();
        }
        #endregion
        #region 按鈕亮燈不亮燈
        Button Previous_button; //紀錄前一個亮燈的按鈕,就不需要用foreach搜尋
        protected virtual void Button_GotFocus(object sender, EventArgs e)
        {
            if (Previous_button != null)
                Previous_button.ForeColor = System.Drawing.Color.Black;
            ((Button)sender).ForeColor = System.Drawing.Color.Red;
            Previous_button = (Button)sender;
        }
        protected virtual void Button_LostFocus(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = System.Drawing.Color.Black;
        }
        #endregion
        #endregion

        #region FormDispose
        private void FormDispose(object sender, System.EventArgs e)
        {
            if (FormLoadSample == null)
                return;
            ((Form)FormLoadSample).Dispose();
            FormLoadSample = null;
            System.GC.Collect();

            foreach (Control con in this.MdiParent.Controls)
            {
                if (con is MenuStrip | con is StatusStrip)
                    con.Enabled = true;
                    con.Show();
            }
        }
        #endregion


    }
}