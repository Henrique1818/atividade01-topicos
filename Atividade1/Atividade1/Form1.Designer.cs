namespace Atividade1
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
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            mnuExercicio1 = new ToolStripMenuItem();
            mnuExercicio2 = new ToolStripMenuItem();
            mnuExercicio3 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuExercicio1, mnuExercicio2, mnuExercicio3, toolStripSeparator1, mnuSair });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mnuExercicio1
            // 
            mnuExercicio1.Name = "mnuExercicio1";
            mnuExercicio1.Size = new Size(180, 22);
            mnuExercicio1.Text = "Exercício 1";
            mnuExercicio1.Click += mnuExercicio1_Click;
            // 
            // mnuExercicio2
            // 
            mnuExercicio2.Name = "mnuExercicio2";
            mnuExercicio2.Size = new Size(180, 22);
            mnuExercicio2.Text = "Exercício 2";
            mnuExercicio2.Click += mnuExercicio2_Click;
            // 
            // mnuExercicio3
            // 
            mnuExercicio3.Name = "mnuExercicio3";
            mnuExercicio3.Size = new Size(180, 22);
            mnuExercicio3.Text = "Exercício 3";
            mnuExercicio3.Click += mnuExercicio3_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // mnuSair
            // 
            mnuSair.Name = "mnuSair";
            mnuSair.Size = new Size(180, 22);
            mnuSair.Text = "Sair";
            mnuSair.Click += mnuSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atividade 1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem mnuExercicio1;
        private ToolStripMenuItem mnuExercicio2;
        private ToolStripMenuItem mnuExercicio3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuSair;
    }
}