
parOimpar();

void parOimpar()
{
    int valorInt = 0;

    var valor = ingresarValor();

    evaluarValor(valor,ref valorInt);
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

void resultado(int valorInt)
{
    if()
}