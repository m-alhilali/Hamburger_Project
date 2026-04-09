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
    public partial class OrdersForm : Form
    {
        Form _MainForm;
        List<string> _Orders;
        string FileName = "Invoice.txt";
        string Saparater = "||--||";
        public OrdersForm(Form main)
        {
            InitializeComponent();
            _MainForm = main;
            LoadAllOrdersFromFile();
        }

        void LoadAllOrdersFromFile()
        {
            _Orders = new List<string>();
            if(File.Exists(FileName))
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    string line ;
                    while ((line = sr.ReadLine())!=null)
                    {
                        _Orders.Add(line);
                    }
                }
            }
        }
        string[] SplitLineFromList(string line)
        {
            string[] newline=null;
            newline = line.Split(new string[] {Saparater},StringSplitOptions.None);
            return newline;
        }
        void ShowDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Custom Name", typeof(string));
            dt.Columns.Add("Order Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Date", typeof(string));

            if (_Orders.Count > 0)
            {
                for (int i = 0; i < _Orders.Count; i++)
                {
                    string[] order = SplitLineFromList(_Orders[i]);

                    dt.Rows.Add(order[3], order[1], order[2], order[0]);
                }

                dataGridView1.DataSource = dt;

            }
        }
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            ShowDataGridView();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _MainForm.Show();
        }
    }
}
