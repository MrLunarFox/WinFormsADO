namespace WinFormsADO
{
    partial class Form_ListeAuteur
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
            dgv_ListeAuteur = new DataGridView();
            Num = new DataGridViewTextBoxColumn();
            Nom = new DataGridViewTextBoxColumn();
            Prenom = new DataGridViewTextBoxColumn();
            Nation = new DataGridViewTextBoxColumn();
            btn_afficher = new Button();
            btn_modifier = new Button();
            btn_supprimer = new Button();
            btn_nouveau = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAuteur).BeginInit();
            SuspendLayout();
            // 
            // dgv_ListeAuteur
            // 
            dgv_ListeAuteur.AllowUserToAddRows = false;
            dgv_ListeAuteur.AllowUserToDeleteRows = false;
            dgv_ListeAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListeAuteur.Columns.AddRange(new DataGridViewColumn[] { Num, Nom, Prenom, Nation });
            dgv_ListeAuteur.Location = new Point(12, 12);
            dgv_ListeAuteur.MultiSelect = false;
            dgv_ListeAuteur.Name = "dgv_ListeAuteur";
            dgv_ListeAuteur.ReadOnly = true;
            dgv_ListeAuteur.RowTemplate.Height = 25;
            dgv_ListeAuteur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_ListeAuteur.Size = new Size(703, 491);
            dgv_ListeAuteur.TabIndex = 0;
            // 
            // Num
            // 
            Num.HeaderText = "Numéro";
            Num.Name = "Num";
            Num.ReadOnly = true;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            Nom.ReadOnly = true;
            Nom.Width = 200;
            // 
            // Prenom
            // 
            Prenom.HeaderText = "Prénom";
            Prenom.Name = "Prenom";
            Prenom.ReadOnly = true;
            // 
            // Nation
            // 
            Nation.HeaderText = "Nationalité";
            Nation.Name = "Nation";
            Nation.ReadOnly = true;
            // 
            // btn_afficher
            // 
            btn_afficher.Location = new Point(761, 30);
            btn_afficher.Name = "btn_afficher";
            btn_afficher.Size = new Size(75, 23);
            btn_afficher.TabIndex = 1;
            btn_afficher.Text = "Afficher";
            btn_afficher.UseVisualStyleBackColor = true;
            btn_afficher.Click += btn_afficher_Click;
            // 
            // btn_modifier
            // 
            btn_modifier.Location = new Point(761, 59);
            btn_modifier.Name = "btn_modifier";
            btn_modifier.Size = new Size(75, 23);
            btn_modifier.TabIndex = 2;
            btn_modifier.Text = "Modifier";
            btn_modifier.UseVisualStyleBackColor = true;
            btn_modifier.Click += btn_modifier_Click;
            // 
            // btn_supprimer
            // 
            btn_supprimer.Location = new Point(761, 88);
            btn_supprimer.Name = "btn_supprimer";
            btn_supprimer.Size = new Size(75, 23);
            btn_supprimer.TabIndex = 3;
            btn_supprimer.Text = "Supprimer";
            btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_nouveau
            // 
            btn_nouveau.Location = new Point(761, 117);
            btn_nouveau.Name = "btn_nouveau";
            btn_nouveau.Size = new Size(75, 23);
            btn_nouveau.TabIndex = 4;
            btn_nouveau.Text = "Nouveau";
            btn_nouveau.UseVisualStyleBackColor = true;
            // 
            // Form_ListeAuteur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 515);
            Controls.Add(btn_nouveau);
            Controls.Add(btn_supprimer);
            Controls.Add(btn_modifier);
            Controls.Add(btn_afficher);
            Controls.Add(dgv_ListeAuteur);
            Name = "Form_ListeAuteur";
            Text = "Liste des auteurs";
            ((System.ComponentModel.ISupportInitialize)dgv_ListeAuteur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_ListeAuteur;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Prenom;
        private DataGridViewTextBoxColumn Nation;
        private Button btn_afficher;
        private Button btn_modifier;
        private Button btn_supprimer;
        private Button btn_nouveau;
    }
}