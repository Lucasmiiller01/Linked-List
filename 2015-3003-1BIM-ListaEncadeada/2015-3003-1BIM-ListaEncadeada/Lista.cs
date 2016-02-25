using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2015_3003_1BIM_ListaEncadeada
{
    class Lista
    {
        private Elemento primeiro;
        public Elemento Primeiro
        {
            get
            {
                return primeiro;
            }
            set
            {
                primeiro = value;
            }
        }

        public Elemento Ultimo
        {
            get
            {
                return BuscaUltimo();
            }
        }

        public Lista()
        {
            
        }

        public void Adiciona(Elemento e)
        {
            if (Primeiro == null)
            {
                Primeiro = e;
            }
            else
            {
                Ultimo.Proximo = e;
            }
        }

        public Elemento BuscaUltimo()
        {
            Elemento current = Primeiro;
            while (current.Proximo != null)
            {
                current = current.Proximo;
            }
            return current;
        }
        public void RemoveValue(int value)
        {
            Elemento a = Primeiro;
            Elemento b = null;
            if (!Primeiro.Valor.Equals(value))
            {
                while (a.Proximo != null)
                {
                    if (a.Valor.Equals(value))
                    {
                        b.Proximo = a.Proximo;
                    }
                    b = a;
                    a = a.Proximo;
                }
                if (a.Proximo != null) b.Proximo = a.Proximo;
                else b.Proximo = null;
            }
            else
            {
                Primeiro = Primeiro.Proximo;
            }
        }
       
        public int Count
        {
            get {
                int count = 1;
                Elemento current = Primeiro;
                while (current != null)
                {
                    current = current.Proximo;
                    count++;
                }
                return count;
            }
        }

        public void ImprimeLista()
        {
            Elemento current = Primeiro;
            while (current != null)
            {
                Debug.WriteLine(current.AsString);
                
                current = current.Proximo;
            } 
        }
    }
}
