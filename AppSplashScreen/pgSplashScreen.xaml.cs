namespace AppSplashScreen;

public partial class pgSplashScreen : ContentPage
{
	public pgSplashScreen()
	{
		InitializeComponent();

		AnimateImage();
	}

	//Criar um m�todo para animar a imagem
	//da tela de splashscreen
	async void AnimateImage()
	{
		//No primeiro iremos aplicar uma 
		//anima��o de giro(sentido do relogio)

		//Aplicar um delay de 2 segundos
		await Task.Delay(2000);
		//Precisamos resetar a posi��o da imagem
		imgSplash.Rotation = 0;
		//Anima��o de giro completo no sentido horario
		imgSplash.RotateTo(360, 3000);
		//resetar a posi��o
		imgSplash.Rotation = 0;
		//Aplicar mais uma espera
		await Task.Delay(1000);

        //Iremo aplicar a segunda parte da anima��o
        //onde aplicaremos um conjunto de escalas(zoom)

        //Iremos aplicar um zoom na imagem
        //Easing.Linear suaviza a anima��o
        await imgSplash.ScaleTo(1.5, 2000, Easing.Linear);
        //Retornar a imagem para o tamanho original
        await imgSplash.ScaleTo(1, 1500, Easing.Linear);
        //Irei aplicar um zoom wide reduzindo o tamanho 
        //da imagem
        await imgSplash.ScaleTo(0.5, 1000, Easing.Linear);
        //Por ultimo aplicar anima��o de explos�o(zoom infinito)
        await imgSplash.ScaleTo(150, 1000, Easing.Linear);

		//Iremos chamar a tela principal
		Application.Current.MainPage =
			new NavigationPage(new MainPage());
    }
}