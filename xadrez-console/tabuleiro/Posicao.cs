namespace tabuleiro {
    class Posicao {

        // Classe que irá indicar posição das peças no tabuleiro

        // Iniciando váriaveis
        public int linha { get; set; }
        public int coluna { get; set; }

        // Instanciando a classe
        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public void definirValores(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public override string ToString() {
            return linha
                + ", "
                + coluna;
        }
    }
}
