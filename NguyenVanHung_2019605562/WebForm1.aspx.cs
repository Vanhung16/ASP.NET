using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace NguyenVanHung_2019605562
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String strConnectingString = @"Data Source=MAY332\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        SqlCommand cmd = null;

        void loadData()
        {
            da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;
            dgvSanPham.DataBind();
        }

        void loadCombo()
        {
            da = new SqlDataAdapter("SELECT * FROM LoaiSP", conn);
            dt = new DataTable();
            da.Fill(dt);
            comboLoai.DataSource = dt;
            comboLoai.DataTextField = "TenLoai";
            comboLoai.DataValueField = "MaLoai";
            comboLoai.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectingString);
            loadData();
            if (!IsPostBack) loadCombo();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectingString);
            conn.Open();

            string sql = "Insert into SanPham Values (" + txtMaSP.Text + "," + txtTenSP.Text.ToString() + "," + comboLoai.SelectedValue + "," + txtDonGia.Text + ")";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectingString);
            conn.Open();
            string sql = "Update SanPham Set TenSP= '" + txtTenSP.Text.ToString() + "', MaLoai = '" + comboLoai.SelectedValue + "', Dongia ='" + txtDonGia.Text + "' where MaSP ='" + txtMaSP.Text.ToString()+"'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        protected void dgvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dong = dgvSanPham.SelectedIndex;
            txtMaSP.Text = dgvSanPham.Rows[dong].Cells[0].Text;
            txtTenSP.Text = dgvSanPham.Rows[dong].Cells[1].Text;
            comboLoai.SelectedValue = dgvSanPham.Rows[dong].Cells[2].Text;
            txtDonGia.Text = dgvSanPham.Rows[dong].Cells[3].Text;
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectingString);
            conn.Open();
            string sql = "Delete From SanPham where MaSP ='" + txtMaSP.Text.ToString() + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        protected void btnTim_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectingString);
            conn.Open();
            string sql = "Select * From SanPham where MaLoai ='" + comboLoai.SelectedValue + "'";
            
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;
            dgvSanPham.DataBind();
        }
    }
}