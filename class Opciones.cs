class Opciones

{
    {
        int elegir, tope = 2000001, contaSaldo = 0;
        Usuarios usua = new Usuarios();

        public void optciUsua(int valide)
        {
            do
            {
                // creo un menu de opciones
                Console.ForegroundColor = ConsoleColor.Red
                Titulo();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Por favor elija una opcion: ");
                Console.WriteLine("Tipos de servicios: \n");
                Console.WriteLine("(1) Saldo:  ");
                Console.WriteLine("(2) Retiros : ");
                Console.WriteLine("(3) Deposito : ");
                Console.WriteLine("(0) Salir : ");
                elegir = int.Parse(Console.ReadLine());

                switch (elegir)
                {
                    case 1:
                        //Consulta Saldo
                        Console.Clear();
                        Saldo(valide);
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        optciUsua(valide);
                        break;

                    case 2:
                        // Realizar Retiros
                        Console.Clear();
                        Retirar(valide);
                        break;

                    case 3:
                        //Realizar Deposito 
                        Console.Clear();
                        Deposito(valide);
                        break;

                    case 4:
                        // limpia la consola
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opcion de transaccion no valida");
                        break;
                }
            } while (elegir != 4);
        }
        
        // nuevo metodo de validacion para verificar saldo,
        // retorno de datos y publico
        public void Saldo(int valide)
        {
            Titulo();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Opcion 1 ----> CONSULTA DE SALDO \n");
            Console.WriteLine($"Su saldo es:  ${usua.Saldos[valide]} \n");
        }

        public void Retirar(int valide)
        {
            // metodo Retiro de dinero, retorna datos y los valida
            Titulo();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Opcion 2 ----> RETIRO DE DINERO \n");
            Console.WriteLine("Seleccione el monto a Retirar: ");
            Console.WriteLine("1. $ 100.000");
            Console.WriteLine("2. $ 200.000");
            Console.WriteLine("3. $ 300.000");
            Console.WriteLine("4. $ 400.000 \n");
            Console.ForegroundColor = ConsoleColor.White;
            int seletMonto = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            switch (seletMonto)
            {
                case 1:
                    if (100000 <= usua.Saldos[valide])
                    {
                        contadorSaldo += 100000;
                        if (contadorSaldo <= tope)
                        {
                            usua.Saldos[valide] -= 100000;
                            Console.WriteLine("Por favor retire su dinero \n\n");
                            Console.WriteLine($"Saldo Actual: {usua.Saldos[valide]} \n");
                        }
                        else
                        {
                            //coloque un tope de retiros. de 2 millones
                            Console.WriteLine("Solo puedes retirar 2.000.000 diarios");
                            contadorSaldo -= 100000;
                        }
                    }
                    else

                        Console.WriteLine("Saldo Insuficiente");
                    Console.WriteLine("presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    optciUsua(valide);
                    break;

                case 2:
                    if (200000 <= usua.Saldos[valide])
                    {
                        contadorSaldo += 200000;
                        if (contadorSaldo <= tope)
                        {
                            usua.Saldos[valide] -= 200000;
                            Console.WriteLine("Por favor retire su dinero \n\n");
                            Console.WriteLine($"Saldo Actual: {usua.Saldos[valide]} \n");
                        }
                        else
                        {
                            //coloque un tope de retiros. de 2 millones
                            Console.WriteLine("Solo puedes retirar 2.000.000 diarios");
                            contadorSaldo -= 200000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo Insuficiente");
                    Console.WriteLine("presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    optciUsua(valide);
                    break;

                case 3:
                    if (300000 <= usua.Saldos[valide])
                    {
                        contadorSaldo += 300000;
                        if (contadorSaldo <= tope)
                        {
                            usua.Saldos[valide] -= 300000;
                            Console.WriteLine("Por favor retire su dinero \n\n");
                            Console.WriteLine($"Saldo Actual: {usua.Saldos[valide]} \n");
                        }
                        else
                        {
                            //coloque un tope de retiros. de 2 millones
                            Console.WriteLine("Solo puedes retirar 2.000.000 diarios");
                            contadorSaldo -= 300000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo Insuficiente");
                    Console.WriteLine("presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    optciUsua(valide);
                    break;

                case 4:
                    if (400000 <= usua.Saldos[valide])
                    {
                        contadorSaldo += 400000;
                        if (contadorSaldo <= tope)
                        {
                            usua.Saldos[valide] -= 400000;
                            Console.WriteLine("Por favor retire su dinero \n\n");
                            Console.WriteLine($"Saldo Actual: {usua.Saldos[valide]} \n");
                        }
                        else
                        {
                            //coloque un tope de retiros. de 2 millones
                            Console.WriteLine("Solo puedes retirar 2.000.000 diarios");
                            contadorSaldo -= 400000;
                        }
                    }
                    else
                        Console.WriteLine("Saldo Insuficiente");
                    Console.WriteLine("presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    optciUsua(valide);
                    break;
            }

        }
        
    }
    public void Deposito(int valide)
    {
        int verificacion; 
        Titulo();
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digita cedula titular a quien deposita: \n");
        int deposito1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Selecciona el monto a Depositar");
        Console.WriteLine("1. $100.000");
        Console.WriteLine("2. $200.000");
        Console.WriteLine("3. $300.000");
        Console.WriteLine("4. $400.000");
        int Deposito2 = int.Parse(Console.ReadLine());
        verificacion = usua.ValidarCedula(deposito1);

        switch (Deposito2)
        {
            case 1:
                if (100.000 <= usua.Saldo[valide])
                {
                    Console.WriteLine("Transferencia exitosa.");
                    usua
                    break;
                }
            
                default:
        }
    }
    public void Titulo
    {
    console.WhriteLine("-------------------------------------");
    console.WhriteLine("-------------------------------------");
    console.WhriteLine("----------BancoSkyColombian----------");
    console.WhriteLine("-------------------------------------");
    console.WhriteLine("-------------------------------------");
        }

}
    
