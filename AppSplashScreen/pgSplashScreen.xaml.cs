namespace AppSplashScreen;

public partial class pgSplashScreen : ContentPage
{
	public pgSplashScreen()
	{
		InitializeComponent();

		AnimateImage();
	}

	//Criar um método para animar a imagem
	//da tela de splashscreen
	async void AnimateImage()
	{
		//No primeiro iremos aplicar uma 
		//animação de giro(sentido do relogio)

		//Aplicar um delay de 2 segundos
		await Task.Delay(2000);
		//Precisamos resetar a posição da imagem
		imgSplash.Rotation = 0;
		//Animação de giro completo no sentido horario
		imgSplash.RotateTo(360, 3000);
		//resetar a posição
		imgSplash.Rotation = 0;
		//Aplicar mais uma espera
		await Task.Delay(1000);

        //Iremo aplicar a segunda parte da animação
        //onde aplicaremos um conjunto de escalas(zoom)

        //Iremos aplicar um zoom na imagem
        //Easing.Linear suaviza a animação
        await imgSplash.ScaleTo(1.5, 2000, Easing.Linear);
        //Retornar a imagem para o tamanho original
        await imgSplash.ScaleTo(1, 1500, Easing.Linear);
        //Irei aplicar um zoom wide reduzindo o tamanho 
        //da imagem
        await imgSplash.ScaleTo(0.5, 1000, Easing.Linear);
        //Por ultimo aplicar animação de explosão(zoom infinito)
        await imgSplash.ScaleTo(150, 1000, Easing.Linear);

		//Iremos chamar a tela principal
		Application.Current.MainPage =
			new NavigationPage(new MainPage());
    }
}