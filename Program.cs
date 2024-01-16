namespace MiPrograma1;
class Program
{
    static void Main(string[] args)
    {
        //0. Pedir espacio en la memoria(Declarar variable) para poder trabajar el tipo de dato
        //    int, float, char, bool, string,etc.
        //1. Ingresar datos
        //2. Procesar esos datos
        //3. Mostrar el resultado
        //  Ejemplo:

        //Declarar variable paso cero
        int num1,num2;
        float num3;

        // Paso 1
        // Emitir un texto por pantalla
        Console.WriteLine("Ingrese un numero:");
       // Console.ReadLine(); // solo lee y despues se pierde
        // para poder leer despues tendremos que guardar en una variable y despues mostrar
        num1=int.Parse(Console.ReadLine());//aseguro al complilador que la lectura es de tipo int
        //Console.WriteLine("El numero ingresado es: "+num1);
        Console.WriteLine("Inserter el segundo numero:");
        num2=int.Parse(Console.ReadLine());

        //paso 2 Procesar
        num3=num1+num2;

        //Paso 3 Mostrar
        Console.WriteLine("El resultado es: " + num3);
    }
}
