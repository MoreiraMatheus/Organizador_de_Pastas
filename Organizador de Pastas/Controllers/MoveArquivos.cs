using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static internal class MoveArquivos {
        static public void separar(string caminhoOrigem, string arquivo) {
            //TODO esse código não me parece nada otimizado, refatorar ele

            //Essas variáveis acredito que tem como compactar em uma coisa só, contendo as extensões, os nomes dos diretórios e as quantidades
            string[] tiposDocumentos = { ".docx", ".pdf", ".html" };
            string[] tiposMusicas = { ".mp3" };
            string[] tiposFotos = { ".jpg", ".jpeg", ".img", ".ico", ".png"};
            string[] tiposVideos = { ".mp4" };
            string[] tiposPlanilhas = { ".xlsx", ".xls", ".csv" };
            string[] tiposAplicativos = { ".exe" };

            //Desenvolver uma forma de avisar quantos arquivos foram movidos
            int quantidadeDocumentos = 0;
            int quantidadeMusicas = 0;
            int quantidadeFotos = 0;
            int quantidadeVideos = 0;
            int quantidadePlanilhas = 0;
            int quantidadeAplicativos = 0;
            int quantidadeOutros = 0;


            string extensao = "";
            extensao = BuscaArquivos.DescobreExtensao(arquivo);

            //Os ifs se repetem demais, não me parece correto para a escalabilidade ou caso o usuário queira adicionar novas pastas
            if (tiposDocumentos.Contains(extensao)) {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Documentos\\" + arquivo);
                quantidadeDocumentos++;
            }
            else if(tiposMusicas.Contains(extensao)) {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Músicas\\" + arquivo);
                quantidadeMusicas++;
            }
            else if (tiposFotos.Contains(extensao)) {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Fotos\\" + arquivo);
                quantidadeFotos++;
            }
            else if (tiposVideos.Contains(extensao)) {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Vídeos\\" + arquivo);
                quantidadeVideos++;
            }
            else if (tiposPlanilhas.Contains(extensao)) {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Planilhas\\" + arquivo);
                quantidadePlanilhas++;
            }
            else if (tiposAplicativos.Contains(extensao)) {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Aplicativos\\" + arquivo);
                quantidadeAplicativos++;
            }
            else {
                File.Move(caminhoOrigem + arquivo, caminhoOrigem + "Outros Arquivos\\" + arquivo);
                quantidadeOutros++;
            }

            //TODO adicionar função pra mover as pastas também

            string mensagem = "";
            mensagem += $"Documentos: {quantidadeDocumentos}\n";
            mensagem += $"Músicas: {quantidadeMusicas}\n";
            mensagem += $"Fotos: {quantidadeFotos}\n";
            mensagem += $"Vídeos: {quantidadeVideos}\n";
            mensagem += $"Planilhas: {quantidadePlanilhas}\n";
            mensagem += $"Aplicativos: {quantidadeAplicativos}\n";
            mensagem += $"Outros Arquivos: {quantidadeOutros}";

            //MessageBox.Show($"Arquivos movidos com sucesso!\nSendo eles:{mensagem}");
        }
    }
}