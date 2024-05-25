
namespace Desafio_2.Ventanas
{
    partial class MBProfundidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MBProfundidad));
            this.ptbDatos = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbDatos
            // 
            this.ptbDatos.Image = ((System.Drawing.Image)(resources.GetObject("ptbDatos.Image")));
            this.ptbDatos.Location = new System.Drawing.Point(303, 33);
            this.ptbDatos.Name = "ptbDatos";
            this.ptbDatos.Size = new System.Drawing.Size(132, 162);
            this.ptbDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbDatos.TabIndex = 5;
            this.ptbDatos.TabStop = false;
            this.ptbDatos.Click += new System.EventHandler(this.ptbDatos_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOk.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(162, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 46);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblMsg.Location = new System.Drawing.Point(12, 33);
            this.lblMsg.MaximumSize = new System.Drawing.Size(450, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(76, 20);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Message";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // MBProfundidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.ptbDatos);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MBProfundidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MBProfundidad";
            ((System.ComponentModel.ISupportInitialize)(this.ptbDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbDatos;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblMsg;
    }
}