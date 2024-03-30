namespace Presentración
{
    partial class frm_numericupdown
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
            this.num_nrodia = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_nrodia)).BeginInit();
            this.SuspendLayout();
            // 
            // num_nrodia
            // 
            this.num_nrodia.Location = new System.Drawing.Point(183, 162);
            this.num_nrodia.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.num_nrodia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_nrodia.Name = "num_nrodia";
            this.num_nrodia.ReadOnly = true;
            this.num_nrodia.Size = new System.Drawing.Size(180, 26);
            this.num_nrodia.TabIndex = 0;
            this.num_nrodia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_nrodia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro de día de la semana:";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.AutoSize = true;
            this.btn_mostrar.Location = new System.Drawing.Point(183, 219);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(180, 30);
            this.btn_mostrar.TabIndex = 2;
            this.btn_mostrar.Text = "Mostrar día en texto";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(424, 162);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(216, 26);
            this.txt_resultado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre día de la semana";
            // 
            // frm_numericupdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_nrodia);
            this.Name = "frm_numericupdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_numericupdown";
            ((System.ComponentModel.ISupportInitialize)(this.num_nrodia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_nrodia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label2;
    }
}