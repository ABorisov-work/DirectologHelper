namespace DirectologControls
{
    partial class DHLists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DHLists));
            this.lbLists = new System.Windows.Forms.ListBox();
            this.cmsActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.setListAsMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.btnSetAsMain = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.ttHelp = new System.Windows.Forms.ToolTip(this.components);
            this.cmsActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLists
            // 
            this.lbLists.AllowDrop = true;
            this.lbLists.ContextMenuStrip = this.cmsActions;
            this.lbLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLists.FormattingEnabled = true;
            this.lbLists.Location = new System.Drawing.Point(0, 42);
            this.lbLists.Name = "lbLists";
            this.lbLists.Size = new System.Drawing.Size(226, 253);
            this.lbLists.TabIndex = 0;
            this.lbLists.SelectedIndexChanged += new System.EventHandler(this.lbLists_SelectedIndexChanged);
            this.lbLists.SelectedValueChanged += new System.EventHandler(this.lbLists_SelectedValueChanged);
            this.lbLists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbLists_MouseDown);
            // 
            // cmsActions
            // 
            this.cmsActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addListToolStripMenuItem,
            this.removeListToolStripMenuItem,
            this.toolStripSeparator1,
            this.setListAsMainToolStripMenuItem});
            this.cmsActions.Name = "cmsActions";
            this.cmsActions.Size = new System.Drawing.Size(213, 76);
            // 
            // addListToolStripMenuItem
            // 
            this.addListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addListToolStripMenuItem.Image")));
            this.addListToolStripMenuItem.Name = "addListToolStripMenuItem";
            this.addListToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.addListToolStripMenuItem.Text = "Добавить список";
            this.addListToolStripMenuItem.Click += new System.EventHandler(this.addListToolStripMenuItem_Click);
            // 
            // removeListToolStripMenuItem
            // 
            this.removeListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeListToolStripMenuItem.Image")));
            this.removeListToolStripMenuItem.Name = "removeListToolStripMenuItem";
            this.removeListToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.removeListToolStripMenuItem.Text = "Удалить список";
            this.removeListToolStripMenuItem.Click += new System.EventHandler(this.removeListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // setListAsMainToolStripMenuItem
            // 
            this.setListAsMainToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setListAsMainToolStripMenuItem.Image")));
            this.setListAsMainToolStripMenuItem.Name = "setListAsMainToolStripMenuItem";
            this.setListAsMainToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.setListAsMainToolStripMenuItem.Text = "Сделать список главным";
            this.setListAsMainToolStripMenuItem.Click += new System.EventHandler(this.setListAsMainToolStripMenuItem_Click);
            // 
            // lTitle
            // 
            this.lTitle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lTitle.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lTitle.Location = new System.Drawing.Point(0, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(226, 20);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Списки";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddList);
            this.panel1.Controls.Add(this.btnRemoveList);
            this.panel1.Controls.Add(this.btnSetAsMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 22);
            this.panel1.TabIndex = 6;
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveList.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveList.Image")));
            this.btnRemoveList.Location = new System.Drawing.Point(186, 1);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(20, 20);
            this.btnRemoveList.TabIndex = 1;
            this.ttHelp.SetToolTip(this.btnRemoveList, "Удалить список");
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // btnSetAsMain
            // 
            this.btnSetAsMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetAsMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetAsMain.Image = ((System.Drawing.Image)(resources.GetObject("btnSetAsMain.Image")));
            this.btnSetAsMain.Location = new System.Drawing.Point(205, 1);
            this.btnSetAsMain.Name = "btnSetAsMain";
            this.btnSetAsMain.Size = new System.Drawing.Size(20, 20);
            this.btnSetAsMain.TabIndex = 0;
            this.ttHelp.SetToolTip(this.btnSetAsMain, "Сделать список главным");
            this.btnSetAsMain.UseVisualStyleBackColor = true;
            this.btnSetAsMain.Click += new System.EventHandler(this.btnSetAsMain_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.Image = ((System.Drawing.Image)(resources.GetObject("btnAddList.Image")));
            this.btnAddList.Location = new System.Drawing.Point(167, 1);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(20, 20);
            this.btnAddList.TabIndex = 2;
            this.ttHelp.SetToolTip(this.btnAddList, "Добавить список");
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // ttHelp
            // 
            this.ttHelp.AutomaticDelay = 200;
            this.ttHelp.AutoPopDelay = 1000;
            this.ttHelp.InitialDelay = 200;
            this.ttHelp.ReshowDelay = 40;
            // 
            // DHLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLists);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lTitle);
            this.Name = "DHLists";
            this.Size = new System.Drawing.Size(226, 295);
            this.cmsActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLists;
        private System.Windows.Forms.ContextMenuStrip cmsActions;
        private System.Windows.Forms.ToolStripMenuItem addListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem setListAsMainToolStripMenuItem;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ToolTip ttHelp;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.Button btnSetAsMain;
    }
}
