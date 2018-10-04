namespace tabuleiro {
    abstract class Peca {

        // Classe para indicar o que é uma peça

        // Iniciando váriaveis
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //Instanciando classe
        public Peca(Tabuleiro tab, Cor cor) {
            posicao = null;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0; //Quando jogo é iniciado, a peça não tem nenhum movimento
        }

        public void incrementarQteMovimentos() {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
