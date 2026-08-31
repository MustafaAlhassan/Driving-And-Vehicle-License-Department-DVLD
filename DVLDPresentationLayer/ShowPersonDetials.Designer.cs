namespace DVLDPresentationLayer
{
    partial class ShowPersonDetials
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
            this.personInformationCard1 = new DVLDPresentationLayer.PersonInformationCard();
            this.personInfomationCard1 = new DVLDPresentationLayer.PersonInformationCard();
            this.SuspendLayout();
            // 
            // personInformationCard1
            // 
            this.personInformationCard1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.personInformationCard1.Location = new System.Drawing.Point(1, -1);
            this.personInformationCard1.Name = "personInformationCard1";
            this.personInformationCard1.Size = new System.Drawing.Size(940, 536);
            this.personInformationCard1.TabIndex = 0;
            // 
            // personInfomationCard1
            // 
            this.personInfomationCard1.Location = new System.Drawing.Point(0, -3);
            this.personInfomationCard1.Name = "personInfomationCard1";
            this.personInfomationCard1.Size = new System.Drawing.Size(940, 536);
            this.personInfomationCard1.TabIndex = 0;
            // 
            // ShowPersonDetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 530);
            this.Controls.Add(this.personInformationCard1);
            this.Name = "ShowPersonDetials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPersonDetials";
            this.ResumeLayout(false);

        }

        #endregion

        private PersonInformationCard personInfomationCard1;
        private PersonInformationCard personInformationCard1;
    }
}