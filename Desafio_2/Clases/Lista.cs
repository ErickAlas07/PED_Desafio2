using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2.Clases
{
    class Lista
    {
        //Objetos privados para instanciar elementos de las otras clases
        private Vertice aElemento;
        private Lista aSubLista;
        //Atributo para el peso de los arcos
        private int aPeso;
        //Constructor con valores iniciales
        public Lista()
        {
            aElemento = null;
            aSubLista = null;
            aPeso = 0;
        }
        public Lista(Lista pLista)//Constructor con 1 parametro del mismo tipo de la clase para inicializar atributos
        {
            if (pLista != null)
            {
                aElemento = pLista.aElemento;
                aSubLista = pLista.aSubLista;
                aPeso = pLista.aPeso;
            }
        }
        public Lista(Vertice pElemento, Lista pSubLista, int pPeso)//Constructor con parametro para agregar valores al nodo con su peso que es cero por defecto 
        {
            aElemento = pElemento;
            aSubLista = pSubLista;
            aPeso = pPeso;
        }
        public Vertice Elemento//propiedad de tipo Vertice 
        {
            get { return aElemento; }
            set { aElemento = value; }
        }
        public Lista SubLista//propiedad de tipo Lista
        {
            get { return aSubLista; }
            set { aSubLista = value; }
        }
        public int Peso//Propiedad para el peso del nodo
        {
            get { return aPeso; }
            set { aPeso = value; }
        }
        public bool EsVacia()//Funcion que retorna un booleano para saber si el vertice esta vacio o no
        {
            return aElemento == null;
        }
        public void Agregar(Vertice pElemento, int pPeso)//Método para agregar nodo
        {
            if (pElemento != null)
            {
                if (aElemento == null)
                {
                    aElemento = new Vertice(pElemento.Valor);
                    aPeso = pPeso;
                    aSubLista = new Lista();
                }
                else if (!ExisteElemento(pElemento))
                {
                    aSubLista.Agregar(pElemento, Peso);
                }
            }
        }
        public void Eliminar(Vertice pElemento)//Método para eliminar nodo
        {
            if (aElemento != null)//Si existe un elemento
            {
                if (aElemento.Equals(pElemento))//Si el elemento que se solicita como parametro es igual al elemento ya existente
                {
                    aElemento = aSubLista.aElemento;
                    aSubLista = aSubLista.SubLista;//se guarda en la sublista
                }
                else
                {
                    aSubLista.Eliminar(pElemento);//se elimina el elemento
                }
            }
        }
        public int NroElementos()//devuelve el numero de elementos
        {
            if (aElemento != null)
                return 1 + aSubLista.NroElementos();
            else
                return 0;
        }
        public object lesimoElemento(int posicion)//retorna el elemento de la posicion solicitada
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                    return aElemento;
                else
                    return aSubLista.lesimoElemento(posicion - 1);
            }
            else
                return 0;
        }
        public object lesimoElementoPeso(int posicion)//retorna el peso de la posicion solicitada
        {
            if ((posicion > 0) && (posicion <= NroElementos()))
            {
                if (posicion == 1)
                    return aPeso;
                else
                    return aSubLista.lesimoElementoPeso(posicion - 1);
            }
            else
                return 0;
        }
        public bool ExisteElemento(Vertice pElemento)//Retorna si existe o no el elemento solicitado como parametro
        {
            if (aElemento != null && pElemento != null)
            {
                return (aElemento.Equals(pElemento) || aSubLista.ExisteElemento(pElemento));
            }
            else
                return false;
        }
        public int PosicionElemento(Vertice pElemento)//Retorna la posicion del nodo en la lista
        {
            if (aElemento != null || ExisteElemento(pElemento))
            {
                if (aElemento.Equals(pElemento))
                    return 1;
                else
                    return 1 + aSubLista.PosicionElemento(pElemento);
            }
            else
                return 0;
        }
    }
}
