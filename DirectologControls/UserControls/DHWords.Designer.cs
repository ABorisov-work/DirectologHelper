namespace DirectologControls
{
    partial class DHWords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lTitle = new System.Windows.Forms.Label();
            this.tbWords = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(212, 20);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Слова списка ";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWords
            // 
            this.tbWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWords.Location = new System.Drawing.Point(0, 20);
            this.tbWords.Name = "tbWords";
            this.tbWords.Size = new System.Drawing.Size(212, 255);
            this.tbWords.TabIndex = 2;
            this.tbWords.Text = "";
            this.tbWords.WordWrap = false;
            this.tbWords.TextChanged += new System.EventHandler(this.tbWords_TextChanged);
            // 
            // DHWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbWords);
            this.Controls.Add(this.lTitle);
            this.Name = "DHWords";
            this.Size = new System.Drawing.Size(212, 275);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.RichTextBox tbWords;
    }
}
