namespace AT2_WFCadastro
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
        }

        private void mnsListar_Click(object sender, EventArgs e)
        {
            FormListar formListar = new FormListar();
            formListar.Show();
        }
    }
}
