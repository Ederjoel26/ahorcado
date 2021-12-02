ahorcado();
static string ahorcado() 
{
    Console.WriteLine("Bienvenido al juego del ahorcado!");
    Console.WriteLine("Ingresa la palabra");
    string palabra = Console.ReadLine().ToLower();
    char[] arreglo_palabra = palabra.ToCharArray();
    string palabra_oculta = "";
    int bandera_errores = 0;
    int bandera_ganador = 0;
    int bandera_correctas = 0;
    int bandera_incorrectas = 4;
    bool bandera_norepeat = false;
    for (int j = 0; j < arreglo_palabra.Length; j++) 
    {
        palabra_oculta += "_";
    }
    Console.WriteLine(palabra_oculta);
    int largo = arreglo_palabra.Length;
    while (bandera_errores >= 0 && bandera_errores < 5 && bandera_ganador == 0)
    {
        bandera_norepeat = false;
        Console.WriteLine("Escribe una letra que creas que pertenece a la palabra");
        string letra = Console.ReadLine().ToLower();
        char[] letra_palabra = letra.ToCharArray();
        for (int i = 0; i < largo; i++)
        {  
            if (arreglo_palabra[i] == letra_palabra[0])
            {
                Console.WriteLine("Felicidades, acertaste una letra");
                palabra_oculta = palabra_oculta.Remove(i, 1).Insert(i, letra.Substring(0, 1));
                Console.WriteLine(String.Join(" ", palabra_oculta));
                bandera_correctas++;
                bandera_norepeat = true;
            }       
        }
        if (bandera_norepeat == false){
            Console.WriteLine("Lo siento, no pertenece a la palabra te quedan " + bandera_incorrectas + " intentos");
            bandera_errores++;
            bandera_incorrectas --;
            if (bandera_incorrectas == -1){
                Console.WriteLine("Lo siento, perdiste. \n No pudiste adivinar la palabra: " + palabra);
            }
        }
        if (bandera_correctas == largo)
        {   
            Console.WriteLine("Felicidades, lograste adivinar la palabra");
            Console.WriteLine(String.Join(" ", palabra));
            bandera_ganador++;
        }
    } 
    return "Creado por: Eder Joel Calzada Espinosa";  
}