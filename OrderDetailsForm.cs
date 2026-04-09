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
    public partial class OrderDetailsForm : Form
    {
        Form _MainForm;
        float TotalInvcoice = 0;
        int _LengthInvoice;
        List<CheckBox>checkBoxes1 = new List<CheckBox>();
        public OrderDetailsForm(Form _mainform,List<CheckBox> checkBoxes)
        {
            InitializeComponent();
            _MainForm = _mainform;
            _LengthInvoice = checkBoxes.Count;
            checkBoxes1 = checkBoxes;
        }

        void DrawTableForInvoice()
        {
            CheckBox cb = new CheckBox();

            DataTable dt = new DataTable();
            
            dt.Columns.Add("Addition",typeof(string));
            dt.Columns.Add("Prices",typeof(float));
            dt.Columns.Add("Picturs", typeof(Image));

            for (int i=0;i< _LengthInvoice; i++)
            {
                cb = checkBoxes1[i];

                string picturname = cb.Text.Trim() + "Icon.jpg";
                picturname=picturname.Replace(" ", "");

                string name = cb.Text;
                Image img=null;

                if (imageList1.Images.ContainsKey(picturname))
                {
                    img = imageList1.Images[picturname];
                }
                TotalInvcoice += Convert.ToSingle(cb.Tag);
                dt.Rows.Add(name, Convert.ToSingle(cb.Tag), img);

            }
            dataGridView1.DataSource = dt;
            lblTotal.Text = $"SYR {TotalInvcoice}";
        }
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
           
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderSize = 1;
            btnBack.FlatAppearance.BorderColor = Color.MediumVioletRed;
            btnBack.BackColor = Color.Green;
            btnBack.ForeColor = Color.White;
            DrawTableForInvoice();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _MainForm.Show();
        }
        private void ChangeButtonForm(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(btn.Width + 6, btn.Height + 4);
        }

        private void ResetButtonForm(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Size = new Size(btn.Width - 6, btn.Height - 4);
        }
    }
}
