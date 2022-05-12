
namespace NoteApp.View
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.DeleteNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.LabelCategoryShow = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.TextBoxNoteText = new System.Windows.Forms.TextBox();
            this.NoteDateModify = new System.Windows.Forms.DateTimePicker();
            this.NoteDateCreate = new System.Windows.Forms.DateTimePicker();
            this.LabelNoteDateModify = new System.Windows.Forms.Label();
            this.LabelNoteDateCreate = new System.Windows.Forms.Label();
            this.LabelSelectedCategoryNote = new System.Windows.Forms.Label();
            this.LabelCategoryNote = new System.Windows.Forms.Label();
            this.LabelNoteName = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRandomNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.DeleteNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.LabelCategoryShow);
            this.splitContainer1.Panel1.Controls.Add(this.CategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.NotesListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxNoteText);
            this.splitContainer1.Panel2.Controls.Add(this.NoteDateModify);
            this.splitContainer1.Panel2.Controls.Add(this.NoteDateCreate);
            this.splitContainer1.Panel2.Controls.Add(this.LabelNoteDateModify);
            this.splitContainer1.Panel2.Controls.Add(this.LabelNoteDateCreate);
            this.splitContainer1.Panel2.Controls.Add(this.LabelSelectedCategoryNote);
            this.splitContainer1.Panel2.Controls.Add(this.LabelCategoryNote);
            this.splitContainer1.Panel2.Controls.Add(this.LabelNoteName);
            this.splitContainer1.Size = new System.Drawing.Size(844, 567);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditNoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.EditNote;
            this.EditNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Location = new System.Drawing.Point(75, 529);
            this.EditNoteButton.MaximumSize = new System.Drawing.Size(30, 35);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(30, 35);
            this.EditNoteButton.TabIndex = 12;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // DeleteNoteButton
            // 
            this.DeleteNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteNoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.DeleteNote;
            this.DeleteNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNoteButton.FlatAppearance.BorderSize = 0;
            this.DeleteNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteButton.Location = new System.Drawing.Point(39, 529);
            this.DeleteNoteButton.MaximumSize = new System.Drawing.Size(30, 35);
            this.DeleteNoteButton.Name = "DeleteNoteButton";
            this.DeleteNoteButton.Size = new System.Drawing.Size(30, 35);
            this.DeleteNoteButton.TabIndex = 11;
            this.DeleteNoteButton.UseVisualStyleBackColor = true;
            this.DeleteNoteButton.Click += new System.EventHandler(this.DeleteNoteButton_Click);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNoteButton.BackgroundImage = global::NoteApp.View.Properties.Resources.AddNote;
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Location = new System.Drawing.Point(3, 529);
            this.AddNoteButton.MaximumSize = new System.Drawing.Size(30, 35);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(30, 35);
            this.AddNoteButton.TabIndex = 10;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // LabelCategoryShow
            // 
            this.LabelCategoryShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategoryShow.AutoSize = true;
            this.LabelCategoryShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategoryShow.Location = new System.Drawing.Point(3, 6);
            this.LabelCategoryShow.Name = "LabelCategoryShow";
            this.LabelCategoryShow.Size = new System.Drawing.Size(105, 17);
            this.LabelCategoryShow.TabIndex = 2;
            this.LabelCategoryShow.Text = "Show category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "All",
            "Documents",
            "Finance",
            "Health and Sports",
            "Home",
            "People",
            "Work",
            "Miscs"});
            this.CategoryComboBox.Location = new System.Drawing.Point(110, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(168, 24);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.IntegralHeight = false;
            this.NotesListBox.ItemHeight = 20;
            this.NotesListBox.Location = new System.Drawing.Point(3, 33);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(275, 490);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // TextBoxNoteText
            // 
            this.TextBoxNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNoteText.Location = new System.Drawing.Point(3, 79);
            this.TextBoxNoteText.Multiline = true;
            this.TextBoxNoteText.Name = "TextBoxNoteText";
            this.TextBoxNoteText.ReadOnly = true;
            this.TextBoxNoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxNoteText.Size = new System.Drawing.Size(553, 472);
            this.TextBoxNoteText.TabIndex = 7;
            // 
            // NoteDateModify
            // 
            this.NoteDateModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteDateModify.Enabled = false;
            this.NoteDateModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteDateModify.Location = new System.Drawing.Point(288, 47);
            this.NoteDateModify.MaximumSize = new System.Drawing.Size(130, 23);
            this.NoteDateModify.Name = "NoteDateModify";
            this.NoteDateModify.Size = new System.Drawing.Size(130, 23);
            this.NoteDateModify.TabIndex = 6;
            // 
            // NoteDateCreate
            // 
            this.NoteDateCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteDateCreate.Enabled = false;
            this.NoteDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteDateCreate.Location = new System.Drawing.Point(81, 47);
            this.NoteDateCreate.MaximumSize = new System.Drawing.Size(130, 23);
            this.NoteDateCreate.Name = "NoteDateCreate";
            this.NoteDateCreate.Size = new System.Drawing.Size(130, 23);
            this.NoteDateCreate.TabIndex = 5;
            // 
            // LabelNoteDateModify
            // 
            this.LabelNoteDateModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoteDateModify.AutoSize = true;
            this.LabelNoteDateModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteDateModify.Location = new System.Drawing.Point(217, 50);
            this.LabelNoteDateModify.Name = "LabelNoteDateModify";
            this.LabelNoteDateModify.Size = new System.Drawing.Size(65, 17);
            this.LabelNoteDateModify.TabIndex = 4;
            this.LabelNoteDateModify.Text = "Modified:";
            // 
            // LabelNoteDateCreate
            // 
            this.LabelNoteDateCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoteDateCreate.AutoSize = true;
            this.LabelNoteDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteDateCreate.Location = new System.Drawing.Point(4, 50);
            this.LabelNoteDateCreate.Name = "LabelNoteDateCreate";
            this.LabelNoteDateCreate.Size = new System.Drawing.Size(62, 17);
            this.LabelNoteDateCreate.TabIndex = 3;
            this.LabelNoteDateCreate.Text = "Created:";
            // 
            // LabelSelectedCategoryNote
            // 
            this.LabelSelectedCategoryNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectedCategoryNote.AutoSize = true;
            this.LabelSelectedCategoryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelectedCategoryNote.Location = new System.Drawing.Point(79, 27);
            this.LabelSelectedCategoryNote.Name = "LabelSelectedCategoryNote";
            this.LabelSelectedCategoryNote.Size = new System.Drawing.Size(120, 17);
            this.LabelSelectedCategoryNote.TabIndex = 2;
            this.LabelSelectedCategoryNote.Text = "SelectedCategory";
            // 
            // LabelCategoryNote
            // 
            this.LabelCategoryNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategoryNote.AutoSize = true;
            this.LabelCategoryNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategoryNote.Location = new System.Drawing.Point(4, 27);
            this.LabelCategoryNote.Name = "LabelCategoryNote";
            this.LabelCategoryNote.Size = new System.Drawing.Size(69, 17);
            this.LabelCategoryNote.TabIndex = 1;
            this.LabelCategoryNote.Text = "Category:";
            // 
            // LabelNoteName
            // 
            this.LabelNoteName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoteName.AutoSize = true;
            this.LabelNoteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteName.Location = new System.Drawing.Point(3, 3);
            this.LabelNoteName.Name = "LabelNoteName";
            this.LabelNoteName.Size = new System.Drawing.Size(109, 24);
            this.LabelNoteName.TabIndex = 0;
            this.LabelNoteName.Text = "NoteName";
            // 
            // menuStrip
            // 
            this.menuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(142, 27);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.DeleteNoteToolStripMenuItem,
            this.AddRandomNotesToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // DeleteNoteToolStripMenuItem
            // 
            this.DeleteNoteToolStripMenuItem.Name = "DeleteNoteToolStripMenuItem";
            this.DeleteNoteToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.DeleteNoteToolStripMenuItem.Text = "Delete Note";
            this.DeleteNoteToolStripMenuItem.Click += new System.EventHandler(this.DeleteNoteToolStripMenuItem_Click);
            // 
            // AddRandomNotesToolStripMenuItem
            // 
            this.AddRandomNotesToolStripMenuItem.Name = "AddRandomNotesToolStripMenuItem";
            this.AddRandomNotesToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.AddRandomNotesToolStripMenuItem.Text = "Add Random Notes";
            this.AddRandomNotesToolStripMenuItem.Click += new System.EventHandler(this.AddRandomNotesToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem1
            // 
            this.HelpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
            this.HelpToolStripMenuItem1.Size = new System.Drawing.Size(49, 23);
            this.HelpToolStripMenuItem1.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(866, 599);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(882, 638);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp v.1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label LabelCategoryShow;
        private System.Windows.Forms.Label LabelNoteDateModify;
        private System.Windows.Forms.Label LabelNoteDateCreate;
        private System.Windows.Forms.Label LabelSelectedCategoryNote;
        private System.Windows.Forms.Label LabelCategoryNote;
        private System.Windows.Forms.Label LabelNoteName;
        private System.Windows.Forms.DateTimePicker NoteDateModify;
        private System.Windows.Forms.DateTimePicker NoteDateCreate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBoxNoteText;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button DeleteNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.ToolStripMenuItem AddRandomNotesToolStripMenuItem;
    }
}

