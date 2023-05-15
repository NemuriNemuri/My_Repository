namespace ExamSimProject.Forms
{

    partial class Main
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
            greetingLabel = new Label();
            coursesPanel = new Panel();
            coursesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.BackColor = Color.Transparent;
            greetingLabel.Font = new Font("Georgia", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            greetingLabel.ForeColor = Color.Black;
            greetingLabel.Location = new Point(28, 30);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(88, 34);
            greetingLabel.TabIndex = 0;
            greetingLabel.Text = "label1";
            // 
            // coursesPanel
            // 
            coursesPanel.AutoScroll = true;
            coursesPanel.BackColor = Color.Transparent;
            coursesPanel.BorderStyle = BorderStyle.FixedSingle;
            coursesPanel.Location = new Point(28, 76);
            coursesPanel.Name = "coursesPanel";
            coursesPanel.Size = new Size(667, 301);
            coursesPanel.TabIndex = 1;
            coursesPanel.Paint += coursesPanel_Paint;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 192, 255, 255);
            Controls.Add(coursesPanel);
            Controls.Add(greetingLabel);
            Name = "Main";
            Size = new Size(729, 406);
            Load += Main_Load;
            coursesPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetingLabel;
        private Panel coursesPanel;
    }
}
