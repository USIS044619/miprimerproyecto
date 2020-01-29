namespace miprimerproyecto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(116, 150);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(126, 124);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "procesar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(47, 57);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(196, 57);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(6, 57);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(38, 13);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "Num 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(153, 60);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(38, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "Num 2";
            this.lblnum2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(156, 109);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(71, 13);
            this.lblrespuesta.TabIndex = 5;
            this.lblrespuesta.Text = "respuesta : ? ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 352);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
    }
}

