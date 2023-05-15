namespace ExamSimProject.Forms
{
    partial class Dashboard
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
            mainPanel = new Main();
            hoverPanel = new Panel();
            sideMenu = new SideMenuPanel();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(128, 192, 255, 255);
            mainPanel.Location = new Point(35, 23);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(729, 406);
            mainPanel.TabIndex = 0;
            // 
            // hoverPanel
            // 
            hoverPanel.BackColor = Color.Transparent;
            hoverPanel.Location = new Point(1, 1);
            hoverPanel.Name = "hoverPanel";
            hoverPanel.Size = new Size(37, 448);
            hoverPanel.TabIndex = 2;
            hoverPanel.MouseHover += hoverPanel_MouseHover;
            // 
            // sideMenu
            // 
            sideMenu.BackColor = Color.FromArgb(6, 28, 48);
            sideMenu.Location = new Point(0, -4);
            sideMenu.Name = "sideMenu";
            sideMenu.Size = new Size(233, 454);
            sideMenu.TabIndex = 3;
            sideMenu.MouseLeave += sideMenu_MouseLeave;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DashboardBgImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(hoverPanel);
            Controls.Add(mainPanel);
            Controls.Add(sideMenu);
            DoubleBuffered = true;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
        }

        #endregion

        private Main mainPanel;
        private Panel hoverPanel;
        private SideMenuPanel sideMenu;
    }
}