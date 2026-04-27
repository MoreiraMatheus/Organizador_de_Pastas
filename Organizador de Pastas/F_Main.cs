using Organizador_de_Pastas.Controllers;

namespace Organizador_de_Pastas
{
    public partial class F_Main : Form {
        public F_Main() {
            InitializeComponent();
            //TODO ao iniciar o formulário carregar as opções de pastas que o usuário terá para criar na guia de configurações
        }

        private void btn_selecionar_pasta_Click(object sender, EventArgs e) {
            fbd_Bucasdor.ShowDialog();
            tb_caminho.Text = fbd_Bucasdor.SelectedPath + "\\";
        }

        private void btn_organizar_Click(object sender, EventArgs e) {
            string caminho = tb_caminho.Text;
            List<string> pastas = BuscaPastas.Consulta(caminho);
            List<string> arquivos = BuscaArquivos.Consulta(caminho);

            CriaPastas.Criar(caminho);

            for (int i = 0; i < pastas.Count; i++) {
                Organizador.OrganizaPastas(caminho, pastas[i]);
            }
            for (int i = 0; i < arquivos.Count; i++) {
                Organizador.OrganizaArquivos(caminho, arquivos[i]);
            }

            MessageBox.Show("Feito!");
        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_caminho.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, EventArgs e) {
            TiposValidos.atualizaTipos();
            
        }
    }
}
