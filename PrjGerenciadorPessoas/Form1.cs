using SamAlvarenga.PrjHelloWorld.Models;
using Newtonsoft.Json;
using System.Windows.Forms;
//using System.Text.Json;

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
            lstPessoas.DisplayMember = "Nome";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFormatoRelatorio.Text = "TXT";
            


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

                ResetForm();

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

                ResetForm();


                MessageBox.Show(" Dados atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //BOTÃO LIMPAR CAIXAS DADOS DA PESSOAS
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnExcluirLista_Click(object sender, EventArgs e)
        {
            DialogResult ApagarLista = MessageBox.Show("Tem certeza que deseja limpar a lista de pessoas?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

            if (ApagarLista == DialogResult.Yes)
            {
                lstPessoas.Items.Clear();

                ResetForm();
            }

        }

        private void ResetForm()
        {
            txtIdade.Clear();
            txtNome.Clear();
            txtNome.Focus();

            lstPessoas.SelectedItem = null; //desmarcando a seleção 
            btnSalvar.Enabled = false;  //deixar inativo o botão
            btnVerPessoa.Enabled = false; //deixar inativo o botão
            btnExcluir.Enabled = false; //deixar inativo o botão
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            /* gerarRelatorioLista()*/

            //File.WriteAllText("relatorio/relatorio.txt", conteudoArquivo);
            //string conteudoArquivo = $"Nome: {this.pessoa.Nome} - Idade: {this.pessoa.getIdadeFormatada()}";


            try
            {
                if (cmbFormatoRelatorio.Text == "TXT")
                {
                    //abrindo um arquivo dentro da pasta
                    gerarRelatorio(SerializarParaTxt());
                    //gerarRelatorio(conteudoArquivo);

                    ResetForm();

                }
                else
                {
                    gerarRelatorio(SerializarParajson());
                    

                }
     
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void gerarRelatorio(string conteudo)
        {
            try
            {
                //string pastaRelatorio = "relatorio";

                Directory.CreateDirectory("relatorio"); //Criando nova pasta fixa do Relatório

                SaveFileDialog salvandoArquivo = new SaveFileDialog();

                salvandoArquivo.Filter = "Arquivos de Texto (*.txt)|*.txt";

                if (salvandoArquivo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvandoArquivo.FileName, conteudo);

                    
                }

               // File.WriteAllText("relatorio/relatorio.txt", conteudo);
                

                MessageBox.Show($"Relatório gerado com sucesso no formato {cmbFormatoRelatorio.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            //catch (DirectoryNotFoundException ex)
            //{

            //    MessageBox.Show("Houve um erro na criação do relatório. Pasta não encontrada!");
            //}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Gerando relatorio em lista
        private string SerializarParaTxt()
        {

            //lstPessoas.Items //total de pessoas
            //laço de repetição
            Pessoa pessoa;
            string linha = "";


            for (int i = 0; i < lstPessoas.Items.Count; i++)
            {
                pessoa = (Pessoa)lstPessoas.Items[i];//casting
                linha = $"{linha}" + $"{pessoa.Nome} - {pessoa.getIdadeFormatada()}\n";
            }
            return linha;



            //File.WriteAllText("relatorio/relatorio.txt", linha);


            //MessageBox.Show("Relatório gerado com sucesso!", "Info",
            //    MessageBoxButtons.OK, MessageBoxIcon.Information);

            //ResetForm();
        }

        private string SerializarParajson()
        {

            //lstPessoas.Items //total de pessoas
            //laço de repetição

            string json = "";
            Pessoa pessoa;


            //List<Pessoa> listaPessoas: declarando uma variável do tipo lista de pessoas
            // new List<Pessoa>();: instanciando uma lista de pessoas e atribuindo à variável
            List<Pessoa> listaPessoas = new List<Pessoa>();

            for (int i = 0; i < lstPessoas.Items.Count; i++)
            {
                pessoa = (Pessoa)lstPessoas.Items[i];
                listaPessoas.Add(pessoa);
            }

            // Formatting.Indented: no pacote newtonsolf é usado para fazer a indetação
            //serializando o objeto(listaPessoas) em Json 
            json = JsonConvert.SerializeObject(listaPessoas, Formatting.Indented); 


            return json;



        }

    }
}