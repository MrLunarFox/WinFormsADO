namespace WinFormsADO
{
    partial class FicheAuteur
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
            components = new System.ComponentModel.Container();
            lb_Num = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lb_Nom = new Label();
            lb_Prenom = new Label();
            lb_Nationalite = new Label();
            txt_Num = new TextBox();
            txt_Nom = new TextBox();
            txt_Prenom = new TextBox();
            txt_Nationalite = new TextBox();
            btn_Valider = new Button();
            btn_Annuler = new Button();
            SuspendLayout();
            // 
            // lb_Num
            // 
            lb_Num.AutoSize = true;
            lb_Num.Location = new Point(29, 26);
            lb_Num.Name = "lb_Num";
            lb_Num.Size = new Size(51, 15);
            lb_Num.TabIndex = 0;
            lb_Num.Text = "Numéro";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lb_Nom
            // 
            lb_Nom.AutoSize = true;
            lb_Nom.Location = new Point(31, 57);
            lb_Nom.Name = "lb_Nom";
            lb_Nom.Size = new Size(34, 15);
            lb_Nom.TabIndex = 5;
            lb_Nom.Text = "Nom";
            // 
            // lb_Prenom
            // 
            lb_Prenom.AutoSize = true;
            lb_Prenom.Location = new Point(29, 84);
            lb_Prenom.Name = "lb_Prenom";
            lb_Prenom.Size = new Size(49, 15);
            lb_Prenom.TabIndex = 6;
            lb_Prenom.Text = "Prénom";
            // 
            // lb_Nationalite
            // 
            lb_Nationalite.AutoSize = true;
            lb_Nationalite.Location = new Point(29, 113);
            lb_Nationalite.Name = "lb_Nationalite";
            lb_Nationalite.Size = new Size(65, 15);
            lb_Nationalite.TabIndex = 7;
            lb_Nationalite.Text = "Nationalité";
            // 
            // txt_Num
            // 
            txt_Num.Enabled = false;
            txt_Num.Location = new Point(115, 18);
            txt_Num.Name = "txt_Num";
            txt_Num.Size = new Size(100, 23);
            txt_Num.TabIndex = 8;
            // 
            // txt_Nom
            // 
            txt_Nom.Location = new Point(115, 47);
            txt_Nom.Name = "txt_Nom";
            txt_Nom.Size = new Size(100, 23);
            txt_Nom.TabIndex = 9;
            // 
            // txt_Prenom
            // 
            txt_Prenom.Location = new Point(115, 76);
            txt_Prenom.Name = "txt_Prenom";
            txt_Prenom.Size = new Size(100, 23);
            txt_Prenom.TabIndex = 10;
            // 
            // txt_Nationalite
            // 
            txt_Nationalite.Location = new Point(115, 105);
            txt_Nationalite.Name = "txt_Nationalite";
            txt_Nationalite.Size = new Size(100, 23);
            txt_Nationalite.TabIndex = 11;
            // 
            // btn_Valider
            // 
            btn_Valider.Location = new Point(44, 165);
            btn_Valider.Name = "btn_Valider";
            btn_Valider.Size = new Size(75, 23);
            btn_Valider.TabIndex = 12;
            btn_Valider.Text = "Valider";
            btn_Valider.UseVisualStyleBackColor = true;
            btn_Valider.Click += btn_Valider_Click;
            // 
            // btn_Annuler
            // 
            btn_Annuler.Location = new Point(140, 165);
            btn_Annuler.Name = "btn_Annuler";
            btn_Annuler.Size = new Size(75, 23);
            btn_Annuler.TabIndex = 13;
            btn_Annuler.Text = "Annuler";
            btn_Annuler.UseVisualStyleBackColor = true;
            btn_Annuler.Click += btn_Annuler_Click;
            // 
            // FicheAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 221);
            Controls.Add(btn_Annuler);
            Controls.Add(btn_Valider);
            Controls.Add(txt_Nationalite);
            Controls.Add(txt_Prenom);
            Controls.Add(txt_Nom);
            Controls.Add(txt_Num);
            Controls.Add(lb_Nationalite);
            Controls.Add(lb_Prenom);
            Controls.Add(lb_Nom);
            Controls.Add(lb_Num);
            Name = "FicheAuteur";
            Text = "FicheAuteur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Num;
        private ContextMenuStrip contextMenuStrip1;
        private Label lb_Nom;
        private Label lb_Prenom;
        private Label lb_Nationalite;
        private TextBox txt_Num;
        private TextBox txt_Nom;
        private TextBox txt_Prenom;
        private TextBox txt_Nationalite;
        private Button btn_Valider;
        private Button btn_Annuler;
    }
}