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
    }
}
