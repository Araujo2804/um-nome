
namespace Multjogos
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.lblPorcento = new System.Windows.Forms.Label();
            this.pgbSpash = new System.Windows.Forms.ProgressBar();
            this.pcbControle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbControle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(398, 148);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(18, 15);
            this.lblPorcentagem.TabIndex = 7;
            this.lblPorcentagem.Text = "%";
            // 
            // lblPorcento
            // 
            this.lblPorcento.AutoSize = true;
            this.lblPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcento.Location = new System.Drawing.Point(388, 148);
            this.lblPorcento.Name = "lblPorcento";
            this.lblPorcento.Size = new System.Drawing.Size(14, 15);
            this.lblPorcento.TabIndex = 6;
            this.lblPorcento.Text = "0";
            this.lblPorcento.Click += new System.EventHandler(this.label1_Click);
            // 
            // pgbSpash
            // 
            this.pgbSpash.Location = new System.Drawing.Point(297, 166);
            this.pgbSpash.Name = "pgbSpash";
            this.pgbSpash.Size = new System.Drawing.Size(200, 11);
            this.pgbSpash.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSpash.TabIndex = 5;
            this.pgbSpash.Value = 50;
            // 
            // pcbControle
            // 
            this.pcbControle.Image = ((System.Drawing.Image)(resources.GetObject("pcbControle.Image")));
            this.pcbControle.Location = new System.Drawing.Point(297, 200);
            this.pcbControle.Name = "pcbControle";
            this.pcbControle.Size = new System.Drawing.Size(200, 158);
            this.pcbControle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbControle.TabIndex = 4;
            this.pcbControle.TabStop = false;
            this.pcbControle.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblPorcento);
            this.Controls.Add(this.pgbSpash);
            this.Controls.Add(this.pcbControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbControle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label lblPorcento;
        private System.Windows.Forms.ProgressBar pgbSpash;
        private System.Windows.Forms.PictureBox pcbControle;
    }
}