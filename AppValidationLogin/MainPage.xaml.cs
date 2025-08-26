namespace AppValidationLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Método para aplicar uma animação de tremida
        //no campo entry
        async void TremerEntry(Entry txtCampo)
        {
            //definir um tempo padrão
            uint tempo = 50;

            await txtCampo.TranslateTo(-15, 0, tempo);
            await txtCampo.TranslateTo(15, 0, tempo);
            await txtCampo.TranslateTo(-10, 0, tempo);
            await txtCampo.TranslateTo(10, 0, tempo);
            await txtCampo.TranslateTo(-5, 0, tempo);
            await txtCampo.TranslateTo(5, 0, tempo);
            txtCampo.TranslationX = 0;
        }

        void ValidarCampo(
            Entry txtCampo, Label lblValidation, string valor)
        {
            if(string.IsNullOrEmpty(txtCampo.Text))
            {
                TremerEntry(txtCampo);
                lblValidation.IsVisible = true;
            }
            else if (txtCampo.Text != valor)
            {
                TremerEntry(txtCampo);
                lblValidation.IsVisible = true;
            }
            else
                lblValidation.IsVisible = false;
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            ValidarCampo(txtEmail, lblValidationEmail, "admin");
            ValidarCampo(txtSenha, lblValidationSenha, "admin");
        }
    }

}
