namespace eco_system.Forms
{
    partial class PersonalAccount
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
            this.labelPersonalId = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelPlaceOfWork = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPersonalId
            // 
            this.labelPersonalId.AutoSize = true;
            this.labelPersonalId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPersonalId.Location = new System.Drawing.Point(13, 24);
            this.labelPersonalId.Name = "labelPersonalId";
            this.labelPersonalId.Size = new System.Drawing.Size(143, 25);
            this.labelPersonalId.TabIndex = 0;
            this.labelPersonalId.Text = "Личный номер";
            this.labelPersonalId.Visible = false;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastname.Location = new System.Drawing.Point(12, 52);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(91, 25);
            this.labelLastname.TabIndex = 1;
            this.labelLastname.Text = "Фамилия";
            this.labelLastname.Visible = false;
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatronymic.Location = new System.Drawing.Point(12, 108);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(93, 25);
            this.labelPatronymic.TabIndex = 2;
            this.labelPatronymic.Text = "Отчество";
            this.labelPatronymic.Visible = false;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstname.Location = new System.Drawing.Point(13, 80);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(49, 25);
            this.labelFirstname.TabIndex = 3;
            this.labelFirstname.Text = "Имя";
            this.labelFirstname.Visible = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(12, 164);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(64, 25);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Адрес";
            this.labelAddress.Visible = false;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(12, 136);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(149, 25);
            this.labelDateOfBirth.TabIndex = 5;
            this.labelDateOfBirth.Text = "День рождения";
            this.labelDateOfBirth.Visible = false;
            // 
            // labelPlaceOfWork
            // 
            this.labelPlaceOfWork.AutoSize = true;
            this.labelPlaceOfWork.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlaceOfWork.Location = new System.Drawing.Point(12, 192);
            this.labelPlaceOfWork.Name = "labelPlaceOfWork";
            this.labelPlaceOfWork.Size = new System.Drawing.Size(136, 25);
            this.labelPlaceOfWork.TabIndex = 6;
            this.labelPlaceOfWork.Text = "Место работы";
            this.labelPlaceOfWork.Visible = false;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxId.Location = new System.Drawing.Point(260, 136);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(205, 33);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.Location = new System.Drawing.Point(260, 176);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(205, 41);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 441);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPlaceOfWork);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelPersonalId);
            this.Name = "PersonalAccount";
            this.Text = "PersonalAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPersonalId;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelPlaceOfWork;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonLogin;
    }
}