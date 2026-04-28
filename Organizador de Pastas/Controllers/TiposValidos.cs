using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizador_de_Pastas.Controllers {
    static class TiposValidos {
        static internal TipoDocumento[] tiposPadroes = [
            new TipoDocumento("Documentos", [".docx", ".pdf", ".html"]),
            new TipoDocumento("Músicas", [".mp3"]),
            new TipoDocumento("Fotos", [".jpg", ".jpeg", ".img", ".ico", ".png"]),
            new TipoDocumento("Vídeos", [".mp4"]),
            new TipoDocumento("Planilhas", [".xlsx", ".xls", ".csv"]),
            new TipoDocumento("Aplicativos", [".exe"])
        ];

        static public void setTipos(TipoDocumento[] novosTipos) {
            tiposPadroes = novosTipos;
        }

        static public TipoDocumento[] getInfo() {
            return tiposPadroes;
        }

        static public List<string> getTipos() {
            List<string> tipos = [];

            foreach (TipoDocumento tipo in tiposPadroes) {
                tipos.Add(tipo.nome);
            }

            return tipos;

        }
    }
}
