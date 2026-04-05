using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static internal class Organizador {
        static public void OrganizaPastas(string caminho, string pasta) {
            string[] pastasDoPrograma = { "Documentos", "Músicas", "Fotos", "Vídeos", "Planilhas", "Aplicativos", "Outros Arquivos", "Pastas" };
            if (!pastasDoPrograma.Contains(pasta)) {
                try {
                    Directory.Move(caminho + pasta, caminho + "Pastas\\" + pasta);
                    MessageBox.Show("Pasta movida");
                }
                catch (Exception e) {
                    MessageBox.Show($"Não foi possível mover a pasta pelo seguinte motivo:\n{e.ToString()}");
                }
            }
        }

        static public void OrganizaArquivos(string caminho, string arquivo) {
            //TODO Desenvolver uma forma de avisar quantos arquivos foram movidos
            TipoDocumento[] tiposValidos = {
                new TipoDocumento("Documentos", [".docx", ".pdf", ".html"]),
                new TipoDocumento("Músicas", [".mp3"]),
                new TipoDocumento("Fotos", [".jpg", ".jpeg", ".img", ".ico", ".png"]),
                new TipoDocumento("Vídeos", [".mp4"]),
                new TipoDocumento("Planilhas", [".xlsx", ".xls", ".csv"]),
                new TipoDocumento("Aplicativos", [".exe"])
            };

            foreach (TipoDocumento tipo in tiposValidos) {
                if (tipo.validaExtensao(arquivo)) {
                    try {
                        File.Move(caminho+ arquivo, caminho+ tipo.nome + "\\" + arquivo);
                    }
                    catch (Exception e) {
                        MessageBox.Show($"Não foi possível mover o arquivo {arquivo} para a pasta {tipo.nome} pelo seguinte motivo:\n{e.ToString()}");
                    }
                    break;
                }
            };

            if (File.Exists(caminho+ arquivo)) {
                try {
                    File.Move(caminho + arquivo, caminho + "Outros Arquivos\\" + arquivo);
                }
                catch (Exception e) {
                    MessageBox.Show($"Não foi possível mover o arquivo {arquivo} para a pasta Outros Arquivos pelo seguinte motivo:\n{e.ToString()}");
                }
            };
        }
    }
}