namespace eco_system
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdministration = new System.Windows.Forms.Button();
            this.buttonMEC = new System.Windows.Forms.Button();
            this.buttonHealthcare = new System.Windows.Forms.Button();
            this.buttonPersonalAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в \"Умный город\"";
            // 
            // buttonAdministration
            // 
            this.buttonAdministration.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdministration.Location = new System.Drawing.Point(130, 54);
            this.buttonAdministration.Name = "buttonAdministration";
            this.buttonAdministration.Size = new System.Drawing.Size(163, 33);
            this.buttonAdministration.TabIndex = 1;
            this.buttonAdministration.Text = "Администрация";
            this.buttonAdministration.UseVisualStyleBackColor = true;
            // 
            // buttonMEC
            // 
            this.buttonMEC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMEC.Location = new System.Drawing.Point(130, 93);
            this.buttonMEC.Name = "buttonMEC";
            this.buttonMEC.Size = new System.Drawing.Size(163, 33);
            this.buttonMEC.TabIndex = 2;
            this.buttonMEC.Text = "МЧС";
            this.buttonMEC.UseVisualStyleBackColor = true;
            // 
            // buttonHealthcare
            // 
            this.buttonHealthcare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHealthcare.Location = new System.Drawing.Point(130, 132);
            this.buttonHealthcare.Name = "buttonHealthcare";
            this.buttonHealthcare.Size = new System.Drawing.Size(163, 33);
            this.buttonHealthcare.TabIndex = 3;
            this.buttonHealthcare.Text = "Здравохранение";
            this.buttonHealthcare.UseVisualStyleBackColor = true;
            // 
            // buttonPersonalAccount
            // 
            this.buttonPersonalAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPersonalAccount.Location = new System.Drawing.Point(130, 171);
            this.buttonPersonalAccount.Name = "buttonPersonalAccount";
            this.buttonPersonalAccount.Size = new System.Drawing.Size(163, 33);
            this.buttonPersonalAccount.TabIndex = 4;
            this.buttonPersonalAccount.Text = "Личный кабинет";
            this.buttonPersonalAccount.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 217);
            this.Controls.Add(this.buttonPersonalAccount);
            this.Controls.Add(this.buttonHealthcare);
            this.Controls.Add(this.buttonMEC);
            this.Controls.Add(this.buttonAdministration);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainWindow";
            this.Text = "Умный город";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdministration;
        private System.Windows.Forms.Button buttonMEC;
        private System.Windows.Forms.Button buttonHealthcare;
        private System.Windows.Forms.Button buttonPersonalAccount;
    }
}

