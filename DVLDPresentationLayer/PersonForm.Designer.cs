namespace DVLDPresentationLayer
{
    partial class PersonForm
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
            this.SuspendLayout();
            // 
            // personControl1
            // 
            this.personControl1.Location = new System.Drawing.Point(3, 1);
            this.personControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.personControl1.Name = "personControl1";
            this.personControl1.Size = new System.Drawing.Size(1082, 656);
            this.personControl1.TabIndex = 0;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 660);
            this.Controls.Add(this.personControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Edit Person Info";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonControl personControl1;
    }
}