using System;
using System.Collections.Generic;
using System.Drawing;

namespace Desafio_2.Clases
{
    class Grafo
    {
        public List<Vertice> nodos;
        public int[,] nodosadya = new int[50, 50];
        private int i, j;

        public Grafo()
        {
            nodos = new List<Vertice>();
        }

        public Vertice AgregarVertice(string valor)
        {
            Vertice nodo = new Vertice(valor);
            nodos.Add(nodo);
            return nodo;
        }

        public void AgregarVertice(Vertice nuevonodo)
        {
            nodos.Add(nuevonodo);
        }

        public Vertice BuscarVertice(string valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }

        public void EliminarVertice(Vertice vertice)
        {
            nodos.Remove(vertice);
            EliminarArco(vertice);
        }

        public void EliminarVertice(string sEvalor)
        {
            Vertice vertice = BuscarVertice(sEvalor);
            if (vertice != null)
            {
                nodos.Remove(vertice);
                EliminarArco(vertice);
            }
        }

        public bool AgregarArco(Vertice origen, Vertice nDestino, int peso)
        {
            i = returnindice(origen);
            j = returnindice(nDestino);

            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                origen.ListaAdyacencia.Add(new Arco(nDestino, peso));
                nodosadya[i, j] = peso;

                if (!Form1.dirigido)
                {
                    nodosadya[j, i] = peso;
                }

                return true;
            }

            return false;
        }

        public int returnindice(Vertice n1)
        {
            return nodos.IndexOf(n1);
        }

        public void EliminarArco(Vertice nOrigen, Vertice nDestino)
        {
            i = returnindice(nOrigen);
            j = returnindice(nDestino);

            nodosadya[i, j] = 0;

            if (!Form1.dirigido)
            {
                nodosadya[j, i] = 0;
            }
        }

        public void EliminarArco(Vertice nBorrar)
        {
            foreach (Vertice nodo in nodos)
            {
                EliminarArista(nodo, nBorrar);
            }
        }

        public bool EliminarArista(Vertice origen, Vertice nDestino)
        {
            Arco arista = origen.ListaAdyacencia.Find(v => v.nDestino == nDestino);
            return origen.ListaAdyacencia.Remove(arista);
        }

        public void ColorearNodo(string valorEscogido)
        {
            Vertice nodoEscogido = BuscarVertice(valorEscogido);
            if (nodoEscogido != null)
            {
                nodoEscogido.Color = Color.DeepSkyBlue;
            }
        }

        public void ReestablecerColorNodo(string valorEscogido)
        {
            Vertice nodoEscogido = BuscarVertice(valorEscogido);
            if (nodoEscogido != null)
            {
                nodoEscogido.Color = Color.LightGreen;
            }
        }

        public void DibujarGrafo(Graphics g)
        {
            foreach (Vertice nodo in nodos)
            {
                nodo.DibujarArco(g);
            }

            foreach (Vertice nodo in nodos)
            {
                nodo.DibujarVertice(g);
            }
        }

        public Vertice DetectarPunto(Point posicionMouse)
        {
            foreach (Vertice nodoActual in nodos)
            {
                if (nodoActual.DetectarPunto(posicionMouse))
                {
                    return nodoActual;
                }
            }

            return null;
        }

        public void ReestablecerGrafo(Graphics g)
        {
            foreach (Vertice nodo in nodos)
            {
                nodo.Color = Color.YellowGreen;
                nodo.FontColor = Color.White;

                foreach (Arco arco in nodo.ListaAdyacencia)
                {
                    arco.grosor_flecha = 2;
                    arco.color = Color.Violet;
                }
            }

            DibujarGrafo(g);
        }
    }
}
