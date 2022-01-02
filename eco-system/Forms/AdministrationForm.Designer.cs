namespace eco_system.Forms
{
    partial class AdministrationForm
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
            this.hello_label = new System.Windows.Forms.Label();
            this.position_label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hello_label.Location = new System.Drawing.Point(13, 13);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(133, 21);
            this.hello_label.TabIndex = 0;
            this.hello_label.Text = "Добрый день, %s";
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.position_label.Location = new System.Drawing.Point(13, 33);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(57, 21);
            this.position_label.TabIndex = 1;
            this.position_label.Text = "Вы: %s";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 358);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 428);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.hello_label);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.ListView listView1;
    }
}