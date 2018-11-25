namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TestButton = new System.Windows.Forms.Button();
            this.LeftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftTopTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.ChangePictureBox = new System.Windows.Forms.PictureBox();
            this.RightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteCategoryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeCreatedLabel = new System.Windows.Forms.Label();
            this.TimeChangedLabel = new System.Windows.Forms.Label();
            this.TimeCreatedComboBox = new System.Windows.Forms.ComboBox();
            this.TimeChangedComboBox = new System.Windows.Forms.ComboBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.LeftTableLayoutPanel.SuspendLayout();
            this.LeftTopTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePictureBox)).BeginInit();
            this.RightLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNoteToolStripMenuItem
            // 
            this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
            this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNoteToolStripMenuItem.Text = "Add Note";
            // 
            // editNoteToolStripMenuItem
            // 
            this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
            this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // removeNoteToolStripMenuItem
            // 
            this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
            this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeNoteToolStripMenuItem.Text = "Remove Note";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // TestButton
            // 
            this.TestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestButton.Location = new System.Drawing.Point(215, 157);
            this.TestButton.MaximumSize = new System.Drawing.Size(99, 32);
            this.TestButton.MinimumSize = new System.Drawing.Size(99, 32);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(99, 32);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "тест классов";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // LeftTableLayoutPanel
            // 
            this.LeftTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftTableLayoutPanel.ColumnCount = 1;
            this.LeftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftTableLayoutPanel.Controls.Add(this.LeftTopTableLayoutPanel, 0, 0);
            this.LeftTableLayoutPanel.Controls.Add(this.NoteListBox, 0, 1);
            this.LeftTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.LeftTableLayoutPanel.Location = new System.Drawing.Point(12, 27);
            this.LeftTableLayoutPanel.Name = "LeftTableLayoutPanel";
            this.LeftTableLayoutPanel.RowCount = 3;
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.3F));
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LeftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.7F));
            this.LeftTableLayoutPanel.Size = new System.Drawing.Size(241, 432);
            this.LeftTableLayoutPanel.TabIndex = 3;
            // 
            // LeftTopTableLayoutPanel
            // 
            this.LeftTopTableLayoutPanel.ColumnCount = 2;
            this.LeftTopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.04255F));
            this.LeftTopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.95745F));
            this.LeftTopTableLayoutPanel.Controls.Add(this.CategoryLabel, 0, 0);
            this.LeftTopTableLayoutPanel.Controls.Add(this.NoteCategoryComboBox, 1, 0);
            this.LeftTopTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftTopTableLayoutPanel.Name = "LeftTopTableLayoutPanel";
            this.LeftTopTableLayoutPanel.RowCount = 1;
            this.LeftTopTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LeftTopTableLayoutPanel.Size = new System.Drawing.Size(235, 25);
            this.LeftTopTableLayoutPanel.TabIndex = 0;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(3, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(73, 27);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Category:";
            this.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(82, 3);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.NoteCategoryComboBox.TabIndex = 1;
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test4"});
            this.NoteListBox.Location = new System.Drawing.Point(3, 34);
            this.NoteListBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(235, 342);
            this.NoteListBox.TabIndex = 1;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel2.Controls.Add(this.RemovePictureBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AddPictureBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ChangePictureBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 379);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 50);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePictureBox.Image = global::NoteAppUI.Properties.Resources.remove;
            this.RemovePictureBox.Location = new System.Drawing.Point(159, 3);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(73, 44);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemovePictureBox.TabIndex = 7;
            this.RemovePictureBox.TabStop = false;
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPictureBox.Image = global::NoteAppUI.Properties.Resources.add;
            this.AddPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(72, 44);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddPictureBox.TabIndex = 5;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            // 
            // ChangePictureBox
            // 
            this.ChangePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePictureBox.Image = global::NoteAppUI.Properties.Resources.change;
            this.ChangePictureBox.Location = new System.Drawing.Point(81, 3);
            this.ChangePictureBox.Name = "ChangePictureBox";
            this.ChangePictureBox.Size = new System.Drawing.Size(72, 44);
            this.ChangePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ChangePictureBox.TabIndex = 6;
            this.ChangePictureBox.TabStop = false;
            // 
            // RightLayoutPanel
            // 
            this.RightLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightLayoutPanel.ColumnCount = 1;
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.Controls.Add(this.NoteNameLabel, 0, 0);
            this.RightLayoutPanel.Controls.Add(this.NoteCategoryLabel, 0, 1);
            this.RightLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.RightLayoutPanel.Controls.Add(this.NoteTextBox, 0, 3);
            this.RightLayoutPanel.Location = new System.Drawing.Point(259, 27);
            this.RightLayoutPanel.Name = "RightLayoutPanel";
            this.RightLayoutPanel.RowCount = 4;
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.RightLayoutPanel.Size = new System.Drawing.Size(375, 435);
            this.RightLayoutPanel.TabIndex = 4;
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Location = new System.Drawing.Point(3, 0);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(369, 43);
            this.NoteNameLabel.TabIndex = 0;
            this.NoteNameLabel.Text = "label1";
            this.NoteNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoteCategoryLabel
            // 
            this.NoteCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteCategoryLabel.AutoSize = true;
            this.NoteCategoryLabel.Location = new System.Drawing.Point(3, 43);
            this.NoteCategoryLabel.Name = "NoteCategoryLabel";
            this.NoteCategoryLabel.Size = new System.Drawing.Size(369, 32);
            this.NoteCategoryLabel.TabIndex = 1;
            this.NoteCategoryLabel.Text = "label1";
            this.NoteCategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TimeCreatedLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeChangedLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeCreatedComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TimeChangedComboBox, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 75);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 32);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TimeCreatedLabel
            // 
            this.TimeCreatedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeCreatedLabel.AutoSize = true;
            this.TimeCreatedLabel.Location = new System.Drawing.Point(3, 0);
            this.TimeCreatedLabel.Name = "TimeCreatedLabel";
            this.TimeCreatedLabel.Size = new System.Drawing.Size(44, 32);
            this.TimeCreatedLabel.TabIndex = 0;
            this.TimeCreatedLabel.Text = "Created";
            // 
            // TimeChangedLabel
            // 
            this.TimeChangedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeChangedLabel.AutoSize = true;
            this.TimeChangedLabel.Location = new System.Drawing.Point(189, 0);
            this.TimeChangedLabel.Name = "TimeChangedLabel";
            this.TimeChangedLabel.Size = new System.Drawing.Size(47, 32);
            this.TimeChangedLabel.TabIndex = 1;
            this.TimeChangedLabel.Text = "Modified";
            // 
            // TimeCreatedComboBox
            // 
            this.TimeCreatedComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeCreatedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeCreatedComboBox.Enabled = false;
            this.TimeCreatedComboBox.FormattingEnabled = true;
            this.TimeCreatedComboBox.Location = new System.Drawing.Point(53, 3);
            this.TimeCreatedComboBox.Name = "TimeCreatedComboBox";
            this.TimeCreatedComboBox.Size = new System.Drawing.Size(121, 21);
            this.TimeCreatedComboBox.TabIndex = 2;
            // 
            // TimeChangedComboBox
            // 
            this.TimeChangedComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TimeChangedComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeChangedComboBox.Enabled = false;
            this.TimeChangedComboBox.FormattingEnabled = true;
            this.TimeChangedComboBox.Location = new System.Drawing.Point(242, 3);
            this.TimeChangedComboBox.Name = "TimeChangedComboBox";
            this.TimeChangedComboBox.Size = new System.Drawing.Size(121, 21);
            this.TimeChangedComboBox.TabIndex = 3;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteTextBox.Location = new System.Drawing.Point(3, 110);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(369, 322);
            this.NoteTextBox.TabIndex = 3;
            this.NoteTextBox.Text = resources.GetString("NoteTextBox.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.RightLayoutPanel);
            this.Controls.Add(this.LeftTableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LeftTableLayoutPanel.ResumeLayout(false);
            this.LeftTopTableLayoutPanel.ResumeLayout(false);
            this.LeftTopTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangePictureBox)).EndInit();
            this.RightLayoutPanel.ResumeLayout(false);
            this.RightLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.TableLayoutPanel LeftTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel LeftTopTableLayoutPanel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.Label NoteCategoryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TimeCreatedLabel;
        private System.Windows.Forms.Label TimeChangedLabel;
        private System.Windows.Forms.ComboBox TimeCreatedComboBox;
        private System.Windows.Forms.ComboBox TimeChangedComboBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.PictureBox ChangePictureBox;
        private System.Windows.Forms.PictureBox RemovePictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

