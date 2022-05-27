
namespace HMS
{
    partial class BloodBank
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBloodBank = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.lblAvailableBloods = new System.Windows.Forms.Label();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblavailableBlood = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.AvailableBloodList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SidePanel.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableBloodList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBloodBank
            // 
            this.lblBloodBank.AutoSize = true;
            this.lblBloodBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.lblBloodBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBloodBank.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBloodBank.Location = new System.Drawing.Point(314, 7);
            this.lblBloodBank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBloodBank.Name = "lblBloodBank";
            this.lblBloodBank.Size = new System.Drawing.Size(143, 28);
            this.lblBloodBank.TabIndex = 6;
            this.lblBloodBank.Text = "Blood Bank";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(792, 12);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 17;
            // 
            // lblAvailableBloods
            // 
            this.lblAvailableBloods.AutoSize = true;
            this.lblAvailableBloods.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableBloods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailableBloods.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBloods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAvailableBloods.Location = new System.Drawing.Point(412, 191);
            this.lblAvailableBloods.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableBloods.Name = "lblAvailableBloods";
            this.lblAvailableBloods.Size = new System.Drawing.Size(177, 30);
            this.lblAvailableBloods.TabIndex = 18;
            this.lblAvailableBloods.Text = "Donate Blood";
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "B+",
        "B-",
        "A+",
        "A-",
        "O+",
        "O-",
        "Ab+",
        "Ab-"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(638, 191);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(368, 35);
            this.bunifuDropdown1.TabIndex = 19;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblavailableBlood
            // 
            this.lblavailableBlood.AutoSize = true;
            this.lblavailableBlood.BackColor = System.Drawing.Color.Transparent;
            this.lblavailableBlood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblavailableBlood.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailableBlood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblavailableBlood.Location = new System.Drawing.Point(387, 285);
            this.lblavailableBlood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblavailableBlood.Name = "lblavailableBlood";
            this.lblavailableBlood.Size = new System.Drawing.Size(202, 30);
            this.lblavailableBlood.TabIndex = 18;
            this.lblavailableBlood.Text = "Available Blood";
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
            this.label9.Location = new System.Drawing.Point(70, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 32);
            this.label9.TabIndex = 32;
            this.label9.Text = "Panskura,Purba Medinipur\r\n                  721152\r\n";
            // 
            // SideName
            // 
            this.SideName.AutoSize = true;
            this.SideName.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SideName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(144)))), ((int)(((byte)(243)))));
            this.SideName.Location = new System.Drawing.Point(56, 105);
            this.SideName.Margin = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.SideName.Name = "SideName";
            this.SideName.Size = new System.Drawing.Size(179, 30);
            this.SideName.TabIndex = 31;
            this.SideName.Text = "Local Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HMS.Properties.Resources.icons8_hospital_3_96px_3;
            this.pictureBox1.Location = new System.Drawing.Point(104, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(1004, 646);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // AvailableBloodList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AvailableBloodList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AvailableBloodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AvailableBloodList.BackgroundColor = System.Drawing.Color.White;
            this.AvailableBloodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AvailableBloodList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AvailableBloodList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AvailableBloodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AvailableBloodList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AvailableBloodList.DefaultCellStyle = dataGridViewCellStyle3;
            this.AvailableBloodList.EnableHeadersVisualStyles = false;
            this.AvailableBloodList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvailableBloodList.Location = new System.Drawing.Point(638, 249);
            this.AvailableBloodList.Name = "AvailableBloodList";
            this.AvailableBloodList.RowHeadersVisible = false;
            this.AvailableBloodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableBloodList.Size = new System.Drawing.Size(368, 177);
            this.AvailableBloodList.TabIndex = 24;
            this.AvailableBloodList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.AvailableBloodList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AvailableBloodList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AvailableBloodList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AvailableBloodList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AvailableBloodList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AvailableBloodList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AvailableBloodList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvailableBloodList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AvailableBloodList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AvailableBloodList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AvailableBloodList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AvailableBloodList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AvailableBloodList.ThemeStyle.HeaderStyle.Height = 4;
            this.AvailableBloodList.ThemeStyle.ReadOnly = false;
            this.AvailableBloodList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AvailableBloodList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AvailableBloodList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AvailableBloodList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AvailableBloodList.ThemeStyle.RowsStyle.Height = 22;
            this.AvailableBloodList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AvailableBloodList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1109, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(37, 29);
            this.guna2ControlBox1.TabIndex = 25;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1066, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(37, 29);
            this.guna2ControlBox2.TabIndex = 25;
            // 
            // BloodBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.AvailableBloodList);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.lblavailableBlood);
            this.Controls.Add(this.lblAvailableBloods);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.lblBloodBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BloodBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodBank";
            this.Load += new System.EventHandler(this.BloodBank_Load);
            this.SidePanel.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableBloodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBloodBank;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Label lblAvailableBloods;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblavailableBlood;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnbloodbank;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnEmergancy;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAddPAtient;
        private System.Windows.Forms.Panel User;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView AvailableBloodList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SideName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}