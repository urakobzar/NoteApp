
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // LabelCategoryShow
            // 
            this.LabelCategoryShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelCategoryShow.AutoSize = true;
            this.LabelCategoryShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategoryShow.Location = new System.Drawing.Point(3, 6);
            this.LabelCategoryShow.Name = "LabelCategoryShow";
            this.LabelCategoryShow.Size = new System.Drawing.Size(101, 17);
            this.LabelCategoryShow.TabIndex = 2;
            this.LabelCategoryShow.Text = "Show category";
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
            "Miscs",
            "People",
            "Work"});
            this.CategoryComboBox.Location = new System.Drawing.Point(110, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(168, 24);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(3, 33);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(275, 532);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.TextBoxNoteText.Size = new System.Drawing.Size(553, 485);
            this.TextBoxNoteText.TabIndex = 7;
            this.TextBoxNoteText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.LabelSelectedCategoryNote.Location = new System.Drawing.Point(78, 27);
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
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(142, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem1});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem1
            // 
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            this.ExitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.ExitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem1,
            this.EditNoteToolStripMenuItem1,
            this.DeleteNoteToolStripMenuItem1});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem1
            // 
            this.AddNoteToolStripMenuItem1.Name = "AddNoteToolStripMenuItem1";
            this.AddNoteToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.AddNoteToolStripMenuItem1.Text = "Add Note";
            this.AddNoteToolStripMenuItem1.Click += new System.EventHandler(this.addNoteToolStripMenuItem1_Click);
            // 
            // EditNoteToolStripMenuItem1
            // 
            this.EditNoteToolStripMenuItem1.Name = "EditNoteToolStripMenuItem1";
            this.EditNoteToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.EditNoteToolStripMenuItem1.Text = "Edit Note";
            this.EditNoteToolStripMenuItem1.Click += new System.EventHandler(this.editNoteToolStripMenuItem1_Click);
            // 
            // DeleteNoteToolStripMenuItem1
            // 
            this.DeleteNoteToolStripMenuItem1.Name = "DeleteNoteToolStripMenuItem1";
            this.DeleteNoteToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.DeleteNoteToolStripMenuItem1.Text = "Delete Note";
            this.DeleteNoteToolStripMenuItem1.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem1_Click);
            // 
            // HelpToolStripMenuItem1
            // 
            this.HelpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem1});
            this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
            this.HelpToolStripMenuItem1.Size = new System.Drawing.Size(49, 23);
            this.HelpToolStripMenuItem1.Text = "Help";
            // 
            // AboutToolStripMenuItem1
            // 
            this.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            this.AboutToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.AboutToolStripMenuItem1.Text = "About";
            this.AboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 599);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(882, 638);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp v.1.0.0";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem DeleteNoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem1;
        private System.Windows.Forms.TextBox TextBoxNoteText;
        private System.Windows.Forms.ListBox NotesListBox;
    }
}

