using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hownet.BaseForm
{
    public partial class frProcessing : DevExpress.XtraEditors.XtraForm
    {
        public frProcessing()
        {
            InitializeComponent();
        }
        BasicClass.cResult r = new BasicClass.cResult();
        int _id = 0;
        bool _isShowPopu = false;
        public frProcessing(BasicClass.cResult cr, int ID)
            : this()
        {
            r = cr;
            _id = ID;
        }
        private DataTable dt = new DataTable();
        private string bll = "Hownet.BLL.Company";
        private int _typeID = 3;
        DataTable dtPro = new DataTable();
        private void frColor_Load(object sender, EventArgs e)
        {
            this.Text = "加工商";
            dt = BasicClass.GetDataSet.GetDS(bll, "GetList", new object[] { "(TypeID=" + _typeID + ")" }).Tables[0];
            gridControl1.DataSource = dt;
            string per = BasicClass.BasicFile.GetPermissions(this.Text);
            if (per.IndexOf(((int)BasicClass.Enums.Operation.Add).ToString()) == -1)
                _barAdd.Enabled = false;
            if (per.IndexOf(((int)BasicClass.Enums.Operation.Edit).ToString()) == -1)
                barButtonItem1.Enabled = _barEdit.Enabled = false;
            if (per.IndexOf(((int)BasicClass.Enums.Operation.Del).ToString()) == -1)
                _barDel.Enabled = false;
        }
        private void _barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BasicClass.cResult cr = new BasicClass.cResult();
            cr.RowChanged += new BasicClass.RowChangedHandler(cr_RowChanged);
            Form fr = new frCompanyOne(cr, 0,_typeID,dt);
            
            fr.ShowDialog();
        }

        private void _barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle > -1)
            {
                int id = (int)gridView1.GetFocusedRowCellValue(_coID);
                BasicClass.cResult cr = new BasicClass.cResult();
                cr.RowChanged += new BasicClass.RowChangedHandler(cr_RowChanged);
                Form fr = new frCompanyOne(cr, id, _typeID,dt);
                
                fr.ShowDialog();
            }
        }

        void cr_RowChanged(DataTable dt)
        {
        
        }

        private void _barDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle > -1)
            {
                int rID = int.Parse(gridView1.GetFocusedRowCellValue(_coID).ToString());

                if (DialogResult.Yes == XtraMessageBox.Show("是否真的删除，确认将删除销售单、收款单及对帐单中所有与此客户相关的数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    DataRow[] drs = dt.Select("(ID=" + rID + ")");
                    if (drs.Length > 0)
                    {
                        DataTable dttt = dt.Clone();
                        dttt.Rows.Add(drs[0].ItemArray);
                        dttt.Rows[0]["IsEnd"] = drs[0]["IsEnd"] = 1;
                        BasicClass.GetDataSet.UpData(bll, dttt);
                    }
                    dt.DefaultView.RowFilter = "IsEnd=0";
                }
            }
        }



        private void _barPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void _barExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void _barExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            GetID();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                if (radioGroup1.SelectedIndex == 0)
                {
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("不能選擇已刪除的項目！");
                    return;
                }
            }
        }
        private void GetID()
        {
            if (_id != 0)
            {
                if (gridView1.FocusedRowHandle > -1)
                {
                    int _mID = int.Parse(gridView1.GetFocusedRowCellValue(_coID).ToString());
                    if (_mID > 0)
                    {
                        r.ChangeText(_mID.ToString());
                    }
                }
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckIsEnd();
        }
        private void CheckIsEnd()
        {
            _barDel.Enabled = _isShowPopu = false;
            if (radioGroup1.SelectedIndex == 0)
            {
                dt.DefaultView.RowFilter = "IsEnd=0";
                _barDel.Enabled = true;
            }
            else if (radioGroup1.SelectedIndex == 1)
            {
                dt.DefaultView.RowFilter = "IsEnd>0";
                _isShowPopu = true;
            }
            else if (radioGroup1.SelectedIndex == 2)
            {
                dt.DefaultView.RowFilter = "";
            }
            gridControl1.DataSource = dt.DefaultView;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle > -1)
            {
                int _TemID = int.Parse(gridView1.GetFocusedRowCellValue(_coID).ToString());
                DataRow[] drs = dt.Select("(ID=" + _TemID + ")");
                DataTable dttt = dt.Clone();
                dttt.Rows.Add(drs[0].ItemArray);
                dttt.Rows[0]["IsEnd"] = 0;
                BasicClass.GetDataSet.UpData(bll, dttt);
                drs[0]["IsEnd"] = 0;
                dt.AcceptChanges();
            }
        }

        private void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isShowPopu)
            {
                if (e.Button == MouseButtons.Right)
                    DoShowMenu(gridView1.CalcHitInfo(new Point(e.X, e.Y)));
            }
        }
        void DoShowMenu(DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hi)
        {
            if (hi.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                popupMenu1.ShowPopup(Control.MousePosition);
            }
        }
    }
}