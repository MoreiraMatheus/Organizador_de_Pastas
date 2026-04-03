using Organizador_de_Pastas.Controllers;

namespace Organizador_de_Pastas
{
    public partial class F_Main : Form {
        public F_Main() {
            InitializeComponent();
        }

        private void btn_selecionar_pasta_Click(object sender, EventArgs e) {
            fbd_Bucasdor.ShowDialog();
            tb_caminho.Text = fbd_Bucasdor.SelectedPath;
        }

        private void btn_organizar_Click(object sender, EventArgs e) {
            //Buscar por pastas para colocar os arquivos
            List<string> pastas = BuscaPastas.Consulta(tb_caminho.Text);

            //se não tiver pastas para os arquivos deverá criar
            CriaPastas.Criar(tb_caminho.Text + "\\");

            //Varrer os arquivos um por um e pegar suas estensões
            List<string> arquivos = BuscaArquivos.Consulta(tb_caminho.Text + "\\");
            string mensagem = "";
            mensagem += $"Foram encontrados {arquivos.Count} arquivos, sendo eles:\n";

            List<string> documentos = new List<string>();
            foreach (string documento in arquivos) {
                string extensao = BuscaArquivos.DescobreExtensao(documento);
                if(extensao == ".docx" || extensao == ".pdf" || extensao == ".html"){
                    documentos.Add(documento);
                }
            }



            //Mover os arquivos para as pastas designadas
            MoveArquivos.separar(documentos[0], tb_caminho.Text + "\\");
            MessageBox.Show("arquivo movido");
                //Documentos (docx, pdf, html)
                //Músicas (mp3)
                //Fotos (jpg, jpeg, img, ico, png)
                //Vídeos (mp4)
                //Planilhas (xlsx, xls, csv)
                //Pastas
                //Outros arquivos 

        }

        private void btn_limpar_Click(object sender, EventArgs e) {
            tb_caminho.Text = string.Empty;
        }
    }
}
