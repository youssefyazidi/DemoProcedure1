namespace DemoProcedure1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrixMin = new System.Windows.Forms.TextBox();
            this.textBoxPrixMax = new System.Windows.Forms.TextBox();
            this.textBoxTypeEdition = new System.Windows.Forms.TextBox();
            this.textBoxTitles = new System.Windows.Forms.TextBox();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonAfficherTitles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prix min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Edition";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPrixMin
            // 
            this.textBoxPrixMin.Location = new System.Drawing.Point(101, 43);
            this.textBoxPrixMin.Name = "textBoxPrixMin";
            this.textBoxPrixMin.Size = new System.Drawing.Size(201, 22);
            this.textBoxPrixMin.TabIndex = 3;
            // 
            // textBoxPrixMax
            // 
            this.textBoxPrixMax.Location = new System.Drawing.Point(436, 43);
            this.textBoxPrixMax.Name = "textBoxPrixMax";
            this.textBoxPrixMax.Size = new System.Drawing.Size(201, 22);
            this.textBoxPrixMax.TabIndex = 4;
            // 
            // textBoxTypeEdition
            // 
            this.textBoxTypeEdition.Location = new System.Drawing.Point(266, 86);
            this.textBoxTypeEdition.Name = "textBoxTypeEdition";
            this.textBoxTypeEdition.Size = new System.Drawing.Size(201, 22);
            this.textBoxTypeEdition.TabIndex = 5;
            this.textBoxTypeEdition.TextChanged += new System.EventHandler(this.textBoxTypeEdition_TextChanged);
            // 
            // textBoxTitles
            // 
            this.textBoxTitles.Location = new System.Drawing.Point(16, 115);
            this.textBoxTitles.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitles.Multiline = true;
            this.textBoxTitles.Name = "textBoxTitles";
            this.textBoxTitles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTitles.Size = new System.Drawing.Size(621, 161);
            this.textBoxTitles.TabIndex = 6;
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(472, 309);
            this.buttonFin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(71, 28);
            this.buttonFin.TabIndex = 8;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            // 
            // buttonAfficherTitles
            // 
            this.buttonAfficherTitles.Location = new System.Drawing.Point(60, 309);
            this.buttonAfficherTitles.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfficherTitles.Name = "buttonAfficherTitles";
            this.buttonAfficherTitles.Size = new System.Drawing.Size(216, 28);
            this.buttonAfficherTitles.TabIndex = 7;
            this.buttonAfficherTitles.Text = "Afficher la liste des titres";
            this.buttonAfficherTitles.UseVisualStyleBackColor = true;
            this.buttonAfficherTitles.Click += new System.EventHandler(this.buttonAfficherTitles_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 399);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonAfficherTitles);
            this.Controls.Add(this.textBoxTitles);
            this.Controls.Add(this.textBoxTypeEdition);
            this.Controls.Add(this.textBoxPrixMax);
            this.Controls.Add(this.textBoxPrixMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrixMin;
        private System.Windows.Forms.TextBox textBoxPrixMax;
        private System.Windows.Forms.TextBox textBoxTypeEdition;
        private System.Windows.Forms.TextBox textBoxTitles;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonAfficherTitles;
    }
}