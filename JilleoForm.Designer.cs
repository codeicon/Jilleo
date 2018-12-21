namespace Jilleo
{
    partial class JilleoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JilleoForm));
            this.openButton = new System.Windows.Forms.Button();
            this.openVideoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.spaceButton = new System.Windows.Forms.Button();
            this.saveLogFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.openButton.Location = new System.Drawing.Point(12, 334);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(120, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open Video File";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // spaceButton
            // 
            this.spaceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceButton.Location = new System.Drawing.Point(160, 334);
            this.spaceButton.Name = "spaceButton";
            this.spaceButton.Size = new System.Drawing.Size(420, 23);
            this.spaceButton.TabIndex = 2;
            this.spaceButton.Text = "To record events, hold/release this button while the video is playing.";
            this.spaceButton.UseVisualStyleBackColor = true;
            this.spaceButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.spaceButton_MouseDown);
            this.spaceButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.spaceButton_MouseUp);
            // 
            // saveLogFileDialog
            // 
            this.saveLogFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // videoPlayer
            // 
            this.videoPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(12, 12);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(568, 316);
            this.videoPlayer.TabIndex = 0;
            this.videoPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.videoPlayer_PlayStateChange);
            // 
            // JilleoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.spaceButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.videoPlayer);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "JilleoForm";
            this.Text = "Event Recorder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JilleoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.OpenFileDialog openVideoFileDialog;
        private System.Windows.Forms.Button spaceButton;
        private System.Windows.Forms.SaveFileDialog saveLogFileDialog;
    }
}

