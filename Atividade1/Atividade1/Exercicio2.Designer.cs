namespace Atividade1
{
    partial class Exercicio2
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
            label3 = new Label();
            btnCalcular = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtSalario = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(292, 31);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 9;
            label3.Text = "Salário:";
            // 
            // btnCalcular
            // 
            btnCalcular.AutoSize = true;
            btnCalcular.BackColor = Color.SteelBlue;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(694, 26);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 30);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(78, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(190, 26);
            txtNome.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // txtSalario
            // 
            txtSalario.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalario.Location = new Point(355, 29);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(101, 26);
            txtSalario.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(569, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 26);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(474, 31);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 11;
            label2.Text = "Nº de filhos:";
            // 
            // Exercicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtSalario);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Exercicio2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label3;
        private Button btnCalcular;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtSalario;
        private Label label2;
    }
}