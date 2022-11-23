
namespace ParcialDeYagoTorres
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BorrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ElipsedataGridView = new System.Windows.Forms.DataGridView();
            this.colMayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElipsedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ElipsedataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 383);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.EditarToolStripButton,
            this.BorrarToolStripButton,
            this.toolStripSeparator1,
            this.FiltrarToolStripButton,
            this.ActualizarToolStripButton,
            this.toolStripSeparator2,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.BackColor = System.Drawing.Color.Gray;
            this.NuevoToolStripButton.ForeColor = System.Drawing.SystemColors.Info;
            this.NuevoToolStripButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NuevoToolStripButton.Size = new System.Drawing.Size(56, 24);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.ToolTipText = "Agregar\r\n";
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.BackColor = System.Drawing.Color.Gray;
            this.EditarToolStripButton.ForeColor = System.Drawing.SystemColors.Info;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(52, 24);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BorrarToolStripButton
            // 
            this.BorrarToolStripButton.BackColor = System.Drawing.Color.Gray;
            this.BorrarToolStripButton.ForeColor = System.Drawing.SystemColors.Info;
            this.BorrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarToolStripButton.Name = "BorrarToolStripButton";
            this.BorrarToolStripButton.Size = new System.Drawing.Size(54, 24);
            this.BorrarToolStripButton.Text = "Borrar";
            this.BorrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.BackColor = System.Drawing.Color.Gray;
            this.FiltrarToolStripButton.ForeColor = System.Drawing.SystemColors.Info;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(51, 24);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.BackColor = System.Drawing.Color.Gray;
            this.ActualizarToolStripButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(79, 24);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.BackColor = System.Drawing.Color.Gray;
            this.toolStripButton6.ForeColor = System.Drawing.SystemColors.Info;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(42, 24);
            this.toolStripButton6.Text = "Salir";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ElipsedataGridView
            // 
            this.ElipsedataGridView.AllowUserToAddRows = false;
            this.ElipsedataGridView.AllowUserToDeleteRows = false;
            this.ElipsedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElipsedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMayor,
            this.colMenor,
            this.colTrazo});
            this.ElipsedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElipsedataGridView.Location = new System.Drawing.Point(0, 0);
            this.ElipsedataGridView.Name = "ElipsedataGridView";
            this.ElipsedataGridView.ReadOnly = true;
            this.ElipsedataGridView.RowHeadersWidth = 51;
            this.ElipsedataGridView.RowTemplate.Height = 24;
            this.ElipsedataGridView.Size = new System.Drawing.Size(800, 383);
            this.ElipsedataGridView.TabIndex = 1;
            // 
            // colMayor
            // 
            this.colMayor.HeaderText = "SemiejeMayor";
            this.colMayor.MinimumWidth = 6;
            this.colMayor.Name = "colMayor";
            this.colMayor.ReadOnly = true;
            this.colMayor.Width = 125;
            // 
            // colMenor
            // 
            this.colMenor.HeaderText = "SemiejeMenor";
            this.colMenor.MinimumWidth = 6;
            this.colMenor.Name = "colMenor";
            this.colMenor.ReadOnly = true;
            this.colMenor.Width = 125;
            // 
            // colTrazo
            // 
            this.colTrazo.HeaderText = "Tipo trazo";
            this.colTrazo.MinimumWidth = 6;
            this.colTrazo.Name = "colTrazo";
            this.colTrazo.ReadOnly = true;
            this.colTrazo.Width = 125;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "INFORMACION DE ELIPSES";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElipsedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ElipsedataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripButton BorrarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrazo;
    }
}

