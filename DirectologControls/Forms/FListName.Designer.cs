namespace DirectologControls
{
    partial class FListName
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGeo = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnWhat = new System.Windows.Forms.Button();
            this.btnWho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(79, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(267, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnGeo);
            this.groupBox1.Controls.Add(this.btnAction);
            this.groupBox1.Controls.Add(this.btnWhat);
            this.groupBox1.Controls.Add(this.btnWho);
            this.groupBox1.Location = new System.Drawing.Point(16, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пресеты";
            // 
            // btnGeo
            // 
            this.btnGeo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGeo.Location = new System.Drawing.Point(264, 19);
            this.btnGeo.Name = "btnGeo";
            this.btnGeo.Size = new System.Drawing.Size(60, 23);
            this.btnGeo.TabIndex = 5;
            this.btnGeo.Text = "4. Гео";
            this.btnGeo.UseVisualStyleBackColor = true;
            this.btnGeo.Click += new System.EventHandler(this.btnPreset_Click);
            // 
            // btnAction
            // 
            this.btnAction.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAction.Location = new System.Drawing.Point(168, 19);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(90, 23);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "3. Действие";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnPreset_Click);
            // 
            // btnWhat
            // 
            this.btnWhat.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnWhat.Location = new System.Drawing.Point(87, 19);
            this.btnWhat.Name = "btnWhat";
            this.btnWhat.Size = new System.Drawing.Size(75, 23);
            this.btnWhat.TabIndex = 3;
            this.btnWhat.Text = "2. Что";
            this.btnWhat.UseVisualStyleBackColor = true;
            this.btnWhat.Click += new System.EventHandler(this.btnPreset_Click);
            // 
            // btnWho
            // 
            this.btnWho.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnWho.Location = new System.Drawing.Point(6, 19);
            this.btnWho.Name = "btnWho";
            this.btnWho.Size = new System.Drawing.Size(75, 23);
            this.btnWho.TabIndex = 2;
            this.btnWho.Text = "1. Кто";
            this.btnWho.UseVisualStyleBackColor = true;
            this.btnWho.Click += new System.EventHandler(this.btnPreset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 29);
            this.panel1.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(199, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.Font = new System.Drawing.Font("Courier New", 13F, System.Drawing.FontStyle.Bold);
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(358, 23);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Название списка";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_MouseDown);
            this.lTitle.MouseEnter += new System.EventHandler(this.Control_MouseEnter);
            this.lTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            this.lTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Control_MouseUp);
            // 
            // FListName
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(358, 147);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FListName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FListName";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGeo;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnWhat;
        private System.Windows.Forms.Button btnWho;
        private System.Windows.Forms.Label lTitle;
    }
}