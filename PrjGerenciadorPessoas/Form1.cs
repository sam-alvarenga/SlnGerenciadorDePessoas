using SamAlvarenga.PrjHelloWorld.Models;
using System.Reflection;

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
            lstPessoas.DisplayMember = "Nome";

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

            ////simplificando o código com o foreach ao inves do for
            ///mostrando a mensagem no label
            //foreach (var pessoa in pessoas)
            //{
            //    lblMensagem.Text = $"{lblMensagem.Text}\n{pessoa.Nome}";
            //}

            MessageBox.Show($"Nome: {pessoa.Nome}\nIdade: {pessoa.getIdadeFormatada()}", "Detalhes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {


            lblMensagem.Text = String.Empty;
            try
            {
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text); // pode lancar exeption

                pessoa = new Pessoa(nome, idade); //atribuir
                lstPessoas.Items.Add(pessoa); //Adicionando a pessoa criada na listbox


                //this.pessoas = new List<Pessoa>(); criando objecto lista de pessoas
                //List<Pessoa> pessoas = new List<Pessoa>(); Declarando a variavel e criando o objeto
                //this.pessoas.Add(pessoa); //Adicionando a pessoa criada na lista



            }
            //duvida try
            catch (FormatException)
            {
                MessageBox.Show("Apenas números podem ser utilizados no campo idade!", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
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

        private void lstPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnExcluir.Enabled = true;

            if (lstPessoas.SelectedItem != null)
            {
                this.pessoa = (Pessoa)lstPessoas.SelectedItem; //Casting
                txtNome.Text = this.pessoa.Nome;
                txtIdade.Text = this.pessoa.Idade.ToString();
            }
        }

        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //if (lstPessoas.SelectedItem == null)
            //{
            //    MessageBox.Show("Não há itens selecionados na lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //else{}

            DialogResult apagarDaLista = MessageBox.Show($"Tem certeza que deseja excluir {lstPessoas.SelectedItem.ToString()} da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (apagarDaLista == DialogResult.Yes)
            {
                lstPessoas.Items.Remove(lstPessoas.SelectedItem); //Remover pessoa da lisBox
                lstPessoas.SelectedItem = null; //remover da lista de pessoas 

                txtNome.Clear();
                txtIdade.Clear();
                txtNome.Focus();

                //duvida
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = false;
                btnVerPessoa.Enabled = false;
            }


        }

        //BOTÃO DE ATUALIZAR E SALVAR PESSOA
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (lstPessoas.SelectedItem != null)
            {
                this.pessoa = (Pessoa)lstPessoas.SelectedItem; //casting
                this.pessoa.Nome = txtNome.Text;
                this.pessoa.Idade = Convert.ToInt32(txtIdade.Text);
                lstPessoas.Items[lstPessoas.SelectedIndex] = this.pessoa;

                txtNome.Clear();
                txtIdade.Clear();
                txtNome.Focus();

                lstPessoas.SelectedItem = null;
                btnSalvar.Enabled = false;
                btnExcluir.Enabled = false;

                MessageBox.Show(" Dados atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //BOTÃO LIMPAR CAIXAS DADOS DA PESSOAS
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult ApagarLista = MessageBox.Show("Tem certeza que deseja limpar a lista de pessoas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (ApagarLista == DialogResult.Yes)
            {
                lstPessoas.Items.Clear();

                txtIdade.Clear();
                txtNome.Clear();
                txtNome.Focus();

                btnSalvar.Enabled = false;
                btnVerPessoa.Enabled = false;
                btnExcluir.Enabled = false;
            }

        }

        private void btnExcluirLista_Click(object sender, EventArgs e)
        {

        }
    }
}