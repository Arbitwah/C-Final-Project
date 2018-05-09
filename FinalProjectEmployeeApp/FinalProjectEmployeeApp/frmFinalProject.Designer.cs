namespace FinalProjectEmployeeApp
{
    partial class frmFinalProject
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
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.txtBxEmpType = new System.Windows.Forms.TextBox();
            this.txtBxSalary = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBxEmpolyee = new System.Windows.Forms.ListBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmpType = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAddNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lstBxEdit = new System.Windows.Forms.ListBox();
            this.txtBxEditLName = new System.Windows.Forms.TextBox();
            this.txtBxEditFName = new System.Windows.Forms.TextBox();
            this.txtBxEditEmpType = new System.Windows.Forms.TextBox();
            this.txtBxEditSalary = new System.Windows.Forms.TextBox();
            this.lblEditLN = new System.Windows.Forms.Label();
            this.lblEditFN = new System.Windows.Forms.Label();
            this.lblEditType = new System.Windows.Forms.Label();
            this.lblEditSal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(173, 79);
            this.txtBxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(234, 27);
            this.txtBxLastName.TabIndex = 1;
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(173, 120);
            this.txtBxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(234, 27);
            this.txtBxFirstName.TabIndex = 2;
            // 
            // txtBxEmpType
            // 
            this.txtBxEmpType.Location = new System.Drawing.Point(173, 161);
            this.txtBxEmpType.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxEmpType.Name = "txtBxEmpType";
            this.txtBxEmpType.Size = new System.Drawing.Size(234, 27);
            this.txtBxEmpType.TabIndex = 3;
            // 
            // txtBxSalary
            // 
            this.txtBxSalary.Location = new System.Drawing.Point(173, 206);
            this.txtBxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxSalary.Name = "txtBxSalary";
            this.txtBxSalary.Size = new System.Drawing.Size(234, 27);
            this.txtBxSalary.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(374, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBxEmpolyee
            // 
            this.lstBxEmpolyee.FormattingEnabled = true;
            this.lstBxEmpolyee.ItemHeight = 19;
            this.lstBxEmpolyee.Location = new System.Drawing.Point(534, 52);
            this.lstBxEmpolyee.Name = "lstBxEmpolyee";
            this.lstBxEmpolyee.Size = new System.Drawing.Size(611, 232);
            this.lstBxEmpolyee.TabIndex = 8;
            this.lstBxEmpolyee.SelectedIndexChanged += new System.EventHandler(this.lstBxEmpolyee_SelectedIndexChanged);
            this.lstBxEmpolyee.DoubleClick += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(5, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 19);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "LastName:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(5, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmpType
            // 
            this.lblEmpType.AutoSize = true;
            this.lblEmpType.Location = new System.Drawing.Point(5, 161);
            this.lblEmpType.Name = "lblEmpType";
            this.lblEmpType.Size = new System.Drawing.Size(143, 19);
            this.lblEmpType.TabIndex = 7;
            this.lblEmpType.Text = "Type of Employee:";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(5, 206);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(58, 19);
            this.lblSalary.TabIndex = 7;
            this.lblSalary.Text = "Salary:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tlsEdit,
            this.tlsHelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsOpen,
            this.tlsSave,
            this.tlsSaveAs});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // tlsOpen
            // 
            this.tlsOpen.Name = "tlsOpen";
            this.tlsOpen.Size = new System.Drawing.Size(114, 22);
            this.tlsOpen.Text = "Open";
            this.tlsOpen.Click += new System.EventHandler(this.tlsOpen_Click);
            // 
            // tlsSave
            // 
            this.tlsSave.Name = "tlsSave";
            this.tlsSave.Size = new System.Drawing.Size(114, 22);
            this.tlsSave.Text = "Save";
            this.tlsSave.Click += new System.EventHandler(this.tlsSave_Click);
            // 
            // tlsSaveAs
            // 
            this.tlsSaveAs.Name = "tlsSaveAs";
            this.tlsSaveAs.Size = new System.Drawing.Size(114, 22);
            this.tlsSaveAs.Text = "Save As";
            this.tlsSaveAs.Click += new System.EventHandler(this.tlsSaveAs_Click);
            // 
            // tlsEdit
            // 
            this.tlsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAddNew,
            this.tlsProperties,
            this.tlsDelete,
            this.deleteAllToolStripMenuItem});
            this.tlsEdit.Name = "tlsEdit";
            this.tlsEdit.Size = new System.Drawing.Size(39, 20);
            this.tlsEdit.Text = "Edit";
            // 
            // tlsAddNew
            // 
            this.tlsAddNew.Name = "tlsAddNew";
            this.tlsAddNew.Size = new System.Drawing.Size(199, 22);
            this.tlsAddNew.Text = "Add New";
            this.tlsAddNew.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tlsProperties
            // 
            this.tlsProperties.Name = "tlsProperties";
            this.tlsProperties.Size = new System.Drawing.Size(199, 22);
            this.tlsProperties.Text = "Properties";
            this.tlsProperties.Click += new System.EventHandler(this.tlsProperties_Click);
            // 
            // tlsDelete
            // 
            this.tlsDelete.Name = "tlsDelete";
            this.tlsDelete.Size = new System.Drawing.Size(199, 22);
            this.tlsDelete.Text = "Delete";
            this.tlsDelete.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All Related Fields";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tlsHelpMenu
            // 
            this.tlsHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAbout});
            this.tlsHelpMenu.Name = "tlsHelpMenu";
            this.tlsHelpMenu.Size = new System.Drawing.Size(78, 20);
            this.tlsHelpMenu.Text = "Help Menu";
            // 
            // tlsAbout
            // 
            this.tlsAbout.Name = "tlsAbout";
            this.tlsAbout.Size = new System.Drawing.Size(152, 22);
            this.tlsAbout.Text = "About";
            this.tlsAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton7,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1158, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lstBxEdit
            // 
            this.lstBxEdit.FormattingEnabled = true;
            this.lstBxEdit.ItemHeight = 19;
            this.lstBxEdit.Location = new System.Drawing.Point(534, 424);
            this.lstBxEdit.Name = "lstBxEdit";
            this.lstBxEdit.Size = new System.Drawing.Size(611, 23);
            this.lstBxEdit.TabIndex = 15;
            this.lstBxEdit.Visible = false;
            // 
            // txtBxEditLName
            // 
            this.txtBxEditLName.Location = new System.Drawing.Point(12, 424);
            this.txtBxEditLName.Name = "txtBxEditLName";
            this.txtBxEditLName.Size = new System.Drawing.Size(200, 27);
            this.txtBxEditLName.TabIndex = 11;
            this.txtBxEditLName.Visible = false;
            // 
            // txtBxEditFName
            // 
            this.txtBxEditFName.Location = new System.Drawing.Point(259, 424);
            this.txtBxEditFName.Name = "txtBxEditFName";
            this.txtBxEditFName.Size = new System.Drawing.Size(200, 27);
            this.txtBxEditFName.TabIndex = 12;
            this.txtBxEditFName.Visible = false;
            // 
            // txtBxEditEmpType
            // 
            this.txtBxEditEmpType.Location = new System.Drawing.Point(12, 512);
            this.txtBxEditEmpType.Name = "txtBxEditEmpType";
            this.txtBxEditEmpType.Size = new System.Drawing.Size(200, 27);
            this.txtBxEditEmpType.TabIndex = 13;
            this.txtBxEditEmpType.Visible = false;
            // 
            // txtBxEditSalary
            // 
            this.txtBxEditSalary.Location = new System.Drawing.Point(259, 512);
            this.txtBxEditSalary.Name = "txtBxEditSalary";
            this.txtBxEditSalary.Size = new System.Drawing.Size(200, 27);
            this.txtBxEditSalary.TabIndex = 14;
            this.txtBxEditSalary.Visible = false;
            // 
            // lblEditLN
            // 
            this.lblEditLN.AutoSize = true;
            this.lblEditLN.Location = new System.Drawing.Point(12, 402);
            this.lblEditLN.Name = "lblEditLN";
            this.lblEditLN.Size = new System.Drawing.Size(84, 19);
            this.lblEditLN.TabIndex = 12;
            this.lblEditLN.Text = "LastName:";
            this.lblEditLN.Visible = false;
            // 
            // lblEditFN
            // 
            this.lblEditFN.AutoSize = true;
            this.lblEditFN.Location = new System.Drawing.Point(255, 402);
            this.lblEditFN.Name = "lblEditFN";
            this.lblEditFN.Size = new System.Drawing.Size(91, 19);
            this.lblEditFN.TabIndex = 13;
            this.lblEditFN.Text = "First Name:";
            this.lblEditFN.Visible = false;
            // 
            // lblEditType
            // 
            this.lblEditType.AutoSize = true;
            this.lblEditType.Location = new System.Drawing.Point(12, 490);
            this.lblEditType.Name = "lblEditType";
            this.lblEditType.Size = new System.Drawing.Size(143, 19);
            this.lblEditType.TabIndex = 14;
            this.lblEditType.Text = "Type of Employee:";
            this.lblEditType.Visible = false;
            // 
            // lblEditSal
            // 
            this.lblEditSal.AutoSize = true;
            this.lblEditSal.Location = new System.Drawing.Point(255, 490);
            this.lblEditSal.Name = "lblEditSal";
            this.lblEditSal.Size = new System.Drawing.Size(58, 19);
            this.lblEditSal.TabIndex = 15;
            this.lblEditSal.Text = "Salary:";
            this.lblEditSal.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 595);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 19);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // btnCommit
            // 
            this.btnCommit.Enabled = false;
            this.btnCommit.Location = new System.Drawing.Point(534, 500);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(133, 39);
            this.btnCommit.TabIndex = 16;
            this.btnCommit.Text = "Commit Edit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Visible = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(218, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 39);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete All Related";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Enabled = false;
            this.btnDeleteSelected.Location = new System.Drawing.Point(966, 290);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(179, 39);
            this.btnDeleteSelected.TabIndex = 10;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Enabled = false;
            this.btnEditSelected.Location = new System.Drawing.Point(534, 290);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(179, 39);
            this.btnEditSelected.TabIndex = 9;
            this.btnEditSelected.Text = "Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|all files(*.*)|*.*";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(704, 500);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(133, 39);
            this.btnCancelEdit.TabIndex = 17;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::FinalProjectEmployeeApp.Properties.Resources.OpenFile_16x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Open File";
            this.toolStripButton1.Click += new System.EventHandler(this.tlsOpen_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::FinalProjectEmployeeApp.Properties.Resources.Save_16x;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.tlsSave_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::FinalProjectEmployeeApp.Properties.Resources.SaveAs_16x;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Save As";
            this.toolStripButton3.Click += new System.EventHandler(this.tlsSaveAs_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::FinalProjectEmployeeApp.Properties.Resources.AddRow_16x;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Add";
            this.toolStripButton4.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::FinalProjectEmployeeApp.Properties.Resources.DeleteCell_16x_32;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Delete All";
            this.toolStripButton7.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::FinalProjectEmployeeApp.Properties.Resources.RemoveRow_16x;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Delete Selected";
            this.toolStripButton5.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::FinalProjectEmployeeApp.Properties.Resources.Property_16x;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Edit Properties";
            this.toolStripButton6.Click += new System.EventHandler(this.tlsProperties_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::FinalProjectEmployeeApp.Properties.Resources.Help_24x24;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "About This Program";
            this.toolStripButton8.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmFinalProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 927);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEditSal);
            this.Controls.Add(this.lblEditType);
            this.Controls.Add(this.lblEditFN);
            this.Controls.Add(this.lblEditLN);
            this.Controls.Add(this.txtBxEditSalary);
            this.Controls.Add(this.txtBxEditFName);
            this.Controls.Add(this.txtBxEditEmpType);
            this.Controls.Add(this.txtBxEditLName);
            this.Controls.Add(this.lstBxEdit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmpType);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lstBxEmpolyee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBxSalary);
            this.Controls.Add(this.txtBxEmpType);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFinalProject";
            this.Text = "Employee\'s Form";
            this.Load += new System.EventHandler(this.frmFinalProject_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.TextBox txtBxEmpType;
        private System.Windows.Forms.TextBox txtBxSalary;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstBxEmpolyee;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmpType;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlsOpen;
        private System.Windows.Forms.ToolStripMenuItem tlsSave;
        private System.Windows.Forms.ToolStripMenuItem tlsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tlsEdit;
        private System.Windows.Forms.ToolStripMenuItem tlsAddNew;
        private System.Windows.Forms.ToolStripMenuItem tlsProperties;
        private System.Windows.Forms.ToolStripMenuItem tlsDelete;
        private System.Windows.Forms.ToolStripMenuItem tlsHelpMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ListBox lstBxEdit;
        private System.Windows.Forms.TextBox txtBxEditLName;
        private System.Windows.Forms.TextBox txtBxEditFName;
        private System.Windows.Forms.TextBox txtBxEditEmpType;
        private System.Windows.Forms.TextBox txtBxEditSalary;
        private System.Windows.Forms.Label lblEditLN;
        private System.Windows.Forms.Label lblEditFN;
        private System.Windows.Forms.Label lblEditType;
        private System.Windows.Forms.Label lblEditSal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.ToolStripMenuItem tlsAbout;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
    }
}

