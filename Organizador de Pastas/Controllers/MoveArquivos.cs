using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static internal class MoveArquivos {
        static public void separar(string arquivo, string origem) {
            string[] tiposDocumentos = { ".docx", ".pdf", ".html" };
            string[] tiposMúsicas = { ".mp3" };
            string[] tiposFotos = { ".jpg", ".jpeg", ".img", ".ico", ".png"};
            string[] tiposVídeos = { ".mp4" };
            string[] tiposPlanilhas = { ".xlsx", ".xls", ".csv" };

            string extensao = "";
            extensao = BuscaArquivos.DescobreExtensao(arquivo);

            if (tiposDocumentos.Contains(extensao)) {
                //TODO terminar essa lógica aqui
                File.Move("C:\\Users\\famil\\Downloads\\Extrato_06_04_2026.pdf", "C:\\Users\\famil\\Downloads\\Documentos\\Extrato_06_04_2026.pdf");
            }

        }
    }
}
