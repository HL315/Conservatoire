namespace ConservatoireChatgpt.Vue
{
    partial class LoginForm
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
            this.boutonLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.messageErreur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boutonLogin
            // 
            this.boutonLogin.Location = new System.Drawing.Point(518, 255);
            this.boutonLogin.Name = "boutonLogin";
            this.boutonLogin.Size = new System.Drawing.Size(75, 23);
            this.boutonLogin.TabIndex = 0;
            this.boutonLogin.Text = "Connexion";
            this.boutonLogin.UseVisualStyleBackColor = true;
            this.boutonLogin.Click += new System.EventHandler(this.boutonLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(300, 114);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 1;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(300, 170);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(100, 20);
            this.txtMdp.TabIndex = 2;
            // 
            // messageErreur
            // 
            this.messageErreur.AutoSize = true;
            this.messageErreur.Location = new System.Drawing.Point(268, 193);
            this.messageErreur.Name = "messageErreur";
            this.messageErreur.Size = new System.Drawing.Size(175, 13);
            this.messageErreur.TabIndex = 3;
            this.messageErreur.Text = "Identifiant ou mot de passe incorect";
            this.messageErreur.Visible = false;
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.messageErreur);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.boutonLogin);
            this.Name = "LoginForm";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label messageErreur;
    }
}

