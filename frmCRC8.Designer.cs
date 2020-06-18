namespace ExemploCRC8
{
    partial class frmCRC8
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
            this.txtTexoOriginal = new System.Windows.Forms.TextBox();
            this.btnCalcularCRC = new System.Windows.Forms.Button();
            this.lblValorCRC = new System.Windows.Forms.Label();
            this.lblDescCRC = new System.Windows.Forms.Label();
            this.lblDescTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTexoOriginal
            // 
            this.txtTexoOriginal.Location = new System.Drawing.Point(13, 25);
            this.txtTexoOriginal.Multiline = true;
            this.txtTexoOriginal.Name = "txtTexoOriginal";
            this.txtTexoOriginal.Size = new System.Drawing.Size(327, 157);
            this.txtTexoOriginal.TabIndex = 0;
            // 
            // btnCalcularCRC
            // 
            this.btnCalcularCRC.Location = new System.Drawing.Point(12, 188);
            this.btnCalcularCRC.Name = "btnCalcularCRC";
            this.btnCalcularCRC.Size = new System.Drawing.Size(127, 23);
            this.btnCalcularCRC.TabIndex = 1;
            this.btnCalcularCRC.Text = "Calcular CRC";
            this.btnCalcularCRC.UseVisualStyleBackColor = true;
            this.btnCalcularCRC.Click += new System.EventHandler(this.btnCalcularCRC_Click);
            // 
            // lblValorCRC
            // 
            this.lblValorCRC.AutoSize = true;
            this.lblValorCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCRC.Location = new System.Drawing.Point(76, 214);
            this.lblValorCRC.Name = "lblValorCRC";
            this.lblValorCRC.Size = new System.Drawing.Size(21, 24);
            this.lblValorCRC.TabIndex = 2;
            this.lblValorCRC.Text = "0";
            // 
            // lblDescCRC
            // 
            this.lblDescCRC.AutoSize = true;
            this.lblDescCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCRC.Location = new System.Drawing.Point(12, 214);
            this.lblDescCRC.Name = "lblDescCRC";
            this.lblDescCRC.Size = new System.Drawing.Size(58, 24);
            this.lblDescCRC.TabIndex = 3;
            this.lblDescCRC.Text = "CRC:";
            // 
            // lblDescTexto
            // 
            this.lblDescTexto.AutoSize = true;
            this.lblDescTexto.Location = new System.Drawing.Point(9, 9);
            this.lblDescTexto.Name = "lblDescTexto";
            this.lblDescTexto.Size = new System.Drawing.Size(37, 13);
            this.lblDescTexto.TabIndex = 4;
            this.lblDescTexto.Text = "Texto:";
            // 
            // frmCRC8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 247);
            this.Controls.Add(this.lblDescTexto);
            this.Controls.Add(this.lblDescCRC);
            this.Controls.Add(this.lblValorCRC);
            this.Controls.Add(this.btnCalcularCRC);
            this.Controls.Add(this.txtTexoOriginal);
            this.Name = "frmCRC8";
            this.Text = "Exemplo CRC8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexoOriginal;
        private System.Windows.Forms.Button btnCalcularCRC;
        private System.Windows.Forms.Label lblValorCRC;
        private System.Windows.Forms.Label lblDescCRC;
        private System.Windows.Forms.Label lblDescTexto;
    }
}

