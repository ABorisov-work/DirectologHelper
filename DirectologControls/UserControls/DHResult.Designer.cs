namespace DirectologControls
{
    partial class DHResult
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DHResult));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThreading = new System.Windows.Forms.ComboBox();
            this.cbToFile = new System.Windows.Forms.CheckBox();
            this.cbAutoProc = new System.Windows.Forms.CheckBox();
            this.btnProccedOne = new System.Windows.Forms.Button();
            this.ProccedAll = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbToFile);
            this.panel1.Controls.Add(this.cbAutoProc);
            this.panel1.Controls.Add(this.cbThreading);
            this.panel1.Controls.Add(this.btnProccedOne);
            this.panel1.Controls.Add(this.ProccedAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 44);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Режим работы:";
            // 
            // cbThreading
            // 
            this.cbThreading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbThreading.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThreading.FormattingEnabled = true;
            this.cbThreading.Items.AddRange(new object[] {
            "Однопоточный",
            "Многопоточный"});
            this.cbThreading.Location = new System.Drawing.Point(93, 2);
            this.cbThreading.Name = "cbThreading";
            this.cbThreading.Size = new System.Drawing.Size(128, 21);
            this.cbThreading.TabIndex = 5;
            // 
            // cbToFile
            // 
            this.cbToFile.AutoSize = true;
            this.cbToFile.Checked = true;
            this.cbToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbToFile.Location = new System.Drawing.Point(10, 27);
            this.cbToFile.Name = "cbToFile";
            this.cbToFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbToFile.Size = new System.Drawing.Size(62, 17);
            this.cbToFile.TabIndex = 4;
            this.cbToFile.Text = "В файл";
            this.cbToFile.UseVisualStyleBackColor = true;
            // 
            // cbAutoProc
            // 
            this.cbAutoProc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAutoProc.AutoSize = true;
            this.cbAutoProc.Location = new System.Drawing.Point(78, 27);
            this.cbAutoProc.Name = "cbAutoProc";
            this.cbAutoProc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAutoProc.Size = new System.Drawing.Size(103, 17);
            this.cbAutoProc.TabIndex = 2;
            this.cbAutoProc.Text = "Автообработка";
            this.cbAutoProc.UseVisualStyleBackColor = true;
            // 
            // btnProccedOne
            // 
            this.btnProccedOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProccedOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProccedOne.Image = ((System.Drawing.Image)(resources.GetObject("btnProccedOne.Image")));
            this.btnProccedOne.Location = new System.Drawing.Point(183, 24);
            this.btnProccedOne.Name = "btnProccedOne";
            this.btnProccedOne.Size = new System.Drawing.Size(20, 20);
            this.btnProccedOne.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnProccedOne, "Посчитать по выбранному алгоритму");
            this.btnProccedOne.UseVisualStyleBackColor = true;
            this.btnProccedOne.Click += new System.EventHandler(this.btnProccedOne_Click);
            // 
            // ProccedAll
            // 
            this.ProccedAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProccedAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProccedAll.Image = ((System.Drawing.Image)(resources.GetObject("ProccedAll.Image")));
            this.ProccedAll.Location = new System.Drawing.Point(202, 24);
            this.ProccedAll.Name = "ProccedAll";
            this.ProccedAll.Size = new System.Drawing.Size(20, 20);
            this.ProccedAll.TabIndex = 0;
            this.toolTip1.SetToolTip(this.ProccedAll, "Посчитать все");
            this.ProccedAll.UseVisualStyleBackColor = true;
            this.ProccedAll.Click += new System.EventHandler(this.ProccedAll_Click);
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(223, 20);
            this.lTitle.TabIndex = 6;
            this.lTitle.Text = "Результат";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 241);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "";
            this.textBox1.WordWrap = false;
            // 
            // DHResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lTitle);
            this.Name = "DHResult";
            this.Size = new System.Drawing.Size(223, 305);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProccedOne;
        private System.Windows.Forms.Button ProccedAll;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.CheckBox cbAutoProc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbToFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThreading;
        private System.Windows.Forms.RichTextBox textBox1;
    }
}
