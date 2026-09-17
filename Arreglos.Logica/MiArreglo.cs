namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos
        private int _tope;
        private int[] _arreglo;

        //Constructor

        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;

        }

        //Propiedades
        public int N { get; }
        public bool EstaLleno => _tope == N;
        public bool EstaVacio => _tope == 0;

        //Métodos
        //Método llenar
        public void Llenar(int minimo, int maximo)
        {
            Random oRandom = new Random();

            for (int i = 0; i < N; i++)
            {
                _arreglo[i] = oRandom.Next(minimo, maximo);

            }
            _tope = N;
        }

        //Método ToString
        public override string ToString()
        {
            if (EstaVacio)
            {
                return "Esta vacío";
            }

            string cadena = string.Empty;
            int contador = 0;
            for (int i = 0; i < _tope; i++)
            {
                cadena += $"{_arreglo[i]}\t";
                contador++;
                if (contador > 9)
                {
                    contador = 0;
                    cadena += "\n";
                }

            }
            return cadena;
        }

    }
}
