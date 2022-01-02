namespace eco_system.Forms
{
    partial class InfoOrganization
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
            this.dataGridViewCalls = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.call_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCalls
            // 
            this.dataGridViewCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.user_name,
            this.user_address,
            this.call_time});
            this.dataGridViewCalls.Location = new System.Drawing.Point(12, 80);
            this.dataGridViewCalls.Name = "dataGridViewCalls";
            this.dataGridViewCalls.Size = new System.Drawing.Size(674, 228);
            this.dataGridViewCalls.TabIndex = 0;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // title
            // 
            this.title.Frozen = true;
            this.title.HeaderText = "Причина";
            this.title.Name = "title";
            // 
            // user_name
            // 
            this.user_name.Frozen = true;
            this.user_name.HeaderText = "Имя пользователя";
            this.user_name.Name = "user_name";
            // 
            // user_address
            // 
            this.user_address.Frozen = true;
            this.user_address.HeaderText = "Адресс";
            this.user_address.Name = "user_address";
            // 
            // call_time
            // 
            this.call_time.Frozen = true;
            this.call_time.HeaderText = "Время вызова";
            this.call_time.Name = "call_time";
            // 
            // InfoOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 320);
            this.Controls.Add(this.dataGridViewCalls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InfoOrganization";
            this.Text = "Информация об организации";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalls)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn call_time;
    }
}