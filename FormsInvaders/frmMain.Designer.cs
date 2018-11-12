namespace FormsInvaders
{
    partial class FormMainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainForm));
            this.playfield = new System.Windows.Forms.Panel();
            this.player = new System.Windows.Forms.PictureBox();
            this.labelShotsLeft = new System.Windows.Forms.Label();
            this.labelFreeYücels = new System.Windows.Forms.Label();
            this.labelDeadYücels = new System.Windows.Forms.Label();
            this.panelWin = new System.Windows.Forms.Panel();
            this.labelWIN = new System.Windows.Forms.Label();
            this.labelWIN2 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelLost = new System.Windows.Forms.Panel();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playfield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelWin.SuspendLayout();
            this.panelLost.SuspendLayout();
            this.SuspendLayout();
            // 
            // playfield
            // 
            this.playfield.Controls.Add(this.panelLost);
            this.playfield.Controls.Add(this.panelWin);
            this.playfield.Controls.Add(this.labelDeadYücels);
            this.playfield.Controls.Add(this.labelFreeYücels);
            this.playfield.Controls.Add(this.labelShotsLeft);
            this.playfield.Controls.Add(this.player);
            this.playfield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playfield.Location = new System.Drawing.Point(0, 0);
            this.playfield.Name = "playfield";
            this.playfield.Size = new System.Drawing.Size(1429, 760);
            this.playfield.TabIndex = 0;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(583, 671);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(149, 77);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // labelShotsLeft
            // 
            this.labelShotsLeft.AutoSize = true;
            this.labelShotsLeft.Location = new System.Drawing.Point(1273, 9);
            this.labelShotsLeft.Name = "labelShotsLeft";
            this.labelShotsLeft.Size = new System.Drawing.Size(68, 17);
            this.labelShotsLeft.TabIndex = 1;
            this.labelShotsLeft.Text = "LeftShots";
            // 
            // labelFreeYücels
            // 
            this.labelFreeYücels.AutoSize = true;
            this.labelFreeYücels.Location = new System.Drawing.Point(1273, 39);
            this.labelFreeYücels.Name = "labelFreeYücels";
            this.labelFreeYücels.Size = new System.Drawing.Size(87, 17);
            this.labelFreeYücels.TabIndex = 2;
            this.labelFreeYücels.Text = "FreedYücels";
            // 
            // labelDeadYücels
            // 
            this.labelDeadYücels.AutoSize = true;
            this.labelDeadYücels.Location = new System.Drawing.Point(1273, 68);
            this.labelDeadYücels.Name = "labelDeadYücels";
            this.labelDeadYücels.Size = new System.Drawing.Size(84, 17);
            this.labelDeadYücels.TabIndex = 3;
            this.labelDeadYücels.Text = "DeadYücels";
            // 
            // panelWin
            // 
            this.panelWin.Controls.Add(this.buttonClose);
            this.panelWin.Controls.Add(this.labelWIN2);
            this.panelWin.Controls.Add(this.labelWIN);
            this.panelWin.Location = new System.Drawing.Point(28, 29);
            this.panelWin.Name = "panelWin";
            this.panelWin.Size = new System.Drawing.Size(1354, 685);
            this.panelWin.TabIndex = 4;
            this.panelWin.Visible = false;
            // 
            // labelWIN
            // 
            this.labelWIN.AutoSize = true;
            this.labelWIN.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWIN.Location = new System.Drawing.Point(217, 70);
            this.labelWIN.Name = "labelWIN";
            this.labelWIN.Size = new System.Drawing.Size(965, 142);
            this.labelWIN.TabIndex = 0;
            this.labelWIN.Text = "YOU HAVE WON!";
            // 
            // labelWIN2
            // 
            this.labelWIN2.AutoSize = true;
            this.labelWIN2.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWIN2.Location = new System.Drawing.Point(19, 224);
            this.labelWIN2.Name = "labelWIN2";
            this.labelWIN2.Size = new System.Drawing.Size(1313, 35);
            this.labelWIN2.TabIndex = 1;
            this.labelWIN2.Text = "You have stopped that evil reporter from showing the truth!";
            // 
            // buttonClose
            // 
            this.buttonClose.AutoSize = true;
            this.buttonClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(464, 544);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(478, 39);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close && inprisonate more Reporter!";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelLost
            // 
            this.panelLost.Controls.Add(this.buttonClose2);
            this.panelLost.Controls.Add(this.label1);
            this.panelLost.Controls.Add(this.label2);
            this.panelLost.Location = new System.Drawing.Point(12, 9);
            this.panelLost.Name = "panelLost";
            this.panelLost.Size = new System.Drawing.Size(1405, 760);
            this.panelLost.TabIndex = 5;
            this.panelLost.Visible = false;
            // 
            // buttonClose2
            // 
            this.buttonClose2.AutoSize = true;
            this.buttonClose2.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose2.Location = new System.Drawing.Point(464, 544);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(478, 39);
            this.buttonClose2.TabIndex = 2;
            this.buttonClose2.Text = "Close && shame on you!";
            this.buttonClose2.UseVisualStyleBackColor = true;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1225, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Now he will bring more truth to the daylight. THATS BAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1381, 142);
            this.label2.TabIndex = 0;
            this.label2.Text = "YOU HAVE LOST Yücel!";
            // 
            // FormMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 760);
            this.Controls.Add(this.playfield);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormsInvaders";
            this.Shown += new System.EventHandler(this.FormMainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMainForm_KeyDown);
            this.playfield.ResumeLayout(false);
            this.playfield.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelWin.ResumeLayout(false);
            this.panelWin.PerformLayout();
            this.panelLost.ResumeLayout(false);
            this.panelLost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playfield;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label labelShotsLeft;
        private System.Windows.Forms.Label labelDeadYücels;
        private System.Windows.Forms.Label labelFreeYücels;
        private System.Windows.Forms.Panel panelWin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelWIN2;
        private System.Windows.Forms.Label labelWIN;
        private System.Windows.Forms.Panel panelLost;
        private System.Windows.Forms.Button buttonClose2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

