using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tBoxUserName.Text == "MRTHO" && tBoxPassWord.Text == "123")
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập không đúng vui lòng kiểm tra lại", "THÔNG BÁO",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBoxUserName.Focus();
                tBoxUserName.Text = "";
                tBoxPassWord.Text = "";
            }
             fGiaodien f = new fGiaodien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult t = MessageBox.Show("Bạn muốn thoát khỏi chương trình", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (t == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
