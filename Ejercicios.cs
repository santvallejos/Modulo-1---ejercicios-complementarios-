
ejercicios();

void ejercicios()
{
    menu();

    var ejercicio = ingresarNumero();

    if(ejercicio == 0 || ejercicio > 22)
    {
        Console.WriteLine("Profe, Porfavor!! Coloque un valor correcto :)");
    }
    else
    {
        switch (ejercicio)
        {
            case 1:
                ejercicio1();
                break;
            case 2:
                ejercicio2();
                break;
            /*case 3:
                ejercicio3();
                break;
            case 4:
                ejercicio4();
                break;
            case 5:
                ejercicio5();
                break;
            case 6:
                ejercicio6();
                break;
            case 7:
                ejercicio7();
                break;
            case 8:
                ejercicio8();
                break;
            case 9:
                ejercicio9();
                break;
            case 10:
                ejercicio10();
                break;
            case 11:
                ejercicio11();
                break;
            case 12:
                ejercicio12();
                break;
            case 13:
                ejercicio13();
                break;
            case 14:
                ejercicio14();
                break;
            case 15:
                ejercicio15();
                break;
            case 16:
                ejercicio16();
                break;
            case 17:
                ejercicio17();
                break;
            case 18:
                ejercicio18();
                break;
            case 19:
                ejercicio19();
                break;
            case 20:
                ejercicio20();
                break;
            case 21:
                ejercicio21();
                break; */
            default:
            Console.WriteLine("saliendo...");
            break;
        }
    }
}

void menu()
{
    Console.WriteLine("Hola profesor!!, Entro en la lista de Ejercicios(complementarios)\n Desea consultar alguno de los siguientes ejercicios?");
    Console.WriteLine("\n1    2" +
                        "\n3    4" +
                        "\n5    6" +
                        "\n7    8" +
                        "\n9    10" +
                        "\n11   12" +
                        "\n13   14" +
                        "\n15   16" +
                        "\n17   18" +
                        "\n19   20" +
                        "\n21   22.salir");
}


//Funciones generales
int ingresarNumero()
{
    var valor = Console.ReadLine();
    int valorInt;
    Int32.TryParse(valor, out valorInt);
    return valorInt;
}


void ejercicio1()
{
    mayor100();

    void mayor100()
    {
        Console.WriteLine("\nIngrese un valor numerico");

        int valorInt = ingresarNumero();

        resultado(valorInt);
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
}

void ejercicio2()
{
    parOImpar();

        void parOImpar()
        {
            Console.WriteLine("\nIngrese un valor numerico");

            int valorInt = ingresarNumero();

            resultado(valorInt);
        }

        void resultado(int valor)
        {
            if(valor % 2 == 0)
            {
                Console.WriteLine($"\nEl numero {valor} es par");
            }
            else
            {
                Console.WriteLine($"\nEl numero {valor} es impar");
            }
        }
}

