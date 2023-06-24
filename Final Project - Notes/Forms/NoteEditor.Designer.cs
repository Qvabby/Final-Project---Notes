namespace Final_Project___Notes.Forms
{
    partial class NoteEditor
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
            this.NoteEditorMenu = new System.Windows.Forms.Panel();
            this.ClosePB = new System.Windows.Forms.PictureBox();
            this.SavePB = new System.Windows.Forms.PictureBox();
            this.DescriptionPB = new System.Windows.Forms.PictureBox();
            this.FillColorPB = new System.Windows.Forms.PictureBox();
            this.FontPB = new System.Windows.Forms.PictureBox();
            this.TextColorPB = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ContentRTF = new System.Windows.Forms.RichTextBox();
            this.NoteEditorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillColorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextColorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteEditorMenu
            // 
            this.NoteEditorMenu.BackColor = System.Drawing.SystemColors.Window;
            this.NoteEditorMenu.Controls.Add(this.ClosePB);
            this.NoteEditorMenu.Controls.Add(this.SavePB);
            this.NoteEditorMenu.Controls.Add(this.DescriptionPB);
            this.NoteEditorMenu.Controls.Add(this.FillColorPB);
            this.NoteEditorMenu.Controls.Add(this.FontPB);
            this.NoteEditorMenu.Controls.Add(this.TextColorPB);
            this.NoteEditorMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoteEditorMenu.Location = new System.Drawing.Point(0, 0);
            this.NoteEditorMenu.Name = "NoteEditorMenu";
            this.NoteEditorMenu.Size = new System.Drawing.Size(484, 44);
            this.NoteEditorMenu.TabIndex = 0;
            // 
            // ClosePB
            // 
            this.ClosePB.Image = global::Final_Project___Notes.Properties.Resources.icons8_multiplication_50;
            this.ClosePB.Location = new System.Drawing.Point(454, 0);
            this.ClosePB.Name = "ClosePB";
            this.ClosePB.Size = new System.Drawing.Size(30, 30);
            this.ClosePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePB.TabIndex = 5;
            this.ClosePB.TabStop = false;
            this.ClosePB.Click += new System.EventHandler(this.ClosePB_Click);
            // 
            // SavePB
            // 
            this.SavePB.Image = global::Final_Project___Notes.Properties.Resources.icons8_save_60;
            this.SavePB.Location = new System.Drawing.Point(367, 0);
            this.SavePB.Name = "SavePB";
            this.SavePB.Size = new System.Drawing.Size(30, 30);
            this.SavePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SavePB.TabIndex = 4;
            this.SavePB.TabStop = false;
            this.SavePB.Click += new System.EventHandler(this.SavePB_Click);
            // 
            // DescriptionPB
            // 
            this.DescriptionPB.Image = global::Final_Project___Notes.Properties.Resources.icons8_description_64;
            this.DescriptionPB.Location = new System.Drawing.Point(403, 0);
            this.DescriptionPB.Name = "DescriptionPB";
            this.DescriptionPB.Size = new System.Drawing.Size(40, 40);
            this.DescriptionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DescriptionPB.TabIndex = 3;
            this.DescriptionPB.TabStop = false;
            this.DescriptionPB.Click += new System.EventHandler(this.DescriptionPB_Click);
            // 
            // FillColorPB
            // 
            this.FillColorPB.Image = global::Final_Project___Notes.Properties.Resources.icons8_fill_color_64;
            this.FillColorPB.Location = new System.Drawing.Point(63, 0);
            this.FillColorPB.Name = "FillColorPB";
            this.FillColorPB.Size = new System.Drawing.Size(30, 30);
            this.FillColorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FillColorPB.TabIndex = 2;
            this.FillColorPB.TabStop = false;
            this.FillColorPB.Click += new System.EventHandler(this.FillColorPB_Click);
            // 
            // FontPB
            // 
            this.FontPB.Image = global::Final_Project___Notes.Properties.Resources.icons8_font_style_formatting_64;
            this.FontPB.Location = new System.Drawing.Point(99, 0);
            this.FontPB.Name = "FontPB";
            this.FontPB.Size = new System.Drawing.Size(30, 30);
            this.FontPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FontPB.TabIndex = 1;
            this.FontPB.TabStop = false;
            this.FontPB.Click += new System.EventHandler(this.FontPB_Click);
            // 
            // TextColorPB
            // 
            this.TextColorPB.Image = global::Final_Project___Notes.Properties.Resources.icons8_text_color_64;
            this.TextColorPB.Location = new System.Drawing.Point(27, 0);
            this.TextColorPB.Name = "TextColorPB";
            this.TextColorPB.Size = new System.Drawing.Size(30, 30);
            this.TextColorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TextColorPB.TabIndex = 0;
            this.TextColorPB.TabStop = false;
            this.TextColorPB.Click += new System.EventHandler(this.TextColorPB_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 47);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(60, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title :";
            // 
            // ContentRTF
            // 
            this.ContentRTF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentRTF.Location = new System.Drawing.Point(17, 75);
            this.ContentRTF.Name = "ContentRTF";
            this.ContentRTF.Size = new System.Drawing.Size(455, 292);
            this.ContentRTF.TabIndex = 1;
            this.ContentRTF.Text = "";
            // 
            // NoteEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 379);
            this.Controls.Add(this.ContentRTF);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NoteEditorMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoteEditor";
            this.Text = "NoteEditor";
            this.NoteEditorMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SavePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FillColorPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextColorPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NoteEditorMenu;
        private System.Windows.Forms.PictureBox TextColorPB;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.RichTextBox ContentRTF;
        private System.Windows.Forms.PictureBox DescriptionPB;
        private System.Windows.Forms.PictureBox FillColorPB;
        private System.Windows.Forms.PictureBox FontPB;
        private System.Windows.Forms.PictureBox SavePB;
        private System.Windows.Forms.PictureBox ClosePB;
    }
}