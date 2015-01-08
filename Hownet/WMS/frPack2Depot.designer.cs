using Hownet.BaseContranl;
namespace Hownet.WMS
{
    partial class frPack2Depot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frPack2Depot));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this._brFrist = new DevExpress.XtraBars.BarButtonItem();
            this._brPrv = new DevExpress.XtraBars.BarLargeButtonItem();
            this._brNext = new DevExpress.XtraBars.BarLargeButtonItem();
            this._brLast = new DevExpress.XtraBars.BarLargeButtonItem();
            this._brAddNew = new DevExpress.XtraBars.BarLargeButtonItem();
            this._barDel = new DevExpress.XtraBars.BarSubItem();
            this._barDelTable = new DevExpress.XtraBars.BarButtonItem();
            this._barDelInfo = new DevExpress.XtraBars.BarButtonItem();
            this._brSave = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this._barPrintTable = new DevExpress.XtraBars.BarButtonItem();
            this._barPrintInfo = new DevExpress.XtraBars.BarButtonItem();
            this._brFilter = new DevExpress.XtraBars.BarButtonItem();
            this._barVerify = new DevExpress.XtraBars.BarButtonItem();
            this._barUnVierfy = new DevExpress.XtraBars.BarButtonItem();
            this._brExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this._barLoan = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this._ldDate = new Hownet.BaseContranl.LabAndData();
            this._ltNum = new Hownet.BaseContranl.LabAndText();
            this.panel1 = new System.Windows.Forms.Panel();
            this._leDepot = new DevExpress.XtraEditors.LookUpEdit();
            this._lePack = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this._ltRemark = new Hownet.BaseContranl.LabAndText();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this._coTaskID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coMaterielID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coColorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coSizeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coColorOneID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coColorTwoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coMeasureID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coPackAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coNowAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coMainID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coA = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coMListID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coDepotBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._coDepotInfoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this._reDepotInfoID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._leDepot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lePack.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._reDepotInfoID)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this._brAddNew,
            this._brSave,
            this._brFrist,
            this._brPrv,
            this._brNext,
            this._brLast,
            this._brFilter,
            this._brExit,
            this.barSubItem1,
            this._barPrintTable,
            this._barPrintInfo,
            this._barVerify,
            this._barUnVierfy,
            this._barLoan,
            this._barDel,
            this._barDelTable,
            this._barDelInfo});
            this.barManager1.MaxItemId = 48;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.barManager1.StatusBar = this.bar2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brFrist, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brPrv, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brNext, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brLast, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brAddNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._barDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brFilter, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._barVerify, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._barUnVierfy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this._brExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 4";
            // 
            // _brFrist
            // 
            this._brFrist.Caption = "�׵�";
            this._brFrist.Glyph = ((System.Drawing.Image)(resources.GetObject("_brFrist.Glyph")));
            this._brFrist.Hint = "Ctrl+Up";
            this._brFrist.Id = 4;
            this._brFrist.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up));
            this._brFrist.Name = "_brFrist";
            this._brFrist.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // _brPrv
            // 
            this._brPrv.Caption = "ǰ��";
            this._brPrv.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this._brPrv.Glyph = ((System.Drawing.Image)(resources.GetObject("_brPrv.Glyph")));
            this._brPrv.Hint = "Ctrl+Left";
            this._brPrv.Id = 5;
            this._brPrv.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left));
            this._brPrv.Name = "_brPrv";
            this._brPrv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonItem5_ItemClick);
            // 
            // _brNext
            // 
            this._brNext.Caption = "�µ�";
            this._brNext.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this._brNext.Glyph = ((System.Drawing.Image)(resources.GetObject("_brNext.Glyph")));
            this._brNext.Hint = "Ctrl+Right";
            this._brNext.Id = 9;
            this._brNext.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right));
            this._brNext.Name = "_brNext";
            this._brNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._brNext_ItemClick);
            // 
            // _brLast
            // 
            this._brLast.Caption = "β��";
            this._brLast.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this._brLast.Glyph = ((System.Drawing.Image)(resources.GetObject("_brLast.Glyph")));
            this._brLast.Hint = "Ctrl+Down";
            this._brLast.Id = 10;
            this._brLast.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down));
            this._brLast.Name = "_brLast";
            this._brLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._brLast_ItemClick);
            // 
            // _brAddNew
            // 
            this._brAddNew.Caption = "�½�";
            this._brAddNew.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this._brAddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("_brAddNew.Glyph")));
            this._brAddNew.Hint = "F5";
            this._brAddNew.Id = 0;
            this._brAddNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this._brAddNew.Name = "_brAddNew";
            this._brAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._brAddNew_ItemClick);
            // 
            // _barDel
            // 
            this._barDel.Caption = "ɾ��";
            this._barDel.Glyph = global::Hownet.Properties.Resources.Delete;
            this._barDel.Id = 45;
            this._barDel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this._barDelTable),
            new DevExpress.XtraBars.LinkPersistInfo(this._barDelInfo)});
            this._barDel.Name = "_barDel";
            // 
            // _barDelTable
            // 
            this._barDelTable.Caption = "����";
            this._barDelTable.Id = 46;
            this._barDelTable.Name = "_barDelTable";
            this._barDelTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._barDelTable_ItemClick);
            // 
            // _barDelInfo
            // 
            this._barDelInfo.Caption = "��ϸ";
            this._barDelInfo.Id = 47;
            this._barDelInfo.Name = "_barDelInfo";
            this._barDelInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._barDelInfo_ItemClick);
            // 
            // _brSave
            // 
            this._brSave.Caption = "����";
            this._brSave.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this._brSave.Glyph = ((System.Drawing.Image)(resources.GetObject("_brSave.Glyph")));
            this._brSave.Hint = "Ctrl+S";
            this._brSave.Id = 1;
            this._brSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this._brSave.Name = "_brSave";
            this._brSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._brSave_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "��ӡ";
            this.barSubItem1.Glyph = global::Hownet.Properties.Resources.PrintDialogAccess;
            this.barSubItem1.Id = 24;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this._barPrintTable),
            new DevExpress.XtraBars.LinkPersistInfo(this._barPrintInfo)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // _barPrintTable
            // 
            this._barPrintTable.Caption = "��ӡ����";
            this._barPrintTable.Id = 25;
            this._barPrintTable.Name = "_barPrintTable";
            this._barPrintTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._barPrintTable_ItemClick);
            // 
            // _barPrintInfo
            // 
            this._barPrintInfo.Caption = "��Ʊ���";
            this._barPrintInfo.Id = 27;
            this._barPrintInfo.Name = "_barPrintInfo";
            this._barPrintInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._barPrintInfo_ItemClick);
            // 
            // _brFilter
            // 
            this._brFilter.Caption = "ɸѡ";
            this._brFilter.Glyph = ((System.Drawing.Image)(resources.GetObject("_brFilter.Glyph")));
            this._brFilter.Hint = "Ctrl+F";
            this._brFilter.Id = 13;
            this._brFilter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this._brFilter.Name = "_brFilter";
            // 
            // _barVerify
            // 
            this._barVerify.Caption = "���";
            this._barVerify.Glyph = global::Hownet.Properties.Resources.EditWorkflowTask;
            this._barVerify.Id = 38;
            this._barVerify.Name = "_barVerify";
            this._barVerify.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._barVerify_ItemClick);
            // 
            // _barUnVierfy
            // 
            this._barUnVierfy.Caption = "����";
            this._barUnVierfy.Glyph = global::Hownet.Properties.Resources.FieldsUpdate;
            this._barUnVierfy.Id = 43;
            this._barUnVierfy.Name = "_barUnVierfy";
            this._barUnVierfy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._barUnVierfy_ItemClick);
            // 
            // _brExit
            // 
            this._brExit.Caption = "�ر�";
            this._brExit.Glyph = ((System.Drawing.Image)(resources.GetObject("_brExit.Glyph")));
            this._brExit.Hint = "Ctrl+Q";
            this._brExit.Id = 14;
            this._brExit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q));
            this._brExit.Name = "_brExit";
            this._brExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this._brExit_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this._barLoan)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // _barLoan
            // 
            this._barLoan.Id = 44;
            this._barLoan.Name = "_barLoan";
            this._barLoan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(818, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Size = new System.Drawing.Size(818, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 378);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(818, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 378);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // _ldDate
            // 
            this._ldDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._ldDate.IsMust = false;
            this._ldDate.IsShowClear = false;
            this._ldDate.labText = "���ڣ�";
            this._ldDate.lenth = new int[] {
        60,
        120};
            this._ldDate.Location = new System.Drawing.Point(549, 39);
            this._ldDate.Margin = new System.Windows.Forms.Padding(0);
            this._ldDate.MaxDate = new System.DateTime(((long)(0)));
            this._ldDate.MinDate = new System.DateTime(((long)(0)));
            this._ldDate.Name = "_ldDate";
            this._ldDate.Size = new System.Drawing.Size(190, 22);
            this._ldDate.strLab = "";
            this._ldDate.TabIndex = 23;
            this._ldDate.val = null;
            // 
            // _ltNum
            // 
            this._ltNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._ltNum.EditVal = "";
            this._ltNum.IsCanEdit = false;
            this._ltNum.IsHand = false;
            this._ltNum.IsMust = false;
            this._ltNum.labText = "��ţ�";
            this._ltNum.lenth = new int[] {
        50,
        130};
            this._ltNum.Location = new System.Drawing.Point(559, 17);
            this._ltNum.Margin = new System.Windows.Forms.Padding(0);
            this._ltNum.Mask = "";
            this._ltNum.Name = "_ltNum";
            this._ltNum.Size = new System.Drawing.Size(180, 22);
            this._ltNum.TabIndex = 19;
            this._ltNum.val = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._leDepot);
            this.panel1.Controls.Add(this._lePack);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this._ltRemark);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._ldDate);
            this.panel1.Controls.Add(this._ltNum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 91);
            this.panel1.TabIndex = 6;
            // 
            // _leDepot
            // 
            this._leDepot.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._leDepot.Location = new System.Drawing.Point(370, 36);
            this._leDepot.Name = "_leDepot";
            this._leDepot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._leDepot.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "��Ʒ���")});
            this._leDepot.Properties.DisplayMember = "Name";
            this._leDepot.Properties.NullText = "";
            this._leDepot.Properties.ValueMember = "ID";
            this._leDepot.Size = new System.Drawing.Size(123, 20);
            this._leDepot.TabIndex = 30;
            this._leDepot.ToolTip = "��Ʒ���";
            this._leDepot.EditValueChanged += new System.EventHandler(this._leDepot_EditValueChanged);
            // 
            // _lePack
            // 
            this._lePack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._lePack.Location = new System.Drawing.Point(128, 36);
            this._lePack.MenuManager = this.barManager1;
            this._lePack.Name = "_lePack";
            this._lePack.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._lePack.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "�ֿ�")});
            this._lePack.Properties.DisplayMember = "Name";
            this._lePack.Properties.NullText = "";
            this._lePack.Properties.ValueMember = "ID";
            this._lePack.Size = new System.Drawing.Size(113, 20);
            this._lePack.TabIndex = 29;
            this._lePack.EditValueChanged += new System.EventHandler(this._lePack_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "�ֿ⣺";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "��װ����";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Location = new System.Drawing.Point(740, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "��ӡ����";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // _ltRemark
            // 
            this._ltRemark.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._ltRemark.EditVal = "";
            this._ltRemark.IsCanEdit = false;
            this._ltRemark.IsHand = false;
            this._ltRemark.IsMust = false;
            this._ltRemark.labText = "˵����";
            this._ltRemark.lenth = new int[] {
        50,
        610};
            this._ltRemark.Location = new System.Drawing.Point(77, 63);
            this._ltRemark.Margin = new System.Windows.Forms.Padding(0);
            this._ltRemark.Mask = "";
            this._ltRemark.Name = "_ltRemark";
            this._ltRemark.Size = new System.Drawing.Size(660, 22);
            this._ltRemark.TabIndex = 26;
            this._ltRemark.val = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("΢���ź�", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "��װ�����";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 122);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this._reDepotInfoID});
            this.gridControl1.Size = new System.Drawing.Size(818, 287);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this._coTaskID,
            this._coMaterielID,
            this._coBrandID,
            this._coColorID,
            this._coSizeID,
            this._coColorOneID,
            this._coColorTwoID,
            this._coMeasureID,
            this._coPackAmount,
            this._coNowAmount,
            this._coRemark,
            this._coID,
            this._coMainID,
            this._coA,
            this._coMListID,
            this._coDepotBrandID,
            this._coDepotInfoID});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less;
            styleFormatCondition1.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // _coTaskID
            // 
            this._coTaskID.Caption = "������";
            this._coTaskID.FieldName = "TaskID";
            this._coTaskID.Name = "_coTaskID";
            this._coTaskID.OptionsColumn.AllowEdit = false;
            this._coTaskID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this._coTaskID.Visible = true;
            this._coTaskID.VisibleIndex = 0;
            // 
            // _coMaterielID
            // 
            this._coMaterielID.Caption = "���";
            this._coMaterielID.FieldName = "MaterielID";
            this._coMaterielID.Name = "_coMaterielID";
            this._coMaterielID.OptionsColumn.AllowEdit = false;
            this._coMaterielID.Visible = true;
            this._coMaterielID.VisibleIndex = 1;
            // 
            // _coBrandID
            // 
            this._coBrandID.Caption = "�̱�";
            this._coBrandID.FieldName = "BrandID";
            this._coBrandID.Name = "_coBrandID";
            this._coBrandID.OptionsColumn.AllowEdit = false;
            this._coBrandID.Visible = true;
            this._coBrandID.VisibleIndex = 2;
            // 
            // _coColorID
            // 
            this._coColorID.Caption = "��ɫ";
            this._coColorID.FieldName = "ColorID";
            this._coColorID.Name = "_coColorID";
            this._coColorID.OptionsColumn.AllowEdit = false;
            this._coColorID.Visible = true;
            this._coColorID.VisibleIndex = 3;
            // 
            // _coSizeID
            // 
            this._coSizeID.Caption = "����";
            this._coSizeID.FieldName = "SizeID";
            this._coSizeID.Name = "_coSizeID";
            this._coSizeID.OptionsColumn.AllowEdit = false;
            this._coSizeID.Visible = true;
            this._coSizeID.VisibleIndex = 4;
            // 
            // _coColorOneID
            // 
            this._coColorOneID.Caption = "��ɫһ";
            this._coColorOneID.FieldName = "ColorOneID";
            this._coColorOneID.Name = "_coColorOneID";
            this._coColorOneID.OptionsColumn.AllowEdit = false;
            this._coColorOneID.Visible = true;
            this._coColorOneID.VisibleIndex = 5;
            // 
            // _coColorTwoID
            // 
            this._coColorTwoID.Caption = "��ɫ��";
            this._coColorTwoID.FieldName = "ColorTwoID";
            this._coColorTwoID.Name = "_coColorTwoID";
            this._coColorTwoID.OptionsColumn.AllowEdit = false;
            this._coColorTwoID.Visible = true;
            this._coColorTwoID.VisibleIndex = 6;
            // 
            // _coMeasureID
            // 
            this._coMeasureID.Caption = "��λ";
            this._coMeasureID.FieldName = "MeasureID";
            this._coMeasureID.Name = "_coMeasureID";
            this._coMeasureID.OptionsColumn.AllowEdit = false;
            this._coMeasureID.Visible = true;
            this._coMeasureID.VisibleIndex = 7;
            // 
            // _coPackAmount
            // 
            this._coPackAmount.Caption = "��װ������";
            this._coPackAmount.FieldName = "PackAmount";
            this._coPackAmount.Name = "_coPackAmount";
            this._coPackAmount.OptionsColumn.AllowEdit = false;
            this._coPackAmount.Visible = true;
            this._coPackAmount.VisibleIndex = 8;
            // 
            // _coNowAmount
            // 
            this._coNowAmount.Caption = "�������";
            this._coNowAmount.FieldName = "NowAmount";
            this._coNowAmount.Name = "_coNowAmount";
            this._coNowAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this._coNowAmount.Visible = true;
            this._coNowAmount.VisibleIndex = 9;
            // 
            // _coRemark
            // 
            this._coRemark.Caption = "˵��";
            this._coRemark.FieldName = "Remark";
            this._coRemark.Name = "_coRemark";
            this._coRemark.Visible = true;
            this._coRemark.VisibleIndex = 10;
            // 
            // _coID
            // 
            this._coID.Caption = "ID";
            this._coID.FieldName = "ID";
            this._coID.Name = "_coID";
            this._coID.OptionsColumn.AllowEdit = false;
            // 
            // _coMainID
            // 
            this._coMainID.Caption = "MainID";
            this._coMainID.FieldName = "MainID";
            this._coMainID.Name = "_coMainID";
            this._coMainID.OptionsColumn.AllowEdit = false;
            // 
            // _coA
            // 
            this._coA.Caption = "A";
            this._coA.FieldName = "A";
            this._coA.Name = "_coA";
            this._coA.OptionsColumn.AllowEdit = false;
            // 
            // _coMListID
            // 
            this._coMListID.Caption = "MListID";
            this._coMListID.FieldName = "MListID";
            this._coMListID.Name = "_coMListID";
            this._coMListID.OptionsColumn.AllowEdit = false;
            // 
            // _coDepotBrandID
            // 
            this._coDepotBrandID.Caption = "����̱�";
            this._coDepotBrandID.FieldName = "DepotBrandID";
            this._coDepotBrandID.Name = "_coDepotBrandID";
            this._coDepotBrandID.Visible = true;
            this._coDepotBrandID.VisibleIndex = 11;
            // 
            // _coDepotInfoID
            // 
            this._coDepotInfoID.Caption = "��λ";
            this._coDepotInfoID.ColumnEdit = this._reDepotInfoID;
            this._coDepotInfoID.FieldName = "DepotInfoID";
            this._coDepotInfoID.Name = "_coDepotInfoID";
            this._coDepotInfoID.Visible = true;
            this._coDepotInfoID.VisibleIndex = 12;
            // 
            // _reDepotInfoID
            // 
            this._reDepotInfoID.AutoHeight = false;
            this._reDepotInfoID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this._reDepotInfoID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "��λ")});
            this._reDepotInfoID.DisplayMember = "Name";
            this._reDepotInfoID.Name = "_reDepotInfoID";
            this._reDepotInfoID.NullText = "";
            this._reDepotInfoID.ValueMember = "ID";
            // 
            // frPack2Depot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 436);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frPack2Depot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "��װ�����";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._leDepot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lePack.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._reDepotInfoID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarLargeButtonItem _brAddNew;
        private DevExpress.XtraBars.BarLargeButtonItem _brSave;
        private DevExpress.XtraBars.BarButtonItem _brFrist;
        private DevExpress.XtraBars.BarLargeButtonItem _brPrv;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarLargeButtonItem _brNext;
        private DevExpress.XtraBars.BarLargeButtonItem _brLast;
        private DevExpress.XtraBars.BarButtonItem _brFilter;
        private DevExpress.XtraBars.BarButtonItem _brExit;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem _barPrintTable;
        private DevExpress.XtraBars.BarButtonItem _barPrintInfo;
        private DevExpress.XtraBars.BarButtonItem _barVerify;
        private LabAndData _ldDate;
        private LabAndText _ltNum;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem _barUnVierfy;
        private LabAndText _ltRemark;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarStaticItem _barLoan;
        private DevExpress.XtraBars.BarSubItem _barDel;
        private DevExpress.XtraBars.BarButtonItem _barDelTable;
        private DevExpress.XtraBars.BarButtonItem _barDelInfo;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn _coMaterielID;
        private DevExpress.XtraGrid.Columns.GridColumn _coBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn _coSizeID;
        private DevExpress.XtraGrid.Columns.GridColumn _coColorOneID;
        private DevExpress.XtraGrid.Columns.GridColumn _coColorTwoID;
        private DevExpress.XtraGrid.Columns.GridColumn _coMeasureID;
        private DevExpress.XtraGrid.Columns.GridColumn _coPackAmount;
        private DevExpress.XtraGrid.Columns.GridColumn _coRemark;
        private DevExpress.XtraGrid.Columns.GridColumn _coID;
        private DevExpress.XtraGrid.Columns.GridColumn _coMainID;
        private DevExpress.XtraGrid.Columns.GridColumn _coA;
        private DevExpress.XtraGrid.Columns.GridColumn _coColorID;
        private DevExpress.XtraGrid.Columns.GridColumn _coMListID;
        private DevExpress.XtraEditors.LookUpEdit _lePack;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.LookUpEdit _leDepot;
        private DevExpress.XtraGrid.Columns.GridColumn _coTaskID;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn _coNowAmount;
        private DevExpress.XtraGrid.Columns.GridColumn _coDepotBrandID;
        private DevExpress.XtraGrid.Columns.GridColumn _coDepotInfoID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit _reDepotInfoID;
    }
}