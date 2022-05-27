
namespace HMS
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnAboutus = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnbloodbank = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnEmergancy = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnAddPAtient = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.SideName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.lblDoctors = new System.Windows.Forms.Label();
            this.DropDoctors = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtTotalPatients = new System.Windows.Forms.TextBox();
            this.lblPatients = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.DropSection = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DataGridAppoinments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SwicthChnageAppoinmet = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SidePanel.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppoinments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.SidePanel.Controls.Add(this.btnAboutus);
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
            this.SidePanel.TabIndex = 0;
            // 
            // btnAboutus
            // 
            this.btnAboutus.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnAboutus.Image = global::HMS.Properties.Resources.icons8_user_32px;
            this.btnAboutus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutus.Location = new System.Drawing.Point(0, 441);
            this.btnAboutus.Margin = new System.Windows.Forms.Padding(2);
            this.btnAboutus.Name = "btnAboutus";
            this.btnAboutus.Size = new System.Drawing.Size(290, 42);
            this.btnAboutus.TabIndex = 11;
            this.btnAboutus.Text = "About Us";
            this.btnAboutus.UseVisualStyleBackColor = false;
            this.btnAboutus.Click += new System.EventHandler(this.btnAboutus_Click);
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
            this.btnDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctors.Image")));
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
            this.label9.Location = new System.Drawing.Point(69, 131);
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
            this.SideName.Location = new System.Drawing.Point(55, 101);
            this.SideName.Margin = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.SideName.Name = "SideName";
            this.SideName.Size = new System.Drawing.Size(179, 30);
            this.SideName.TabIndex = 1;
            this.SideName.Text = "Local Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.icons8_hospital_3_96px_3;
            this.pictureBox1.Location = new System.Drawing.Point(103, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblAppointments.Location = new System.Drawing.Point(295, 9);
            this.lblAppointments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(174, 28);
            this.lblAppointments.TabIndex = 2;
            this.lblAppointments.Text = "Appointments";
            // 
            // lblDoctors
            // 
            this.lblDoctors.AutoSize = true;
            this.lblDoctors.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblDoctors.Location = new System.Drawing.Point(375, 117);
            this.lblDoctors.Name = "lblDoctors";
            this.lblDoctors.Size = new System.Drawing.Size(116, 21);
            this.lblDoctors.TabIndex = 4;
            this.lblDoctors.Text = "Select Doctor";
            // 
            // DropDoctors
            // 
            this.DropDoctors.BackColor = System.Drawing.Color.Transparent;
            this.DropDoctors.BorderRadius = 3;
            this.DropDoctors.DisabledColor = System.Drawing.Color.Gray;
            this.DropDoctors.ForeColor = System.Drawing.Color.White;
            this.DropDoctors.Items = new string[0];
            this.DropDoctors.Location = new System.Drawing.Point(497, 108);
            this.DropDoctors.Name = "DropDoctors";
            this.DropDoctors.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.DropDoctors.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.DropDoctors.selectedIndex = -1;
            this.DropDoctors.Size = new System.Drawing.Size(287, 30);
            this.DropDoctors.TabIndex = 2;
            this.DropDoctors.onItemSelected += new System.EventHandler(this.DropDoctors_onItemSelected);
            // 
            // txtTotalPatients
            // 
            this.txtTotalPatients.Location = new System.Drawing.Point(1025, 212);
            this.txtTotalPatients.Name = "txtTotalPatients";
            this.txtTotalPatients.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPatients.TabIndex = 22;
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPatients.Location = new System.Drawing.Point(924, 212);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(94, 17);
            this.lblPatients.TabIndex = 21;
            this.lblPatients.Text = "Total Patients";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(361, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "Today\'s Appoinment -";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblSection.Location = new System.Drawing.Point(375, 70);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(120, 21);
            this.lblSection.TabIndex = 4;
            this.lblSection.Text = "Select Section";
            // 
            // DropSection
            // 
            this.DropSection.BackColor = System.Drawing.Color.Transparent;
            this.DropSection.BorderRadius = 3;
            this.DropSection.DisabledColor = System.Drawing.Color.Gray;
            this.DropSection.ForeColor = System.Drawing.Color.White;
            this.DropSection.Items = new string[0];
            this.DropSection.Location = new System.Drawing.Point(497, 61);
            this.DropSection.Name = "DropSection";
            this.DropSection.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.DropSection.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.DropSection.selectedIndex = -1;
            this.DropSection.Size = new System.Drawing.Size(287, 30);
            this.DropSection.TabIndex = 1;
            this.DropSection.onItemSelected += new System.EventHandler(this.DropSection_onItemSelected);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // DataGridAppoinments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridAppoinments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridAppoinments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridAppoinments.BackgroundColor = System.Drawing.Color.White;
            this.DataGridAppoinments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridAppoinments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridAppoinments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridAppoinments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridAppoinments.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridAppoinments.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridAppoinments.EnableHeadersVisualStyles = false;
            this.DataGridAppoinments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridAppoinments.Location = new System.Drawing.Point(366, 273);
            this.DataGridAppoinments.Name = "DataGridAppoinments";
            this.DataGridAppoinments.RowHeadersVisible = false;
            this.DataGridAppoinments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAppoinments.Size = new System.Drawing.Size(759, 350);
            this.DataGridAppoinments.TabIndex = 23;
            this.DataGridAppoinments.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridAppoinments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridAppoinments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridAppoinments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridAppoinments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridAppoinments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridAppoinments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridAppoinments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridAppoinments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridAppoinments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridAppoinments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridAppoinments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridAppoinments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridAppoinments.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridAppoinments.ThemeStyle.ReadOnly = false;
            this.DataGridAppoinments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridAppoinments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridAppoinments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridAppoinments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridAppoinments.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridAppoinments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridAppoinments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1084, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(29, 26);
            this.guna2ControlBox2.TabIndex = 25;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1116, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 26);
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // SwicthChnageAppoinmet
            // 
            this.SwicthChnageAppoinmet.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwicthChnageAppoinmet.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SwicthChnageAppoinmet.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwicthChnageAppoinmet.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SwicthChnageAppoinmet.CheckedState.Parent = this.SwicthChnageAppoinmet;
            this.SwicthChnageAppoinmet.Location = new System.Drawing.Point(986, 669);
            this.SwicthChnageAppoinmet.Name = "SwicthChnageAppoinmet";
            this.SwicthChnageAppoinmet.ShadowDecoration.Parent = this.SwicthChnageAppoinmet;
            this.SwicthChnageAppoinmet.Size = new System.Drawing.Size(35, 20);
            this.SwicthChnageAppoinmet.TabIndex = 27;
            this.SwicthChnageAppoinmet.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwicthChnageAppoinmet.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SwicthChnageAppoinmet.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SwicthChnageAppoinmet.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SwicthChnageAppoinmet.UncheckedState.Parent = this.SwicthChnageAppoinmet;
            this.SwicthChnageAppoinmet.CheckedChanged += new System.EventHandler(this.SwicthChnageAppoinmet_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(910, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(1027, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emergency";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(914, 659);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator1.TabIndex = 28;
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(497, 11);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 29);
            this.DateTime.TabIndex = 29;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.SwicthChnageAppoinmet);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.DataGridAppoinments);
            this.Controls.Add(this.txtTotalPatients);
            this.Controls.Add(this.lblPatients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DropSection);
            this.Controls.Add(this.DropDoctors);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDoctors);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.guna2Separator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.SidePanel.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAppoinments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel User;
        private System.Windows.Forms.Label SideName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmergancy;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAddPAtient;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Label lblDoctors;
        private Bunifu.Framework.UI.BunifuDropdown DropDoctors;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnbloodbank;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.TextBox txtTotalPatients;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSection;
        private Bunifu.Framework.UI.BunifuDropdown DropSection;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridAppoinments;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button btnAboutus;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SwicthChnageAppoinmet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private MetroFramework.Controls.MetroDateTime DateTime;
        private System.Windows.Forms.Label label9;
    }
}