namespace DemoProcedure1
{
    partial class Form1
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
            this.textBoxTitles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAfficherTitles = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitles
            // 
            this.textBoxTitles.Location = new System.Drawing.Point(85, 59);
            this.textBoxTitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTitles.Multiline = true;
            this.textBoxTitles.Name = "textBoxTitles";
            this.textBoxTitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTitles.Size = new System.Drawing.Size(483, 282);
            this.textBoxTitles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "La Liste des livres";
            // 
            // buttonAfficherTitles
            // 
            this.buttonAfficherTitles.Location = new System.Drawing.Point(85, 378);
            this.buttonAfficherTitles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAfficherTitles.Name = "buttonAfficherTitles";
            this.buttonAfficherTitles.Size = new System.Drawing.Size(216, 28);
            this.buttonAfficherTitles.TabIndex = 2;
            this.buttonAfficherTitles.Text = "Afficher la liste des titres";
            this.buttonAfficherTitles.UseVisualStyleBackColor = true;
            this.buttonAfficherTitles.Click += new System.EventHandler(this.buttonAfficherTitles_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(497, 378);
            this.buttonFin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(71, 28);
            this.buttonFin.TabIndex = 3;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 439);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonAfficherTitles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAfficherTitles;
        private System.Windows.Forms.Button buttonFin;
    }
}

