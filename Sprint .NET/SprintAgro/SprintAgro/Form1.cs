using MySqlConnector;

namespace SprintAgro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCultivo.Text.Equals("") && !txtClima.Text.Equals("") && !txtEstacaoAno.Text.Equals("") && !txtFertilizante.Text.Equals(""))
                {
                    CadastroAgricultura cadAgro = new CadastroAgricultura();
                    cadAgro.Cultivo = txtCultivo.Text;
                    cadAgro.Clima = txtClima.Text;
                    cadAgro.EstacaoAno = txtEstacaoAno.Text;
                    cadAgro.Fertilizante = txtFertilizante.Text;

                    if (cadAgro.cadastrarAgro())
                    {
                        MessageBox.Show($"A agricultura {cadAgro.Cultivo} foi cadastrada com sucesso!");
                        txtCultivo.Clear();
                        txtClima.Clear();
                        txtEstacaoAno.Clear();
                        txtFertilizante.Clear();
                        txtCultivo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel cadastrar agricultura");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente");
                    txtCultivo.Clear();
                    txtClima.Clear();
                    txtEstacaoAno.Clear();
                    txtFertilizante.Clear();
                    txtCultivo.Focus();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastrar agricultura" + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCultivo.Text.Equals(""))
                {
                    CadastroAgricultura cadAgri = new CadastroAgricultura();
                    cadAgri.Cultivo = txtCultivo.Text;

                    MySqlDataReader reader = cadAgri.localizarAgricultura();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblid.Text = reader["id"].ToString();
                            lblid.Text = reader["fertilizante"].ToString();
                            lblid.Text = reader["estacaoAno"].ToString();
                            lblid.Text = reader["clima"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cultivo nao encontrado");
                            txtCultivo.Clear();
                            txtClima.Clear();
                            txtEstacaoAno.Clear();
                            txtFertilizante.Clear();
                            txtCultivo.Focus();
                            lblid.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cultivo nao encontrado");
                        txtCultivo.Clear();
                        txtClima.Clear();
                        txtEstacaoAno.Clear();
                        txtFertilizante.Clear();
                        txtCultivo.Focus();
                        lblid.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo cultivo para realizar a pesquisa");
                    txtCultivo.Clear();
                    txtClima.Clear();
                    txtEstacaoAno.Clear();
                    txtFertilizante.Clear();
                    txtCultivo.Focus();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao encontrar cultivo" + ex.Message);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCultivo.Equals("") && !txtClima.Equals("") && !txtEstacaoAno.Equals("") && !txtFertilizante.Equals(""))
                {
                    CadastroAgricultura cadastroAgricultura = new CadastroAgricultura();
                    cadastroAgricultura.Id = int.Parse(lblid.Text);
                    cadastroAgricultura.Clima = txtClima.Text;
                    cadastroAgricultura.Cultivo = txtCultivo.Text;

                    if (cadastroAgricultura.atualizarAgricultura())
                    {
                        MessageBox.Show("Os dados foram atualizados com sucesso");
                        txtCultivo.Clear();
                        txtClima.Clear();
                        txtEstacaoAno.Clear();
                        txtFertilizante.Clear();
                        txtCultivo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel atualizar os dados");
                        txtCultivo.Clear();
                        txtClima.Clear();
                        txtEstacaoAno.Clear();
                        txtFertilizante.Clear();
                        txtCultivo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar cultivo que deseja atualizar as informacoes");
                    txtCultivo.Clear();
                    txtClima.Clear();
                    txtEstacaoAno.Clear();
                    txtFertilizante.Clear();
                    txtCultivo.Focus();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao atualizar dados do cultivo" + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCultivo.Equals("") && !txtClima.Equals("") && !txtEstacaoAno.Equals("") && !txtFertilizante.Equals(""))
                {
                    CadastroAgricultura cadastroAgricultura = new CadastroAgricultura();
                    cadastroAgricultura.Id = int.Parse(lblid.Text);

                    if (cadastroAgricultura.deletarAgricultura())
                    {
                        MessageBox.Show("A agricultura foi excluido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Nao foi possivel excluir agricultura");
                        txtCultivo.Clear();
                        txtClima.Clear();
                        txtEstacaoAno.Clear();
                        txtFertilizante.Clear();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar qual agricultura deseja excluir");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao excluir agricultura" + ex.Message);
            }
        }
    }
}
