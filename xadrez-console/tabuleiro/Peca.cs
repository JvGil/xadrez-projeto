namespace tabuleiro {
    class Peca {

        // Classe para indicar o que é uma peça

        // Iniciando váriaveis
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //Instanciando classe
        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            qteMovimentos = 0; //Quando jogo é iniciado, a peça não tem nenhum movimento
        }
    }
}
