using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppValidationLogin
{
    //Tranformar a classe em estatica
    //pois não é nescessario realizar instancia
    //de classe static
    //Quando a classe é static, obrigatoriamente
    //todos os seus métodos tambem devem ser
    //static
    public static class Animation
    {
        //Criar um método generico
        //para aplicar animação de tremida
        //em componenentes visuais (usuario ve)
        static public async void Tremer(VisualElement elemento)
        {
            //Validar se o componente não é nullo
            //ou seja se ele existe
            if (elemento == null)
                return; //abortar a rotina

            //tempo padrão
            uint tempo = 50;

            //Lista de deslocamento (quantidade de movimentação)
            var lista = new[] {-15, 15, -10, 10, -5, 5 };

            //Loop na lista e a animação
            foreach (var deslocamento in lista)
            {
                await elemento.TranslateTo(deslocamento, 0, tempo); ;
            }
            elemento.TranslationX = 0;
        }
    }
}
