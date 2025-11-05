using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.FormClosing += frmLogin_FormClosing;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }           
            string query = $"SELECT * FROM TAIKHOAN WHERE Username = N'{username}' AND Password = N'{password}'";
            DataTable result = DataProvider.ThucThiTruyVan(query);   
            if (result.Rows.Count > 0)
            {
                
                DataRow taiKhoan = result.Rows[0]; 

                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //GỬI thông tin tài khoản cho frmMain
                frmMain f = new frmMain(taiKhoan, this); 

                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        
    }
}
