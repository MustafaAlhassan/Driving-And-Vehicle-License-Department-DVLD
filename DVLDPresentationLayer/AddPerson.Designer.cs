namespace DVLDPresentationLayer
{
    partial class AddPerson
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
            this.personControl1 = new DVLDPresentationLayer.PersonControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // personControl1
            // 
            this.personControl1.Location = new System.Drawing.Point(12, 96);
            this.personControl1.Name = "personControl1";
            this.personControl1.Size = new System.Drawing.Size(1010, 483);
            this.personControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(337, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Person";
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personControl1);
            this.Name = "AddPerson";
            this.Text = "AddPerson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PersonControl personControl1;
        private System.Windows.Forms.Label label1;
    }
}