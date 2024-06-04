namespace lab_mvp.Views
{
    partial class FilterView
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
            this.dateTimePickerFilter = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFilterPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxPriority = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePickerFilter
            // 
            this.dateTimePickerFilter.Location = new System.Drawing.Point(12, 150);
            this.dateTimePickerFilter.Name = "dateTimePickerFilter";
            this.dateTimePickerFilter.Size = new System.Drawing.Size(238, 22);
            this.dateTimePickerFilter.TabIndex = 29;
            // 
            // comboBoxFilterPriority
            // 
            this.comboBoxFilterPriority.AutoCompleteCustomSource.AddRange(new string[] {
            "Data",
            "Typ",
            "Priorytet"});
            this.comboBoxFilterPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterPriority.FormattingEnabled = true;
            this.comboBoxFilterPriority.Items.AddRange(new object[] {
            "Wysoki",
            "Średni",
            "Niski"});
            this.comboBoxFilterPriority.Location = new System.Drawing.Point(12, 94);
            this.comboBoxFilterPriority.Name = "comboBoxFilterPriority";
            this.comboBoxFilterPriority.Size = new System.Drawing.Size(238, 24);
            this.comboBoxFilterPriority.TabIndex = 27;
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.AutoCompleteCustomSource.AddRange(new string[] {
            "Data",
            "Typ",
            "Priorytet"});
            this.comboBoxFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "Praca",
            "Rodzina",
            "Rozrywka",
            "Zdrowie",
            "Sport"});
            this.comboBoxFilterType.Location = new System.Drawing.Point(12, 38);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(238, 24);
            this.comboBoxFilterType.TabIndex = 25;
            // 
            // buttonAccept
            // 
            this.buttonAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAccept.Location = new System.Drawing.Point(12, 190);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(127, 23);
            this.buttonAccept.TabIndex = 34;
            this.buttonAccept.Text = "Filtruj";
            this.buttonAccept.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(145, 190);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 23);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(12, 12);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(53, 20);
            this.checkBoxType.TabIndex = 36;
            this.checkBoxType.Text = "Typ";
            this.checkBoxType.UseVisualStyleBackColor = true;
            // 
            // checkBoxPriority
            // 
            this.checkBoxPriority.AutoSize = true;
            this.checkBoxPriority.Location = new System.Drawing.Point(12, 68);
            this.checkBoxPriority.Name = "checkBoxPriority";
            this.checkBoxPriority.Size = new System.Drawing.Size(78, 20);
            this.checkBoxPriority.TabIndex = 37;
            this.checkBoxPriority.Text = "Priorytet";
            this.checkBoxPriority.UseVisualStyleBackColor = true;
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Location = new System.Drawing.Point(12, 124);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(58, 20);
            this.checkBoxDate.TabIndex = 38;
            this.checkBoxDate.Text = "Data";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            // 
            // FilterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 225);
            this.Controls.Add(this.checkBoxDate);
            this.Controls.Add(this.checkBoxPriority);
            this.Controls.Add(this.checkBoxType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.dateTimePickerFilter);
            this.Controls.Add(this.comboBoxFilterPriority);
            this.Controls.Add(this.comboBoxFilterType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FilterView";
            this.Text = "Filtruj wg.";
            this.Load += new System.EventHandler(this.FilterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePickerFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterPriority;
        private System.Windows.Forms.ComboBox comboBoxFilterType;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxPriority;
        private System.Windows.Forms.CheckBox checkBoxDate;
    }
}