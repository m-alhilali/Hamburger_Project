namespace HamburgerProject
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAllOrders = new System.Windows.Forms.Label();
            this.lblUnder = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAllOrders
            // 
            this.lblAllOrders.BackColor = System.Drawing.Color.DarkCyan;
            this.lblAllOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAllOrders.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblAllOrders.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblAllOrders.Location = new System.Drawing.Point(0, 0);
            this.lblAllOrders.Name = "lblAllOrders";
            this.lblAllOrders.Size = new System.Drawing.Size(822, 54);
            this.lblAllOrders.TabIndex = 0;
            this.lblAllOrders.Text = "All Orders";
            this.lblAllOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnder
            // 
            this.lblUnder.BackColor = System.Drawing.Color.DarkCyan;
            this.lblUnder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUnder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F);
            this.lblUnder.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblUnder.Location = new System.Drawing.Point(0, 580);
            this.lblUnder.Name = "lblUnder";
            this.lblUnder.Size = new System.Drawing.Size(822, 54);
            this.lblUnder.TabIndex = 1;
            this.lblUnder.Text = "All Orders";
            this.lblUnder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(687, 438);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(12, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.ChangeButtonForm);
            this.button1.MouseLeave += new System.EventHandler(this.ResetButtonForm);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblUnder);
            this.Controls.Add(this.lblAllOrders);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersForm";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAllOrders;
        private System.Windows.Forms.Label lblUnder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}