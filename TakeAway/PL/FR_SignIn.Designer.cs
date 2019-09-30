namespace TakeAway.PL
{
    partial class FR_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FR_SignIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_USER_NAME = new System.Windows.Forms.TextBox();
            this.pan_USER_NAME = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_PASSWORD = new System.Windows.Forms.TextBox();
            this.pan_PASSWORD = new System.Windows.Forms.Panel();
            this.btn_LOGIN = new System.Windows.Forms.Button();
            this.btn_CREATE_USER = new System.Windows.Forms.Button();
            this.CH_REMEMPER_PASS = new System.Windows.Forms.CheckBox();
            this.CH_SHOW_PASS = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(475, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 364);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_USER_NAME);
            this.panel2.Controls.Add(this.pan_USER_NAME);
            this.panel2.Location = new System.Drawing.Point(50, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 50);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(267, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم المستخدم:";
            // 
            // txt_USER_NAME
            // 
            this.txt_USER_NAME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_USER_NAME.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_USER_NAME.Location = new System.Drawing.Point(9, 13);
            this.txt_USER_NAME.Multiline = true;
            this.txt_USER_NAME.Name = "txt_USER_NAME";
            this.txt_USER_NAME.Size = new System.Drawing.Size(256, 25);
            this.txt_USER_NAME.TabIndex = 3;
            this.txt_USER_NAME.TextChanged += new System.EventHandler(this.txt_USER_NAME_TextChanged);
            this.txt_USER_NAME.Leave += new System.EventHandler(this.txt_USER_NAME_Leave);
            // 
            // pan_USER_NAME
            // 
            this.pan_USER_NAME.BackColor = System.Drawing.SystemColors.Control;
            this.pan_USER_NAME.Location = new System.Drawing.Point(9, 38);
            this.pan_USER_NAME.Name = "pan_USER_NAME";
            this.pan_USER_NAME.Size = new System.Drawing.Size(361, 3);
            this.pan_USER_NAME.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_PASSWORD);
            this.panel4.Controls.Add(this.pan_PASSWORD);
            this.panel4.Location = new System.Drawing.Point(50, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 50);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(294, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمة المرور:";
            // 
            // txt_PASSWORD
            // 
            this.txt_PASSWORD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PASSWORD.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txt_PASSWORD.Location = new System.Drawing.Point(9, 13);
            this.txt_PASSWORD.Multiline = true;
            this.txt_PASSWORD.Name = "txt_PASSWORD";
            this.txt_PASSWORD.Size = new System.Drawing.Size(256, 25);
            this.txt_PASSWORD.TabIndex = 3;
            this.txt_PASSWORD.TextChanged += new System.EventHandler(this.txt_PASSWORD_TextChanged);
            this.txt_PASSWORD.Leave += new System.EventHandler(this.txt_PASSWORD_Leave);
            // 
            // pan_PASSWORD
            // 
            this.pan_PASSWORD.BackColor = System.Drawing.SystemColors.Control;
            this.pan_PASSWORD.Location = new System.Drawing.Point(9, 38);
            this.pan_PASSWORD.Name = "pan_PASSWORD";
            this.pan_PASSWORD.Size = new System.Drawing.Size(361, 3);
            this.pan_PASSWORD.TabIndex = 2;
            // 
            // btn_LOGIN
            // 
            this.btn_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(49)))), ((int)(((byte)(103)))));
            this.btn_LOGIN.FlatAppearance.BorderSize = 0;
            this.btn_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LOGIN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LOGIN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_LOGIN.Location = new System.Drawing.Point(90, 290);
            this.btn_LOGIN.Name = "btn_LOGIN";
            this.btn_LOGIN.Size = new System.Drawing.Size(114, 31);
            this.btn_LOGIN.TabIndex = 3;
            this.btn_LOGIN.Text = "تسجيل الدخول";
            this.btn_LOGIN.UseVisualStyleBackColor = false;
            this.btn_LOGIN.Click += new System.EventHandler(this.btn_LOGIN_Click);
            // 
            // btn_CREATE_USER
            // 
            this.btn_CREATE_USER.FlatAppearance.BorderSize = 0;
            this.btn_CREATE_USER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CREATE_USER.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CREATE_USER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.btn_CREATE_USER.Location = new System.Drawing.Point(255, 290);
            this.btn_CREATE_USER.Name = "btn_CREATE_USER";
            this.btn_CREATE_USER.Size = new System.Drawing.Size(114, 31);
            this.btn_CREATE_USER.TabIndex = 4;
            this.btn_CREATE_USER.Text = "انشاء حساب";
            this.btn_CREATE_USER.UseVisualStyleBackColor = true;
            this.btn_CREATE_USER.Click += new System.EventHandler(this.btn_CREATE_USER_Click);
            // 
            // CH_REMEMPER_PASS
            // 
            this.CH_REMEMPER_PASS.AutoSize = true;
            this.CH_REMEMPER_PASS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CH_REMEMPER_PASS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.CH_REMEMPER_PASS.Location = new System.Drawing.Point(90, 228);
            this.CH_REMEMPER_PASS.Name = "CH_REMEMPER_PASS";
            this.CH_REMEMPER_PASS.Size = new System.Drawing.Size(103, 18);
            this.CH_REMEMPER_PASS.TabIndex = 5;
            this.CH_REMEMPER_PASS.Text = "تذكر كلمة السر";
            this.CH_REMEMPER_PASS.UseVisualStyleBackColor = true;
            // 
            // CH_SHOW_PASS
            // 
            this.CH_SHOW_PASS.AutoSize = true;
            this.CH_SHOW_PASS.Font = new System.Drawing.Font("Tahoma", 9F);
            this.CH_SHOW_PASS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.CH_SHOW_PASS.Location = new System.Drawing.Point(255, 228);
            this.CH_SHOW_PASS.Name = "CH_SHOW_PASS";
            this.CH_SHOW_PASS.Size = new System.Drawing.Size(108, 18);
            this.CH_SHOW_PASS.TabIndex = 6;
            this.CH_SHOW_PASS.Text = "اظهار كلمة السر";
            this.CH_SHOW_PASS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(25)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(156, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "TAKE AWAY";
            // 
            // FR_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(764, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CH_SHOW_PASS);
            this.Controls.Add(this.CH_REMEMPER_PASS);
            this.Controls.Add(this.btn_CREATE_USER);
            this.Controls.Add(this.btn_LOGIN);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FR_LOGIN";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FR_LOGIN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_USER_NAME;
        private System.Windows.Forms.Panel pan_USER_NAME;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_PASSWORD;
        private System.Windows.Forms.Panel pan_PASSWORD;
        private System.Windows.Forms.Button btn_LOGIN;
        private System.Windows.Forms.Button btn_CREATE_USER;
        private System.Windows.Forms.CheckBox CH_REMEMPER_PASS;
        private System.Windows.Forms.CheckBox CH_SHOW_PASS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}