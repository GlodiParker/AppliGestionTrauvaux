
namespace AppliGestionTrauvaux
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.cbograde = new System.Windows.Forms.ComboBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MS ENCANDREURS ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Image = global::AppliGestionTrauvaux.Properties.Resources._098_close;
            this.label2.Location = new System.Drawing.Point(519, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "CODE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "TELEPHONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "GRADE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "PRENOM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(56, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "NOM";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcode.Location = new System.Drawing.Point(124, 83);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(392, 26);
            this.txtcode.TabIndex = 7;
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnom.Location = new System.Drawing.Point(124, 119);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(392, 26);
            this.txtnom.TabIndex = 8;
            // 
            // txtprenom
            // 
            this.txtprenom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtprenom.Location = new System.Drawing.Point(124, 161);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(392, 26);
            this.txtprenom.TabIndex = 9;
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtphone.Location = new System.Drawing.Point(124, 261);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(392, 26);
            this.txtphone.TabIndex = 10;
            // 
            // cbograde
            // 
            this.cbograde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbograde.FormattingEnabled = true;
            this.cbograde.Items.AddRange(new object[] {
            "AUTRE",
            "ASSISTANT 1",
            "ASSISTANT 2",
            "CHEF DE TRAVAUX",
            "PROFESSEUR"});
            this.cbograde.Location = new System.Drawing.Point(124, 213);
            this.cbograde.Name = "cbograde";
            this.cbograde.Size = new System.Drawing.Size(177, 29);
            this.cbograde.TabIndex = 11;
            this.cbograde.Text = "--------CHOIX---------";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.White;
            this.btnEnregistrer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnregistrer.Image = global::AppliGestionTrauvaux.Properties.Resources.save;
            this.btnEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 314);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(119, 36);
            this.btnEnregistrer.TabIndex = 12;
            this.btnEnregistrer.Text = "ENREGISTRER";
            this.btnEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.MistyRose;
            this.btnSupprimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Image")));
            this.btnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupprimer.Location = new System.Drawing.Point(150, 314);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(119, 36);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModifier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(289, 314);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(119, 36);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.Honeydew;
            this.btnRechercher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnRechercher.Image")));
            this.btnRechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.Location = new System.Drawing.Point(430, 314);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(119, 36);
            this.btnRechercher.TabIndex = 15;
            this.btnRechercher.Text = "RECHERCHER";
            this.btnRechercher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(569, 382);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.cbograde);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnRechercher;
        public System.Windows.Forms.TextBox txtnom;
        public System.Windows.Forms.TextBox txtprenom;
        public System.Windows.Forms.ComboBox cbograde;
        public System.Windows.Forms.TextBox txtphone;
        public System.Windows.Forms.TextBox txtcode;
    }
}

