namespace Xiangqi
{
    partial class MatchGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testRestart = new Button();
            SuspendLayout();
            // 
            // testRestart
            // 
            testRestart.Location = new Point(766, 31);
            testRestart.Name = "testRestart";
            testRestart.Size = new Size(112, 100);
            testRestart.TabIndex = 0;
            testRestart.Text = "testRestart";
            testRestart.UseVisualStyleBackColor = true;
            testRestart.Click += testRestart_Click;
            // 
            // MatchGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 616);
            Controls.Add(testRestart);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MatchGame";
            Text = "Game";
            Paint += MatchGame_Paint;
            ResumeLayout(false);
        }

        #endregion

        private Button testRestart;
    }
}
