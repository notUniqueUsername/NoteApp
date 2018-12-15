namespace NoteAppUI
{
    partial class AddChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChangeForm));
            this.RightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.TimeCreatedLabel = new System.Windows.Forms.Label();
            this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeChangedLabel = new System.Windows.Forms.Label();
            this.ModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteNameTextBox = new System.Windows.Forms.TextBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.RightLayoutPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightLayoutPanel
            // 
            this.RightLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightLayoutPanel.ColumnCount = 1;
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.RightLayoutPanel.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.RightLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.RightLayoutPanel.Controls.Add(this.NoteTextBox, 0, 3);
            this.RightLayoutPanel.Location = new System.Drawing.Point(0, 1);
            this.RightLayoutPanel.Name = "RightLayoutPanel";
            this.RightLayoutPanel.RowCount = 4;
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.RightLayoutPanel.Size = new System.Drawing.Size(600, 505);
            this.RightLayoutPanel.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.TimeCreatedLabel);
            this.flowLayoutPanel3.Controls.Add(this.CreatedTimePicker);
            this.flowLayoutPanel3.Controls.Add(this.TimeChangedLabel);
            this.flowLayoutPanel3.Controls.Add(this.ModifiedTimePicker);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 67);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(594, 26);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // TimeCreatedLabel
            // 
            this.TimeCreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeCreatedLabel.AutoSize = true;
            this.TimeCreatedLabel.Location = new System.Drawing.Point(3, 0);
            this.TimeCreatedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.TimeCreatedLabel.Name = "TimeCreatedLabel";
            this.TimeCreatedLabel.Size = new System.Drawing.Size(44, 26);
            this.TimeCreatedLabel.TabIndex = 0;
            this.TimeCreatedLabel.Text = "Created";
            // 
            // CreatedTimePicker
            // 
            this.CreatedTimePicker.Enabled = false;
            this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreatedTimePicker.Location = new System.Drawing.Point(71, 3);
            this.CreatedTimePicker.Name = "CreatedTimePicker";
            this.CreatedTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CreatedTimePicker.TabIndex = 8;
            // 
            // TimeChangedLabel
            // 
            this.TimeChangedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeChangedLabel.AutoSize = true;
            this.TimeChangedLabel.Location = new System.Drawing.Point(277, 0);
            this.TimeChangedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 21, 0);
            this.TimeChangedLabel.Name = "TimeChangedLabel";
            this.TimeChangedLabel.Size = new System.Drawing.Size(47, 26);
            this.TimeChangedLabel.TabIndex = 1;
            this.TimeChangedLabel.Text = "Modified";
            // 
            // ModifiedTimePicker
            // 
            this.ModifiedTimePicker.Enabled = false;
            this.ModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModifiedTimePicker.Location = new System.Drawing.Point(348, 3);
            this.ModifiedTimePicker.Name = "ModifiedTimePicker";
            this.ModifiedTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ModifiedTimePicker.TabIndex = 9;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.NoteCategoryLabel);
            this.flowLayoutPanel2.Controls.Add(this.NoteCategoryComboBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(594, 26);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Location = new System.Drawing.Point(3, 6);
            this.NoteCategoryLabel.Margin = new System.Windows.Forms.Padding(3, 6, 16, 0);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.NoteCategoryLabel.TabIndex = 0;
            this.NoteCategoryLabel.Text = "Category";
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(71, 3);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(89, 21);
            this.NoteCategoryComboBox.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.NoteNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.NoteNameTextBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(594, 26);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Location = new System.Drawing.Point(3, 6);
            this.NoteNameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(62, 13);
            this.NoteNameLabel.TabIndex = 0;
            this.NoteNameLabel.Text = "Note name:";
            this.NoteNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoteNameTextBox
            // 
            this.NoteNameTextBox.Location = new System.Drawing.Point(71, 3);
            this.NoteNameTextBox.Name = "NoteNameTextBox";
            this.NoteNameTextBox.Size = new System.Drawing.Size(512, 20);
            this.NoteNameTextBox.TabIndex = 1;
            this.NoteNameTextBox.TextChanged += new System.EventHandler(this.NoteNameTextBox_TextChanged);
            this.NoteNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NoteNameTextBox_KeyPress);
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoteTextBox.Location = new System.Drawing.Point(3, 99);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(594, 403);
            this.NoteTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(525, 512);
            this.CancelButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.CancelButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(444, 512);
            this.OkButton.MaximumSize = new System.Drawing.Size(75, 23);
            this.OkButton.MinimumSize = new System.Drawing.Size(75, 23);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 539);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RightLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(618, 578);
            this.Name = "AddChangeForm";
            this.Text = "Editable Note";
            this.RightLayoutPanel.ResumeLayout(false);
            this.RightLayoutPanel.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;
        private System.Windows.Forms.Label TimeCreatedLabel;
        private System.Windows.Forms.Label TimeChangedLabel;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.TextBox NoteNameTextBox;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DateTimePicker CreatedTimePicker;
        private System.Windows.Forms.DateTimePicker ModifiedTimePicker;
    }
}