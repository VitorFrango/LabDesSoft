using System;

namespace QuartoChines {
    class Controller {
        View view;
        Model model;
        string texto;
        bool estadoAtualDocumento = false;
        public void IniciarPrograma() {
            model = new Model(this, view);
            view = new View(this, model);
            
            view.ApresentarBoasVindas();
            view.ApresentarRotuloPrompt();
            DigitarInformacoes();
            model.Traduzir(texto);
            view.ApresentarRotuloTraducao();
            view.MostrarTraducao();
            while (estadoAtualDocumento != false)
            {
                TeclarQualquer();
                model.AvancarPagina();
            }
            view.MostrarMSGFinal();
            // ... Programa Encerrado
        }

        public void DigitarInformacoes() {
            texto = Console.ReadLine();
        }

        private void TeclarQualquer() { }

        public void TraducaoPronta(int numPaginas) { estadoAtualDocumento = true; }

        public void DocumentoTerminou() { estadoAtualDocumento = false; }    
    }
}