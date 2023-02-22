// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Write("======");
Console.Write("BIENVENIDO USUARIO INTELIGENTE");
Console.Write("======");
Console.WriteLine();

Console.WriteLine("Porfavor ingrese valor incial con el cual desea comenzar:");
int ValorInicial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Porfavor ingrese valor final con el cual desea terminar:");
int ValorFinal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Usuario de los valores que ingreso en  valor incial y valor final [{0},{1}]." ,ValorInicial,ValorFinal);
Console.WriteLine(); 
Console.WriteLine("Se obtuvo de los siguientes numeros pares:");


for (int i = ValorInicial; i < ValorFinal; i++)
{if (i % 2 == 0)
{
Console.WriteLine("{0}", i);
}
}

 



