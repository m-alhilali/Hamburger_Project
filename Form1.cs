using HamburgerProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HamburgerProject
{
    public partial class Form1 : Form
    {
        List<CheckBox>listcheckBoxes = new List<CheckBox>();
        string FileName = "Invoice.txt";
        string Saparater = "||--||";
        Form _LoginForm;
        public Form1(Form loginform)
        {
            InitializeComponent();
            _LoginForm = loginform;
        }

        void ResetScreen()
        {
            pictureBox1.Image= null;
            lblName.Text="Mohammed Alhilali";
            textCustomName.Text=string.Empty;
            lblTotal.Text = "SYR 0";
            listcheckBoxes.Clear();
            gbBun.Enabled = true;
            gbCommonSides.Enabled = true;
            gbPatty.Enabled = true;
            gbToppings.Enabled = true;
            gbCondiments.Enabled = true;
            foreach (CheckBox cb in gbCondiments.Controls)
            {
               cb.Checked = false;     
            }
            foreach (CheckBox cb in gbBun.Controls)
            {
                cb.Checked = false;

            }
            foreach (CheckBox cb in gbToppings.Controls)
            {
                cb.Checked = false;

            }
            foreach (CheckBox cb in gbPatty.Controls)
            {
                cb.Checked = false;

            }
            foreach (CheckBox cb in gbCommonSides.Controls)
            {
                cb.Checked = false;

            }
            btnOrder.Enabled = true;

        }
        float TotalCheckedBoxAndAddToList()
        {
            float Total=0;
            listcheckBoxes.Clear();
            foreach (CheckBox cb in gbCondiments.Controls)
            {
                if (cb.Checked)
                {
                    Total += Convert.ToSingle(cb.Tag);
                    listcheckBoxes.Add(cb);
                }
            }
            foreach(CheckBox cb in gbBun.Controls)
            {
                if (cb.Checked)
                {
                    Total += Convert.ToSingle(cb.Tag);
                    listcheckBoxes.Add(cb);
                }
            }
            foreach(CheckBox cb in gbToppings.Controls)
            {
                if (cb.Checked)
                {
                    Total += Convert.ToSingle(cb.Tag);
                    listcheckBoxes.Add(cb);
                }
            }
            foreach(CheckBox cb in gbPatty.Controls)
            {
                if (cb.Checked)
                {
                    Total += Convert.ToSingle(cb.Tag);
                    listcheckBoxes.Add(cb);
                }
            }
            foreach(CheckBox cb in gbCommonSides.Controls)
            {
                if (cb.Checked)
                {
                    Total += Convert.ToSingle(cb.Tag);
                    listcheckBoxes.Add(cb);
                }
            }

            return Total;
        }

        float TotalAdditions()
        {
            return (float)TotalCheckedBoxAndAddToList();
        }

        void GetTotalOrder()
        {
            lblTotal.Text="SYR "+TotalAdditions().ToString();
        }


        void ChangeThePicturByChoice(CheckBox cb,bool isHover=false)
        {
           
            if(cb.Checked||isHover)
            {
                string name = cb.Text.Trim()+"Icon.jpg";
                name = name.Replace(" ", "");
                if (imageList1.Images.ContainsKey(name))
                {
                    //btnPicture.Image = null;
                    Image img= imageList1.Images[name];
                    pictureBox1.Image=img;
                    //pictureBox1.BackgroundImageLayout= ImageLayout.Stretch;
                }
                lblName.Text = cb.Text.Trim();
            }
            else
            {
                pictureBox1.Image = null;
                lblName.Text = null;

            }
        }
        private void GitTotalOrder_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalOrder();
            ChangeThePicturByChoice((CheckBox)sender);
        }

        private void ChangeControlForm(object sender, EventArgs e)
        {
            Control btn =(Control)sender;
            btn.Size= new Size(btn.Width+6, btn.Height+4);
            btn.ForeColor = (btn is CheckBox) ? Color.DarkGreen : Color.Black;
            if (btn is CheckBox)
            {
                ChangeThePicturByChoice((CheckBox)btn,true);
            }
        }

        private void ResetControlForm(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
            btn.Size = new Size(btn.Width - 6, btn.Height - 4);
            btn.ForeColor = Color.White;
            if (btn is CheckBox)
            {
                ChangeThePicturByChoice((CheckBox)btn, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetScreen();
        }

        void DisabelAllCheckedButton()
        {
            gbBun.Enabled = false;
            gbCommonSides.Enabled = false;
            gbPatty.Enabled = false;
            gbToppings.Enabled = false;
            gbCondiments.Enabled = false;
        }

        bool IsCustomNameEmpty()
        {
            if (string.IsNullOrWhiteSpace(textCustomName.Text))
            {
                errorProvider1.SetError(textCustomName, "The Box is empty");
                return true;
            }
           
            errorProvider1.SetError(textCustomName, "");
            return false;
        }

        void SaveToFile()
        {
            
             string TextOrder = DateTime.Now.ToString("G") + Saparater + "Hamburger" + Saparater + lblTotal.Text.Trim() + Saparater + textCustomName.Text.Trim();
            
             using (StreamWriter writer = File.AppendText(FileName))
             {
                 writer.WriteLine(TextOrder);
             }
            
        }
        void GoToInvoiceForm()
        {
            if (IsCustomNameEmpty())
            {;
                textCustomName.Text = "Alhilali's Resturant";
            }
            SaveToFile();
            DisabelAllCheckedButton();
            Form form = new OrderDetailsForm(this, listcheckBoxes);
            this.Hide();
            form.Show();
           
            
            
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (listcheckBoxes.Count>0)
            {
                if (MessageBox.Show("Are Sure ", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    GoToInvoiceForm();
                    btnOrder.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("You have to choice", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ChangeNowTime(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("G");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] btn = { btnAllInvoices, btnOrder, btnReset, btnLogout };
            lblTime.Text = DateTime.Now.ToString("G");
            foreach (Button o in btn)
            {
                o.FlatStyle = FlatStyle.Flat;
                o.FlatAppearance.BorderSize = 2;
                o.ForeColor = Color.White;
                o.BackColor= Color.Transparent;
            }
            btnAllInvoices.FlatAppearance.BorderColor = Color.Blue;
            btnLogout.FlatAppearance.BorderColor= Color.Red;
            btnReset.FlatAppearance.BorderColor= Color.Red;
            btnOrder.FlatAppearance.BorderColor = Color.DarkGreen;



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            _LoginForm.Show();
        }

        private void btnAllInvoices_Click(object sender, EventArgs e)
        {
            Form form = new OrdersForm(this);
            this.Hide();
            form.Show();
        }
    }
}
