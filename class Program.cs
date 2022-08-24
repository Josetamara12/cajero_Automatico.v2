class Program
{
    {
        static void Main(string[] args)
        {
            Usuarios usuarios = new Usuarios();
            Opciones opciones = new Opciones();
            int cedula, clave, valide = -1, valide2 = -1;

            do
            {
                try
                {
                    // Llamo metodo que contiene el Titulo
                    opciones.Titulo();
                    // pido al usuario autenticarce con la cedula 
                    Console.WriteLine("Ingresa tu cedula:  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    // guardo la cedula en variable cedula 
                    cedula = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    // pido que ingree la clave 
                    Console.WriteLine("Ingresa tu clave: ");
                    // guardo la clave en variable clave
                    clave = int.Parse(Console.ReadLine());
                    // valido la cedula con el id
                    valide = usuarios.id(cedula);
                    //valido la clave con la contraseña. 
                    valide2 = usuarios.Contraseña(clave);

                    if (valide != -1 && valide2 != -1 && valide == valide2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Autenticacion de usuario es correcta: \n");
                        opciones.optciUsua(valide);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            } while (true);
        }
    }

}