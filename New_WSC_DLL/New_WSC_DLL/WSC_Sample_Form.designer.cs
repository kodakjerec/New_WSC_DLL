namespace New_WSC_DLL
{
    partial class WSC_Sample_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WSC_Sample_Form));
            this.WSC_FormBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorNewButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorEditButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDelButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCanceButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorLeaveButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSearchButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddItemButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDelItemButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorToExcelButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.WSC_FormBindingNavigator)).BeginInit();
            this.WSC_FormBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // WSC_FormBindingNavigator
            // 
            this.WSC_FormBindingNavigator.AddNewItem = null;
            this.WSC_FormBindingNavigator.BackColor = System.Drawing.SystemColors.MenuBar;
            this.WSC_FormBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.WSC_FormBindingNavigator.DeleteItem = null;
            this.WSC_FormBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorNewButton,
            this.bindingNavigatorEditButton,
            this.bindingNavigatorDelButton,
            this.bindingNavigatorSaveButton,
            this.bindingNavigatorCanceButton,
            this.bindingNavigatorLeaveButton,
            this.bindingNavigatorSearchButton,
            this.bindingNavigatorAddItemButton,
            this.bindingNavigatorDelItemButton,
            this.bindingNavigatorToExcelButton});
            this.WSC_FormBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.WSC_FormBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.WSC_FormBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.WSC_FormBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.WSC_FormBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.WSC_FormBindingNavigator.Name = "WSC_FormBindingNavigator";
            this.WSC_FormBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.WSC_FormBindingNavigator.Size = new System.Drawing.Size(1008, 35);
            this.WSC_FormBindingNavigator.TabIndex = 1;
            this.WSC_FormBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(24, 32);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.IndexChange_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.IndexChange_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            this.bindingNavigatorPositionItem.Leave += new System.EventHandler(this.IndexChange_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.IndexChange_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.IndexChange_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorNewButton
            // 
            this.bindingNavigatorNewButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorNewButton.Image")));
            this.bindingNavigatorNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorNewButton.Name = "bindingNavigatorNewButton";
            this.bindingNavigatorNewButton.Size = new System.Drawing.Size(49, 32);
            this.bindingNavigatorNewButton.Text = "新增(&N)";
            this.bindingNavigatorNewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorNewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // bindingNavigatorEditButton
            // 
            this.bindingNavigatorEditButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorEditButton.Image")));
            this.bindingNavigatorEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorEditButton.Name = "bindingNavigatorEditButton";
            this.bindingNavigatorEditButton.Size = new System.Drawing.Size(48, 32);
            this.bindingNavigatorEditButton.Text = "修改(&E)";
            this.bindingNavigatorEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorEditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // bindingNavigatorDelButton
            // 
            this.bindingNavigatorDelButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDelButton.Image")));
            this.bindingNavigatorDelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDelButton.Name = "bindingNavigatorDelButton";
            this.bindingNavigatorDelButton.Size = new System.Drawing.Size(49, 32);
            this.bindingNavigatorDelButton.Text = "刪除(&D)";
            this.bindingNavigatorDelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // bindingNavigatorSaveButton
            // 
            this.bindingNavigatorSaveButton.Enabled = false;
            this.bindingNavigatorSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveButton.Image")));
            this.bindingNavigatorSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveButton.Name = "bindingNavigatorSaveButton";
            this.bindingNavigatorSaveButton.Size = new System.Drawing.Size(47, 32);
            this.bindingNavigatorSaveButton.Text = "儲存(&S)";
            this.bindingNavigatorSaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // bindingNavigatorCanceButton
            // 
            this.bindingNavigatorCanceButton.Enabled = false;
            this.bindingNavigatorCanceButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorCanceButton.Image")));
            this.bindingNavigatorCanceButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCanceButton.Name = "bindingNavigatorCanceButton";
            this.bindingNavigatorCanceButton.Size = new System.Drawing.Size(49, 32);
            this.bindingNavigatorCanceButton.Text = "取消(&C)";
            this.bindingNavigatorCanceButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorCanceButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // bindingNavigatorLeaveButton
            // 
            this.bindingNavigatorLeaveButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorLeaveButton.Image")));
            this.bindingNavigatorLeaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorLeaveButton.Name = "bindingNavigatorLeaveButton";
            this.bindingNavigatorLeaveButton.Size = new System.Drawing.Size(62, 32);
            this.bindingNavigatorLeaveButton.Text = "離開(ESC)";
            this.bindingNavigatorLeaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorLeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // bindingNavigatorSearchButton
            // 
            this.bindingNavigatorSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSearchButton.Image")));
            this.bindingNavigatorSearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSearchButton.Name = "bindingNavigatorSearchButton";
            this.bindingNavigatorSearchButton.Size = new System.Drawing.Size(47, 32);
            this.bindingNavigatorSearchButton.Text = "查詢(&F)";
            this.bindingNavigatorSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorSearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // bindingNavigatorAddItemButton
            // 
            this.bindingNavigatorAddItemButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddItemButton.Image")));
            this.bindingNavigatorAddItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddItemButton.Name = "bindingNavigatorAddItemButton";
            this.bindingNavigatorAddItemButton.Size = new System.Drawing.Size(83, 32);
            this.bindingNavigatorAddItemButton.Text = "新增明細(F11)";
            this.bindingNavigatorAddItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorAddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // bindingNavigatorDelItemButton
            // 
            this.bindingNavigatorDelItemButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDelItemButton.Image")));
            this.bindingNavigatorDelItemButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorDelItemButton.Name = "bindingNavigatorDelItemButton";
            this.bindingNavigatorDelItemButton.Size = new System.Drawing.Size(83, 32);
            this.bindingNavigatorDelItemButton.Text = "刪除明細(F12)";
            this.bindingNavigatorDelItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorDelItemButton.Click += new System.EventHandler(this.DelItemButton_Click);
            // 
            // bindingNavigatorToExcelButton
            // 
            this.bindingNavigatorToExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorToExcelButton.Image")));
            this.bindingNavigatorToExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorToExcelButton.Name = "bindingNavigatorToExcelButton";
            this.bindingNavigatorToExcelButton.Size = new System.Drawing.Size(75, 32);
            this.bindingNavigatorToExcelButton.Text = "匯出Excel(&X)";
            this.bindingNavigatorToExcelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bindingNavigatorToExcelButton.Click += new System.EventHandler(this.ToExcelButton_Click);
            // 
            // WSC_Sample_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.WSC_FormBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "WSC_Sample_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_WSC_DLL_Form";
            this.Load += new System.EventHandler(this.New_WSC_DLL_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WSC_Sample_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WSC_FormBindingNavigator)).EndInit();
            this.WSC_FormBindingNavigator.ResumeLayout(false);
            this.WSC_FormBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        protected System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        protected System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorNewButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorEditButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorDelButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorLeaveButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorCanceButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorSaveButton;
        protected System.Windows.Forms.BindingNavigator WSC_FormBindingNavigator;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorSearchButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorAddItemButton;
        protected System.Windows.Forms.ToolStripButton bindingNavigatorDelItemButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorToExcelButton;
    }
}