using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Runtime.InteropServices;

/*
 * 開啟按鈕 SetButtonEnable("N E D C S L F EX")
 * 設定母表單 SetMasterBindingNavigator(BindingSource)
 * 設定子表單 SetChildBindingNavigator(BindingSource)
 * 開啟讀取視窗 StartLoadingShow()
 * 關閉讀取視窗 CloseLoadingShow()
 * 訊息視窗 msgBox.Show()
 */
namespace New_WSC_DLL
{
    public partial class WSC_Sample_Form : Form
    {
        #region 此處用於取得計算機視窗的控制碼
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        #endregion

        public WSC_Sample_Form()
        {
            InitializeComponent();

            WSC_FormBindingNavigator.Visible = false;
            foreach (ToolStripItem tsb in WSC_FormBindingNavigator.Items)
            {
                if (tsb.Name.IndexOf("Button") > 0)
                    if (tsb.Name.IndexOf("Leave") < 0)
                        tsb.Visible = false;
            }
        }

        #region 全域變數設定
        protected static string FormStatus = "Search";  //目前程式執行狀態
        protected BindingSource MasterBS;   //母表單
        protected BindingSource ChildBS;    //子表單
        protected DataSet ChildBSSet;       //子表單DateSet
        protected DataTable ChildBSTable;   //子表單DataTable
        protected List<object> MasterObj;   //統一啟用/不啟用的物件集合
        protected MessageBoxWSC msgBox = new MessageBoxWSC();
        #endregion

        #region 一定要做的設定
        #region 新增時自動給值
        protected void BindingSource_AddingNew(BindingSource bs)
        {
            if (bs == null)
                return;
            DataView view = (DataView)bs.List;
            DataRowView drv = (DataRowView)bs.Current;
            foreach (DataColumn column in view.Table.Columns)
            {
                if (column.DataType == Type.GetType("System.String"))
                {
                    drv[column.ColumnName] = "";
                }
                else if (column.DataType == Type.GetType("System.Boolean"))
                {
                    drv[column.ColumnName] = false;
                }
                else if (column.DataType == Type.GetType("System.DateTime"))
                {
                    drv[column.ColumnName] = DateTime.Now.ToString();
                }
                else if (column.DataType == Type.GetType("System.Int32"))
                {
                    drv[column.ColumnName] = 0;
                }
            }
        }
        #endregion

        #region 指定資料繫結的Table--Master 設定母表單
        public void SetMasterBindingNavigator(BindingSource bs)
        {
            WSC_FormBindingNavigator.Visible = true;
            MasterBS = bs;
            WSC_FormBindingNavigator.BindingSource = MasterBS;
            bindingNavigatorPositionItem.Font = bindingNavigatorCountItem.Font;
        }
        #endregion

        #region 指定資料繫結的Table--Master 設定子表單
        public void SetChildBindingNavigator(BindingSource bs)
        {
            ChildBS = bs;
            ChildBSSet = ((DataSet)ChildBS.DataSource);
            ChildBSTable = ((DataSet)ChildBS.DataSource).Tables[0];
        }
        #endregion

        #region 要開啟的按鈕, 有標記的才開啟 N E D C S L F EX
        private string enable_string;
        public void SetButtonEnable(string Enable_string_User)
        {
            enable_string = Enable_string_User;
            SetButtonEnable();
        }
        public void SetButtonEnable()
        {
            if (enable_string == null || enable_string.Length == 0)
                enable_string = "L";

            enable_string = enable_string.ToUpper();
            if (enable_string.IndexOf('N') > -1)
                bindingNavigatorNewButton.Visible = true;

            if (enable_string.IndexOf('E') > -1)
                bindingNavigatorEditButton.Visible = true;

            if (enable_string.IndexOf('D') > -1)
                bindingNavigatorDelButton.Visible = true;

            if (enable_string.IndexOf('S') > -1)
                bindingNavigatorSaveButton.Visible = true;

            if (enable_string.IndexOf('C') > -1)
                bindingNavigatorCanceButton.Visible = true;
            if (enable_string.IndexOf('L') > -1)
                bindingNavigatorLeaveButton.Visible = true;
            if (enable_string.IndexOf('F') > -1)
                bindingNavigatorSearchButton.Visible = true;
            if (enable_string.IndexOf("EX") > -1)
                bindingNavigatorToExcelButton.Visible = true;
        }
        #endregion
        #endregion

