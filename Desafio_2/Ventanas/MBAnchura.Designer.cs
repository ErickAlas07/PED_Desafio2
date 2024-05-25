namespace Desafio_2.Ventanas
{
    partial class MBAnchura
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBAnchura));
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.ptbDatos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblMsg.Location = new System.Drawing.Point(12, 32);
            this.lblMsg.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(76, 20);
            this.lblMsg.TabIndex = 0;
            this.lblMsg.Text = "Message";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(164, 192);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 46);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ptbDatos
            // 
            this.ptbDatos.Image = ((System.Drawing.Image)(resources.GetObject("ptbDatos.Image")));
            this.ptbDatos.Location = new System.Drawing.Point(297, 32);
            this.ptbDatos.Name = "ptbDatos";
            this.ptbDatos.Size = new System.Drawing.Size(132, 162);
            this.ptbDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDatos.TabIndex = 2;
            this.ptbDatos.TabStop = false;
            this.ptbDatos.Click += new System.EventHandler(this.ptbDatos_Click);
            // 
            // MBAnchura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(441, 250);
            this.Controls.Add(this.ptbDatos);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MBAnchura";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MBAnchura";
            this.Load += new System.EventHandler(this.MBAnchura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox ptbDatos;
    }
}
