
namespace AgencyClient
{
    partial class RoomDetailsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_roomid = new System.Windows.Forms.TextBox();
            this.tb_rometype = new System.Windows.Forms.TextBox();
            this.tb_roomnbplace = new System.Windows.Forms.TextBox();
            this.tb_roomprice = new System.Windows.Forms.TextBox();
            this.pb_roome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_roome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de la chambre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type de la chambre ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de places";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(478, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pirx de la chambre pour une nuits ";
            // 
            // tb_roomid
            // 
            this.tb_roomid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_roomid.Location = new System.Drawing.Point(589, 110);
            this.tb_roomid.Name = "tb_roomid";
            this.tb_roomid.Size = new System.Drawing.Size(100, 39);
            this.tb_roomid.TabIndex = 4;
            // 
            // tb_rometype
            // 
            this.tb_rometype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rometype.Location = new System.Drawing.Point(589, 173);
            this.tb_rometype.Name = "tb_rometype";
            this.tb_rometype.Size = new System.Drawing.Size(100, 39);
            this.tb_rometype.TabIndex = 5;
            // 
            // tb_roomnbplace
            // 
            this.tb_roomnbplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_roomnbplace.Location = new System.Drawing.Point(589, 242);
            this.tb_roomnbplace.Name = "tb_roomnbplace";
            this.tb_roomnbplace.Size = new System.Drawing.Size(100, 39);
            this.tb_roomnbplace.TabIndex = 6;
            // 
            // tb_roomprice
            // 
            this.tb_roomprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_roomprice.Location = new System.Drawing.Point(589, 319);
            this.tb_roomprice.Name = "tb_roomprice";
            this.tb_roomprice.Size = new System.Drawing.Size(100, 39);
            this.tb_roomprice.TabIndex = 7;
            // 
            // pb_roome
            // 
            this.pb_roome.Location = new System.Drawing.Point(730, 110);
            this.pb_roome.Name = "pb_roome";
            this.pb_roome.Size = new System.Drawing.Size(1030, 875);
            this.pb_roome.TabIndex = 8;
            this.pb_roome.TabStop = false;
            // 
            // RoomDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1785, 1010);
            this.Controls.Add(this.pb_roome);
            this.Controls.Add(this.tb_roomprice);
            this.Controls.Add(this.tb_roomnbplace);
            this.Controls.Add(this.tb_rometype);
            this.Controls.Add(this.tb_roomid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RoomDetailsForm";
            this.Text = "RoomDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_roome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_roomid;
        private System.Windows.Forms.TextBox tb_rometype;
        private System.Windows.Forms.TextBox tb_roomnbplace;
        private System.Windows.Forms.TextBox tb_roomprice;
        private System.Windows.Forms.PictureBox pb_roome;
    }
}