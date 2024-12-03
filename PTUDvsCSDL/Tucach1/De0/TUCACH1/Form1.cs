﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUCACH1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loaddgvLoaiChungChi();
        }

        private bool CheckForm()
        {
            erpBaoLoi.Clear();
            bool isFine = true;
            if(txtTenLoaiChungChi.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtTenLoaiChungChi, "Nhap ten loai chung chi");
                isFine = false;
            }
            if(txtThoiHan.Text.Trim() == "")
            {
                erpBaoLoi.SetError(txtThoiHan, "Nhap thoi han");
                isFine = false;
            }
            return isFine;
        }
        private void loaddgvLoaiChungChi()
        {
            //string sql = "select * from LoaiChungChi_9";
            string sql = "select L.MaLoaiChungChi, L.TenLoaiChungChi, L.MaNgonNgu, N.TenNgonNgu, L.ThoiHan from LoaiChungChi_9 L join NgonNgu_9 N on L.MaNgonNgu = N.MaNgonNgu";
            dgvLoaiChungChi.DataSource = Database.Query(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "select * from LoaiChungChi_9 where TenLoaiChungChi = N'" + txtTenLoaiChungChi.Text + "'";
            bool error = false;
            if(Database.Query(sql).Rows.Count > 0)
            {
                erpBaoLoi.SetError(txtTenLoaiChungChi, "Ten chung chi da ton tai");
                error = true;
            }
            if (error) return;
            if (!CheckForm()) return;
            sql = "insert LoaiChungChi_9 values(N'" + txtTenLoaiChungChi.Text + "', '" + cbbMaNgonNgu.SelectedValue + "', '" + txtThoiHan.Text + "')";
            Database.Execute(sql);
            loaddgvLoaiChungChi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbMaNgonNgu.DisplayMember = "TenNgonNgu";
            cbbMaNgonNgu.ValueMember = "MaNgonNgu";
            cbbMaNgonNgu.DataSource = Database.Query("select * from NgonNgu_9");
        }

        private void dgvLoaiChungChi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtTenLoaiChungChi.Text = dgvLoaiChungChi.Rows[e.RowIndex].Cells["colTenLoaiChungChi"].Value.ToString();
            txtThoiHan.Text = dgvLoaiChungChi.Rows[e.RowIndex].Cells["colThoiHan"].Value.ToString();
            cbbMaNgonNgu.SelectedValue = dgvLoaiChungChi.Rows[e.RowIndex].Cells["colMaNgonNgu"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!CheckForm()) return;
            string sql = "update LoaiChungChi_9 set TenLoaiChungChi = N'" + txtTenLoaiChungChi.Text + "', MaNgonNgu = '" + cbbMaNgonNgu.SelectedValue.ToString() + "', ThoiHan = '" + txtThoiHan.Text + "' where TenLoaiChungChi = N'" + dgvLoaiChungChi.CurrentRow.Cells["colTenLoaiChungChi"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvLoaiChungChi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from LoaiChungChi_9 where MaLoaiChungChi = '" + dgvLoaiChungChi.CurrentRow.Cells["colMaLoaiChungChi"].Value.ToString() + "'";
            Database.Execute(sql);
            loaddgvLoaiChungChi();
        }
    }
}
