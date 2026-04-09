using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.FlatAppearance.BorderSize = 1;
            btnStart.FlatAppearance.BorderColor = Color.White;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited=true;
            System.Diagnostics.Process.Start("http://github/m-alhilali");
        }
        private void ChangeButtonForm(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(btn.Width + 6, btn.Height + 4);
            btn.BackColor = Color.SkyBlue;
            btn.ForeColor = Color.Black;
        }

        private void ResetButtonForm(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(btn.Width - 6, btn.Height - 4);
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Gold;


        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form form = new Form1(this);
            this.Hide();
            form.Show();
        }
    }
}
