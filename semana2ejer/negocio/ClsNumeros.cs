using semana2ejer.entidades;

namespace semana2ejer.negocio
{
    public class ClsNumeros
    {
        public string Res(Numeros numeros){
            if (numeros.Num1>numeros.Num2 ){
                return $"el numero {numeros.Num1} es mayor que {numeros.Num2}"; }

            if (numeros.Num1 < numeros.Num2 ){
                return $"el numero {numeros.Num2} es mayor que {numeros.Num1}";
                 }
            if (numeros.Num1 == numeros.Num2 ){
                return $"el numero {numeros.Num1 } es igual que {numeros.Num2}";}

            else return "Intente de nuevo";
        }

    }
}