namespace VetDosagem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtDose = new TextBox();
            txtConcentracao = new TextBox();
            btnCalcular = new Button();
            btnVerHistorico = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Peso do Animal (kg):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 1;
            label2.Text = "Dose Recomendada (mg/ml):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 112);
            label3.Name = "label3";
            label3.Size = new Size(197, 15);
            label3.TabIndex = 2;
            label3.Text = "Concentração de Farmaco (mg/ml):";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(237, 26);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 3;
            // 
            // txtDose
            // 
            txtDose.Location = new Point(237, 68);
            txtDose.Name = "txtDose";
            txtDose.Size = new Size(100, 23);
            txtDose.TabIndex = 4;
            // 
            // txtConcentracao
            // 
            txtConcentracao.Location = new Point(237, 114);
            txtConcentracao.Name = "txtConcentracao";
            txtConcentracao.Size = new Size(100, 23);
            txtConcentracao.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(247, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnVerHistorico
            // 
            btnVerHistorico.Location = new Point(628, 415);
            btnVerHistorico.Name = "btnVerHistorico";
            btnVerHistorico.Size = new Size(151, 23);
            btnVerHistorico.TabIndex = 7;
            btnVerHistorico.Text = "VER HISTÓRICO";
            btnVerHistorico.UseVisualStyleBackColor = true;
            btnVerHistorico.Click += btnVerHistorico_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerHistorico);
            Controls.Add(btnCalcular);
            Controls.Add(txtConcentracao);
            Controls.Add(txtDose);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtDose;
        private TextBox txtConcentracao;
        private Button btnCalcular;
        private Button btnVerHistorico;
    }
}
