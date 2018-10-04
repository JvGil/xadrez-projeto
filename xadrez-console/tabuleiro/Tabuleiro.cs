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

        public Peca peca(Posicao pos) {
            // Classe de sobrecarga para obter uma peca pela Posicao
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos) {
            // Verifica se existe uma peça em determinada posição
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) {
            // Coloca a peca indicada no lugar que foi passado
            if (existePeca(pos))
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos) {
            if (peca(pos) == null)
                return null;
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos) {
            // Valida posição indicada
            if (pos.linha<0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna>=colunas)
                return false;
            return true;
        }

        public void validarPosicao(Posicao pos) {
            // Lança uma mensagem de exceção caso posição seja inválida
            if (!posicaoValida(pos))
                throw new TabuleiroException("Posição inválida!");
        }
    }
}
