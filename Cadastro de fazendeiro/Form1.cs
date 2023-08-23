namespace Cadastro_de_fazendeiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Fazendeiro f = new Fazendeiro();
                f.Nome = Convert.ToString(nome.Text);
                f.Idade = Convert.ToInt32(idade.Text);
                string cpf1 = cpf.Text;
                f.PropriedadeR = Convert.ToDouble(propriedadeR.Text);
                f.CabecaG = Convert.ToInt32(cabecaG.Text);
                string C = cnpj.Text;
                label9.Text = f.MarcaGado(f.Nome);
                MessageBox.Show("CNPJ: " + ValidaCNPJ.IsCnpj(C).ToString());
                MessageBox.Show("CPF: " + Validacoes.ValidaCPF(cpf1).ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show(" ajasbhashas: "+ ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nome.Clear();
            idade.Clear();
            cpf.Clear();
            cnpj.Clear();
            propriedadeR.Clear();
            cabecaG.Clear();
           
        }

        private void cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}