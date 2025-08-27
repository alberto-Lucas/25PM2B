using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValidationLogin
{
    public class Validation
    {
        //Definir as propriedades referente
        //ao nosso PAR de componentes
        private Entry EntryCampo {  get; set; }
        private Label LabelValidation { get; set; }

        //Criar o construtor da classe
        //para vincular os componentes as propriedades
        public Validation(Entry txtCampo, Label lblValidation) 
        { 
            EntryCampo = txtCampo;
            LabelValidation = lblValidation;
        }

        //Método para retornar o conteudo do Entry
        public string GetText()
        {
            return EntryCampo.Text;
        }

        //Método para validar se o valor é igual
        public bool IsEqual(string valor)
        {
            return EntryCampo.Text == valor;
        }

        //Método que verifica se está vazio
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(EntryCampo.Text);
        }

        //Método para definir o texto do validation
        public void SetValidation(string mensagem)
        {
            LabelValidation.Text = mensagem;
            LabelValidation.IsVisible = true;
        }

        //Método de sobrecarga para aplicar animação de tremida
        public void SetValidation(string mensagem, bool isTremer)
        {
            if (isTremer)
                Animation.Tremer(EntryCampo);
            SetValidation(mensagem);
        }

        //Método para ocultar o Validation
        public void HideValidation()
        {
            LabelValidation.IsVisible = false;
        }
    }
}
