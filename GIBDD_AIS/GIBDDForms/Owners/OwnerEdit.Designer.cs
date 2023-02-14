﻿namespace GIBDD_AIS.GIBDDForms.Owners
{
    partial class OwnerEdit
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
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.MaxLength = 30;
            // 
            // nameTextBox
            // 
            this.nameTextBox.MaxLength = 30;
            // 
            // addressTextBox
            // 
            this.addressTextBox.MaxLength = 60;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.MaxLength = 30;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(151, 271);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 168;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(25, 271);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 23);
            this.deleteButton.TabIndex = 169;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // OwnerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(426, 317);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Name = "OwnerEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OwnerEditFormClosed);
            this.Load += new System.EventHandler(this.OwnerEditLoad);
            this.Controls.SetChildIndex(this.topLabel, 0);
            this.Controls.SetChildIndex(this.surnameTextBox, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(this.surnameLabel, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(this.middleNameTextBox, 0);
            this.Controls.SetChildIndex(this.birthDateDateTimePicker, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
