using MetroFramework.Controls;
namespace HMS
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            this.lblPatientDetails = new System.Windows.Forms.Label();
            this.lblPatirntProblem = new System.Windows.Forms.Label();
            this.lblPatientContact = new System.Windows.Forms.Label();
            this.lblPatientAddress = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.DropProblem = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.LblAvilableDoctors = new System.Windows.Forms.Label();
            this.DropAvDoctors = new Bunifu.Framework.UI.BunifuDropdown();
            this.PaymentCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SidePanel = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.SideName = new System.Windows.Forms.Label();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtPatientContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPatientName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnbloodbank = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnEmergancy = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnAddPAtient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientDetails
            // 
            this.lblPatientDetails.AutoSize = true;
            this.lblPatientDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.lblPatientDetails.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblPatientDetails.Location = new System.Drawing.Point(304, 7);
            this.lblPatientDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientDetails.Name = "lblPatientDetails";
            this.lblPatientDetails.Size = new System.Drawing.Size(175, 28);
            this.lblPatientDetails.TabIndex = 2;
            this.lblPatientDetails.Text = "Patient Details";
            // 
            // lblPatirntProblem
            // 
            this.lblPatirntProblem.AutoSize = true;
            this.lblPatirntProblem.BackColor = System.Drawing.Color.Transparent;
            this.lblPatirntProblem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatirntProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblPatirntProblem.Location = new System.Drawing.Point(346, 369);
            this.lblPatirntProblem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatirntProblem.Name = "lblPatirntProblem";
            this.lblPatirntProblem.Size = new System.Drawing.Size(127, 30);
            this.lblPatirntProblem.TabIndex = 4;
            this.lblPatirntProblem.Text = "Problem -";
            // 
            // lblPatientContact
            // 
            this.lblPatientContact.AutoSize = true;
            this.lblPatientContact.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientContact.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblPatientContact.Location = new System.Drawing.Point(346, 306);
            this.lblPatientContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientContact.Name = "lblPatientContact";
            this.lblPatientContact.Size = new System.Drawing.Size(127, 30);
            this.lblPatientContact.TabIndex = 5;
            this.lblPatientContact.Text = "Contact -";
            // 
            // lblPatientAddress
            // 
            this.lblPatientAddress.AutoSize = true;
            this.lblPatientAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientAddress.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblPatientAddress.Location = new System.Drawing.Point(346, 243);
            this.lblPatientAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientAddress.Name = "lblPatientAddress";
            this.lblPatientAddress.Size = new System.Drawing.Size(120, 30);
            this.lblPatientAddress.TabIndex = 6;
            this.lblPatientAddress.Text = "Address -";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblPatientName.Location = new System.Drawing.Point(346, 180);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(192, 30);
            this.lblPatientName.TabIndex = 4;
            this.lblPatientName.Text = "Patient Name -";
            // 
            // DropProblem
            // 
            this.DropProblem.BackColor = System.Drawing.Color.Transparent;
            this.DropProblem.BorderRadius = 3;
            this.DropProblem.DisabledColor = System.Drawing.Color.Gray;
            this.DropProblem.ForeColor = System.Drawing.Color.White;
            this.DropProblem.Items = new string[0];
            this.DropProblem.Location = new System.Drawing.Point(587, 364);
            this.DropProblem.Name = "DropProblem";
            this.DropProblem.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.DropProblem.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.DropProblem.selectedIndex = -1;
            this.DropProblem.Size = new System.Drawing.Size(470, 35);
            this.DropProblem.TabIndex = 4;
            this.DropProblem.onItemSelected += new System.EventHandler(this.DropProblem_onItemSelected);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnSubmit.Location = new System.Drawing.Point(991, 635);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 52);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LblAvilableDoctors
            // 
            this.LblAvilableDoctors.AutoSize = true;
            this.LblAvilableDoctors.BackColor = System.Drawing.Color.Transparent;
            this.LblAvilableDoctors.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvilableDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.LblAvilableDoctors.Location = new System.Drawing.Point(346, 429);
            this.LblAvilableDoctors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAvilableDoctors.Name = "LblAvilableDoctors";
            this.LblAvilableDoctors.Size = new System.Drawing.Size(209, 30);
            this.LblAvilableDoctors.TabIndex = 4;
            this.LblAvilableDoctors.Text = "Avilable Doctors";
            // 
            // DropAvDoctors
            // 
            this.DropAvDoctors.BackColor = System.Drawing.Color.Transparent;
            this.DropAvDoctors.BorderRadius = 3;
            this.DropAvDoctors.DisabledColor = System.Drawing.Color.Gray;
            this.DropAvDoctors.ForeColor = System.Drawing.Color.White;
            this.DropAvDoctors.Items = new string[0];
            this.DropAvDoctors.Location = new System.Drawing.Point(587, 424);
            this.DropAvDoctors.Name = "DropAvDoctors";
            this.DropAvDoctors.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(80)))));
            this.DropAvDoctors.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(49)))), ((int)(((byte)(40)))));
            this.DropAvDoctors.selectedIndex = -1;
            this.DropAvDoctors.Size = new System.Drawing.Size(470, 35);
            this.DropAvDoctors.TabIndex = 5;
            this.DropAvDoctors.Click += new System.EventHandler(this.DropAvDoctors_Click);
            // 
            // PaymentCheckBox
            // 
            this.PaymentCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.PaymentCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.PaymentCheckBox.Checked = true;
            this.PaymentCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.PaymentCheckBox.ForeColor = System.Drawing.Color.White;
            this.PaymentCheckBox.Location = new System.Drawing.Point(770, 529);
            this.PaymentCheckBox.Name = "PaymentCheckBox";
            this.PaymentCheckBox.Size = new System.Drawing.Size(20, 20);
            this.PaymentCheckBox.TabIndex = 6;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblPayment.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblPayment.Location = new System.Drawing.Point(646, 519);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(119, 30);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.SidePanel.Controls.Add(this.btnAppointments);
            this.SidePanel.Controls.Add(this.btnbloodbank);
            this.SidePanel.Controls.Add(this.btnDashbord);
            this.SidePanel.Controls.Add(this.btnSetting);
            this.SidePanel.Controls.Add(this.btnEmergancy);
            this.SidePanel.Controls.Add(this.btnDoctors);
            this.SidePanel.Controls.Add(this.btnAddPAtient);
            this.SidePanel.Controls.Add(this.User);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(290, 699);
            this.SidePanel.TabIndex = 23;
            // 
            // User
            // 
            this.User.Controls.Add(this.label9);
            this.User.Controls.Add(this.SideName);
            this.User.Controls.Add(this.pictureBox1);
            this.User.Dock = System.Windows.Forms.DockStyle.Top;
            this.User.Location = new System.Drawing.Point(0, 0);
            this.User.Margin = new System.Windows.Forms.Padding(2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(290, 189);
            this.User.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(75, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 29;
            this.label9.Text = "Panskura,Purba Medinipur\r\n                  721152\r\n";
            // 
            // SideName
            // 
            this.SideName.AutoSize = true;
            this.SideName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(144)))), ((int)(((byte)(243)))));
            this.SideName.Location = new System.Drawing.Point(58, 101);
            this.SideName.Margin = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.SideName.Name = "SideName";
            this.SideName.Size = new System.Drawing.Size(179, 30);
            this.SideName.TabIndex = 1;
            this.SideName.Text = "Local Hospital";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(492, 12);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 29);
            this.DateTime.TabIndex = 24;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1116, 9);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox3.TabIndex = 25;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1081, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 29);
            this.guna2ControlBox1.TabIndex = 25;
            // 
            // txtPatientContact
            // 
            this.txtPatientContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientContact.DefaultText = "";
            this.txtPatientContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientContact.DisabledState.Parent = this.txtPatientContact;
            this.txtPatientContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientContact.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtPatientContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientContact.FocusedState.Parent = this.txtPatientContact;
            this.txtPatientContact.ForeColor = System.Drawing.Color.White;
            this.txtPatientContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientContact.HoverState.Parent = this.txtPatientContact;
            this.txtPatientContact.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPatientContact.IconLeft")));
            this.txtPatientContact.Location = new System.Drawing.Point(587, 306);
            this.txtPatientContact.Name = "txtPatientContact";
            this.txtPatientContact.PasswordChar = '\0';
            this.txtPatientContact.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientContact.PlaceholderText = "Enter Contact Number";
            this.txtPatientContact.SelectedText = "";
            this.txtPatientContact.ShadowDecoration.Parent = this.txtPatientContact;
            this.txtPatientContact.Size = new System.Drawing.Size(470, 36);
            this.txtPatientContact.TabIndex = 3;
            this.txtPatientContact.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientAddress.DefaultText = "";
            this.txtPatientAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientAddress.DisabledState.Parent = this.txtPatientAddress;
            this.txtPatientAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientAddress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtPatientAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientAddress.FocusedState.Parent = this.txtPatientAddress;
            this.txtPatientAddress.ForeColor = System.Drawing.Color.White;
            this.txtPatientAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientAddress.HoverState.Parent = this.txtPatientAddress;
            this.txtPatientAddress.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPatientAddress.IconLeft")));
            this.txtPatientAddress.Location = new System.Drawing.Point(587, 243);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.PasswordChar = '\0';
            this.txtPatientAddress.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientAddress.PlaceholderText = "Enter Address";
            this.txtPatientAddress.SelectedText = "";
            this.txtPatientAddress.ShadowDecoration.Parent = this.txtPatientAddress;
            this.txtPatientAddress.Size = new System.Drawing.Size(470, 36);
            this.txtPatientAddress.TabIndex = 2;
            this.txtPatientAddress.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPatientName.DefaultText = "";
            this.txtPatientName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPatientName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPatientName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientName.DisabledState.Parent = this.txtPatientName;
            this.txtPatientName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPatientName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtPatientName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientName.FocusedState.Parent = this.txtPatientName;
            this.txtPatientName.ForeColor = System.Drawing.Color.White;
            this.txtPatientName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPatientName.HoverState.Parent = this.txtPatientName;
            this.txtPatientName.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPatientName.IconLeft")));
            this.txtPatientName.Location = new System.Drawing.Point(587, 180);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.PasswordChar = '\0';
            this.txtPatientName.PlaceholderForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPatientName.PlaceholderText = "Enter Name";
            this.txtPatientName.SelectedText = "";
            this.txtPatientName.ShadowDecoration.Parent = this.txtPatientName;
            this.txtPatientName.Size = new System.Drawing.Size(470, 36);
            this.txtPatientName.TabIndex = 1;
            this.txtPatientName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.Color.Transparent;
            this.btnAppointments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointments.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnAppointments.Image = global::HMS.Properties.Resources.icons8_appointment_scheduling_24px;
            this.btnAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointments.Location = new System.Drawing.Point(0, 399);
            this.btnAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(290, 42);
            this.btnAppointments.TabIndex = 7;
            this.btnAppointments.Text = "Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnbloodbank
            // 
            this.btnbloodbank.BackColor = System.Drawing.Color.Transparent;
            this.btnbloodbank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnbloodbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbloodbank.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbloodbank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnbloodbank.Image = global::HMS.Properties.Resources.icons8_drop_of_blood_24px;
            this.btnbloodbank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbloodbank.Location = new System.Drawing.Point(0, 357);
            this.btnbloodbank.Margin = new System.Windows.Forms.Padding(2);
            this.btnbloodbank.Name = "btnbloodbank";
            this.btnbloodbank.Size = new System.Drawing.Size(290, 42);
            this.btnbloodbank.TabIndex = 6;
            this.btnbloodbank.Text = "Blood Bank";
            this.btnbloodbank.UseVisualStyleBackColor = false;
            this.btnbloodbank.Click += new System.EventHandler(this.btnbloodbank_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.BackColor = System.Drawing.Color.Transparent;
            this.btnDashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashbord.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnDashbord.Image = global::HMS.Properties.Resources.icons8_line_chart_16px;
            this.btnDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashbord.Location = new System.Drawing.Point(0, 315);
            this.btnDashbord.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(290, 42);
            this.btnDashbord.TabIndex = 6;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.UseVisualStyleBackColor = false;
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnSetting.Image = global::HMS.Properties.Resources.icons8_settings_24px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 654);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(287, 42);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnEmergancy
            // 
            this.btnEmergancy.BackColor = System.Drawing.Color.Transparent;
            this.btnEmergancy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmergancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergancy.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmergancy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnEmergancy.Image = global::HMS.Properties.Resources.icons8_hospital_24px;
            this.btnEmergancy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmergancy.Location = new System.Drawing.Point(0, 273);
            this.btnEmergancy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmergancy.Name = "btnEmergancy";
            this.btnEmergancy.Size = new System.Drawing.Size(290, 42);
            this.btnEmergancy.TabIndex = 2;
            this.btnEmergancy.Text = "Emargency";
            this.btnEmergancy.UseVisualStyleBackColor = false;
            this.btnEmergancy.Click += new System.EventHandler(this.btnEmergancy_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctors.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnDoctors.Image = global::HMS.Properties.Resources.icons8_doctor_male_24px;
            this.btnDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctors.Location = new System.Drawing.Point(0, 231);
            this.btnDoctors.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(290, 42);
            this.btnDoctors.TabIndex = 3;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseVisualStyleBackColor = false;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // btnAddPAtient
            // 
            this.btnAddPAtient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPAtient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPAtient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPAtient.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPAtient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnAddPAtient.Image = global::HMS.Properties.Resources.icons8_user_24px;
            this.btnAddPAtient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPAtient.Location = new System.Drawing.Point(0, 189);
            this.btnAddPAtient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPAtient.Name = "btnAddPAtient";
            this.btnAddPAtient.Size = new System.Drawing.Size(290, 42);
            this.btnAddPAtient.TabIndex = 4;
            this.btnAddPAtient.Text = "Add Patients";
            this.btnAddPAtient.UseVisualStyleBackColor = false;
            this.btnAddPAtient.Click += new System.EventHandler(this.btnAddPAtient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.icons8_hospital_3_96px_3;
            this.pictureBox1.Location = new System.Drawing.Point(98, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.txtPatientContact);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.PaymentCheckBox);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.DropAvDoctors);
            this.Controls.Add(this.DropProblem);
            this.Controls.Add(this.lblPatientAddress);
            this.Controls.Add(this.lblPatientContact);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.LblAvilableDoctors);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblPatirntProblem);
            this.Controls.Add(this.lblPatientDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPatientDetails;
        private System.Windows.Forms.Label lblPatirntProblem;
        private System.Windows.Forms.Label lblPatientContact;
        private System.Windows.Forms.Label lblPatientAddress;
        private System.Windows.Forms.Label lblPatientName;
        private Bunifu.Framework.UI.BunifuDropdown DropProblem;
        //private MetroFramework.Controls.MetroDateTime DateTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label LblAvilableDoctors;
        private Bunifu.Framework.UI.BunifuDropdown DropAvDoctors;
        private Bunifu.Framework.UI.BunifuCheckbox PaymentCheckBox;
        private System.Windows.Forms.Label lblPayment;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnbloodbank;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnEmergancy;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAddPAtient;
        private System.Windows.Forms.Panel User;
        private System.Windows.Forms.Label SideName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientContact;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtPatientName;
        private MetroDateTime DateTime;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
    }
}