
namespace ParcialDeYagoTorres
{
    partial class frmIngresoDatos
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
            this.EjeMayorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Okbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EjeMenortextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EjeMayorTextBox
            // 
            this.EjeMayorTextBox.Location = new System.Drawing.Point(88, 49);
            this.EjeMayorTextBox.Name = "EjeMayorTextBox";
            this.EjeMayorTextBox.Size = new System.Drawing.Size(140, 22);
            this.EjeMayorTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el Semi eje Mayor";
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(189, 199);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 62);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "Cancelar";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Okbutton
            // 
            this.Okbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Okbutton.Location = new System.Drawing.Point(78, 199);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 62);
            this.Okbutton.TabIndex = 4;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el Semi eje Menor";
            // 
            // EjeMenortextBox
            // 
            this.EjeMenortextBox.Location = new System.Drawing.Point(88, 129);
            this.EjeMenortextBox.Name = "EjeMenortextBox";
            this.EjeMenortextBox.Size = new System.Drawing.Size(140, 22);
            this.EjeMenortextBox.TabIndex = 6;
            // 
            // frmIngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 413);
            this.Controls.Add(this.EjeMenortextBox);
            this.Controls.Add(this.EjeMayorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Okbutton);
            this.Name = "frmIngresoDatos";
            this.Text = "ingreso de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EjeMayorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EjeMenortextBox;
    }
}