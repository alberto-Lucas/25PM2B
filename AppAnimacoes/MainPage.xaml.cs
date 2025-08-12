namespace AppAnimacoes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnGirarDireita_Clicked(object sender, EventArgs e)
        {
            //Iremos aplicar a animção de girar a imagem
            //no sentido horario seguindo os ponteiros
            //do relogio, para isso precisamos
            //definir a quantidade de graus a ser girado
            //e o tempo para realizar a animação
            //OBS: o tempo é medido em milisegundos
            //ou seja 1 segundo é igual a 1000 milisegundos
            //Animações de rotação é recomendo resetar a posição
            //da animação antes de rotacionar

            imgTeste.Rotation = 0;
            imgTeste.RotateTo(360, 2000);
        }

        private void btnGirarEsquerda_Clicked(object sender, EventArgs e)
        {
            imgTeste.Rotation = 0;
            imgTeste.RotateTo(-360, 500);
        }

        private void btnGirarHorizontal_Clicked(object sender, EventArgs e)
        {
            //Amição de rotação sobre eixo horizontal
            //Eixo X
            imgTeste.RotationX = 0;
            imgTeste.RotateXTo(360, 1000);
        }

        private void btnGirarVertical_Clicked(object sender, EventArgs e)
        {
            //Amição de rotação sobre eixo horizontal
            //Eixo Y
            imgTeste.RotationY = 0;
            imgTeste.RotateYTo(360, 3000);
        }

        private void btnZoomMais_Clicked(object sender, EventArgs e)
        {
            //A animação de Escala(zoom) ela resata aumtomatiamente
            //a escala da imagem, ou o zoom sera aplicado
            //sempre da escala 0, para um conjunto de zoom
            //é preciso aplicar o zoom, sobre a escala atual
            imgTeste.ScaleTo(imgTeste.Scale + 0.5, 250);
        }

        private void btnZoomMenos_Clicked(object sender, EventArgs e)
        {
            imgTeste.ScaleTo(imgTeste.Scale - 0.5, 250);
        }

        private void btnTremer_Clicked(object sender, EventArgs e)
        {
            Tremer(50);
        }

        //Criar um método utilizando animação
        //de movimentação para simular o efeito de tremida
        async void Tremer(uint tempo)
        {
            //Para o efeito de tremida
            //irei mover para a direita e mesma quantidade
            //para esquerda, diminuindo o valor a cada ciclo

            //Primeiro parametro qunatidade de pixel horizontal
            //Segundo parametro quantidade de pixel vertical
            //Terceiro parametro o tempo da animação

            //A animação de movimentação realizar um resete
            //automatico da posição
            await imgTeste.TranslateTo(15, 0, tempo);
            await imgTeste.TranslateTo(-15, 0, tempo);
            await imgTeste.TranslateTo(10, 0, tempo);
            await imgTeste.TranslateTo(-10, 0, tempo);
            await imgTeste.TranslateTo(5, 0, tempo);
            await imgTeste.TranslateTo(-5, 0, tempo);
            imgTeste.TranslationX = 0;
        }

        private async void btnFade_Clicked(object sender, EventArgs e)
        {
            //O efeito de opacidade tem apenas 2 valores
            //1 = totalmente solido
            //0 = totalmente transparente

            imgTeste.Opacity = 1;
            await imgTeste.FadeTo(0, 1000);

            imgTeste.Opacity = 0;
            await imgTeste.FadeTo(1, 1000);
        }
    }
}
