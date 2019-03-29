namespace StupidBot
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAdmin = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnContribution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdmin.FlatAppearance.BorderSize = 0;
            this.BtnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.Location = new System.Drawing.Point(110, 36);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(23, 23);
            this.BtnAdmin.TabIndex = 0;
            this.BtnAdmin.UseVisualStyleBackColor = false;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(9, 136);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(124, 45);
            this.btnChat.TabIndex = 1;
            this.btnChat.Text = "Parler avec StupidBot";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnContribution
            // 
            this.btnContribution.Location = new System.Drawing.Point(9, 187);
            this.btnContribution.Name = "btnContribution";
            this.btnContribution.Size = new System.Drawing.Size(124, 45);
            this.btnContribution.TabIndex = 2;
            this.btnContribution.Text = "Apprener à StupidBot";
            this.btnContribution.UseVisualStyleBackColor = true;
            this.btnContribution.Click += new System.EventHandler(this.btnContribution_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StupidBot.Properties.Resources.TASC_LOGO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.btnContribution);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.BtnAdmin);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdmin;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnContribution;
    }
}

