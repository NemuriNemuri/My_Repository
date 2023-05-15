using ExamSimProject.General;

namespace ExamSimProject.Forms
{
    partial class SideMenuPanel
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
            nameLabel = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.Font = new Font("Lucida Fax", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = SystemColors.ControlLight;
            nameLabel.Location = new Point(31, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(167, 57);
            nameLabel.TabIndex = 0;
            nameLabel.Text = User.FirstName + " " + User.LastName;
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.ControlLight;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = SystemColors.ControlLight;
            linkLabel1.Location = new Point(44, 179);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(94, 18);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "My Profile";
            linkLabel1.VisitedLinkColor = SystemColors.ControlLight;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = SystemColors.ControlLight;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = SystemColors.ControlLight;
            linkLabel2.Location = new Point(44, 227);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(108, 18);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Certificates";
            linkLabel2.VisitedLinkColor = SystemColors.ControlLight;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = SystemColors.ControlLight;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel3.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel3.LinkColor = SystemColors.ControlLight;
            linkLabel3.Location = new Point(44, 268);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(77, 18);
            linkLabel3.TabIndex = 1;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Courses";
            linkLabel3.VisitedLinkColor = SystemColors.ControlLight;
            // 
            // SideMenuPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 28, 48);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(nameLabel);
            Name = "SideMenuPanel";
            Size = new Size(233, 454);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
    }
}
