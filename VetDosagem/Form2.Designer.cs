namespace VetDosagem
{
    partial class Form2
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
            label1 = new Label();
            lblResultadoFinal = new Label();
            btnVoltar = new Button();
            pnlGrafico = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 20);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 0;
            label1.Text = "Volume a ser Administrado";
            // 
            // lblResultadoFinal
            // 
            lblResultadoFinal.AutoSize = true;
            lblResultadoFinal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoFinal.ForeColor = Color.Red;
            lblResultadoFinal.Location = new Point(27, 69);
            lblResultadoFinal.Name = "lblResultadoFinal";
            lblResultadoFinal.Size = new Size(121, 45);
            lblResultadoFinal.TabIndex = 1;
            lblResultadoFinal.Text = "0.00ml";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(27, 141);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(170, 23);
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar / Novo Cálculo";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // pnlGrafico
            // 
            pnlGrafico.Location = new Point(223, 248);
            pnlGrafico.Name = "pnlGrafico";
            pnlGrafico.Size = new Size(340, 180);
            pnlGrafico.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(pnlGrafico);
            Controls.Add(btnVoltar);
            Controls.Add(lblResultadoFinal);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultadoFinal;
        private Button btnVoltar;
        private Panel pnlGrafico;
    }
}