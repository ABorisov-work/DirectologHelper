namespace DirectologControls
{
    partial class DHAlgoritms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DHAlgoritms));
            this.lTitle = new System.Windows.Forms.Label();
            this.lbAlgorytms = new System.Windows.Forms.ListBox();
            this.cmsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addAlgorytmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAlgorytmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAlgorytmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreateAlgos = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmsActions.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lTitle.Size = new System.Drawing.Size(232, 20);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Алгоритмы";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAlgorytms
            // 
            this.lbAlgorytms.ContextMenuStrip = this.cmsActions;
            this.lbAlgorytms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAlgorytms.FormattingEnabled = true;
            this.lbAlgorytms.Location = new System.Drawing.Point(0, 42);
            this.lbAlgorytms.Name = "lbAlgorytms";
            this.lbAlgorytms.Size = new System.Drawing.Size(232, 251);
            this.lbAlgorytms.TabIndex = 3;
            this.lbAlgorytms.SelectedValueChanged += new System.EventHandler(this.lbAlgorytms_SelectedValueChanged);
            this.lbAlgorytms.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAlgorytms_MouseDown);
            // 
            // cmsActions
            // 
            this.cmsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAlgorytmToolStripMenuItem,
            this.removeAlgorytmToolStripMenuItem,
            this.editAlgorytmToolStripMenuItem});
            this.cmsActions.Name = "cmsActions";
            this.cmsActions.Size = new System.Drawing.Size(185, 70);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCreateAlgos);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 22);
            this.panel1.TabIndex = 5;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 200;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 40;
            // 
            // addAlgorytmToolStripMenuItem
            // 
            this.addAlgorytmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addAlgorytmToolStripMenuItem.Image")));
            this.addAlgorytmToolStripMenuItem.Name = "addAlgorytmToolStripMenuItem";
            this.addAlgorytmToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addAlgorytmToolStripMenuItem.Text = "Добавить алгоритм";
            this.addAlgorytmToolStripMenuItem.Click += new System.EventHandler(this.addAlgorytmToolStripMenuItem_Click);
            // 
            // removeAlgorytmToolStripMenuItem
            // 
            this.removeAlgorytmToolStripMenuItem.Image = global::DirectologControls.Properties.Resources.delete_icon;
            this.removeAlgorytmToolStripMenuItem.Name = "removeAlgorytmToolStripMenuItem";
            this.removeAlgorytmToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.removeAlgorytmToolStripMenuItem.Text = "Удалить алгоритм";
            this.removeAlgorytmToolStripMenuItem.Click += new System.EventHandler(this.removeAlgorytmToolStripMenuItem_Click);
            // 
            // editAlgorytmToolStripMenuItem
            // 
            this.editAlgorytmToolStripMenuItem.Image = global::DirectologControls.Properties.Resources.pencil_icon;
            this.editAlgorytmToolStripMenuItem.Name = "editAlgorytmToolStripMenuItem";
            this.editAlgorytmToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editAlgorytmToolStripMenuItem.Text = "Изменить алгоритм";
            this.editAlgorytmToolStripMenuItem.Click += new System.EventHandler(this.editAlgorytmToolStripMenuItem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::DirectologControls.Properties.Resources.pencil_icon;
            this.btnEdit.Location = new System.Drawing.Point(166, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(20, 20);
            this.btnEdit.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEdit, "Изменить алгоритм");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::DirectologControls.Properties.Resources.delete_icon;
            this.btnDelete.Location = new System.Drawing.Point(147, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnDelete, "Удалить алгоритм");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::DirectologControls.Properties.Resources.add_icon;
            this.btnAdd.Location = new System.Drawing.Point(128, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAdd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAdd, "Добавить алгоритм");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreateAlgos
            // 
            this.btnCreateAlgos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAlgos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAlgos.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAlgos.Image")));
            this.btnCreateAlgos.Location = new System.Drawing.Point(192, 1);
            this.btnCreateAlgos.Name = "btnCreateAlgos";
            this.btnCreateAlgos.Size = new System.Drawing.Size(20, 20);
            this.btnCreateAlgos.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnCreateAlgos, "Создать алгоритмы автоматически");
            this.btnCreateAlgos.UseVisualStyleBackColor = true;
            this.btnCreateAlgos.Click += new System.EventHandler(this.btnCreateAlgos_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(211, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(20, 20);
            this.btnClear.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnClear, "Очистить список алгоритмов");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DHAlgoritms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbAlgorytms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lTitle);
            this.Name = "DHAlgoritms";
            this.Size = new System.Drawing.Size(232, 293);
            this.cmsActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ListBox lbAlgorytms;
        private System.Windows.Forms.ContextMenuStrip cmsActions;
        private System.Windows.Forms.ToolStripMenuItem addAlgorytmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAlgorytmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAlgorytmToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCreateAlgos;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}
