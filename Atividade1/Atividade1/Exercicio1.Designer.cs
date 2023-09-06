namespace Atividade1
{
    partial class Exercicio1
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
            txtNome = new TextBox();
            btnCalcular = new Button();
            label2 = new Label();
            txtIdade = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(378, 51);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(312, 73);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(190, 26);
            txtNome.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.AutoSize = true;
            btnCalcular.BackColor = Color.SteelBlue;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(367, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 30);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(281, 9);
            label2.Name = "label2";
            label2.Size = new Size(257, 29);
            label2.TabIndex = 3;
            label2.Text = "Converter idade em dias";
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(345, 137);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(113, 26);
            txtIdade.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(378, 115);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 4;
            label3.Text = "Idade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(367, 263);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 6;
            label4.Text = "Resultado:";
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.LightSlateGray;
            lblResultado.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.ForeColor = Color.White;
            lblResultado.Location = new Point(312, 298);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(190, 88);
            lblResultado.TabIndex = 7;
            // 
            // Exercicio1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(label4);
            Controls.Add(txtIdade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCalcular);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Exercicio1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtIdade;
        private Label label3;
        private Label label4;
        private Label lblResultado;
    }
}