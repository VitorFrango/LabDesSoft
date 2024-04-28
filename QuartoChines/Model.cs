using System;

namespace QuartoChines {
    class Model {
        private Controller controller;
        private View view;
        int nPaginas=0;
        String traducao;

        public Model(Controller c, View v) {
            controller = c;
            view = v;
        }

        public void Traduzir(string texto) {
            // Guardar o texto para ser traduzido para o chinês
            controller.TraducaoPronta(nPaginas);
        }
        public String SolicitarPaginaAtual() {
            // Devolver o texto traduzido, virá a ser só a página atual
            return traducao;
        }
        public void AvancarPagina() {
            if (PaginaAtualIncrementa())
                view.PaginaAtualMudou();
            else
                controller.DocumentoTerminou();
        }

        private bool PaginaAtualIncrementa() { return false; } //Verificar páginas
    }
}