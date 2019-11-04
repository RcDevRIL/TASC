namespace StupidBot.Views
{
    /// <author>
    ///     The Amazing Stupid Company, Inc.
    /// </author>
    partial class ContributionForm
    {
        private System.ComponentModel.IContainer components = null;
        
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelReponse = new System.Windows.Forms.Label();
            this.buttonValid = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxReponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout Question/Réponse";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(31, 100);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(49, 13);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelReponse
            // 
            this.labelReponse.AutoSize = true;
            this.labelReponse.Location = new System.Drawing.Point(31, 165);
            this.labelReponse.Name = "labelReponse";
            this.labelReponse.Size = new System.Drawing.Size(50, 13);
            this.labelReponse.TabIndex = 2;
            this.labelReponse.Text = "Réponse";
            // 
            // buttonValid
            // 
            this.buttonValid.Location = new System.Drawing.Point(269, 296);
            this.buttonValid.Name = "buttonValid";
            this.buttonValid.Size = new System.Drawing.Size(75, 23);
            this.buttonValid.TabIndex = 3;
            this.buttonValid.Text = "Valider";
            this.buttonValid.UseVisualStyleBackColor = true;
            this.buttonValid.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(24, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Quitter";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(34, 116);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuestion.TabIndex = 5;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxReponse
            // 
            this.textBoxReponse.Location = new System.Drawing.Point(34, 181);
            this.textBoxReponse.Name = "textBoxReponse";
            this.textBoxReponse.Size = new System.Drawing.Size(100, 20);
            this.textBoxReponse.TabIndex = 6;
            // 
            // ContributionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 331);
            this.Controls.Add(this.textBoxReponse);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonValid);
            this.Controls.Add(this.labelReponse);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.label1);
            this.Name = "ContributionForm";
            this.Text = "ContributionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelReponse;
        private System.Windows.Forms.Button buttonValid;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxReponse;
    }
}