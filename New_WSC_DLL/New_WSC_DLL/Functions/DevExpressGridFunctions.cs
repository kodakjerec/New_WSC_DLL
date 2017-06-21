using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace New_WSC_DLL
{
    public partial class DevExpressGridFunctions
    {
        public static void GridviewSetup(DevExpress.XtraGrid.Views.Grid.GridView MyGridview)
        {
            MyGridview.Appearance.EvenRow.BackColor = Color.FromArgb(0, 192, 255, 255);
            MyGridview.Appearance.FocusedCell.BackColor = Color.FromArgb(0, 255, 255, 192);
            MyGridview.Appearance.Row.Font = new Font(MyGridview.Appearance.Row.Font.Name, MyGridview.Appearance.Row.Font.Size * ResizeForm.ResizeForm.ChangeSize);
            MyGridview.Appearance.EvenRow.Options.UseBackColor = true;
            MyGridview.PaintAppearance.EvenRow.BackColor = Color.FromArgb(0, 192, 255, 255);
            MyGridview.OptionsView.EnableAppearanceEvenRow = true;
            MyGridview.OptionsView.ShowGroupPanel = false;
        }
    }
}
