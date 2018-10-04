namespace tabuleiro {
    class Tabuleiro {

        // Classe para indicar o que é um tabuleiro

        // Iniciando váriaveis
        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        // Instanciando a classe
        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }
    }
}
