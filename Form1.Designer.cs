namespace mp3_converter {
    partial class Form1 {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDownload = new System.Windows.Forms.Button();
            this.tUrl = new System.Windows.Forms.TextBox();
            this.lblCountSong = new System.Windows.Forms.Label();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.tDirectory = new System.Windows.Forms.TextBox();
            this.btnSetDirectory = new System.Windows.Forms.Button();
            this.lblTimeElapse = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(404, 301);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(167, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Scarica";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tUrl
            // 
            this.tUrl.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUrl.Location = new System.Drawing.Point(12, 41);
            this.tUrl.Multiline = true;
            this.tUrl.Name = "tUrl";
            this.tUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tUrl.Size = new System.Drawing.Size(559, 254);
            this.tUrl.TabIndex = 3;
            this.tUrl.Text = "ES LINK:\r\nhttps://www.youtube.com/watch?v=TEST\r\nhttps://www.youtube.com/watch?v=T" +
    "EST\r\nhttps://www.youtube.com/watch?v=TEST\r\nhttps://www.youtube.com/watch?v=TEST";
            this.tUrl.Click += new System.EventHandler(this.tUrl_Click);
            // 
            // lblCountSong
            // 
            this.lblCountSong.AutoSize = true;
            this.lblCountSong.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSong.Location = new System.Drawing.Point(12, 306);
            this.lblCountSong.Name = "lblCountSong";
            this.lblCountSong.Size = new System.Drawing.Size(31, 16);
            this.lblCountSong.TabIndex = 4;
            this.lblCountSong.Text = "---";
            // 
            // pbProgress
            // 
            this.pbProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbProgress.Location = new System.Drawing.Point(436, 301);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(135, 21);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbProgress.TabIndex = 5;
            this.pbProgress.Visible = false;
            // 
            // tDirectory
            // 
            this.tDirectory.Font = new System.Drawing.Font("Courier New", 8.75F);
            this.tDirectory.Location = new System.Drawing.Point(152, 13);
            this.tDirectory.Name = "tDirectory";
            this.tDirectory.ReadOnly = true;
            this.tDirectory.Size = new System.Drawing.Size(379, 21);
            this.tDirectory.TabIndex = 6;
            // 
            // btnSetDirectory
            // 
            this.btnSetDirectory.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDirectory.Location = new System.Drawing.Point(12, 12);
            this.btnSetDirectory.Name = "btnSetDirectory";
            this.btnSetDirectory.Size = new System.Drawing.Size(134, 23);
            this.btnSetDirectory.TabIndex = 7;
            this.btnSetDirectory.Text = "Path";
            this.btnSetDirectory.UseVisualStyleBackColor = true;
            this.btnSetDirectory.Click += new System.EventHandler(this.btnSetDirectory_Click);
            // 
            // lblTimeElapse
            // 
            this.lblTimeElapse.AutoSize = true;
            this.lblTimeElapse.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapse.Location = new System.Drawing.Point(193, 306);
            this.lblTimeElapse.Name = "lblTimeElapse";
            this.lblTimeElapse.Size = new System.Drawing.Size(31, 16);
            this.lblTimeElapse.TabIndex = 8;
            this.lblTimeElapse.Text = "---";
            // 
            // btnHelp
            // 
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(537, 6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(34, 34);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 328);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTimeElapse);
            this.Controls.Add(this.btnSetDirectory);
            this.Controls.Add(this.tDirectory);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.lblCountSong);
            this.Controls.Add(this.tUrl);
            this.Controls.Add(this.btnDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube MP3 Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tUrl;
        private System.Windows.Forms.Label lblCountSong;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.TextBox tDirectory;
        private System.Windows.Forms.Button btnSetDirectory;
        private System.Windows.Forms.Label lblTimeElapse;
        private System.Windows.Forms.Button btnHelp;
    }
}

