namespace Temporizador
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.txtContador = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panelCmbs = new System.Windows.Forms.Panel();
            this.cmbMinutos = new System.Windows.Forms.ComboBox();
            this.cmbSegundos = new System.Windows.Forms.ComboBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.panelCmbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContador
            // 
            this.txtContador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContador.Location = new System.Drawing.Point(107, 65);
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(270, 22);
            this.txtContador.TabIndex = 0;
            this.txtContador.Text = "99:99:59";
            this.txtContador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(34, 224);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(125, 39);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "button1";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(180, 224);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(129, 39);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "button2";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(337, 224);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 39);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "button3";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // panelCmbs
            // 
            this.panelCmbs.Controls.Add(this.txtHoras);
            this.panelCmbs.Controls.Add(this.lblSegundos);
            this.panelCmbs.Controls.Add(this.lblMinutos);
            this.panelCmbs.Controls.Add(this.lblHoras);
            this.panelCmbs.Controls.Add(this.cmbSegundos);
            this.panelCmbs.Controls.Add(this.cmbMinutos);
            this.panelCmbs.Location = new System.Drawing.Point(34, 118);
            this.panelCmbs.Name = "panelCmbs";
            this.panelCmbs.Size = new System.Drawing.Size(408, 100);
            this.panelCmbs.TabIndex = 4;
            // 
            // cmbMinutos
            // 
            this.cmbMinutos.FormattingEnabled = true;
            this.cmbMinutos.Location = new System.Drawing.Point(131, 41);
            this.cmbMinutos.Name = "cmbMinutos";
            this.cmbMinutos.Size = new System.Drawing.Size(121, 24);
            this.cmbMinutos.TabIndex = 1;
            // 
            // cmbSegundos
            // 
            this.cmbSegundos.FormattingEnabled = true;
            this.cmbSegundos.Location = new System.Drawing.Point(258, 41);
            this.cmbSegundos.Name = "cmbSegundos";
            this.cmbSegundos.Size = new System.Drawing.Size(121, 24);
            this.cmbSegundos.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(38, 16);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(46, 17);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Hours";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(174, 16);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(57, 17);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "Minutes";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(297, 16);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(63, 17);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "Seconds";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(25, 43);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 22);
            this.txtHoras.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(631, 306);
            this.Controls.Add(this.panelCmbs);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtContador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Temporizador";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelCmbs.ResumeLayout(false);
            this.panelCmbs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel panelCmbs;
        private System.Windows.Forms.ComboBox cmbSegundos;
        private System.Windows.Forms.ComboBox cmbMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
    }
}

