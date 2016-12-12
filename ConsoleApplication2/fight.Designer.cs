namespace ConsoleApplication2
{
    partial class fightFrame
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
            this.playerPicture = new System.Windows.Forms.PictureBox();
            this.enemyPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerPicture
            // 
            this.playerPicture.Location = new System.Drawing.Point(12, 80);
            this.playerPicture.Name = "playerPicture";
            this.playerPicture.Size = new System.Drawing.Size(200, 200);
            this.playerPicture.TabIndex = 0;
            this.playerPicture.TabStop = false;
            // 
            // enemyPicture
            // 
            this.enemyPicture.Location = new System.Drawing.Point(457, 12);
            this.enemyPicture.Name = "enemyPicture";
            this.enemyPicture.Size = new System.Drawing.Size(200, 200);
            this.enemyPicture.TabIndex = 1;
            this.enemyPicture.TabStop = false;
            // 
            // fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(669, 292);
            this.Controls.Add(this.enemyPicture);
            this.Controls.Add(this.playerPicture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 331);
            this.MinimumSize = new System.Drawing.Size(685, 331);
            this.Name = "fight";
            this.ShowInTaskbar = false;
            this.Text = "fight";
            ((System.ComponentModel.ISupportInitialize)(this.playerPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPicture;
        private System.Windows.Forms.PictureBox enemyPicture;
    }
}