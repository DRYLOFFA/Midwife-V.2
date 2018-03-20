namespace Midwife_v._2
{
    partial class Welcome
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbLogIn = new System.Windows.Forms.GroupBox();
            this.gbCreateUser = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUsernameCreate = new System.Windows.Forms.TextBox();
            this.tbPasswordCreate = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnExistingUser = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbLogIn.SuspendLayout();
            this.gbCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 224);
            this.label1.TabIndex = 0;
            this.label1.Text = "      Welcome  to \r\nMidWife\'s Companion";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameLogin.Location = new System.Drawing.Point(166, 39);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(221, 29);
            this.tbUsernameLogin.TabIndex = 1;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordLogin.Location = new System.Drawing.Point(166, 81);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(221, 29);
            this.tbPasswordLogin.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(166, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(221, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1279, 674);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // gbLogIn
            // 
            this.gbLogIn.Controls.Add(this.textBox2);
            this.gbLogIn.Controls.Add(this.textBox1);
            this.gbLogIn.Controls.Add(this.label2);
            this.gbLogIn.Controls.Add(this.label3);
            this.gbLogIn.Controls.Add(this.tbUsernameLogin);
            this.gbLogIn.Controls.Add(this.tbPasswordLogin);
            this.gbLogIn.Controls.Add(this.btnLogin);
            this.gbLogIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogIn.Location = new System.Drawing.Point(475, 329);
            this.gbLogIn.Name = "gbLogIn";
            this.gbLogIn.Size = new System.Drawing.Size(430, 200);
            this.gbLogIn.TabIndex = 7;
            this.gbLogIn.TabStop = false;
            this.gbLogIn.Text = "Please Log In";
            // 
            // gbCreateUser
            // 
            this.gbCreateUser.Controls.Add(this.label4);
            this.gbCreateUser.Controls.Add(this.label5);
            this.gbCreateUser.Controls.Add(this.tbUsernameCreate);
            this.gbCreateUser.Controls.Add(this.tbPasswordCreate);
            this.gbCreateUser.Controls.Add(this.btnCreateUser);
            this.gbCreateUser.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreateUser.Location = new System.Drawing.Point(469, 342);
            this.gbCreateUser.Name = "gbCreateUser";
            this.gbCreateUser.Size = new System.Drawing.Size(430, 200);
            this.gbCreateUser.TabIndex = 8;
            this.gbCreateUser.TabStop = false;
            this.gbCreateUser.Text = "Create User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // tbUsernameCreate
            // 
            this.tbUsernameCreate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsernameCreate.Location = new System.Drawing.Point(166, 39);
            this.tbUsernameCreate.Name = "tbUsernameCreate";
            this.tbUsernameCreate.Size = new System.Drawing.Size(221, 29);
            this.tbUsernameCreate.TabIndex = 1;
            // 
            // tbPasswordCreate
            // 
            this.tbPasswordCreate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordCreate.Location = new System.Drawing.Point(166, 81);
            this.tbPasswordCreate.Name = "tbPasswordCreate";
            this.tbPasswordCreate.Size = new System.Drawing.Size(221, 29);
            this.tbPasswordCreate.TabIndex = 2;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.Location = new System.Drawing.Point(166, 122);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(221, 37);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "CREATE USER";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnExistingUser
            // 
            this.btnExistingUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExistingUser.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingUser.Location = new System.Drawing.Point(75, 260);
            this.btnExistingUser.Name = "btnExistingUser";
            this.btnExistingUser.Size = new System.Drawing.Size(140, 37);
            this.btnExistingUser.TabIndex = 9;
            this.btnExistingUser.Text = "Existing User";
            this.btnExistingUser.UseVisualStyleBackColor = true;
            this.btnExistingUser.Click += new System.EventHandler(this.btnExistingUser_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.Location = new System.Drawing.Point(75, 329);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(140, 37);
            this.btnNewUser.TabIndex = 10;
            this.btnNewUser.Text = "New User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(66, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(55, 15);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "P@ssw0rd";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(54, 15);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "MaryPop";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnExistingUser);
            this.Controls.Add(this.gbCreateUser);
            this.Controls.Add(this.gbLogIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.gbLogIn.ResumeLayout(false);
            this.gbLogIn.PerformLayout();
            this.gbCreateUser.ResumeLayout(false);
            this.gbCreateUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbLogIn;
        private System.Windows.Forms.GroupBox gbCreateUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUsernameCreate;
        private System.Windows.Forms.TextBox tbPasswordCreate;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnExistingUser;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

