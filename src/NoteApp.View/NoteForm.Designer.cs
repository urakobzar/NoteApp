
namespace NoteApp.View
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.NoteDateModify = new System.Windows.Forms.DateTimePicker();
            this.NoteDateCreate = new System.Windows.Forms.DateTimePicker();
            this.LabelNoteDateModify = new System.Windows.Forms.Label();
            this.LabelNoteDateCreate = new System.Windows.Forms.Label();
            this.LabelNoteCategory = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxNoteText = new System.Windows.Forms.TextBox();
            this.ComboBoxNoteCategory = new System.Windows.Forms.ComboBox();
            this.TextBoxNoteTitle = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoteDateModify
            // 
            this.NoteDateModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteDateModify.Enabled = false;
            this.NoteDateModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteDateModify.Location = new System.Drawing.Point(292, 66);
            this.NoteDateModify.MaximumSize = new System.Drawing.Size(128, 23);
            this.NoteDateModify.Name = "NoteDateModify";
            this.NoteDateModify.Size = new System.Drawing.Size(128, 23);
            this.NoteDateModify.TabIndex = 13;
            // 
            // NoteDateCreate
            // 
            this.NoteDateCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteDateCreate.Enabled = false;
            this.NoteDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteDateCreate.Location = new System.Drawing.Point(87, 66);
            this.NoteDateCreate.MaximumSize = new System.Drawing.Size(128, 23);
            this.NoteDateCreate.Name = "NoteDateCreate";
            this.NoteDateCreate.Size = new System.Drawing.Size(128, 23);
            this.NoteDateCreate.TabIndex = 12;
            // 
            // LabelNoteDateModify
            // 
            this.LabelNoteDateModify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoteDateModify.AutoSize = true;
            this.LabelNoteDateModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteDateModify.Location = new System.Drawing.Point(221, 69);
            this.LabelNoteDateModify.Name = "LabelNoteDateModify";
            this.LabelNoteDateModify.Size = new System.Drawing.Size(65, 17);
            this.LabelNoteDateModify.TabIndex = 11;
            this.LabelNoteDateModify.Text = "Modified:";
            // 
            // LabelNoteDateCreate
            // 
            this.LabelNoteDateCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoteDateCreate.AutoSize = true;
            this.LabelNoteDateCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteDateCreate.Location = new System.Drawing.Point(12, 69);
            this.LabelNoteDateCreate.Name = "LabelNoteDateCreate";
            this.LabelNoteDateCreate.Size = new System.Drawing.Size(62, 17);
            this.LabelNoteDateCreate.TabIndex = 10;
            this.LabelNoteDateCreate.Text = "Created:";
            // 
            // LabelNoteCategory
            // 
            this.LabelNoteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNoteCategory.AutoSize = true;
            this.LabelNoteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNoteCategory.Location = new System.Drawing.Point(12, 39);
            this.LabelNoteCategory.Name = "LabelNoteCategory";
            this.LabelNoteCategory.Size = new System.Drawing.Size(69, 17);
            this.LabelNoteCategory.TabIndex = 8;
            this.LabelNoteCategory.Text = "Category:";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(39, 17);
            this.LabelTitle.TabIndex = 14;
            this.LabelTitle.Text = "Title:";
            // 
            // TextBoxNoteText
            // 
            this.TextBoxNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNoteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNoteText.Location = new System.Drawing.Point(12, 95);
            this.TextBoxNoteText.Multiline = true;
            this.TextBoxNoteText.Name = "TextBoxNoteText";
            this.TextBoxNoteText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxNoteText.Size = new System.Drawing.Size(672, 367);
            this.TextBoxNoteText.TabIndex = 15;
            // 
            // ComboBoxNoteCategory
            // 
            this.ComboBoxNoteCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxNoteCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNoteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxNoteCategory.FormattingEnabled = true;
            this.ComboBoxNoteCategory.Items.AddRange(new object[] {
            "Documents",
            "Finance",
            "Health and Sports",
            "Home",
            "Miscs",
            "People",
            "Work"});
            this.ComboBoxNoteCategory.Location = new System.Drawing.Point(87, 36);
            this.ComboBoxNoteCategory.MaximumSize = new System.Drawing.Size(168, 0);
            this.ComboBoxNoteCategory.Name = "ComboBoxNoteCategory";
            this.ComboBoxNoteCategory.Size = new System.Drawing.Size(168, 24);
            this.ComboBoxNoteCategory.TabIndex = 16;
            // 
            // TextBoxNoteTitle
            // 
            this.TextBoxNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNoteTitle.Location = new System.Drawing.Point(87, 7);
            this.TextBoxNoteTitle.Name = "TextBoxNoteTitle";
            this.TextBoxNoteTitle.Size = new System.Drawing.Size(597, 23);
            this.TextBoxNoteTitle.TabIndex = 17;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOK.Location = new System.Drawing.Point(528, 471);
            this.ButtonOK.MaximumSize = new System.Drawing.Size(346, 32);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 32);
            this.ButtonOK.TabIndex = 18;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCancel.Location = new System.Drawing.Point(609, 471);
            this.ButtonCancel.MaximumSize = new System.Drawing.Size(346, 32);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 32);
            this.ButtonCancel.TabIndex = 19;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(696, 511);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxNoteTitle);
            this.Controls.Add(this.ComboBoxNoteCategory);
            this.Controls.Add(this.TextBoxNoteText);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.NoteDateModify);
            this.Controls.Add(this.NoteDateCreate);
            this.Controls.Add(this.LabelNoteDateModify);
            this.Controls.Add(this.LabelNoteDateCreate);
            this.Controls.Add(this.LabelNoteCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(712, 550);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker NoteDateModify;
        private System.Windows.Forms.DateTimePicker NoteDateCreate;
        private System.Windows.Forms.Label LabelNoteDateModify;
        private System.Windows.Forms.Label LabelNoteDateCreate;
        private System.Windows.Forms.Label LabelNoteCategory;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxNoteText;
        private System.Windows.Forms.ComboBox ComboBoxNoteCategory;
        private System.Windows.Forms.TextBox TextBoxNoteTitle;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
    }
}