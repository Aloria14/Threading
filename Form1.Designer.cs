namespace Threading
{
    partial class FrmBasicThread
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
            lblStatusOfThread = new Label();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblStatusOfThread
            // 
            lblStatusOfThread.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblStatusOfThread.AutoSize = true;
            lblStatusOfThread.Font = new Font("Arial Black", 14F, FontStyle.Bold);
            lblStatusOfThread.Location = new Point(47, 36);
            lblStatusOfThread.Name = "lblStatusOfThread";
            lblStatusOfThread.Size = new Size(264, 27);
            lblStatusOfThread.TabIndex = 0;
            lblStatusOfThread.Text = "-Before Starting Thread-";
            lblStatusOfThread.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top;
            btnStart.BackColor = SystemColors.ButtonHighlight;
            btnStart.FlatStyle = FlatStyle.System;
            btnStart.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(119, 127);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(103, 31);
            btnStart.TabIndex = 1;
            btnStart.Text = "Run";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(334, 211);
            Controls.Add(btnStart);
            Controls.Add(lblStatusOfThread);
            Name = "FrmBasicThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatusOfThread;
        private Button btnStart;
    }
}
