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
            this.update_button = new System.Windows.Forms.Button();
            this.edit_person_button = new System.Windows.Forms.Button();
            this.add_person_button = new System.Windows.Forms.Button();
            this.delete_person_button = new System.Windows.Forms.Button();
            this.users_action_group_box = new System.Windows.Forms.GroupBox();
            this.additional_group_box = new System.Windows.Forms.GroupBox();
            this.people_grid_view = new System.Windows.Forms.DataGridView();
            this.id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.users_action_group_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.people_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hello_label.Location = new System.Drawing.Point(13, 12);
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
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(6, 19);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(112, 29);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Обновить";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // edit_person_button
            // 
            this.edit_person_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_person_button.Location = new System.Drawing.Point(6, 54);
            this.edit_person_button.Name = "edit_person_button";
            this.edit_person_button.Size = new System.Drawing.Size(112, 29);
            this.edit_person_button.TabIndex = 4;
            this.edit_person_button.Text = "Редактировать";
            this.edit_person_button.UseVisualStyleBackColor = true;
            this.edit_person_button.Click += new System.EventHandler(this.edit_person_button_Click);
            // 
            // add_person_button
            // 
            this.add_person_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_person_button.Location = new System.Drawing.Point(124, 19);
            this.add_person_button.Name = "add_person_button";
            this.add_person_button.Size = new System.Drawing.Size(112, 29);
            this.add_person_button.TabIndex = 5;
            this.add_person_button.Text = "Добавить";
            this.add_person_button.UseVisualStyleBackColor = true;
            this.add_person_button.Click += new System.EventHandler(this.add_person_button_Click);
            // 
            // delete_person_button
            // 
            this.delete_person_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_person_button.Location = new System.Drawing.Point(6, 89);
            this.delete_person_button.Name = "delete_person_button";
            this.delete_person_button.Size = new System.Drawing.Size(112, 29);
            this.delete_person_button.TabIndex = 6;
            this.delete_person_button.Text = "Удалить";
            this.delete_person_button.UseVisualStyleBackColor = true;
            this.delete_person_button.Click += new System.EventHandler(this.delete_person_button_Click);
            // 
            // users_action_group_box
            // 
            this.users_action_group_box.Controls.Add(this.update_button);
            this.users_action_group_box.Controls.Add(this.delete_person_button);
            this.users_action_group_box.Controls.Add(this.add_person_button);
            this.users_action_group_box.Controls.Add(this.edit_person_button);
            this.users_action_group_box.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.users_action_group_box.Location = new System.Drawing.Point(17, 57);
            this.users_action_group_box.Name = "users_action_group_box";
            this.users_action_group_box.Size = new System.Drawing.Size(243, 127);
            this.users_action_group_box.TabIndex = 7;
            this.users_action_group_box.TabStop = false;
            this.users_action_group_box.Text = "Пользователи";
            // 
            // additional_group_box
            // 
            this.additional_group_box.Location = new System.Drawing.Point(266, 57);
            this.additional_group_box.Name = "additional_group_box";
            this.additional_group_box.Size = new System.Drawing.Size(243, 127);
            this.additional_group_box.TabIndex = 8;
            this.additional_group_box.TabStop = false;
            this.additional_group_box.Text = "Дополнительно";
            // 
            // people_grid_view
            // 
            this.people_grid_view.AllowUserToAddRows = false;
            this.people_grid_view.AllowUserToDeleteRows = false;
            this.people_grid_view.AllowUserToResizeRows = false;
            this.people_grid_view.BackgroundColor = System.Drawing.SystemColors.Control;
            this.people_grid_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.people_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.people_grid_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_column,
            this.name_column,
            this.surname_column,
            this.patronymic_column,
            this.phone_column,
            this.date_birth_column,
            this.address_column,
            this.work_column});
            this.people_grid_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.people_grid_view.Location = new System.Drawing.Point(17, 190);
            this.people_grid_view.MultiSelect = false;
            this.people_grid_view.Name = "people_grid_view";
            this.people_grid_view.ReadOnly = true;
            this.people_grid_view.Size = new System.Drawing.Size(492, 150);
            this.people_grid_view.TabIndex = 9;
            // 
            // id_column
            // 
            this.id_column.HeaderText = "ID";
            this.id_column.Name = "id_column";
            this.id_column.ReadOnly = true;
            this.id_column.Width = 30;
            // 
            // name_column
            // 
            this.name_column.HeaderText = "Имя";
            this.name_column.Name = "name_column";
            this.name_column.ReadOnly = true;
            // 
            // surname_column
            // 
            this.surname_column.HeaderText = "Фамилия";
            this.surname_column.Name = "surname_column";
            this.surname_column.ReadOnly = true;
            // 
            // patronymic_column
            // 
            this.patronymic_column.HeaderText = "Отчество";
            this.patronymic_column.Name = "patronymic_column";
            this.patronymic_column.ReadOnly = true;
            // 
            // phone_column
            // 
            this.phone_column.HeaderText = "Телефон";
            this.phone_column.Name = "phone_column";
            this.phone_column.ReadOnly = true;
            // 
            // date_birth_column
            // 
            this.date_birth_column.HeaderText = "Дата Рождения";
            this.date_birth_column.Name = "date_birth_column";
            this.date_birth_column.ReadOnly = true;
            // 
            // address_column
            // 
            this.address_column.HeaderText = "Адрес";
            this.address_column.Name = "address_column";
            this.address_column.ReadOnly = true;
            // 
            // work_column
            // 
            this.work_column.HeaderText = "Место работы";
            this.work_column.Name = "work_column";
            this.work_column.ReadOnly = true;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 346);
            this.Controls.Add(this.people_grid_view);
            this.Controls.Add(this.additional_group_box);
            this.Controls.Add(this.users_action_group_box);
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.hello_label);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.users_action_group_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.people_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button edit_person_button;
        private System.Windows.Forms.Button add_person_button;
        private System.Windows.Forms.Button delete_person_button;
        private System.Windows.Forms.GroupBox users_action_group_box;
        private System.Windows.Forms.GroupBox additional_group_box;
        private System.Windows.Forms.DataGridView people_grid_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_column;
    }
}