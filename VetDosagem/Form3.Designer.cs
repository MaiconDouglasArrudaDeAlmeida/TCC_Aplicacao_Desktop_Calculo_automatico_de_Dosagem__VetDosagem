namespace VetDosagem
{
    partial class btnLimpar
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
            dgvHistorico = new DataGridView();
            btnLimpar_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).BeginInit();
            SuspendLayout();
            // 
            // dgvHistorico
            // 
            dgvHistorico.BackgroundColor = Color.White;
            dgvHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorico.Location = new Point(12, 12);
            dgvHistorico.Name = "dgvHistorico";
            dgvHistorico.ReadOnly = true;
            dgvHistorico.Size = new Size(776, 347);
            dgvHistorico.TabIndex = 0;
            // 
            // btnLimpar_Click
            // 
            btnLimpar_Click.Location = new Point(332, 394);
            btnLimpar_Click.Name = "btnLimpar_Click";
            btnLimpar_Click.Size = new Size(134, 23);
            btnLimpar_Click.TabIndex = 1;
            btnLimpar_Click.Text = "Limpar Tudo";
            btnLimpar_Click.UseVisualStyleBackColor = true;
            btnLimpar_Click.Click += button1_Click;
            // 
            // btnLimpar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpar_Click);
            Controls.Add(dgvHistorico);
            Name = "btnLimpar";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistorico;
        private Button btnLimpar_Click;
    }
}