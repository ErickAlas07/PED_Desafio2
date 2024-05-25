using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Desafio_2.Clases
{
    class Arco
    {
        public Vertice nDestino;//Objeto para referenciar elementos de la clase Vertice
        public int peso;//Atributo para peso
        public float grosor_flecha;//Atributo para indicar el grosor del arco
        public Color color;//Objeto para invocar elementos de la clase Color

        public Arco(Vertice destino) : this(destino, 1)//Constructor con herencia para poder darle valor al arco dentro de la clase Vertice
        {
            this.nDestino = destino;
        }
        public Arco(Vertice destino, int peso)//Constructor con parametros para dar valores iniciales
        {
            this.nDestino = destino;
            this.peso = peso;
            this.grosor_flecha = 3;
            this.color = Color.Violet;//color del arco
        }

        public void Dibujar(Graphics g, Point origen)
        {
            AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
            bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;

            Pen pen = new Pen(color, grosor_flecha);
            if (Form1.dirigido)
            {
                pen.CustomEndCap = bigArrow;
            }

            g.DrawLine(pen, origen, nDestino.Posicion);

            // Dibuja el peso del arco dentro de un rectángulo
            string pesoTexto = peso.ToString();
            Font font = new Font("Century Gothic", 9, FontStyle.Bold);
            SizeF textSize = g.MeasureString(pesoTexto, font);
            Point medio = new Point((origen.X + nDestino.Posicion.X) / 2, (origen.Y + nDestino.Posicion.Y) / 2);

            RectangleF rect = new RectangleF(
                medio.X - textSize.Width / 2 - 2,
                medio.Y - textSize.Height / 2 - 2,
                textSize.Width + 4,
                textSize.Height + 4
            );

            // Dibujar el rectángulo con borde y relleno
            g.FillRectangle(Brushes.White, rect);
            g.DrawRectangle(Pens.Black, rect.X, rect.Y, rect.Width, rect.Height);

            // Dibujar el valor en el centro del rectángulo
            g.DrawString(pesoTexto, font, Brushes.Black, rect, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
        }
    }
}
