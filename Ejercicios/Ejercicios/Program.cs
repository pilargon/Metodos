using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //1)Diseña un método esPar() que reciba como parámetro un entero y devuelva si ese número es par o no.
        //    //Utilízalo en un programa que lea un número por teclado y determine si es par o no.

        //    Console.WriteLine("Escribe un numero");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    esPar(num);//la consola sabe que el numero introducido es num porque definimos aqui el metodo
        //}

        //public static void esPar( int numRecibido)//hay que declarar los parametros dentro
        //{    //se pueden declarar variables con el mismo nombre en el metodo
        //    if (numRecibido%2==0)
        //    {
        //        Console.WriteLine("Es par");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Es impar");
        //    }
        //    Console.ReadLine();
        //}

        //Escribe una función que escriba “Hola” 3 veces. Llámala desde el programa principal.

        //static void Main(string[] args)
        //{
        //    saludatresVeces();
        //}

        //public static void saludatresVeces()//el metodo lo invoca
        //{           
        //    Console.WriteLine("Hola");
        //    Console.WriteLine("Hola");
        //    Console.WriteLine("Hola");
        //    Console.ReadLine();
        //}

        //Escribe una función que escriba “Hola” tantas veces como el número que le pasamos de parámetro. 
        //Llámala desde el programa principal dos veces, primero con 5 y después con 3.


        //static void Main(string[] args)
        //{
        //    Holas(5);
        //    Holas(3);
        //}

        //public static void Holas(int veces)//el metodo lo invoca
        //{
        //    for(int i=0;i<veces;i++)
        //    {
        //        Console.WriteLine("Hola ");
        //    }
        //    Console.ReadLine();
        //}


        //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
        //Asigna el valor de llamar a la función en una variable en el programa principal y muestra 
        //el resultado en la pantalla.


        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe un numero");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Escribe un numero");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Suma(num+num1);
        //}
        //public static void Suma(int numrecibido)//el metodo lo invoca
        //{
        //    Console.WriteLine("La suma de los 2 numeros es "+ numrecibido);
        //    Console.ReadLine();
        //}

        //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
        //En el programa principal, pide al usuario 2 números. Usa esos 2 números como parámetros de la 
        //función y después asigna el valor que devuelve la función a una tercera variable en el programa. 
        //Finalmente, muestra el valor de la variable en la pantalla.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe un numero");
        //    int num = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Escribe un numero");
        //    int num1 = Convert.ToInt32(Console.ReadLine());

        //    int resultado = Suma(num,num1);
        //    Console.WriteLine("La suma de los 2 numeros es " + resultado);

        //    //Console.WriteLine("La suma de los 2 numeros es " + Suma(num, num1)); podriamos poner esto tambien,uno de los
        //    //2 lados de la igualdad

        //    Console.ReadLine();

        //}
        //public static int Suma(int number1, int number2)
        //{           
        //    return number1 + number2;           
        //}

        //Escribe un programa que pida al usuario dos números. 
        //Usa esos 2 números en una función que divide el primero por 
        //el segundo y devuelve el resultado. Muestra el resultado que devuelve la función en pantalla.
        //Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 como segundo número.

        //static void Main(string[] args)
        //{
        //    double num2 = 0;// hay que declarar las variables del while fuera porque si no no las encuentra
        //    bool cero = false;

        //    do
        //    {

        //        Console.WriteLine("Escribe un numero");
        //        double num1 = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Escribe un numero");
        //        num2 = Convert.ToDouble(Console.ReadLine());

        //        double resultado = Division(num1, num2);
        //        Console.WriteLine("La division de los 2 numeros es " + resultado);
        //    }


        //    while (num2 != 0);

        //    Console.WriteLine("El segundo numero introducido es cero");
        //    cero = true;
        //    Console.ReadLine();
        //}

        //public static double Division(double number1, double number2)
        //{
        //    return number1 / number2;
        //}

        //Escribe una función a la que le damos dos números y que devuelva true si el primer número 
        //es más grande que el segundo número y false en el caso contrario.En el programa principal, 
        //pide dos números al usuario, y pasalos a la función.Muestra en pantalla 
        //“El primer número es más grande” o “El primer número no es más grande”.



        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Escribe un numero");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Escribe un numero");
        //    int num2 = Convert.ToInt32(Console.ReadLine());
        //    int resultado = Tamaño(num1, num2);

        //    Console.WriteLine("El mayor numero es " + resultado);
        //    Console.ReadLine();
        //}

        //public static int Tamaño(int number1, int number2)
        //{
        //    if (number1 > number2)
        //    {
        //        return number1;
        //    }
        //    else
        //    {
        //        return number2;
        //    }

        //}

        //Escribe una función a la que le pasamos un año y devuelve true si es bisiesto. 
        //En el programa principal, pídele al usuario un número y muestra en pantalla 
        //“El año … es bisiesto” o “El año … no es bisiesto” y sigue pidiendo números y diciendo 
        //si es o no bisiesto hasta que introduzca un 0.

        //static void Main(string[] args)
        //{
        //    int año;
        //    bool cero = false;

        //    do
        //    {
        //        Console.WriteLine("Escribe un año");
        //        año = Convert.ToInt32(Console.ReadLine());
        //        if (año != 0)
        //        {
        //            EsBisiesto(año);
        //        }
        //    }
        //    while (año != 0);
        //    {
        //        Console.WriteLine("El año introducido es cero!");
        //        cero = true;
        //        Console.ReadLine();
        //    }
        //}
        //public static void EsBisiesto(int añoIntroducido)
        //{
        //    if (DateTime.IsLeapYear(añoIntroducido))
        //    {
        //        Console.WriteLine("El año introducido es bisiesto");
        //    }

        //    else
        //    {
        //        Console.WriteLine("El año introducido no es bisiesto");
        //    }
        //}

        //2) Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo. 
        //Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores 
        //necesarios para calcular el área. Crea un método por cada figura para calcular cada área, este 
        //devolverá un número real. Muestra el resultado por pantalla
        //Aquí te mostramos que necesita cada figura:
        //Circulo: (radio^2)*PI
        //Triangulo: (base * altura) / 2
        //Cuadrado: lado* lado

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Elige la opcion: \n 1-Area de un circulo \n 2-Area de un triangulo \n 3-Area de un cuadrado");
        //    int opcion = Convert.ToInt32(Console.ReadLine());
        //    double area = Resultado(opcion);


        //    Console.WriteLine("El area elegida es: " + area);
        //    Console.ReadLine();
        //}
        //public static double Resultado(int numIntroducido)
        //{
        //    double area=0;
        //    switch (numIntroducido)
        //    {

        //        case 1:
        //            Console.WriteLine("Dame el radio del circulo: ");
        //            double radio = Convert.ToDouble(Console.ReadLine());
        //            const double PI = 3.14;
        //             area = Math.Pow(radio, 2) * PI;
        //            break;
        //        case 2:
        //            Console.WriteLine("Dame la base del triangulo: ");
        //            double base1 = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine("Dame la altura del triangulo: ");
        //            double altura = Convert.ToDouble(Console.ReadLine());
        //             area = (base1 * altura) / 2;
        //            break;
        //        case 3:
        //            Console.WriteLine("Dame la altura del cuadrado: ");
        //            double alturaCuadrado = Convert.ToDouble(Console.ReadLine());
        //             area = alturaCuadrado * alturaCuadrado;
        //            break;

        //    }
        //    return area;

        //4) Crea una aplicación que nos calcule el factorial de un número pedido por teclado,
        //lo realizara mediante un método al que le pasamos el número como parámetro. Para calcular 
        //el factorial, se multiplica los números anteriores hasta llegar a uno. Por ejemplo, 
        //si introducimos un 5, realizara esta operación 1*2*3*4*5=120.

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Dame un numero: ");
        //    int num = Convert.ToInt32(Console.ReadLine());           
        //    int factorial = Factorial(num);//Realmente no haria falta poner la invocacion,si no la ve,la busca en el resultado
        //                                   //de C.W.

        //    Console.WriteLine(num + "! es : " + Factorial(num));
        //    Console.ReadLine();
        //}

        //public static int Factorial(int numIntroducido)
        //{
        //    int resultado = 1;
        //    for(int i = numIntroducido; i > 0; i--)
        //    {
        //        resultado *= i;
        //    }
        //    return resultado;
        //}



        //10) Diseña  un  método  pedirMes().  Solicita  un  número  de  mes  y  valida  que  se  trata  de  
        //un número de mes correcto. Devuelve dicho número de mes. 
        //Diseña un método pedirAnio(). Recibe como parámetros los límites entre los que debe de estar el año que se debe 
        //solicitar por teclado.Devuelve el año entre dichos límites.Devuelve el año aleatorio entre dichos límites. 
        //Validar que el límite máximo sea mayor que el límite mínimo y en caso contrario, cambiarles el valor.

        //Diseña un método pedirDia(). Solicita un número de día por teclado, y dado un mes y un año válidos  recibidos 
        //por  parámetro, devuelve un  día correcto.  (Nota:  puede llamar  al método esBisiesto)
        // Crea un nuevo método mostrarSiguienteDia() que recibe un día, un mes y un año válido(estos tres datos 
        //forman la fecha actual) y muestra en pantalla 2 fechas: la actual y la del día siguiente, a calcular a partir
        //del día actual.
        //Pruébalo en  un programa  que pida  al usuario  una fecha(pedirDia(), pedirMes(), pedirAnio()) y muestre 
        //la fecha del día siguiente.
        //Ejemplo:  
        //Fecha actual: 31/12/2011 
        //Día siguiente: 1/1/2012 

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Dime un numero de mes: ");
        //    int month = Convert.ToInt32(Console.ReadLine());
        //    month = AskMonth(month);

        //    Console.WriteLine("El numero de mes es: " + month);
        //    Console.ReadLine();

        //    Console.WriteLine("Dime un año: ");
        //    int year1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dime un año: ");
        //    int year2 = Convert.ToInt32(Console.ReadLine());

        //    int limMax = Math.Max(year1, year2);
        //    int limMin = Math.Min(year1, year2);
        //    int num = RandomYear(limMin, limMax);

        //    Console.WriteLine("El año aleatorio es: " + num);
        //    Console.ReadLine();

        //    Console.WriteLine("Dime un dia del mes: ");
        //    int day = Convert.ToInt32(Console.ReadLine());
        //    day = AskDay(num, month, day);

        //    Console.WriteLine("La fecha es: " + day + "/" + month + "/" + num);
        //    Console.ReadLine();
        //}

        //public static int AskMonth(int mesIntroducido)
        //{

        //    while (mesIntroducido < 1 || mesIntroducido > 12)
        //    {
        //        Console.WriteLine("Dime un numero de mes: ");
        //        mesIntroducido = Convert.ToInt32(Console.ReadLine());
        //    }

        //    return mesIntroducido;
        //}

        //public static int RandomYear(int limMin, int limMax)
        //{
        //    Random rnd = new Random();
        //    int RandomYear = rnd.Next(limMin, limMax+1);
        //    return RandomYear;
        //}

        //public static int AskDay(int num, int month, int day)
        //{
        //    bool correcto = false;


        //        while (day > 1 || day < 31)
        //        {

        //            if (DateTime.IsLeapYear(num) && month == 2)
        //            {
        //                if (day > 29)
        //                {
        //                    Console.WriteLine("Error.Introduce otro dia");
        //                    day = Convert.ToInt32(Console.ReadLine());
        //                }

        //            }
        //            else
        //            {
        //                if (month == 2)
        //                {
        //                    if (day > 28)
        //                    {
        //                        Console.WriteLine("Error.Introduce otro dia");
        //                        day = Convert.ToInt32(Console.ReadLine());
        //                    }
        //                }
        //            }
        //            if (month == 11 || month == 4 || month == 6 || month == 9)
        //            {
        //                if (day > 30)
        //                {
        //                    Console.WriteLine("Error.Introduce otro dia");
        //                    day = Convert.ToInt32(Console.ReadLine());
        //                }
        //            }
        //            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        //            {
        //                if (day > 31)
        //                {
        //                    Console.WriteLine("Error.Introduce otro dia");
        //                    day = Convert.ToInt32(Console.ReadLine());
        //                }
        //            }
        //        }

        //    return day;

        //Escribe una función que reciba un array y lo muestre en pantalla de modo ascendente.
        //Después escribe otra función que reciba un array y lo muestre en pantalla de modo descendencte. 
        //Crea un array en el programa principal y pásalo a cada una de las funciones.

        //static void Main(string[] args)// PREGUNTAR A JM
        //{   
        //    int[]numeros = new int[5];//declaro un array de 5 por ej

        //    for(int i=0;i<5;i++)
        //    {
        //        Console.WriteLine("Introduce 5 valores del array");
        //        numeros[i] = Convert.ToInt32(Console.ReadLine());
        //        numeros()=cuenta;
        //    }

        //    Console.WriteLine(cuenta);
        //    Console.ReadLine();
        //}
        //public static void numeros(int []arrayIntr)
        //{
        //    int cuenta=0;
        //    for(int i=0;i<5;i++)
        //    {
        //        arrayIntr[5] = cuenta;
        //        cuenta++;

        //    }



        //5) Crea una aplicación que nos cuente el número de cifras de un número entero positivo 
        //(hay que controlarlo) pedido por teclado. Crea un método que realice esta acción,
        //pasando el número por parámetro, devolverá el número de cifras.


        static void Main(string[] args)//pasar de int a string y .length
        {
            
            Console.WriteLine("Introduce un numero entero positivo");
            string num =Console.ReadLine();
            num = Cifras();
        }
        public static string Cifras(string numeroIntroducido)
        {
           numeroIntroducido.Length;
        }
        return numIntroducido;


    }




}










}




















