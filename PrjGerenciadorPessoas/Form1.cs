using SamAlvarenga.PrjHelloWorld.Models;

namespace PrjGerenciadorPessoas

{
    public partial class Form1 : Form
    {
        //declarando class
        private Pessoa pessoa;
        //private List<Pessoa> pessoas; criando uma variável que amarzena um conjunto de similares

        List<Pessoa> pessoas = new List<Pessoa>(); // criando e declarando a variavel

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pessoa pessoinha = new Pessoa();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }


        private void btnVerPessoa_Click(object sender, EventArgs e)
        {
            //lblMensagem.Text = $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}"; msg que mostra uma pessoa



            //for (int contador = 0; contador < this.pessoas.Count; contador++)
            //{
            //    lblMensagem.Text = $"{lblMensagem.Text}\n{this.pessoas[contador].Nome.ToString()}";
            //}

            //simplificando o código com o foreach ao inves do for
            foreach (var pessoa in pessoas)
            {
                lblMensagem.Text = $"{lblMensagem.Text}\n{pessoa.Nome}";
            }

        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {

            lblMensagem.Text = String.Empty;
            try
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text); // pode lancar exeption

                pessoa = new Pessoa(nome, idade); //atribuir


                //this.pessoas = new List<Pessoa>(); criando objecto lista de pessoas
                //List<Pessoa> pessoas = new List<Pessoa>(); Declarando a variavel e criando o objeto

                this.pessoas.Add(pessoa); //Adcionando a pessoa criada na lista

                

            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.Message;
            }


            txtNome.Clear(); //Limpar a caixa 
            txtIdade.Clear();
            txtNome.Focus(); // colocar foco na caixa 

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

    }
}