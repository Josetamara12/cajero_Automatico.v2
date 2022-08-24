class Usuarios
{
    {
        //inicializo metodos enteros y publicos con asignaciones de valores
        public int[] id = { 1001, 1002, 1003 };
        public int[] password = { 1000, 2000, 3000 };
        // determine un metodo con un rango para total para los 3 usuarios. 
        public int[] Saldos = { 1000000, 2000000, 3000000 };

        // Validacion de cedula
        public int ValidarCedula(int cedula)
        {
            int respuesta = -1;
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == cedula)
                {
                    respuesta = i;
                }
            }
            return respuesta;
        }
        public int ValidarPassword(int clave)
        {
            int respuesta = -1;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == clave)
                {
                    respuesta = i; 
                }
            }
            return respuesta;
        }
    }
}
