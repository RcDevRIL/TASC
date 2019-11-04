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
            this.AddQandA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCorrespondance
            // 
            this.listBoxCorrespondance.FormattingEnabled = true;
            this.listBoxCorrespondance.ItemHeight = 16;
            this.listBoxCorrespondance.Location = new System.Drawing.Point(16, 53);
            this.listBoxCorrespondance.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCorrespondance.Name = "listBoxCorrespondance";
            this.listBoxCorrespondance.Size = new System.Drawing.Size(392, 452);
            this.listBoxCorrespondance.TabIndex = 0;
            this.listBoxCorrespondance.SelectedIndexChanged += new System.EventHandler(this.listBoxCorrespondance_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(17, 16);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Quitter";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteThis
            // 
            this.btnDeleteThis.Location = new System.Drawing.Point(16, 511);
            this.btnDeleteThis.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteThis.Name = "btnDeleteThis";
            this.btnDeleteThis.Size = new System.Drawing.Size(163, 28);
            this.btnDeleteThis.TabIndex = 2;
            this.btnDeleteThis.Text = "Supprimer sélection";
            this.btnDeleteThis.UseVisualStyleBackColor = true;
            this.btnDeleteThis.Click += new System.EventHandler(this.btnDeleteThis_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(308, 511);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteAll.TabIndex = 3;
            this.btnDeleteAll.Text = "Tout effacer";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            // 
            // AddQandA
            // 
            this.AddQandA.Location = new System.Drawing.Point(414, 86);
            this.AddQandA.Name = "AddQandA";
            this.AddQandA.Size = new System.Drawing.Size(65, 40);
            this.AddQandA.TabIndex = 4;
            this.AddQandA.Text = "Ajouter";
            this.AddQandA.UseVisualStyleBackColor = true;
            this.AddQandA.Click += new System.EventHandler(this.AddQandA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Editer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddQandA);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDeleteThis);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBoxCorrespondance);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCorrespondance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDeleteThis;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button AddQandA;
        private System.Windows.Forms.Button button2;
    }
}