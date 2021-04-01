
namespace AgencyClient
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
            this.l_titel = new System.Windows.Forms.Label();
            this.l_dateA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_nbp = new System.Windows.Forms.Label();
            this.tb_da = new System.Windows.Forms.TextBox();
            this.tb_dd = new System.Windows.Forms.TextBox();
            this.tb_nbp = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.l_agence = new System.Windows.Forms.Label();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_titel
            // 
            this.l_titel.AutoSize = true;
            this.l_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_titel.Location = new System.Drawing.Point(356, 71);
            this.l_titel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_titel.Name = "l_titel";
            this.l_titel.Size = new System.Drawing.Size(321, 24);
            this.l_titel.TabIndex = 0;
            this.l_titel.Text = "Vous voulez reserver une chambre ?";
            this.l_titel.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_dateA
            // 
            this.l_dateA.AutoSize = true;
            this.l_dateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dateA.Location = new System.Drawing.Point(283, 173);
            this.l_dateA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_dateA.Name = "l_dateA";
            this.l_dateA.Size = new System.Drawing.Size(120, 24);
            this.l_dateA.TabIndex = 1;
            this.l_dateA.Text = "Date d\'arriver";
            this.l_dateA.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date départ ";
            // 
            // l_nbp
            // 
            this.l_nbp.AutoSize = true;
            this.l_nbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nbp.Location = new System.Drawing.Point(283, 262);
            this.l_nbp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_nbp.Name = "l_nbp";
            this.l_nbp.Size = new System.Drawing.Size(201, 24);
            this.l_nbp.TabIndex = 3;
            this.l_nbp.Text = "Nombre de personnes";
            // 
            // tb_da
            // 
            this.tb_da.Location = new System.Drawing.Point(491, 173);
            this.tb_da.Margin = new System.Windows.Forms.Padding(2);
            this.tb_da.Name = "tb_da";
            this.tb_da.Size = new System.Drawing.Size(234, 20);
            this.tb_da.TabIndex = 5;
            this.tb_da.Text = "10/10/2021";
            // 
            // tb_dd
            // 
            this.tb_dd.Location = new System.Drawing.Point(491, 218);
            this.tb_dd.Margin = new System.Windows.Forms.Padding(2);
            this.tb_dd.Name = "tb_dd";
            this.tb_dd.Size = new System.Drawing.Size(234, 20);
            this.tb_dd.TabIndex = 5;
            this.tb_dd.Text = "12/10/2021";
            // 
            // tb_nbp
            // 
            this.tb_nbp.Location = new System.Drawing.Point(491, 262);
            this.tb_nbp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nbp.Name = "tb_nbp";
            this.tb_nbp.Size = new System.Drawing.Size(234, 20);
            this.tb_nbp.TabIndex = 6;
            this.tb_nbp.Text = "1";
            // 
            // b_search
            // 
            this.b_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.Location = new System.Drawing.Point(460, 334);
            this.b_search.Margin = new System.Windows.Forms.Padding(2);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(134, 31);
            this.b_search.TabIndex = 8;
            this.b_search.Text = "Rechercher";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // l_agence
            // 
            this.l_agence.AutoSize = true;
            this.l_agence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_agence.Location = new System.Drawing.Point(456, 20);
            this.l_agence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_agence.Name = "l_agence";
            this.l_agence.Size = new System.Drawing.Size(105, 24);
            this.l_agence.TabIndex = 9;
            this.l_agence.Text = "Agence A1";
            this.l_agence.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(491, 125);
            this.tb_ville.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(234, 20);
            this.tb_ville.TabIndex = 11;
            this.tb_ville.Text = "montpellier";
            this.tb_ville.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ville";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 448);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_agence);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_nbp);
            this.Controls.Add(this.tb_dd);
            this.Controls.Add(this.tb_da);
            this.Controls.Add(this.l_nbp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_dateA);
            this.Controls.Add(this.l_titel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_titel;
        private System.Windows.Forms.Label l_dateA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_nbp;
        private System.Windows.Forms.TextBox tb_da;
        private System.Windows.Forms.TextBox tb_dd;
        private System.Windows.Forms.TextBox tb_nbp;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label l_agence;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Label label2;
    }
}

