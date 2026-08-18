namespace DVLDPresentationLayer
{
    partial class ManagePeopleForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecordsNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetials = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.SendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.PhoneNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(523, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // lblRecordsNumber
            // 
            this.lblRecordsNumber.AutoSize = true;
            this.lblRecordsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsNumber.Location = new System.Drawing.Point(12, 629);
            this.lblRecordsNumber.Name = "lblRecordsNumber";
            this.lblRecordsNumber.Size = new System.Drawing.Size(96, 18);
            this.lblRecordsNumber.TabIndex = 3;
            this.lblRecordsNumber.Text = "# Records: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter By:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(93, 270);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(201, 24);
            this.cmbFilter.TabIndex = 7;
            this.cmbFilter.Text = "None";
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPeople.Location = new System.Drawing.Point(15, 300);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersWidth = 51;
            this.dgvPeople.RowTemplate.Height = 24;
            this.dgvPeople.Size = new System.Drawing.Size(1538, 326);
            this.dgvPeople.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetials,
            this.toolStripMenuItem1,
            this.AddNewPerson,
            this.Edit,
            this.Delete,
            this.toolStripMenuItem2,
            this.SendEmail,
            this.PhoneNumber});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(192, 172);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ShowDetials
            // 
            this.ShowDetials.Image = global::DVLDPresentationLayer.Properties.Resources.Person_details;
            this.ShowDetials.Name = "ShowDetials";
            this.ShowDetials.Size = new System.Drawing.Size(214, 26);
            this.ShowDetials.Text = "Show Detials";
            // 
            // AddNewPerson
            // 
            this.AddNewPerson.Image = global::DVLDPresentationLayer.Properties.Resources.Add_User;
            this.AddNewPerson.Name = "AddNewPerson";
            this.AddNewPerson.Size = new System.Drawing.Size(214, 26);
            this.AddNewPerson.Text = "Add New Person";
            // 
            // Edit
            // 
            this.Edit.Image = global::DVLDPresentationLayer.Properties.Resources.Person_edit;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(214, 26);
            this.Edit.Text = "Edit";
            // 
            // Delete
            // 
            this.Delete.Image = global::DVLDPresentationLayer.Properties.Resources.Person_delete;
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(214, 26);
            this.Delete.Text = "Delete";
            // 
            // SendEmail
            // 
            this.SendEmail.Image = global::DVLDPresentationLayer.Properties.Resources.email;
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.Size = new System.Drawing.Size(214, 26);
            this.SendEmail.Text = "Send Email";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Image = global::DVLDPresentationLayer.Properties.Resources.phone;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(214, 26);
            this.PhoneNumber.Text = "Phone Number";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Image = global::DVLDPresentationLayer.Properties.Resources.Add_User;
            this.btnAddUser.Location = new System.Drawing.Point(1494, 246);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(59, 48);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLDPresentationLayer.Properties.Resources.close;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1445, 632);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 48);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLDPresentationLayer.Properties.Resources.People_Large_Size;
            this.pictureBox1.Location = new System.Drawing.Point(708, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(211, 6);
            // 
            // ManagePeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1565, 692);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRecordsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagePeopleForm";
            this.Text = "Manage People";
            this.Load += new System.EventHandler(this.ManagePeopleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecordsNumber;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowDetials;
        private System.Windows.Forms.ToolStripMenuItem AddNewPerson;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem SendEmail;
        private System.Windows.Forms.ToolStripMenuItem PhoneNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}