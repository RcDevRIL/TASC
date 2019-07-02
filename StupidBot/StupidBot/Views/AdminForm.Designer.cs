namespace StupidBot.Views
{
    partial class AdminForm
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
            this.listBoxCorrespondance = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteThis = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCorrespondance
            // 
            this.listBoxCorrespondance.FormattingEnabled = true;
            this.listBoxCorrespondance.Location = new System.Drawing.Point(12, 43);
            this.listBoxCorrespondance.Name = "listBoxCorrespondance";
            this.listBoxCorrespondance.Size = new System.Drawing.Size(328, 368);
            this.listBoxCorrespondance.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteThis
            // 
            this.btnDeleteThis.Location = new System.Drawing.Point(12, 415);
            this.btnDeleteThis.Name = "btnDeleteThis";
            this.btnDeleteThis.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteThis.TabIndex = 2;
            this.btnDeleteThis.Text = "Supprimer sélection";
            this.btnDeleteThis.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(265, 415);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Tout effacer";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteThis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBoxCorrespondance);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCorrespondance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteThis;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}