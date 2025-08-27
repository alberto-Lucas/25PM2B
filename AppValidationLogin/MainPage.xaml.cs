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
            //Método de validação 1
            //ValidarCampo(txtEmail, lblValidationEmail, "admin");
            //ValidarCampo(txtSenha, lblValidationSenha, "admin");

            //Método de validação 2 usando classe
            Validation email = 
                new Validation(txtEmail, lblValidationEmail);
            Validation senha =
                new Validation(txtSenha, lblValidationSenha);

            //Agora podemos aplicar as validação personalizadas]
            //de acordo com cada campo

            bool bEmail = ValidarEmail(email);
            bool bSenha = ValidarSenha(senha);

            if (bEmail && bSenha)
                DisplayAlert("Informação",
                             "Acesso liberado.",
                             "OK");
        }

        //Método personalizado para email
        public bool ValidarEmail(Validation Email)
        {
            //Definir um resultado padrão

            bool resultado = false;

            //Validações
            if (Email.IsEmpty())
                Email.SetValidation("* Informe o Email.", true);
            else if (Email.GetText().Length < 5)
                Email.SetValidation(
                    "* Informe um email com no minimo 5 caracteres.",
                    true);
            else if (!Email.IsEqual("admin")) //negar o retorno
                Email.SetValidation("* Email inválido.");
            else
            {
                resultado = true;
                Email.HideValidation();
            }

            return resultado;
        }

        //Método personalizado para senha
        public bool ValidarSenha(Validation Senha)
        {
            //Definir um resultado padrão

            bool resultado = false;

            //Validações
            if (Senha.IsEmpty())
                Senha.SetValidation("* Informe a Senha.", true);
            else if (Senha.GetText().Length < 5)
                Senha.SetValidation(
                    "* Informe uma senha com no minimo 5 caracteres.",
                    true);
            else if (!Senha.IsEqual("admin")) //negar o retorno
                Senha.SetValidation("* Senha inválida.");
            else
            {
                resultado = true;
                Senha.HideValidation();
            }

            return resultado;
        }
    }

}
