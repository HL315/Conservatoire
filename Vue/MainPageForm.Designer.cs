namespace ConservatoireChatgpt.Vue
{
    partial class MainPageForm
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
            this.comboBoxProfesseur = new System.Windows.Forms.ComboBox();
            this.comboBoxEleve = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxProfesseur
            // 
            this.comboBoxProfesseur.FormattingEnabled = true;
            this.comboBoxProfesseur.Location = new System.Drawing.Point(186, 104);
            this.comboBoxProfesseur.Name = "comboBoxProfesseur";
            this.comboBoxProfesseur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProfesseur.TabIndex = 0;
            // 
            // comboBoxEleve
            // 
            this.comboBoxEleve.FormattingEnabled = true;
            this.comboBoxEleve.Location = new System.Drawing.Point(186, 183);
            this.comboBoxEleve.Name = "comboBoxEleve";
            this.comboBoxEleve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEleve.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Professeurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Eleves";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(499, 105);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(100, 20);
            this.txtMontant.TabIndex = 4;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(499, 184);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(100, 20);
            this.txtLibelle.TabIndex = 5;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(523, 285);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "button1";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Montant à payer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Libelle";
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEleve);
            this.Controls.Add(this.comboBoxProfesseur);
            this.Name = "MainPageForm";
            this.Text = "MainPageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProfesseur;
        private System.Windows.Forms.ComboBox comboBoxEleve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}