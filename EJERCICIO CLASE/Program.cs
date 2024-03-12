//CONTADOR DE PALABRAS
int number = 0;
int maxim = int.MaxValue;
int minim = int.MinValue;




Console.WriteLine("Ingrese numeros enteros positivos:\n");
number = Convert.ToInt32(Console.ReadLine());

if (number != 0)
{
    if(number > minim)
    {
        maxim = minim;
    }
    if (number < maxim)
    {
        minim = maxim;
    }

}
else
{
    Console.WriteLine("INGRESE NUMEROS POSITIVOS");
}



//ADIVINAR EL NUMERO
Console.WriteLine("Ingrese un numero:\n");
int numero = int.Parse(Console.ReadLine());
//OPERACIONES
Console.WriteLine("MULTIPLIQUELO POR DOS");
numero *=2;
Console.WriteLine("SUMELE OCHO");
numero += 8;
Console.WriteLine("A SU RESULTADO MULTIPLIQUELO POR CINCO");
numero *= 5;

Console.WriteLine("Introduzca su resultado final:");
int result = int.Parse(Console.ReadLine());

result /= 10;
result -= 4;

Console.WriteLine("Su numero es:"+ result);


//PALINDROMO
Console.WriteLine("Ingrese una frase o cadena de texto:\n");
string text = Console.ReadLine();

int numberwords = 0;
bool word = false;
for (int o = 0; o < text.Length; o++)
{
    if (char.IsWhiteSpace(text[o]))
    {
        word = false;
    }
    else if (!word)
    {
        word = true;
        numberwords++;
    }
}
int vocalnumbers = 0;
for (int o=0; o < text.Length; o++)
{
    char letter = char.ToLower(text[0]);
    if ("aeiouáéíóú".Contains(letter))
    {
        vocalnumbers++;
    }
}
Console.WriteLine("El total de numero de palabras es:" + numberwords);
Console.WriteLine("El total de vocales es:" + vocalnumbers);


string palab, invertpalab = "";

Console.WriteLine("Ingrese alguna palabra:");
palab = Console.ReadLine();

for (int u= palab.Length - 1; u >= 0; u--)
{
    invertpalab += palab[u];
}
if (palab.Equals(invertpalab))
{
    Console.WriteLine("La palabra ingresada es un palindromo.", palab);
}
    else 
    {
        Console.WriteLine("La palabra ingresada no es un palindromo.", palab);
    }


    



