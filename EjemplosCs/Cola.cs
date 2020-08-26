using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosCs
{
    class Cola
    {
        private Nodo raiz, fondo;
        public Cola() 
        {
            raiz = null;
            fondo = null;
        }
        public bool Vacio() 
        {
            if (raiz!=null)
            {
                return false;
            }
            return true;
        }
        public void Insertar(int info) 
        {
            var nuevo=new Nodo();
            nuevo.info = info;
            nuevo.sig = null;
            if (Vacio())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                fondo.sig=nuevo;
                fondo = nuevo;
            }
        }
    }
}
