
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
            this.SuspendLayout();
            // 
            // l_titel
            // 
            this.l_titel.AutoSize = true;
            this.l_titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_titel.Location = new System.Drawing.Point(534, 110);
            this.l_titel.Name = "l_titel";
            this.l_titel.Size = new System.Drawing.Size(475, 32);
            this.l_titel.TabIndex = 0;
            this.l_titel.Text = "Vous voulez reserver une chambre ?";
            this.l_titel.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_dateA
            // 
            this.l_dateA.AutoSize = true;
            this.l_dateA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_dateA.Location = new System.Drawing.Point(427, 193);
            this.l_dateA.Name = "l_dateA";
            this.l_dateA.Size = new System.Drawing.Size(183, 32);
            this.l_dateA.TabIndex = 1;
            this.l_dateA.Text = "Date d\'arriver";
            this.l_dateA.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date départ ";
            // 
            // l_nbp
            // 
            this.l_nbp.AutoSize = true;
            this.l_nbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nbp.Location = new System.Drawing.Point(427, 330);
            this.l_nbp.Name = "l_nbp";
            this.l_nbp.Size = new System.Drawing.Size(294, 32);
            this.l_nbp.TabIndex = 3;
            this.l_nbp.Text = "Nombre de personnes";
            // 
            // tb_da
            // 
            this.tb_da.Location = new System.Drawing.Point(740, 193);
            this.tb_da.Name = "tb_da";
            this.tb_da.Size = new System.Drawing.Size(349, 26);
            this.tb_da.TabIndex = 5;
            this.tb_da.Text = "dd/mm/yyyy";
            // 
            // tb_dd
            // 
            this.tb_dd.Location = new System.Drawing.Point(740, 261);
            this.tb_dd.Name = "tb_dd";
            this.tb_dd.Size = new System.Drawing.Size(349, 26);
            this.tb_dd.TabIndex = 5;
            this.tb_dd.Text = "dd/mm/yyyy";
            // 
            // tb_nbp
            // 
            this.tb_nbp.Location = new System.Drawing.Point(740, 330);
            this.tb_nbp.Name = "tb_nbp";
            this.tb_nbp.Size = new System.Drawing.Size(349, 26);
            this.tb_nbp.TabIndex = 6;
            // 
            // b_search
            // 
            this.b_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.Location = new System.Drawing.Point(690, 514);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(201, 48);
            this.b_search.TabIndex = 8;
            this.b_search.Text = "Rechercher";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // l_agence
            // 
            this.l_agence.AutoSize = true;
            this.l_agence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_agence.Location = new System.Drawing.Point(684, 31);
            this.l_agence.Name = "l_agence";
            this.l_agence.Size = new System.Drawing.Size(154, 32);
            this.l_agence.TabIndex = 9;
            this.l_agence.Text = "Agence A1";
            this.l_agence.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 690);
            this.Controls.Add(this.l_agence);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_nbp);
            this.Controls.Add(this.tb_dd);
            this.Controls.Add(this.tb_da);
            this.Controls.Add(this.l_nbp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_dateA);
            this.Controls.Add(this.l_titel);
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
    }
}

