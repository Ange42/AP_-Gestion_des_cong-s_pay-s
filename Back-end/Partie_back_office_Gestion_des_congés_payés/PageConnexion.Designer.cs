namespace Partie_back_office_Gestion_des_congés_payés
{
    partial class PageConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageConnexion));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.pb_arbre = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_arbre)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matricule";
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(331, 369);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.Size = new System.Drawing.Size(211, 20);
            this.txt_mdp.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(331, 302);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 20);
            this.txt_id.TabIndex = 6;
            // 
            // pb_arbre
            // 
            this.pb_arbre.Image = ((System.Drawing.Image)(resources.GetObject("pb_arbre.Image")));
            this.pb_arbre.Location = new System.Drawing.Point(259, 50);
            this.pb_arbre.Name = "pb_arbre";
            this.pb_arbre.Size = new System.Drawing.Size(320, 190);
            this.pb_arbre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_arbre.TabIndex = 5;
            this.pb_arbre.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.pb_arbre);
            this.Name = "PageConnexion";
            this.Text = "PageConnexion";
            ((System.ComponentModel.ISupportInitialize)(this.pb_arbre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox pb_arbre;
        private System.Windows.Forms.Button button1;
    }
}