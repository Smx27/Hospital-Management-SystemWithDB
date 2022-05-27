
namespace HMS
{
    partial class Emargency
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lb = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSex = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBloodGroup = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCause = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdmitedby = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dropAvilableDoc = new Bunifu.Framework.UI.BunifuDropdown();
            this.droupAvilableBed = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchPatient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDischarge = new Guna.UI2.WinForms.Guna2Button();
            this.SidePanel.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.lb.Location = new System.Drawing.Point(295, 9);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(214, 28);
            this.lb.TabIndex = 5;
            this.lb.Text = "Emargency Ward";
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
            this.SidePanel.TabIndex = 6;
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
            this.btnAppointments.TabIndex = 18;
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
            this.btnbloodbank.TabIndex = 17;
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
            this.btnDashbord.TabIndex = 16;
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
            this.btnSetting.TabIndex = 19;
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
            this.btnEmergancy.TabIndex = 14;
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
            this.btnDoctors.TabIndex = 12;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(405, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Animated = true;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.IconLeft = global::HMS.Properties.Resources.icons8_cast_24px;
            this.txtName.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtName.Location = new System.Drawing.Point(544, 197);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Patient Name";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(489, 27);
            this.txtName.TabIndex = 1;
            this.txtName.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(405, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex";
            // 
            // txtSex
            // 
            this.txtSex.Animated = true;
            this.txtSex.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female\t",
            "Others"});
            this.txtSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSex.DefaultText = "";
            this.txtSex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSex.DisabledState.Parent = this.txtSex;
            this.txtSex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtSex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSex.FocusedState.Parent = this.txtSex;
            this.txtSex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.ForeColor = System.Drawing.Color.White;
            this.txtSex.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSex.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtSex.HoverState.Parent = this.txtSex;
            this.txtSex.IconLeft = global::HMS.Properties.Resources.icons8_gender_50px;
            this.txtSex.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSex.Location = new System.Drawing.Point(544, 243);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4);
            this.txtSex.Name = "txtSex";
            this.txtSex.PasswordChar = '\0';
            this.txtSex.PlaceholderText = "Enter Gender";
            this.txtSex.SelectedText = "";
            this.txtSex.ShadowDecoration.Parent = this.txtSex;
            this.txtSex.Size = new System.Drawing.Size(489, 27);
            this.txtSex.TabIndex = 2;
            this.txtSex.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(405, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blood Group";
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Animated = true;
            this.txtBloodGroup.AutoCompleteCustomSource.AddRange(new string[] {
            "B+",
            "B-",
            "A+",
            "A-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.txtBloodGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBloodGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBloodGroup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBloodGroup.DefaultText = "";
            this.txtBloodGroup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBloodGroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBloodGroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBloodGroup.DisabledState.Parent = this.txtBloodGroup;
            this.txtBloodGroup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBloodGroup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtBloodGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBloodGroup.FocusedState.Parent = this.txtBloodGroup;
            this.txtBloodGroup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBloodGroup.ForeColor = System.Drawing.Color.White;
            this.txtBloodGroup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBloodGroup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtBloodGroup.HoverState.Parent = this.txtBloodGroup;
            this.txtBloodGroup.IconLeft = global::HMS.Properties.Resources.icons8_drop_of_blood_24px;
            this.txtBloodGroup.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtBloodGroup.Location = new System.Drawing.Point(544, 289);
            this.txtBloodGroup.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.PasswordChar = '\0';
            this.txtBloodGroup.PlaceholderText = "Enter Blood Group";
            this.txtBloodGroup.SelectedText = "";
            this.txtBloodGroup.ShadowDecoration.Parent = this.txtBloodGroup;
            this.txtBloodGroup.Size = new System.Drawing.Size(489, 27);
            this.txtBloodGroup.TabIndex = 3;
            this.txtBloodGroup.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(405, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cause";
            // 
            // txtCause
            // 
            this.txtCause.Animated = true;
            this.txtCause.AutoCompleteCustomSource.AddRange(new string[] {
            "Accident",
            "Heart Attack",
            "Serious Illness"});
            this.txtCause.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCause.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCause.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCause.DefaultText = "";
            this.txtCause.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCause.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCause.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCause.DisabledState.Parent = this.txtCause;
            this.txtCause.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtCause.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCause.FocusedState.Parent = this.txtCause;
            this.txtCause.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCause.ForeColor = System.Drawing.Color.White;
            this.txtCause.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCause.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtCause.HoverState.Parent = this.txtCause;
            this.txtCause.IconLeft = global::HMS.Properties.Resources.icons8_traffic_accident_24px;
            this.txtCause.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCause.Location = new System.Drawing.Point(544, 335);
            this.txtCause.Margin = new System.Windows.Forms.Padding(4);
            this.txtCause.Name = "txtCause";
            this.txtCause.PasswordChar = '\0';
            this.txtCause.PlaceholderText = "Enter Cause Of Admission";
            this.txtCause.SelectedText = "";
            this.txtCause.ShadowDecoration.Parent = this.txtCause;
            this.txtCause.Size = new System.Drawing.Size(489, 27);
            this.txtCause.TabIndex = 4;
            this.txtCause.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(405, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Admitted By";
            // 
            // txtAdmitedby
            // 
            this.txtAdmitedby.Animated = true;
            this.txtAdmitedby.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdmitedby.DefaultText = "";
            this.txtAdmitedby.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdmitedby.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdmitedby.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdmitedby.DisabledState.Parent = this.txtAdmitedby;
            this.txtAdmitedby.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdmitedby.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtAdmitedby.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdmitedby.FocusedState.Parent = this.txtAdmitedby;
            this.txtAdmitedby.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmitedby.ForeColor = System.Drawing.Color.White;
            this.txtAdmitedby.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdmitedby.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtAdmitedby.HoverState.Parent = this.txtAdmitedby;
            this.txtAdmitedby.IconLeft = global::HMS.Properties.Resources.icons8_user_50px;
            this.txtAdmitedby.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtAdmitedby.Location = new System.Drawing.Point(544, 381);
            this.txtAdmitedby.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdmitedby.Name = "txtAdmitedby";
            this.txtAdmitedby.PasswordChar = '\0';
            this.txtAdmitedby.PlaceholderText = "Enter Admitted By Whom";
            this.txtAdmitedby.SelectedText = "";
            this.txtAdmitedby.ShadowDecoration.Parent = this.txtAdmitedby;
            this.txtAdmitedby.Size = new System.Drawing.Size(489, 27);
            this.txtAdmitedby.TabIndex = 5;
            this.txtAdmitedby.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(405, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contact Num";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Animated = true;
            this.txtContactNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNum.DefaultText = "";
            this.txtContactNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNum.DisabledState.Parent = this.txtContactNum;
            this.txtContactNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtContactNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNum.FocusedState.Parent = this.txtContactNum;
            this.txtContactNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNum.ForeColor = System.Drawing.Color.White;
            this.txtContactNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNum.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtContactNum.HoverState.Parent = this.txtContactNum;
            this.txtContactNum.IconLeft = global::HMS.Properties.Resources.icons8_phone_50px;
            this.txtContactNum.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtContactNum.Location = new System.Drawing.Point(544, 427);
            this.txtContactNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.PasswordChar = '\0';
            this.txtContactNum.PlaceholderText = "Contact Number";
            this.txtContactNum.SelectedText = "";
            this.txtContactNum.ShadowDecoration.Parent = this.txtContactNum;
            this.txtContactNum.Size = new System.Drawing.Size(489, 27);
            this.txtContactNum.TabIndex = 6;
            this.txtContactNum.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cyan;
            this.label7.Location = new System.Drawing.Point(405, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Avilable Doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(405, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Avilable Bed";
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(536, 11);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 29);
            this.DateTime.TabIndex = 11;
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(1084, 9);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.Gray;
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(29, 26);
            this.guna2ControlBox2.TabIndex = 23;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1116, 9);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(29, 26);
            this.guna2ControlBox1.TabIndex = 24;
            // 
            // dropAvilableDoc
            // 
            this.dropAvilableDoc.BackColor = System.Drawing.Color.Transparent;
            this.dropAvilableDoc.BorderRadius = 0;
            this.dropAvilableDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropAvilableDoc.DisabledColor = System.Drawing.Color.White;
            this.dropAvilableDoc.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropAvilableDoc.ForeColor = System.Drawing.Color.White;
            this.dropAvilableDoc.Items = new string[0];
            this.dropAvilableDoc.Location = new System.Drawing.Point(544, 473);
            this.dropAvilableDoc.Margin = new System.Windows.Forms.Padding(4);
            this.dropAvilableDoc.Name = "dropAvilableDoc";
            this.dropAvilableDoc.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.dropAvilableDoc.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.dropAvilableDoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dropAvilableDoc.selectedIndex = -1;
            this.dropAvilableDoc.Size = new System.Drawing.Size(489, 29);
            this.dropAvilableDoc.TabIndex = 7;
            // 
            // droupAvilableBed
            // 
            this.droupAvilableBed.BackColor = System.Drawing.Color.Transparent;
            this.droupAvilableBed.BorderRadius = 0;
            this.droupAvilableBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.droupAvilableBed.DisabledColor = System.Drawing.Color.White;
            this.droupAvilableBed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.droupAvilableBed.ForeColor = System.Drawing.Color.White;
            this.droupAvilableBed.Items = new string[0];
            this.droupAvilableBed.Location = new System.Drawing.Point(545, 521);
            this.droupAvilableBed.Margin = new System.Windows.Forms.Padding(5);
            this.droupAvilableBed.Name = "droupAvilableBed";
            this.droupAvilableBed.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.droupAvilableBed.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.droupAvilableBed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.droupAvilableBed.selectedIndex = -1;
            this.droupAvilableBed.Size = new System.Drawing.Size(489, 29);
            this.droupAvilableBed.TabIndex = 8;
            this.droupAvilableBed.onItemSelected += new System.EventHandler(this.droupAvilableBed_onItemSelected);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnSubmit.BorderThickness = 1;
            this.btnSubmit.CheckedState.Parent = this.btnSubmit;
            this.btnSubmit.CustomImages.Parent = this.btnSubmit;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.Parent = this.btnSubmit;
            this.btnSubmit.Location = new System.Drawing.Point(913, 617);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.Parent = this.btnSubmit;
            this.btnSubmit.Size = new System.Drawing.Size(121, 39);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSearchPatient
            // 
            this.txtSearchPatient.Animated = true;
            this.txtSearchPatient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchPatient.DefaultText = "";
            this.txtSearchPatient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchPatient.DisabledState.Parent = this.txtSearchPatient;
            this.txtSearchPatient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.txtSearchPatient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchPatient.FocusedState.Parent = this.txtSearchPatient;
            this.txtSearchPatient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPatient.ForeColor = System.Drawing.Color.White;
            this.txtSearchPatient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchPatient.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.txtSearchPatient.HoverState.Parent = this.txtSearchPatient;
            this.txtSearchPatient.IconLeft = global::HMS.Properties.Resources.icons8_search_26px;
            this.txtSearchPatient.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearchPatient.Location = new System.Drawing.Point(409, 68);
            this.txtSearchPatient.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchPatient.Name = "txtSearchPatient";
            this.txtSearchPatient.PasswordChar = '\0';
            this.txtSearchPatient.PlaceholderText = "Search By Patient Name";
            this.txtSearchPatient.SelectedText = "";
            this.txtSearchPatient.ShadowDecoration.Parent = this.txtSearchPatient;
            this.txtSearchPatient.Size = new System.Drawing.Size(489, 35);
            this.txtSearchPatient.TabIndex = 1;
            this.txtSearchPatient.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Animated = true;
            this.btnDischarge.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnDischarge.BorderThickness = 1;
            this.btnDischarge.CheckedState.Parent = this.btnDischarge;
            this.btnDischarge.CustomImages.Parent = this.btnDischarge;
            this.btnDischarge.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.btnDischarge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDischarge.ForeColor = System.Drawing.Color.White;
            this.btnDischarge.HoverState.Parent = this.btnDischarge;
            this.btnDischarge.Location = new System.Drawing.Point(924, 68);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.ShadowDecoration.Parent = this.btnDischarge;
            this.btnDischarge.Size = new System.Drawing.Size(121, 35);
            this.btnDischarge.TabIndex = 2;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // Emargency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1157, 699);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.droupAvilableBed);
            this.Controls.Add(this.dropAvilableDoc);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdmitedby);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCause);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBloodGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchPatient);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.lb);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Emargency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emargency";
            this.Load += new System.EventHandler(this.Emargency_Load);
            this.SidePanel.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lb;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnbloodbank;
        private System.Windows.Forms.Button btnDashbord;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnEmergancy;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.Button btnAddPAtient;
        private System.Windows.Forms.Panel User;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNum;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAdmitedby;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtCause;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBloodGroup;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSex;
        private System.Windows.Forms.Label label2;
        //private BunifuDropdown bunifuDropdown1; (rdr["Patientid"].ToString())
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        //private BunifuDropdown bunifuDropdown2;
        private MetroFramework.Controls.MetroDateTime DateTime;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Bunifu.Framework.UI.BunifuDropdown droupAvilableBed;
        private Bunifu.Framework.UI.BunifuDropdown dropAvilableDoc;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SideName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDischarge;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchPatient;
    }
}