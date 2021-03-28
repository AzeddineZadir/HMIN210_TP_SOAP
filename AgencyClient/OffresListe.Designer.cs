
namespace AgencyClient
{
    partial class OffresListe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.b_reserver = new System.Windows.Forms.Button();
            this.tb_idroom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_offeres = new System.Windows.Forms.DataGridView();
            this.romeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.romeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.romeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_offeres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.romeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les Offres Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 747);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 813);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(164, 750);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(273, 26);
            this.tb_nom.TabIndex = 4;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(164, 817);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(273, 26);
            this.tb_prenom.TabIndex = 5;
            // 
            // b_reserver
            // 
            this.b_reserver.Location = new System.Drawing.Point(1252, 865);
            this.b_reserver.Name = "b_reserver";
            this.b_reserver.Size = new System.Drawing.Size(256, 46);
            this.b_reserver.TabIndex = 6;
            this.b_reserver.Text = "Reserver";
            this.b_reserver.UseVisualStyleBackColor = true;
            this.b_reserver.Click += new System.EventHandler(this.b_reserver_Click);
            // 
            // tb_idroom
            // 
            this.tb_idroom.Location = new System.Drawing.Point(1235, 747);
            this.tb_idroom.Name = "tb_idroom";
            this.tb_idroom.Size = new System.Drawing.Size(273, 26);
            this.tb_idroom.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(889, 744);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "id de la chambre a réserver ";
            // 
            // dgv_offeres
            // 
            this.dgv_offeres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_offeres.Location = new System.Drawing.Point(38, 102);
            this.dgv_offeres.Name = "dgv_offeres";
            this.dgv_offeres.RowHeadersWidth = 62;
            this.dgv_offeres.RowTemplate.Height = 28;
            this.dgv_offeres.Size = new System.Drawing.Size(1498, 600);
            this.dgv_offeres.TabIndex = 10;
            // 
            // romeBindingSource
            // 
            this.romeBindingSource.DataSource = typeof(AgencyClient.ServiceReservationHotel.Rome);
            // 
            // romeBindingSource1
            // 
            this.romeBindingSource1.DataSource = typeof(AgencyClient.ServiceReservationHotel.Rome);
            // 
            // romeBindingSource2
            // 
            this.romeBindingSource2.DataSource = typeof(AgencyClient.ServiceReservationHotel.Rome);
            // 
            // OffresListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 1061);
            this.Controls.Add(this.dgv_offeres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_idroom);
            this.Controls.Add(this.b_reserver);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OffresListe";
            this.Text = "OffresListe";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_offeres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.romeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Button b_reserver;
        private System.Windows.Forms.TextBox tb_idroom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_offeres;
        private System.Windows.Forms.BindingSource romeBindingSource;
        private System.Windows.Forms.BindingSource romeBindingSource1;
        private System.Windows.Forms.BindingSource romeBindingSource2;
    }
}