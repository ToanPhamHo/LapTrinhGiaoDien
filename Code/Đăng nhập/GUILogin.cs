using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LapTrinhCoSoDuLieu
{
    public partial class GUILogin : Form
    {
        DAOvsBUSLogin dn = new DAOvsBUSLogin();

        public GUILogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chứ ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void BtnĐN_Click(object sender, EventArgs e)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = dn.GetMd5Hash(md5Hash, txtMK.Text);

                if (dn.kt(txtTK.Text, hash))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    txtTK.Clear();
                    txtMK.Clear();
                    txtTK.Focus();
                    GUIMain main = new GUIMain();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không hợp lệ!", "Thông báo");
                    txtTK.Clear();
                    txtMK.Clear();
                    txtTK.Focus();
                }
            }
        }
    }
}

    

