using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Desafio_2.Clases
{
    class Vertice
    {
        public string Valor;
        Color color_nodo;
        Size dimensiones;
        Color color_fuente;
        Point _posicion;
        int radio;
        static int size = 18;
        public int grado = 0;
        public List<Arco> ListaAdyacencia;
        Dictionary<string, short> _banderas;
        Dictionary<string, short> _banderas_predeterminado;
        //Form1 f1 = new Form1();

        public Color Color
        {
            get { return color_nodo; }
            set { color_nodo = value; }
        }
        public Color FontColor
        {
            get { return color_fuente; }
            set { color_fuente = value; }
        }
        public Point Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }
        public Size Dimensiones
        {
            get { return dimensiones; }
            set
            {
                radio = value.Width / 2;
                dimensiones = value;
            }
        }
        public Vertice(string Valor)
        {
            this.Valor = Valor;
            this.ListaAdyacencia = new List<Arco>();
            this._banderas = new Dictionary<string, short>();
            this._banderas_predeterminado = new Dictionary<string, short>();
            this.Color = Color.LightGreen;
            this.Dimensiones = new Size(size, size);
            this.FontColor = Color.White;
        }
        public Vertice() : this("") { }//constructor por defecto

        public void DibujarVertice(Graphics g)
        {
            SolidBrush b = new SolidBrush(this.color_nodo);
            Rectangle areaNodo = new Rectangle(this._posicion.X - radio, this._posicion.Y - radio, this.dimensiones.Width, this.dimensiones.Height);
            g.FillEllipse(b, areaNodo);
            //MessageBox.Show(" ");
            g.DrawString(this.Valor, new Font("Century Gothic", 9), new SolidBrush(Color.Black), this._posicion.X, this._posicion.Y, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            g.DrawEllipse(new Pen(Brushes.Black, (float)1.0), areaNodo);
            b.Dispose();
        }

        public bool DetectarPunto(Point p)
        {
            GraphicsPath posicion = new GraphicsPath();
            posicion.AddEllipse(new Rectangle(this._posicion.X - this.dimensiones.Width / 2, this._posicion.Y - this.dimensiones.Height / 2, this.dimensiones.Width, this.dimensiones.Height));
            bool retval = posicion.IsVisible(p);
            posicion.Dispose();
            return retval;
        }

        public override string ToString()
        {
            return this.Valor;
        }

         public void DibujarArco(Graphics g)
        {
            foreach (Arco arco in ListaAdyacencia)
            {
                arco.Dibujar(g, Posicion);
            }
        }
    }
}
