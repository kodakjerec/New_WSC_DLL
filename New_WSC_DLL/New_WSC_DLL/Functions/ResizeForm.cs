using System.Windows.Forms;
using System.Drawing;
using DevExpress.Utils;
using System.Text.RegularExpressions;
using System;

namespace ResizeForm
{
    #region 調整表單大小
    public partial class ResizeForm
    {
        public static float WidthChange = 0;
        public static float HeightChange = 0;
        public static float ChangeSize = 0;

        public static void WSC_Resize(Form form)
        {
            //將視窗所有控制項大小調整至與  螢幕  相同
            WidthChange = (float)Screen.PrimaryScreen.WorkingArea.Width / form.Width;
            HeightChange = (float)(Screen.PrimaryScreen.WorkingArea.Height) / form.Height;
            ChangeSize = (float)WidthChange > HeightChange ? HeightChange : WidthChange;
            Controls_adjust(form);
        }

        public static void WSC_Resize(Form form, float type)
        {
            //將視窗所有控制項大小調整至與  *設計大小*  相同
            WidthChange = (float)Screen.PrimaryScreen.WorkingArea.Width / (1024 * type);
            HeightChange = (float)Screen.PrimaryScreen.WorkingArea.Height / (768 * type);
            ChangeSize = (float)WidthChange > HeightChange ? HeightChange : WidthChange;
            Controls_adjust(form);
        }

        public static void Controls_adjust(Form form)
        {
            #region 更改表單大小
            form.AutoScaleMode = AutoScaleMode.None;
            form.Width = (int)(form.Width * WidthChange);
            form.Height = (int)(form.Height * HeightChange);
            #endregion

            #region 更改表單起始位置
            int StartX = 0, StartY = 0;
            StartX = (Screen.PrimaryScreen.WorkingArea.Width - form.Width) / 2;
            StartY = (Screen.PrimaryScreen.WorkingArea.Height - form.Height) / 2;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(StartX, StartY);
            #endregion

            #region 迴圈對每個控制項做變更
            foreach (Control con in form.Controls)
            {
                GetAllInitInfo(con);
            }
            #endregion
        }

        private static void GetAllInitInfo(Control CrlContainer)
        {

            CrlContainer.Left = (int)(CrlContainer.Left * WidthChange);
            CrlContainer.Width = (int)(CrlContainer.Width * WidthChange);
            //超出寬度邊界的判斷
            if (CrlContainer.Right > Screen.PrimaryScreen.WorkingArea.Right)
                CrlContainer.Left = Screen.PrimaryScreen.WorkingArea.Right - CrlContainer.Width;
            CrlContainer.Top = (int)(CrlContainer.Top * HeightChange);
            CrlContainer.Height = (int)(CrlContainer.Height * HeightChange);
            //超出高度邊界的判斷
            if (CrlContainer.Bottom > Screen.PrimaryScreen.WorkingArea.Bottom)
                CrlContainer.Top = Screen.PrimaryScreen.WorkingArea.Bottom - CrlContainer.Height;

            if (Regex.IsMatch(CrlContainer.GetType().Name.ToString(), "DataGridView") == true)
                ((DataGridView)CrlContainer).ColumnHeadersHeight = Convert.ToInt32(((DataGridView)CrlContainer).ColumnHeadersHeight * ChangeSize);
            else
                CrlContainer.Font = new Font(CrlContainer.Font.Name, CrlContainer.Font.Size * ChangeSize);

            if (CrlContainer.Controls.Count > 0)
            {
                foreach (Control con in CrlContainer.Controls)
                {
                    GetAllInitInfo(con);
                }
            }
        }
    }
    #endregion
}