namespace Atividade1
{
    partial class Exercicio3
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
            txtNotaA1 = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtNotaA2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNotaA1
            // 
            txtNotaA1.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNotaA1.Location = new Point(345, 35);
            txtNotaA1.Name = "txtNotaA1";
            txtNotaA1.Size = new Size(116, 26);
            txtNotaA1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(274, 37);
            label3.Name = "label3";
            label3.Size = new Size(65, 19);
            label3.TabIndex = 9;
            label3.Text = "Nota A1:";
            // 
            // btnCalcular
            // 
            btnCalcular.AutoSize = true;
            btnCalcular.BackColor = Color.SteelBlue;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(679, 31);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 30);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(73, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(190, 26);
            txtNome.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // txtNotaA2
            // 
            txtNotaA2.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNotaA2.Location = new Point(547, 35);
            txtNotaA2.Name = "txtNotaA2";
            txtNotaA2.Size = new Size(116, 26);
            txtNotaA2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(476, 37);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 11;
            label2.Text = "Nota A2:";
            // 
            // Exercicio3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNotaA2);
            Controls.Add(label2);
            Controls.Add(txtNotaA1);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Exercicio3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNotaA1;
        private Label label3;
        private Button btnCalcular;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtNotaA2;
        private Label label2;
    }
}