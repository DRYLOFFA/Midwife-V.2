namespace Midwife_v._2
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pbNewClient = new System.Windows.Forms.PictureBox();
            this.pbCalander = new System.Windows.Forms.PictureBox();
            this.pbExistingClient = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLoggedinas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExistingClient)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1279, 674);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(93, 25);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbNewClient
            // 
            this.pbNewClient.BackColor = System.Drawing.Color.Yellow;
            this.pbNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNewClient.Image = ((System.Drawing.Image)(resources.GetObject("pbNewClient.Image")));
            this.pbNewClient.Location = new System.Drawing.Point(839, 65);
            this.pbNewClient.Name = "pbNewClient";
            this.pbNewClient.Size = new System.Drawing.Size(222, 164);
            this.pbNewClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNewClient.TabIndex = 6;
            this.pbNewClient.TabStop = false;
            this.pbNewClient.Click += new System.EventHandler(this.pbNewClient_Click);
            // 
            // pbCalander
            // 
            this.pbCalander.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCalander.Image = ((System.Drawing.Image)(resources.GetObject("pbCalander.Image")));
            this.pbCalander.Location = new System.Drawing.Point(12, 65);
            this.pbCalander.Name = "pbCalander";
            this.pbCalander.Size = new System.Drawing.Size(222, 164);
            this.pbCalander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalander.TabIndex = 8;
            this.pbCalander.TabStop = false;
            this.pbCalander.Click += new System.EventHandler(this.pbCalander_Click);
            // 
            // pbExistingClient
            // 
            this.pbExistingClient.BackColor = System.Drawing.Color.Transparent;
            this.pbExistingClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbExistingClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExistingClient.Image = ((System.Drawing.Image)(resources.GetObject("pbExistingClient.Image")));
            this.pbExistingClient.Location = new System.Drawing.Point(422, 65);
            this.pbExistingClient.Name = "pbExistingClient";
            this.pbExistingClient.Size = new System.Drawing.Size(222, 164);
            this.pbExistingClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExistingClient.TabIndex = 9;
            this.pbExistingClient.TabStop = false;
            this.pbExistingClient.Click += new System.EventHandler(this.pbExistingClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Client";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Existing Clients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Calander";
            // 
            // lbLoggedinas
            // 
            this.lbLoggedinas.AutoSize = true;
            this.lbLoggedinas.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoggedinas.Location = new System.Drawing.Point(12, 9);
            this.lbLoggedinas.Name = "lbLoggedinas";
            this.lbLoggedinas.Size = new System.Drawing.Size(136, 33);
            this.lbLoggedinas.TabIndex = 13;
            this.lbLoggedinas.Text = "Logged in as";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.lbLoggedinas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbExistingClient);
            this.Controls.Add(this.pbCalander);
            this.Controls.Add(this.pbNewClient);
            this.Controls.Add(this.btnLogOut);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExistingClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pbNewClient;
        private System.Windows.Forms.PictureBox pbCalander;
        private System.Windows.Forms.PictureBox pbExistingClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLoggedinas;
    }
}