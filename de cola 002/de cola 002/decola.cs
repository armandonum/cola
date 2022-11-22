using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_cola_002
{
    public  class decola
    {
        public string[] coladatos = new string[100];
        public int primero = 0;
        public int ultimo = -1;
        public int MaxCola = 4;
        public string valor = "";
        public decola()
        {
            primero = 0;
            ultimo = -1;
        }

        public bool Vacia()
        {
            if (ultimo < primero) return true;
            else return false;
        }

        public bool Llena()
        {
            if (ultimo == MaxCola - 1) return true;
            else return false;
        }

        public void Insertar(string insert)
        {
            if (Llena()) MessageBox.Show("Error: La cola de elementos esta LLENA");
            else
            {
                ultimo++;
                coladatos[ultimo] = insert;
            }
        }

        public string Eliminar()
        {
            string valor = " ";
            if (Vacia()) MessageBox.Show("Error: La cola de elementos esta VACIA");
            else
            {
                valor = coladatos[primero];
                for (int i = 0; i < ultimo; i++)
                {
                    coladatos[i] = coladatos[i + 1];
                }
                ultimo--;
            }
            return valor;
        }
    }
}
    

