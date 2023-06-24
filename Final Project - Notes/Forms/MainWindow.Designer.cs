namespace Final_Project___Notes.Forms
{
    partial class MainWindow
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
            this.AddNotePB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddNotePB)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNotePB
            // 
            this.AddNotePB.Image = global::Final_Project___Notes.Properties.Resources.icons8_plus_math_100;
            this.AddNotePB.Location = new System.Drawing.Point(12, 12);
            this.AddNotePB.Name = "AddNotePB";
            this.AddNotePB.Size = new System.Drawing.Size(130, 130);
            this.AddNotePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddNotePB.TabIndex = 0;
            this.AddNotePB.TabStop = false;
            this.AddNotePB.Click += new System.EventHandler(this.AddNotePB_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(484, 379);
            this.Controls.Add(this.AddNotePB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.AddNotePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AddNotePB;
    }
}