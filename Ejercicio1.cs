
mayor100();

void mayor100()
{
    int valorInt = 0;

    var valor = ingresarValor();

    evaluarValor(valor,ref valorInt);

    resultado(valorInt);
}

string ingresarValor()
{
    Console.WriteLine("Ingrese un valor númerico: ");
    return Console.ReadLine();
}

void evaluarValor(string valor,ref int valorInt)
{
    Int32.TryParse(valor, out valorInt);
}

void resultado(int valor)
{
    if(valor < 100)
    {
        Console.Write($"\nEl valor: {valor} es menor que 100");
    }
    else
    {
        Console.Write($"\nEl valor: {valor} es mayor que 100");
    }
}
