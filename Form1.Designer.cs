namespace HamburgerProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbCondiments = new System.Windows.Forms.GroupBox();
            this.chbSpecialSauce = new System.Windows.Forms.CheckBox();
            this.chbMayonnaise = new System.Windows.Forms.CheckBox();
            this.chbMustard = new System.Windows.Forms.CheckBox();
            this.chbKetchup = new System.Windows.Forms.CheckBox();
            this.gbBun = new System.Windows.Forms.GroupBox();
            this.chbSesameSeed = new System.Windows.Forms.CheckBox();
            this.chbPotatoRolls = new System.Windows.Forms.CheckBox();
            this.chbBrioche = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbPickles = new System.Windows.Forms.CheckBox();
            this.chbCheese = new System.Windows.Forms.CheckBox();
            this.chbTomatoSlices = new System.Windows.Forms.CheckBox();
            this.chbLettuce = new System.Windows.Forms.CheckBox();
            this.chbCaramelized = new System.Windows.Forms.CheckBox();
            this.gbCommonSides = new System.Windows.Forms.GroupBox();
            this.chbOnionRings = new System.Windows.Forms.CheckBox();
            this.chbFrenchFries = new System.Windows.Forms.CheckBox();
            this.chbSeasoning = new System.Windows.Forms.CheckBox();
            this.gbPatty = new System.Windows.Forms.GroupBox();
            this.chbGroundBeef = new System.Windows.Forms.CheckBox();
            this.gbMoreDetails = new System.Windows.Forms.GroupBox();
            this.lblCustomName = new System.Windows.Forms.Label();
            this.textCustomName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAllInvoices = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbCondiments.SuspendLayout();
            this.gbBun.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbCommonSides.SuspendLayout();
            this.gbPatty.SuspendLayout();
            this.gbMoreDetails.SuspendLayout();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Bauhaus 93", 50F);
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1178, 114);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hampurger";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbCondiments
            // 
            this.gbCondiments.BackColor = System.Drawing.Color.Transparent;
            this.gbCondiments.Controls.Add(this.chbSpecialSauce);
            this.gbCondiments.Controls.Add(this.chbMayonnaise);
            this.gbCondiments.Controls.Add(this.chbMustard);
            this.gbCondiments.Controls.Add(this.chbKetchup);
            this.gbCondiments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.gbCondiments.ForeColor = System.Drawing.Color.MintCream;
            this.gbCondiments.Location = new System.Drawing.Point(5, 117);
            this.gbCondiments.Name = "gbCondiments";
            this.gbCondiments.Size = new System.Drawing.Size(332, 207);
            this.gbCondiments.TabIndex = 1;
            this.gbCondiments.TabStop = false;
            this.gbCondiments.Text = "Condiments";
            // 
            // chbSpecialSauce
            // 
            this.chbSpecialSauce.AutoSize = true;
            this.chbSpecialSauce.Location = new System.Drawing.Point(9, 129);
            this.chbSpecialSauce.Name = "chbSpecialSauce";
            this.chbSpecialSauce.Size = new System.Drawing.Size(203, 32);
            this.chbSpecialSauce.TabIndex = 3;
            this.chbSpecialSauce.Tag = "4";
            this.chbSpecialSauce.Text = "Special Sauce";
            this.chbSpecialSauce.UseVisualStyleBackColor = true;
            this.chbSpecialSauce.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbSpecialSauce.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbSpecialSauce.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbMayonnaise
            // 
            this.chbMayonnaise.AutoSize = true;
            this.chbMayonnaise.Location = new System.Drawing.Point(9, 171);
            this.chbMayonnaise.Name = "chbMayonnaise";
            this.chbMayonnaise.Size = new System.Drawing.Size(175, 32);
            this.chbMayonnaise.TabIndex = 2;
            this.chbMayonnaise.Tag = "5";
            this.chbMayonnaise.Text = "Mayonnaise";
            this.chbMayonnaise.UseVisualStyleBackColor = true;
            this.chbMayonnaise.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbMayonnaise.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbMayonnaise.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbMustard
            // 
            this.chbMustard.AutoSize = true;
            this.chbMustard.Location = new System.Drawing.Point(9, 87);
            this.chbMustard.Name = "chbMustard";
            this.chbMustard.Size = new System.Drawing.Size(133, 32);
            this.chbMustard.TabIndex = 1;
            this.chbMustard.Tag = "3";
            this.chbMustard.Text = "Mustard";
            this.chbMustard.UseVisualStyleBackColor = true;
            this.chbMustard.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbMustard.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbMustard.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbKetchup
            // 
            this.chbKetchup.AutoSize = true;
            this.chbKetchup.Location = new System.Drawing.Point(9, 45);
            this.chbKetchup.Name = "chbKetchup";
            this.chbKetchup.Size = new System.Drawing.Size(135, 32);
            this.chbKetchup.TabIndex = 3;
            this.chbKetchup.Tag = "3";
            this.chbKetchup.Text = "Ketchup";
            this.chbKetchup.UseVisualStyleBackColor = true;
            this.chbKetchup.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbKetchup.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbKetchup.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // gbBun
            // 
            this.gbBun.BackColor = System.Drawing.Color.Transparent;
            this.gbBun.Controls.Add(this.chbSesameSeed);
            this.gbBun.Controls.Add(this.chbPotatoRolls);
            this.gbBun.Controls.Add(this.chbBrioche);
            this.gbBun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.gbBun.ForeColor = System.Drawing.Color.MintCream;
            this.gbBun.Location = new System.Drawing.Point(379, 148);
            this.gbBun.Name = "gbBun";
            this.gbBun.Size = new System.Drawing.Size(291, 176);
            this.gbBun.TabIndex = 4;
            this.gbBun.TabStop = false;
            this.gbBun.Text = "The Bun";
            // 
            // chbSesameSeed
            // 
            this.chbSesameSeed.AutoSize = true;
            this.chbSesameSeed.Location = new System.Drawing.Point(9, 129);
            this.chbSesameSeed.Name = "chbSesameSeed";
            this.chbSesameSeed.Size = new System.Drawing.Size(246, 32);
            this.chbSesameSeed.TabIndex = 3;
            this.chbSesameSeed.Tag = "12";
            this.chbSesameSeed.Text = "Sesame Seed Bun";
            this.chbSesameSeed.UseVisualStyleBackColor = true;
            this.chbSesameSeed.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbSesameSeed.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbSesameSeed.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbPotatoRolls
            // 
            this.chbPotatoRolls.AutoSize = true;
            this.chbPotatoRolls.Location = new System.Drawing.Point(9, 87);
            this.chbPotatoRolls.Name = "chbPotatoRolls";
            this.chbPotatoRolls.Size = new System.Drawing.Size(176, 32);
            this.chbPotatoRolls.TabIndex = 1;
            this.chbPotatoRolls.Tag = "7";
            this.chbPotatoRolls.Text = "Potato Rolls";
            this.chbPotatoRolls.UseVisualStyleBackColor = true;
            this.chbPotatoRolls.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbPotatoRolls.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbPotatoRolls.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbBrioche
            // 
            this.chbBrioche.AutoSize = true;
            this.chbBrioche.Location = new System.Drawing.Point(9, 45);
            this.chbBrioche.Name = "chbBrioche";
            this.chbBrioche.Size = new System.Drawing.Size(129, 32);
            this.chbBrioche.TabIndex = 0;
            this.chbBrioche.Tag = "10";
            this.chbBrioche.Text = "Brioche";
            this.chbBrioche.UseVisualStyleBackColor = true;
            this.chbBrioche.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbBrioche.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbBrioche.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chbOnion);
            this.gbToppings.Controls.Add(this.chbPickles);
            this.gbToppings.Controls.Add(this.chbCheese);
            this.gbToppings.Controls.Add(this.chbTomatoSlices);
            this.gbToppings.Controls.Add(this.chbLettuce);
            this.gbToppings.Controls.Add(this.chbCaramelized);
            this.gbToppings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.gbToppings.ForeColor = System.Drawing.Color.MintCream;
            this.gbToppings.Location = new System.Drawing.Point(5, 330);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(332, 176);
            this.gbToppings.TabIndex = 5;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(205, 129);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(106, 32);
            this.chbOnion.TabIndex = 6;
            this.chbOnion.Tag = "2";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbOnion.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbOnion.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbPickles
            // 
            this.chbPickles.AutoSize = true;
            this.chbPickles.Location = new System.Drawing.Point(205, 87);
            this.chbPickles.Name = "chbPickles";
            this.chbPickles.Size = new System.Drawing.Size(123, 32);
            this.chbPickles.TabIndex = 5;
            this.chbPickles.Tag = "4";
            this.chbPickles.Text = "Pickles";
            this.chbPickles.UseVisualStyleBackColor = true;
            this.chbPickles.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbPickles.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbPickles.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbCheese
            // 
            this.chbCheese.AutoSize = true;
            this.chbCheese.Location = new System.Drawing.Point(205, 45);
            this.chbCheese.Name = "chbCheese";
            this.chbCheese.Size = new System.Drawing.Size(125, 32);
            this.chbCheese.TabIndex = 4;
            this.chbCheese.Tag = "6";
            this.chbCheese.Text = "Cheese";
            this.chbCheese.UseVisualStyleBackColor = true;
            this.chbCheese.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbCheese.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbCheese.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbTomatoSlices
            // 
            this.chbTomatoSlices.AutoSize = true;
            this.chbTomatoSlices.Location = new System.Drawing.Point(9, 129);
            this.chbTomatoSlices.Name = "chbTomatoSlices";
            this.chbTomatoSlices.Size = new System.Drawing.Size(201, 32);
            this.chbTomatoSlices.TabIndex = 3;
            this.chbTomatoSlices.Tag = "2";
            this.chbTomatoSlices.Text = "Tomato Slices";
            this.chbTomatoSlices.UseVisualStyleBackColor = true;
            this.chbTomatoSlices.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbTomatoSlices.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbTomatoSlices.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbLettuce
            // 
            this.chbLettuce.AutoSize = true;
            this.chbLettuce.Location = new System.Drawing.Point(9, 87);
            this.chbLettuce.Name = "chbLettuce";
            this.chbLettuce.Size = new System.Drawing.Size(124, 32);
            this.chbLettuce.TabIndex = 1;
            this.chbLettuce.Tag = "2";
            this.chbLettuce.Text = "Lettuce";
            this.chbLettuce.UseVisualStyleBackColor = true;
            this.chbLettuce.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbLettuce.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbLettuce.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbCaramelized
            // 
            this.chbCaramelized.AutoSize = true;
            this.chbCaramelized.Location = new System.Drawing.Point(9, 45);
            this.chbCaramelized.Name = "chbCaramelized";
            this.chbCaramelized.Size = new System.Drawing.Size(186, 32);
            this.chbCaramelized.TabIndex = 0;
            this.chbCaramelized.Tag = "3";
            this.chbCaramelized.Text = "Caramelized";
            this.chbCaramelized.UseVisualStyleBackColor = true;
            this.chbCaramelized.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbCaramelized.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbCaramelized.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // gbCommonSides
            // 
            this.gbCommonSides.BackColor = System.Drawing.Color.Transparent;
            this.gbCommonSides.Controls.Add(this.chbOnionRings);
            this.gbCommonSides.Controls.Add(this.chbFrenchFries);
            this.gbCommonSides.ForeColor = System.Drawing.Color.MintCream;
            this.gbCommonSides.Location = new System.Drawing.Point(379, 330);
            this.gbCommonSides.Name = "gbCommonSides";
            this.gbCommonSides.Size = new System.Drawing.Size(291, 123);
            this.gbCommonSides.TabIndex = 5;
            this.gbCommonSides.TabStop = false;
            this.gbCommonSides.Text = "Common Sides";
            // 
            // chbOnionRings
            // 
            this.chbOnionRings.AutoSize = true;
            this.chbOnionRings.Location = new System.Drawing.Point(9, 87);
            this.chbOnionRings.Name = "chbOnionRings";
            this.chbOnionRings.Size = new System.Drawing.Size(153, 27);
            this.chbOnionRings.TabIndex = 1;
            this.chbOnionRings.Tag = "12";
            this.chbOnionRings.Text = "Onion Rings";
            this.chbOnionRings.UseVisualStyleBackColor = true;
            this.chbOnionRings.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbOnionRings.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbOnionRings.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbFrenchFries
            // 
            this.chbFrenchFries.AutoSize = true;
            this.chbFrenchFries.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.chbFrenchFries.Location = new System.Drawing.Point(9, 54);
            this.chbFrenchFries.Name = "chbFrenchFries";
            this.chbFrenchFries.Size = new System.Drawing.Size(184, 32);
            this.chbFrenchFries.TabIndex = 0;
            this.chbFrenchFries.Tag = "15";
            this.chbFrenchFries.Text = "French Fries";
            this.chbFrenchFries.UseVisualStyleBackColor = true;
            this.chbFrenchFries.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbFrenchFries.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbFrenchFries.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // chbSeasoning
            // 
            this.chbSeasoning.AutoSize = true;
            this.chbSeasoning.Location = new System.Drawing.Point(9, 37);
            this.chbSeasoning.Name = "chbSeasoning";
            this.chbSeasoning.Size = new System.Drawing.Size(159, 32);
            this.chbSeasoning.TabIndex = 1;
            this.chbSeasoning.Tag = "6";
            this.chbSeasoning.Text = "Seasoning";
            this.chbSeasoning.UseVisualStyleBackColor = true;
            this.chbSeasoning.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbSeasoning.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbSeasoning.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // gbPatty
            // 
            this.gbPatty.BackColor = System.Drawing.Color.Transparent;
            this.gbPatty.Controls.Add(this.chbSeasoning);
            this.gbPatty.Controls.Add(this.chbGroundBeef);
            this.gbPatty.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.gbPatty.ForeColor = System.Drawing.Color.MintCream;
            this.gbPatty.Location = new System.Drawing.Point(5, 512);
            this.gbPatty.Name = "gbPatty";
            this.gbPatty.Size = new System.Drawing.Size(665, 70);
            this.gbPatty.TabIndex = 6;
            this.gbPatty.TabStop = false;
            this.gbPatty.Text = "The Patty";
            // 
            // chbGroundBeef
            // 
            this.chbGroundBeef.AutoSize = true;
            this.chbGroundBeef.Location = new System.Drawing.Point(424, 37);
            this.chbGroundBeef.Name = "chbGroundBeef";
            this.chbGroundBeef.Size = new System.Drawing.Size(184, 32);
            this.chbGroundBeef.TabIndex = 0;
            this.chbGroundBeef.Tag = "30";
            this.chbGroundBeef.Text = "Ground Beef";
            this.chbGroundBeef.UseVisualStyleBackColor = true;
            this.chbGroundBeef.CheckedChanged += new System.EventHandler(this.GitTotalOrder_CheckedChanged);
            this.chbGroundBeef.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.chbGroundBeef.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // gbMoreDetails
            // 
            this.gbMoreDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbMoreDetails.Controls.Add(this.lblCustomName);
            this.gbMoreDetails.Controls.Add(this.textCustomName);
            this.gbMoreDetails.Controls.Add(this.lblTotal);
            this.gbMoreDetails.Controls.Add(this.table);
            this.gbMoreDetails.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.gbMoreDetails.ForeColor = System.Drawing.Color.MintCream;
            this.gbMoreDetails.Location = new System.Drawing.Point(704, 148);
            this.gbMoreDetails.Name = "gbMoreDetails";
            this.gbMoreDetails.Size = new System.Drawing.Size(339, 434);
            this.gbMoreDetails.TabIndex = 7;
            this.gbMoreDetails.TabStop = false;
            this.gbMoreDetails.Text = "More Detalis";
            // 
            // lblCustomName
            // 
            this.lblCustomName.AutoSize = true;
            this.lblCustomName.Location = new System.Drawing.Point(36, 262);
            this.lblCustomName.Name = "lblCustomName";
            this.lblCustomName.Size = new System.Drawing.Size(173, 28);
            this.lblCustomName.TabIndex = 5;
            this.lblCustomName.Text = "Custom Name";
            // 
            // textCustomName
            // 
            this.textCustomName.Location = new System.Drawing.Point(40, 288);
            this.textCustomName.Name = "textCustomName";
            this.textCustomName.Size = new System.Drawing.Size(249, 35);
            this.textCustomName.TabIndex = 4;
            this.textCustomName.Text = "Mohammed Alhilali";
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Bernard MT Condensed", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Snow;
            this.lblTotal.Location = new System.Drawing.Point(3, 341);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(333, 90);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "SYR 0";
            // 
            // table
            // 
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table.Controls.Add(this.pictureBox1, 0, 0);
            this.table.Controls.Add(this.lblName, 0, 1);
            this.table.Location = new System.Drawing.Point(46, 45);
            this.table.Name = "table";
            this.table.RowCount = 2;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.41026F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.58974F));
            this.table.Size = new System.Drawing.Size(243, 179);
            this.table.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.lblName.ForeColor = System.Drawing.SystemColors.Window;
            this.lblName.Location = new System.Drawing.Point(3, 136);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(237, 43);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "  ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BriocheIcon.jpg");
            this.imageList1.Images.SetKeyName(1, "CaramelizedIcon.jpg");
            this.imageList1.Images.SetKeyName(2, "CheeseIcon.jpg");
            this.imageList1.Images.SetKeyName(3, "FrenchFriesIcon.jpg");
            this.imageList1.Images.SetKeyName(4, "GroundBeefIcon.jpg");
            this.imageList1.Images.SetKeyName(5, "KetchupIcon.jpg");
            this.imageList1.Images.SetKeyName(6, "LettuceIcon.jpg");
            this.imageList1.Images.SetKeyName(7, "MayonnaiseIcon.jpg");
            this.imageList1.Images.SetKeyName(8, "MustardIcon.jpg");
            this.imageList1.Images.SetKeyName(9, "OnionIcon.jpg");
            this.imageList1.Images.SetKeyName(10, "OnionRingsIcon.jpg");
            this.imageList1.Images.SetKeyName(11, "PicklesIcon.jpg");
            this.imageList1.Images.SetKeyName(12, "PotatoRollsIcon.jpg");
            this.imageList1.Images.SetKeyName(13, "SeasoningIcon.jpg");
            this.imageList1.Images.SetKeyName(14, "SpecialSauceIcon.jpg");
            this.imageList1.Images.SetKeyName(15, "SesameSeedBunIcon.jpg");
            this.imageList1.Images.SetKeyName(16, "TomatoSlicesIcon.jpg");
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOrder.Location = new System.Drawing.Point(1061, 340);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 60);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "ORDER";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.btnOrder.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReset.Location = new System.Drawing.Point(1061, 440);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 60);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.button1_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.btnReset.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTime.Location = new System.Drawing.Point(33, 47);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 37);
            this.lblTime.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.ChangeNowTime);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAllInvoices
            // 
            this.btnAllInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnAllInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllInvoices.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAllInvoices.Location = new System.Drawing.Point(1048, 55);
            this.btnAllInvoices.Name = "btnAllInvoices";
            this.btnAllInvoices.Size = new System.Drawing.Size(124, 48);
            this.btnAllInvoices.TabIndex = 11;
            this.btnAllInvoices.Text = "INVOICES";
            this.btnAllInvoices.UseVisualStyleBackColor = false;
            this.btnAllInvoices.Click += new System.EventHandler(this.btnAllInvoices_Click);
            this.btnAllInvoices.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.btnAllInvoices.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(1048, 6);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 43);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click_1);
            this.btnLogout.MouseEnter += new System.EventHandler(this.ChangeControlForm);
            this.btnLogout.MouseLeave += new System.EventHandler(this.ResetControlForm);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HamburgerProject.Properties.Resources.hampurgerIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1178, 594);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAllInvoices);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbMoreDetails);
            this.Controls.Add(this.gbPatty);
            this.Controls.Add(this.gbCommonSides);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbBun);
            this.Controls.Add(this.gbCondiments);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hampurger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCondiments.ResumeLayout(false);
            this.gbCondiments.PerformLayout();
            this.gbBun.ResumeLayout(false);
            this.gbBun.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbCommonSides.ResumeLayout(false);
            this.gbCommonSides.PerformLayout();
            this.gbPatty.ResumeLayout(false);
            this.gbPatty.PerformLayout();
            this.gbMoreDetails.ResumeLayout(false);
            this.gbMoreDetails.PerformLayout();
            this.table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbCondiments;
        private System.Windows.Forms.CheckBox chbSpecialSauce;
        private System.Windows.Forms.CheckBox chbMayonnaise;
        private System.Windows.Forms.CheckBox chbMustard;
        private System.Windows.Forms.CheckBox chbKetchup;
        private System.Windows.Forms.GroupBox gbBun;
        private System.Windows.Forms.CheckBox chbSesameSeed;
        private System.Windows.Forms.CheckBox chbPotatoRolls;
        private System.Windows.Forms.CheckBox chbBrioche;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbPickles;
        private System.Windows.Forms.CheckBox chbCheese;
        private System.Windows.Forms.CheckBox chbTomatoSlices;
        private System.Windows.Forms.CheckBox chbLettuce;
        private System.Windows.Forms.CheckBox chbCaramelized;
        private System.Windows.Forms.GroupBox gbCommonSides;
        private System.Windows.Forms.CheckBox chbSeasoning;
        private System.Windows.Forms.CheckBox chbFrenchFries;
        private System.Windows.Forms.GroupBox gbPatty;
        private System.Windows.Forms.CheckBox chbGroundBeef;
        private System.Windows.Forms.CheckBox chbOnionRings;
        private System.Windows.Forms.GroupBox gbMoreDetails;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCustomName;
        private System.Windows.Forms.TextBox textCustomName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAllInvoices;
        private System.Windows.Forms.Button btnLogout;
    }
}

