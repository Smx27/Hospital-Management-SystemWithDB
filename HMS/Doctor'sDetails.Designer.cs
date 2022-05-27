
namespace HMS
{
    partial class DoctorDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDocDetails = new System.Windows.Forms.Label();
            this.lblDocSec = new System.Windows.Forms.Label();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DropDocSec = new Bunifu.Framework.UI.BunifuDropdown();
            this.DocView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnbloodbank = new System.Windows.Forms.Button();
            this.btnDashbord = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnEmergancy = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.btnAddPAtient = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SideName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.User = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.User.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocDetails
            // 
            this.lblDocDetails.AutoSize = true;
            this.lblDocDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.lblDocDetails.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblDocDetails.Location = new System.Drawing.Point(314, 7);
            this.lblDocDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocDetails.Name = "lblDocDetails";
            this.lblDocDetails.Size = new System.Drawing.Size(197, 28);
            this.lblDocDetails.TabIndex = 3;
            this.lblDocDetails.Text = "Doctor\'s  Details";
            // 
            // lblDocSec
            // 
            this.lblDocSec.AutoSize = true;
            this.lblDocSec.BackColor = System.Drawing.Color.Transparent;
            this.lblDocSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDocSec.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lblDocSec.Location = new System.Drawing.Point(390, 132);
            this.lblDocSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocSec.Name = "lblDocSec";
            this.lblDocSec.Size = new System.Drawing.Size(190, 30);
            this.lblDocSec.TabIndex = 5;
            this.lblDocSec.Text = "Doctor Section";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(878, 12);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 14;
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
            this.SidePanel.TabIndex = 16;
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
            // DropDocSec
            // 
            this.DropDocSec.BackColor = System.Drawing.Color.Transparent;
            this.DropDocSec.BorderRadius = 3;
            this.DropDocSec.DisabledColor = System.Drawing.Color.Gray;
            this.DropDocSec.ForeColor = System.Drawing.Color.White;
            this.DropDocSec.Items = new string[0];
            this.DropDocSec.Location = new System.Drawing.Point(585, 132);
            this.DropDocSec.Name = "DropDocSec";
            this.DropDocSec.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.DropDocSec.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(62)))));
            this.DropDocSec.selectedIndex = -1;
            this.DropDocSec.Size = new System.Drawing.Size(470, 35);
            this.DropDocSec.TabIndex = 18;
            this.DropDocSec.onItemSelected += new System.EventHandler(this.DropDocSec_onItemSelected);
            // 
            // DocView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DocView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DocView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DocView.BackgroundColor = System.Drawing.Color.White;
            this.DocView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DocView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DocView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DocView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DocView.DefaultCellStyle = dataGridViewCellStyle6;
            this.DocView.EnableHeadersVisualStyles = false;
            this.DocView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DocView.Location = new System.Drawing.Point(380, 207);
            this.DocView.Name = "DocView";
            this.DocView.RowHeadersVisible = false;
            this.DocView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DocView.Size = new System.Drawing.Size(675, 312);
            this.DocView.TabIndex = 19;
            this.DocView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.DocView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.DocView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DocView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DocView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DocView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DocView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DocView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.DocView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.DocView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DocView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DocView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DocView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DocView.ThemeStyle.HeaderStyle.Height = 4;
            this.DocView.ThemeStyle.ReadOnly = false;
            this.DocView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.DocView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DocView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DocView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DocView.ThemeStyle.RowsStyle.Height = 22;
            this.DocView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.DocView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1116, 7);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 26);
            this.guna2ControlBox1.TabIndex = 20;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(1084, 7);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(29, 26);
            this.guna2ControlBox2.TabIndex = 20;
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
            this.btnAppointments.TabIndex = 15;
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
            this.btnbloodbank.TabIndex = 13;
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
            this.btnDashbord.TabIndex = 14;
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
            this.btnSetting.Location = new System.Drawing.Point(0, 655);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(287, 42);
            this.btnSetting.TabIndex = 12;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click_1);
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
            this.btnEmergancy.TabIndex = 9;
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
            this.btnDoctors.TabIndex = 10;
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
            this.btnAddPAtient.TabIndex = 11;
            this.btnAddPAtient.Text = "Add Patients";
            this.btnAddPAtient.UseVisualStyleBackColor = false;
            this.btnAddPAtient.Click += new System.EventHandler(this.btnAddPAtient_Click);
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
            this.User.TabIndex = 8;
            // 
            // DoctorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.DocView);
            this.Controls.Add(this.DropDocSec);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.lblDocSec);
            this.Controls.Add(this.lblDocDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DoctorDetails_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DocView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDocDetails;
        private System.Windows.Forms.Label lblDocSec;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Panel SidePanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDropdown DropDocSec;
        private Guna.UI2.WinForms.Guna2DataGridView DocView;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnbloodbank;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnEmergancy;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAddPAtient;
        private System.Windows.Forms.Panel User;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SideName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}