        #region 按鈕動作:FormControl
        //新增
        protected virtual void NewButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "New";
            MasterBS.AddNew();
            BindingSource_AddingNew(MasterBS);
            MasterBS.Filter = "";
            if (ChildBS != null)
                ChildBS.Filter = "";
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorNewButton.Enabled = false;
            bindingNavigatorEditButton.Enabled = false;
            bindingNavigatorDelButton.Enabled = false;
            bindingNavigatorSaveButton.Enabled = true;
            bindingNavigatorCanceButton.Enabled = true;
            bindingNavigatorSearchButton.Enabled = false;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = true;
                bindingNavigatorDelItemButton.Visible = true;
            }
            Object_Enable(MasterObj, true);
        }
        //修改
        protected virtual void EditButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "Edit";
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveNextItem.Enabled = false;
            bindingNavigatorMoveLastItem.Enabled = false;
            bindingNavigatorNewButton.Enabled = false;
            bindingNavigatorEditButton.Enabled = false;
            bindingNavigatorDelButton.Enabled = false;
            bindingNavigatorSaveButton.Enabled = true;
            bindingNavigatorCanceButton.Enabled = true;
            bindingNavigatorSearchButton.Enabled = false;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = true;
                bindingNavigatorDelItemButton.Visible = true;
            }
            Object_Enable(MasterObj, true);
        }
        //刪除
        protected virtual void DelButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "Del";
            DialogResult dr1 = MessageBox.Show("確定刪除資料??", "刪除確認", MessageBoxButtons.YesNo);
            if (dr1 == System.Windows.Forms.DialogResult.No)
                return;
            DelButton_Click_SubFunction();
            FormStatus = "Search";
        }
        //刪除的子程式，放置確定刪除時應該做的事情
        protected virtual void DelButton_Click_SubFunction()
        {
            if (ChildBS != null && ChildBS.Count > 0)
            {
                //DataRowView只能刪除眼前所看到的資料，建議使用Table來做刪除
                foreach (DataRowView drv in ChildBS.CurrencyManager.List)
                {
                    drv.Delete();
                }
                ChildBS.EndEdit();
            }
            MasterBS.RemoveCurrent();
            MasterBS.EndEdit();
        }
        //儲存
        protected virtual void SaveButton_Click(object sender, EventArgs e)
        {
            FormStatus = "Save";
            MasterBS.EndEdit();
            if (ChildBS != null)
                ChildBS.EndEdit();
            FormStatus = "Search";
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorNewButton.Enabled = true;
            bindingNavigatorEditButton.Enabled = true;
            bindingNavigatorDelButton.Enabled = true;
            bindingNavigatorSaveButton.Enabled = false;
            bindingNavigatorCanceButton.Enabled = false;
            bindingNavigatorSearchButton.Enabled = true;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = false;
                bindingNavigatorDelItemButton.Visible = false;
            }
            Object_Enable(MasterObj, false);
        }
        //取消
        protected virtual void CancelButton_Click(object sender, System.EventArgs e)
        {
            FormStatus = "Cancel";
            DialogResult dr1 = MessageBox.Show("資料尚未儲存，確定取消??", "取消確認", MessageBoxButtons.YesNo);
            if (dr1 == System.Windows.Forms.DialogResult.No)
                return;
            ((DataSet)MasterBS.DataSource).RejectChanges();
            MasterBS.CancelEdit();
            if (ChildBS != null)
            {
                ((DataSet)ChildBS.DataSource).RejectChanges();
                ChildBS.CancelEdit();
            }
            FormStatus = "Search";
            bindingNavigatorMoveFirstItem.Enabled = true;
            bindingNavigatorMovePreviousItem.Enabled = true;
            bindingNavigatorMoveNextItem.Enabled = true;
            bindingNavigatorMoveLastItem.Enabled = true;
            bindingNavigatorNewButton.Enabled = true;
            bindingNavigatorEditButton.Enabled = true;
            bindingNavigatorDelButton.Enabled = true;
            bindingNavigatorSaveButton.Enabled = false;
            bindingNavigatorCanceButton.Enabled = false;
            bindingNavigatorSearchButton.Enabled = true;
            if (enable_string.IndexOf("E0") > -1)
            {
                bindingNavigatorAddItemButton.Visible = false;
                bindingNavigatorDelItemButton.Visible = false;
            }
            Object_Enable(MasterObj, false);
        }
        //離開
        protected virtual void LeaveButton_Click(object sender, System.EventArgs e)
        {
            if (bindingNavigatorSaveButton.Visible == true)   //儲存按鈕有啟用
            {
                if (bindingNavigatorSaveButton.Enabled == true)
                {
                    DialogResult dr1 = MessageBox.Show("資料尚未儲存，確定離開程式??", "離開確認", MessageBoxButtons.YesNo);
                    if (dr1 == System.Windows.Forms.DialogResult.No)
                    {
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                }
            }
            this.Close();
        }
        //查詢按鈕
        protected virtual void SearchButton_Click(object sender, EventArgs e)
        {
            if (MasterBS.Count > 0)
                bindingNavigatorEditButton.Enabled = true;
            else
                bindingNavigatorEditButton.Enabled = false;
            Object_Enable(MasterObj, false);
        }
        protected virtual void ToExcelButton_Click(object sender, EventArgs e)
        {

        }
        //新增明細
        protected virtual void AddItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChildBS != null)
                {
                    ChildBS.AddNew();
                    BindingSource_AddingNew(ChildBS);
                }
            }
            catch
            {
                if (ChildBS != null)
                    ChildBS.RemoveCurrent();
            }
        }
        //刪除明細
        protected virtual void DelItemButton_Click(object sender, EventArgs e)
        {
            if (ChildBS != null && ChildBS.Count > 0)
                ChildBS.RemoveCurrent();
        }
        //GridView指標移動通用函數
        protected virtual void IndexChange_Click(object sender, System.EventArgs e)
        {
        }
        //表單物件的啟用/不啟用
        protected virtual void Object_Enable(List<object> IwantObj, bool Iwant)
        {
            if (IwantObj == null)
                return;
            foreach (Object obj1 in IwantObj)
            {
                if (obj1 is TextBox)
                {
                    ((TextBox)obj1).ReadOnly = !Iwant;
                }
                else if (obj1 is Button)
                {
                    ((Button)obj1).Enabled = Iwant;
                }
                else if (obj1 is ComboBox)
                {
                    ((ComboBox)obj1).Enabled = Iwant;
                }
                else if (obj1 is DateTimePicker)
                {
                    ((DateTimePicker)obj1).Enabled = Iwant;
                }
                else if (obj1 is DevExpress.XtraGrid.GridControl)
                {
                    ((DevExpress.XtraGrid.GridControl)obj1).Enabled = !Iwant;
                }
                else if (obj1 is DevExpress.XtraGrid.Columns.GridColumn)
                {
                    ((DevExpress.XtraGrid.Columns.GridColumn)obj1).OptionsColumn.AllowEdit = Iwant;
                }
            }
        }
        #endregion

        #region 通用設定:FormView
        //設定通用的按鍵指令
        protected virtual void WSC_Sample_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = MessageBox.Show("確定離開  " + this.Text + "??", "離開確認", MessageBoxButtons.YesNo);
                if (this.DialogResult == DialogResult.Yes)
                {
                    bindingNavigatorLeaveButton.PerformClick();
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            else if (e.KeyCode == Keys.F11)
                bindingNavigatorAddItemButton.PerformClick();
            else if (e.KeyCode == Keys.F12)
                bindingNavigatorDelItemButton.PerformClick();
        }
        //設定通用的顯示和排版
        public Color Color_BackColor = Color.FromArgb(97, 116, 140);   //背景顏色
        public Color Color_ForeColor = Color.FromArgb(255, 255, 255);  //前景顏色
        public Color Color_Menu = Color.FromArgb(229, 223, 202);       //選單顏色
        public Color Color_MenuFore = Color.FromArgb(0, 0, 0);         //選單前景顏色

        //統一介面顏色
        private void New_WSC_DLL_Form_Uniform()
        {
            this.BackColor = Color_BackColor;
            WSC_FormBindingNavigator.BackColor = Color_Menu;

            New_WSC_DLL_Form_Uniform_SubFun1(this);

        }
        private void New_WSC_DLL_Form_Uniform_SubFun1(Control MainControl)
        {
            foreach (Control tb in MainControl.Controls)
            {
                string tbName = tb.GetType().Name.ToString();
                if (tbName == "Label")
                {
                    if (tb.ForeColor == Color.Black)
                        tb.ForeColor = Color_ForeColor;
                }
                else if (tbName == "Button")
                {
                    tb.BackColor = Color_Menu;
                    tb.ForeColor = Color_MenuFore;
                    tb.GotFocus += new EventHandler(Button_GotFocus);
                    tb.LostFocus += new EventHandler(Button_LostFocus);
                    tb.MouseEnter += new EventHandler(Button_GotFocus);
                    tb.MouseLeave += new EventHandler(Button_LostFocus);
                }
                else if (tbName == "RadioButton")
                {
                    tb.BackColor = Color_BackColor;
                    tb.ForeColor = Color_ForeColor;
                }
                else if (tbName == "TextBox")
                {
                    tb.DoubleClick += new EventHandler(TextBox_GotFocus);
                    tb.KeyDown += new KeyEventHandler(ToolStripTextBox_KeyDown);
                }
                else if (tbName == "ToolStripTextBoxControl")
                {
                    tb.KeyDown += new KeyEventHandler(ToolStripTextBox_KeyDown);
                }
                else if (tbName == "ToolStrip")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "Panel")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "GroupBox")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "TabControl")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
                else if (tbName == "TabPage")
                {
                    New_WSC_DLL_Form_Uniform_SubFun1(tb);
                }
            }
        }

        //TextBox通用功能
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            //反白
            ((TextBox)sender).SelectAll();
        }
        void ToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //自動跳到下一個TextBox
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        void ToolStripTextBox_GotFocus(object sender, EventArgs e)
        {
            //反白
            ((ToolStripTextBox)sender).SelectAll();
        }

        //Button通用功能
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

        protected virtual void New_WSC_DLL_Form_Load(object sender, EventArgs e)
        {
            New_WSC_DLL_Form_Uniform();
            //ResizeForm.ResizeForm.WSC_Resize(this);
        }
        #endregion

        #region 自定義Format格式
        //public class XXXXFormatter : IFormatProvider, ICustomFormatter
        //{
        //    public XXXXFormatter() { }

        //    public object GetFormat(System.Type type)
        //    {
        //        return this;
        //    }

        //    public string Format(string formatString, object arg, IFormatProvider formatProvider)
        //    {
        //        switch (arg.ToString())
        //        {
        //            case "0": formatString = "建立"; break;
        //            case "1": formatString = "確認"; break;
        //            case "9": formatString = "認帳"; break;
        //            default: formatString = ""; break;
        //        }
        //        return formatString;
        //        //注意这里我们返回的是string值.
        //        //formatString 就是你自己定义的format方法,需要在这里实现判断
        //        //arg 就是这个单元格的值, 或者说是 绑定datasource后的字段值
        //        //formatProvider 这个就可以不用管他的,说实话我也没有搞清楚怎么用,知道的朋友补充一下吧!
        //    }
        //}
        #endregion

        #region WSC自定讀取中的等待視窗
        Thread LoadingWindowThread;
        WaitWindow ww;

        #region Thread的執行
        protected void StartLoadingShow()
        {
            ww = new WaitWindow();
            ww.SetMessage("查詢中，請稍等");
            CheckThreadState();
        }

        protected void StartLoadingShow(string TitleText)
        {
            ww = new WaitWindow();
            ww.SetMessage(TitleText);
            CheckThreadState();
        }
        private void CheckThreadState()
        {
            if (LoadingWindowThread == null || LoadingWindowThread.ThreadState == ThreadState.Aborted)
            {
                LoadingWindowThread = new Thread(CreateLoadingWindow);
            }
            LoadingWindowThread.Start();
        }
        /// <summary>
        /// 存取不同執行緒的元件時，用委派的方式
        /// </summary>
        protected void CreateLoadingWindow()
        {
            this.Invoke(new MethodInvoker(CreateLoadingWindowShowDialog));
        }
        protected void CreateLoadingWindowShowDialog()
        {
            ww.ShowDialog();
        }
        #endregion

        #region Thread的關閉
        protected void CloseLoadingShow()
        {
            this.Invoke(new MethodInvoker(HideLoadingWindow));

            //避免重複呼叫到關閉程式
            if (LoadingWindowThread != null)
            {
                LoadingWindowThread.Abort();
            }
            LoadingWindowThread = null;
        }
        protected void HideLoadingWindow()
        {
            if (ww != null)
                ww.Close();
        }
        #endregion

        #endregion
    }
}
