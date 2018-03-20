namespace Midwife_v._2
{
    partial class ExistingClients
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
            this.btnBack = new System.Windows.Forms.Button();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbPostCode = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbCellPhone = new System.Windows.Forms.Label();
            this.lbLandLine = new System.Windows.Forms.Label();
            this.lbStreetName = new System.Windows.Forms.Label();
            this.lbStreetNumber = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbPFirstName = new System.Windows.Forms.Label();
            this.lbPLastName = new System.Windows.Forms.Label();
            this.lbPLandLine = new System.Windows.Forms.Label();
            this.lbPCellPhone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEFirstName = new System.Windows.Forms.Label();
            this.lbELastName = new System.Windows.Forms.Label();
            this.lbECellPhone = new System.Windows.Forms.Label();
            this.lbELandLine = new System.Windows.Forms.Label();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.btnSex = new System.Windows.Forms.Button();
            this.btnChangeSex = new System.Windows.Forms.Button();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSubburb = new System.Windows.Forms.Label();
            this.tbTodaysNotes = new System.Windows.Forms.TextBox();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.tbExistingNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCID = new System.Windows.Forms.Label();
            this.lbLoggedinas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.gbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(1260, 667);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 32);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Location = new System.Drawing.Point(12, 205);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(259, 20);
            this.tbNameSearch.TabIndex = 2;
            this.tbNameSearch.TextChanged += new System.EventHandler(this.tbNameSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search for clients last name:";
            // 
            // dgClients
            // 
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(12, 60);
            this.dgClients.MultiSelect = false;
            this.dgClients.Name = "dgClients";
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(324, 105);
            this.dgClients.TabIndex = 4;
            this.dgClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_CellContentClick);
            this.dgClients.SelectionChanged += new System.EventHandler(this.dgClients_SelectionChanged);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(16, 302);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(59, 15);
            this.lbFirstName.TabIndex = 5;
            this.lbFirstName.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Partner:";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(16, 388);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(33, 15);
            this.lbState.TabIndex = 7;
            this.lbState.Text = "State";
            // 
            // lbPostCode
            // 
            this.lbPostCode.AutoSize = true;
            this.lbPostCode.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostCode.Location = new System.Drawing.Point(140, 388);
            this.lbPostCode.Name = "lbPostCode";
            this.lbPostCode.Size = new System.Drawing.Size(60, 15);
            this.lbPostCode.TabIndex = 8;
            this.lbPostCode.Text = "Post Code";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(142, 362);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(27, 15);
            this.lbCity.TabIndex = 9;
            this.lbCity.Text = "City";
            // 
            // lbCellPhone
            // 
            this.lbCellPhone.AutoSize = true;
            this.lbCellPhone.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCellPhone.Location = new System.Drawing.Point(140, 420);
            this.lbCellPhone.Name = "lbCellPhone";
            this.lbCellPhone.Size = new System.Drawing.Size(63, 15);
            this.lbCellPhone.TabIndex = 10;
            this.lbCellPhone.Text = "Cell Phone";
            // 
            // lbLandLine
            // 
            this.lbLandLine.AutoSize = true;
            this.lbLandLine.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLandLine.Location = new System.Drawing.Point(16, 420);
            this.lbLandLine.Name = "lbLandLine";
            this.lbLandLine.Size = new System.Drawing.Size(58, 15);
            this.lbLandLine.TabIndex = 11;
            this.lbLandLine.Text = "Land Line";
            // 
            // lbStreetName
            // 
            this.lbStreetName.AutoSize = true;
            this.lbStreetName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreetName.Location = new System.Drawing.Point(142, 333);
            this.lbStreetName.Name = "lbStreetName";
            this.lbStreetName.Size = new System.Drawing.Size(70, 15);
            this.lbStreetName.TabIndex = 12;
            this.lbStreetName.Text = "Street Name";
            this.lbStreetName.Click += new System.EventHandler(this.lbStreetName_Click);
            // 
            // lbStreetNumber
            // 
            this.lbStreetNumber.AutoSize = true;
            this.lbStreetNumber.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreetNumber.Location = new System.Drawing.Point(16, 333);
            this.lbStreetNumber.Name = "lbStreetNumber";
            this.lbStreetNumber.Size = new System.Drawing.Size(82, 15);
            this.lbStreetNumber.TabIndex = 13;
            this.lbStreetNumber.Text = "Street Number";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(142, 302);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(61, 15);
            this.lbLastName.TabIndex = 14;
            this.lbLastName.Text = "Last Name";
            // 
            // lbPFirstName
            // 
            this.lbPFirstName.AutoSize = true;
            this.lbPFirstName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPFirstName.Location = new System.Drawing.Point(16, 493);
            this.lbPFirstName.Name = "lbPFirstName";
            this.lbPFirstName.Size = new System.Drawing.Size(62, 15);
            this.lbPFirstName.TabIndex = 15;
            this.lbPFirstName.Text = "First Name";
            // 
            // lbPLastName
            // 
            this.lbPLastName.AutoSize = true;
            this.lbPLastName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLastName.Location = new System.Drawing.Point(140, 493);
            this.lbPLastName.Name = "lbPLastName";
            this.lbPLastName.Size = new System.Drawing.Size(61, 15);
            this.lbPLastName.TabIndex = 16;
            this.lbPLastName.Text = "Last Name";
            // 
            // lbPLandLine
            // 
            this.lbPLandLine.AutoSize = true;
            this.lbPLandLine.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLandLine.Location = new System.Drawing.Point(16, 526);
            this.lbPLandLine.Name = "lbPLandLine";
            this.lbPLandLine.Size = new System.Drawing.Size(58, 15);
            this.lbPLandLine.TabIndex = 17;
            this.lbPLandLine.Text = "Land Line";
            // 
            // lbPCellPhone
            // 
            this.lbPCellPhone.AutoSize = true;
            this.lbPCellPhone.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCellPhone.Location = new System.Drawing.Point(142, 526);
            this.lbPCellPhone.Name = "lbPCellPhone";
            this.lbPCellPhone.Size = new System.Drawing.Size(63, 15);
            this.lbPCellPhone.TabIndex = 18;
            this.lbPCellPhone.Text = "Cell Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Alternative Emergency Contact:";
            // 
            // lbEFirstName
            // 
            this.lbEFirstName.AutoSize = true;
            this.lbEFirstName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEFirstName.Location = new System.Drawing.Point(13, 607);
            this.lbEFirstName.Name = "lbEFirstName";
            this.lbEFirstName.Size = new System.Drawing.Size(62, 15);
            this.lbEFirstName.TabIndex = 20;
            this.lbEFirstName.Text = "First Name";
            // 
            // lbELastName
            // 
            this.lbELastName.AutoSize = true;
            this.lbELastName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbELastName.Location = new System.Drawing.Point(140, 607);
            this.lbELastName.Name = "lbELastName";
            this.lbELastName.Size = new System.Drawing.Size(61, 15);
            this.lbELastName.TabIndex = 21;
            this.lbELastName.Text = "Last Name";
            // 
            // lbECellPhone
            // 
            this.lbECellPhone.AutoSize = true;
            this.lbECellPhone.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbECellPhone.Location = new System.Drawing.Point(142, 637);
            this.lbECellPhone.Name = "lbECellPhone";
            this.lbECellPhone.Size = new System.Drawing.Size(63, 15);
            this.lbECellPhone.TabIndex = 22;
            this.lbECellPhone.Text = "Cell Phone";
            // 
            // lbELandLine
            // 
            this.lbELandLine.AutoSize = true;
            this.lbELandLine.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbELandLine.Location = new System.Drawing.Point(16, 637);
            this.lbELandLine.Name = "lbELandLine";
            this.lbELandLine.Size = new System.Drawing.Size(58, 15);
            this.lbELandLine.TabIndex = 23;
            this.lbELandLine.Text = "Land Line";
            // 
            // gbSex
            // 
            this.gbSex.BackColor = System.Drawing.Color.Silver;
            this.gbSex.Controls.Add(this.btnSex);
            this.gbSex.Controls.Add(this.btnChangeSex);
            this.gbSex.Controls.Add(this.rbGirl);
            this.gbSex.Controls.Add(this.rbBoy);
            this.gbSex.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSex.Location = new System.Drawing.Point(1237, 22);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(124, 120);
            this.gbSex.TabIndex = 24;
            this.gbSex.TabStop = false;
            // 
            // btnSex
            // 
            this.btnSex.BackColor = System.Drawing.Color.Red;
            this.btnSex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSex.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSex.Location = new System.Drawing.Point(-5, -16);
            this.btnSex.Name = "btnSex";
            this.btnSex.Size = new System.Drawing.Size(146, 140);
            this.btnSex.TabIndex = 25;
            this.btnSex.Text = "Show \r\nBaby\'s \r\nSex";
            this.btnSex.UseVisualStyleBackColor = false;
            this.btnSex.Click += new System.EventHandler(this.btnSex_Click);
            // 
            // btnChangeSex
            // 
            this.btnChangeSex.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeSex.Location = new System.Drawing.Point(6, 76);
            this.btnChangeSex.Name = "btnChangeSex";
            this.btnChangeSex.Size = new System.Drawing.Size(112, 38);
            this.btnChangeSex.TabIndex = 2;
            this.btnChangeSex.Text = "Change Sex";
            this.btnChangeSex.UseVisualStyleBackColor = true;
            this.btnChangeSex.Click += new System.EventHandler(this.btnChangeSex_Click);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGirl.ForeColor = System.Drawing.Color.White;
            this.rbGirl.Location = new System.Drawing.Point(15, 38);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(60, 32);
            this.rbGirl.TabIndex = 1;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "Girl";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.rbGirl_CheckedChanged);
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBoy.ForeColor = System.Drawing.Color.White;
            this.rbBoy.Location = new System.Drawing.Point(15, 12);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(60, 32);
            this.rbBoy.TabIndex = 0;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "Boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbSubburb
            // 
            this.lbSubburb.AutoSize = true;
            this.lbSubburb.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubburb.Location = new System.Drawing.Point(16, 362);
            this.lbSubburb.Name = "lbSubburb";
            this.lbSubburb.Size = new System.Drawing.Size(52, 15);
            this.lbSubburb.TabIndex = 25;
            this.lbSubburb.Text = "Subburb";
            // 
            // tbTodaysNotes
            // 
            this.tbTodaysNotes.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTodaysNotes.Location = new System.Drawing.Point(356, 425);
            this.tbTodaysNotes.Multiline = true;
            this.tbTodaysNotes.Name = "tbTodaysNotes";
            this.tbTodaysNotes.Size = new System.Drawing.Size(870, 196);
            this.tbTodaysNotes.TabIndex = 27;
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNotes.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNotes.Location = new System.Drawing.Point(671, 640);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(253, 38);
            this.btnSaveNotes.TabIndex = 28;
            this.btnSaveNotes.Text = "Save Notes";
            this.btnSaveNotes.UseVisualStyleBackColor = true;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // tbExistingNotes
            // 
            this.tbExistingNotes.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExistingNotes.Location = new System.Drawing.Point(356, 60);
            this.tbExistingNotes.Multiline = true;
            this.tbExistingNotes.Name = "tbExistingNotes";
            this.tbExistingNotes.ReadOnly = true;
            this.tbExistingNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbExistingNotes.Size = new System.Drawing.Size(870, 279);
            this.tbExistingNotes.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Existing Notes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "New Notes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 28);
            this.label6.TabIndex = 32;
            this.label6.Text = "Client:";
            // 
            // lbCID
            // 
            this.lbCID.AutoSize = true;
            this.lbCID.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCID.Location = new System.Drawing.Point(144, 272);
            this.lbCID.Name = "lbCID";
            this.lbCID.Size = new System.Drawing.Size(18, 15);
            this.lbCID.TabIndex = 33;
            this.lbCID.Text = "ID";
            // 
            // lbLoggedinas
            // 
            this.lbLoggedinas.AutoSize = true;
            this.lbLoggedinas.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoggedinas.Location = new System.Drawing.Point(13, 18);
            this.lbLoggedinas.Name = "lbLoggedinas";
            this.lbLoggedinas.Size = new System.Drawing.Size(136, 33);
            this.lbLoggedinas.TabIndex = 34;
            this.lbLoggedinas.Text = "Logged in as";
            // 
            // ExistingClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.lbLoggedinas);
            this.Controls.Add(this.lbCID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbExistingNotes);
            this.Controls.Add(this.btnSaveNotes);
            this.Controls.Add(this.tbTodaysNotes);
            this.Controls.Add(this.lbSubburb);
            this.Controls.Add(this.gbSex);
            this.Controls.Add(this.lbELandLine);
            this.Controls.Add(this.lbECellPhone);
            this.Controls.Add(this.lbELastName);
            this.Controls.Add(this.lbEFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPCellPhone);
            this.Controls.Add(this.lbPLandLine);
            this.Controls.Add(this.lbPLastName);
            this.Controls.Add(this.lbPFirstName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbStreetNumber);
            this.Controls.Add(this.lbStreetName);
            this.Controls.Add(this.lbLandLine);
            this.Controls.Add(this.lbCellPhone);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.lbPostCode);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNameSearch);
            this.Controls.Add(this.btnBack);
            this.Name = "ExistingClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExistingClients";
            this.Load += new System.EventHandler(this.ExistingClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.gbSex.ResumeLayout(false);
            this.gbSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbPostCode;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbCellPhone;
        private System.Windows.Forms.Label lbLandLine;
        private System.Windows.Forms.Label lbStreetName;
        private System.Windows.Forms.Label lbStreetNumber;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbPFirstName;
        private System.Windows.Forms.Label lbPLastName;
        private System.Windows.Forms.Label lbPLandLine;
        private System.Windows.Forms.Label lbPCellPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEFirstName;
        private System.Windows.Forms.Label lbELastName;
        private System.Windows.Forms.Label lbECellPhone;
        private System.Windows.Forms.Label lbELandLine;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.Button btnChangeSex;
        private System.Windows.Forms.Button btnSex;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSubburb;
        private System.Windows.Forms.TextBox tbTodaysNotes;
        private System.Windows.Forms.Button btnSaveNotes;
        private System.Windows.Forms.TextBox tbExistingNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCID;
        private System.Windows.Forms.Label lbLoggedinas;
    }
}