namespace Atividade1
{
    public partial class Form1 : Form
    {

        #region Construtor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion


        #region Eventos

        private void mnuExercicio1_Click(object sender, EventArgs e)
        {
            FecharFilhosAbertos(sender, e);

            Exercicio1 frmExercicio1 = new Exercicio1();
            frmExercicio1.MdiParent = this;
            frmExercicio1.Show();
        }

        private void mnuExercicio2_Click(object sender, EventArgs e)
        {
            FecharFilhosAbertos(sender, e);

            Exercicio2 frmExercicio2 = new Exercicio2();
            frmExercicio2.MdiParent = this;
            frmExercicio2.Show();
        }

        private void mnuExercicio3_Click(object sender, EventArgs e)
        {
            FecharFilhosAbertos(sender, e);

            Exercicio3 frmExercicio3 = new Exercicio3();
            frmExercicio3.MdiParent = this;
            frmExercicio3.Show();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        #region Metodos

        private void FecharFilhosAbertos(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
        }

        #endregion
    }
}