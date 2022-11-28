namespace DemoProcedure1
{
    partial class Form3
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
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLastDate = new System.Windows.Forms.Label();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir le code de Job :";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(234, 64);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(221, 20);
            this.textBoxCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date du plus jeune employe dans ce Job";
            // 
            // labelLastDate
            // 
            this.labelLastDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLastDate.Location = new System.Drawing.Point(155, 189);
            this.labelLastDate.Name = "labelLastDate";
            this.labelLastDate.Size = new System.Drawing.Size(231, 26);
            this.labelLastDate.TabIndex = 3;
            this.labelLastDate.Text = "label3";
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(87, 280);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficher.TabIndex = 4;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Location = new System.Drawing.Point(380, 280);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(75, 23);
            this.buttonFin.TabIndex = 5;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 396);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.labelLastDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLastDate;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.Button buttonFin;
    }
}