namespace ExamSimProject.Forms
{
    partial class coursePanel
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
            iconPic = new PictureBox();
            bestProgress = new Label();
            bestTime = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPic).BeginInit();
            SuspendLayout();
            // 
            // iconPic
            // 
            iconPic.Location = new Point(50, 18);
            iconPic.Name = "iconPic";
            iconPic.Size = new Size(75, 75);
            iconPic.TabIndex = 0;
            iconPic.TabStop = false;
            // 
            // bestProgress
            // 
            bestProgress.BackColor = Color.Transparent;
            bestProgress.Location = new Point(0, 105);
            bestProgress.Name = "bestProgress";
            bestProgress.Size = new Size(175, 15);
            bestProgress.TabIndex = 1;
            bestProgress.Text = "label1";
            bestProgress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bestTime
            // 
            bestTime.BackColor = Color.Transparent;
            bestTime.Location = new Point(0, 132);
            bestTime.Name = "bestTime";
            bestTime.Size = new Size(175, 15);
            bestTime.TabIndex = 1;
            bestTime.Text = "label1";
            bestTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // coursePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 255, 255, 255);
            Controls.Add(bestTime);
            Controls.Add(bestProgress);
            Controls.Add(iconPic);
            Name = "coursePanel";
            Size = new Size(175, 175);
            ((System.ComponentModel.ISupportInitialize)iconPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox iconPic;
        private Label bestProgress;
        private Label bestTime;

        public Label BestProgress { get => bestProgress; set => bestProgress = value; }
        public Label BestTime { get => bestTime; set => bestTime = value; }
    }
}
