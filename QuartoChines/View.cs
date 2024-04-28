using System;

namespace QuartoChines {
    class View {
        private Controller controller;
        private Model model;

        public View(Controller c, Model m) {
            controller = c;
            model = m;
        }

        public void ApresentarBoasVindas() {
            Console.WriteLine("Bem vindo ao tradutor do Quarto Chinês!");
        }

        public void ApresentarRotuloPrompt() {
            Console.WriteLine("Digite o texto a traduzir");
            Console.Write("> ");
        }

        public void ApresentarRotuloTraducao() {
            Console.WriteLine("Texto traduzido:");
        }

        public void ApresentarRotuloTraducao(string texto) {
            // Apresentar solicitação para tradução
        }

        public void MostrarTraducao() {
            DesenharPagina(model.SolicitarPaginaAtual());
        }
        public void PaginaAtualMudou() {
            MostrarTraducao();
        }

        public void MostrarMSGFinal() {
            // Apresentar informações de término da aplicação
        }

        public void PaginaAtualMudou(bool estadoAtualDocumento) {
            // Apresentar a mensagem adequada
        }

        private void DesenharPagina(string pagina) { } //Apresenta página no ecrã e "Prima qualquer tecla"

    }
}