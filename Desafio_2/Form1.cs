using Desafio_2.Clases;
using Desafio_2.Ventanas;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Desafio_2
{

    public partial class Form1 : Form
    {
        private Grafo grafo;
        private Vertice nuevoNodo;
        private Vertice NodoOrigen;
        private Vertice NodoDestino;
        private Vertice NodoEliminar;
        private Vertice NdoArco;
        private int var_control = 0;
        private FVertice ventanaVertice;
        private FArco ventanaArco;
        public static Boolean dirigido = true;

        private bool isImageLoaded = false; // Bandera para verificar si la imagen está cargada

        // Diccionarios para almacenar los nodos de cada país
        private Dictionary<string, Point> nodosElSalvador = new Dictionary<string, Point>();
        private Dictionary<string, Point> nodosHonduras = new Dictionary<string, Point>();
        private Dictionary<string, Point> nodosCostaRica = new Dictionary<string, Point>();

        public Form1()
        {
            InitializeComponent();
            resetear();

            // Inicializar el ComboBox con las opciones de países
            cmbPaises.Items.Add("El Salvador");
            cmbPaises.Items.Add("Honduras");
            cmbPaises.Items.Add("Costa Rica");

            // Maneja el evento de cambio de selección
            cmbPaises.SelectedIndexChanged += cmbPaises_SelectedIndexChanged;

            // Configurar el PictureBox para que llene el panel
            ptbMapa.Dock = DockStyle.Fill;
            ptbMapa.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMapa.Paint += ptbMapa_Paint; // Agrega el evento Paint al PictureBox
            ptbMapa.SizeMode = PictureBoxSizeMode.Zoom; // Asegúrate de que esto esté configurado

            // Configurar nodos de cada país
            ConfigurarNodos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void resetear()
        {
            grafo = new Grafo();
            nuevoNodo = null;
            var_control = 0;
            ventanaVertice = new FVertice();
            ventanaArco = new FArco();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grafo = new Grafo();
            cmbDepartamentos.Items.Clear();
            CargarNodos("El Salvador");
        }

        private void rbDirigido_CheckedChanged(object sender, EventArgs e)
        {
            dirigido = true;
            ptbMapa.Invalidate(); 
        }

        private void rbNoDirigido_CheckedChanged(object sender, EventArgs e)
        {
            dirigido = false;
            ptbMapa.Invalidate();
        }

        private void ptbMapa_MouseLeave(object sender, EventArgs e)
        {
            ptbMapa.Refresh();
        }

        private void ptbMapa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NodoOrigen = grafo.DetectarPunto(e.Location);
                if (NodoOrigen != null)
                {
                    var_control = 1;
                }
            }
        }

        private void ptbMapa_MouseMove(object sender, MouseEventArgs e)
        {
            if (var_control == 1 && NodoOrigen != null)
            {
                AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true);
                bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;
                ptbMapa.Refresh();
                ptbMapa.Invalidate();
                using (Graphics g = ptbMapa.CreateGraphics())
                {
                    if (rbDirigido.Checked)
                    {
                        g.DrawLine(new Pen(Brushes.Violet, 2) { CustomEndCap = bigArrow }, NodoOrigen.Posicion, e.Location);
                    }
                    else
                    {
                        g.DrawLine(new Pen(Brushes.Violet, 2), NodoOrigen.Posicion, e.Location);
                    }
                }
            }
        }

        private void ptbMapa_MouseUp(object sender, MouseEventArgs e)
        {
            if (var_control == 1)
            {
                NodoDestino = grafo.DetectarPunto(e.Location);
                if (NodoDestino != null && NodoOrigen != NodoDestino)
                {
                    ventanaArco.Visible = false;
                    ventanaArco.control = false;
                    ventanaArco.ShowDialog();
                    int peso = 0;
                    if (ventanaArco.control)
                    {
                        if (int.TryParse(ventanaArco.textBox1.Text, out peso))
                        {
                            if (grafo.AgregarArco(NodoOrigen, NodoDestino, peso))
                            {
                                NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = peso;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese un valor válido para el peso del arco.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                var_control = 0;
                NodoOrigen = null;
                NodoDestino = null;

                ptbMapa.Invalidate();  
            }
        }


        private void ptbMapa_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

                if (ptbMapa.Image != null)
                {
                    e.Graphics.DrawImage(ptbMapa.Image, 0, 0, ptbMapa.Width, ptbMapa.Height);
                }

                if (isImageLoaded)
                {
                    grafo.DibujarGrafo(e.Graphics);
                }

                // Dibuja la línea temporal mientras se arrastra el mouse
                if (var_control == 1 && NodoOrigen != null)
                {
                    Point mousePosition = ptbMapa.PointToClient(MousePosition);
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, true)
                    {
                        BaseCap = System.Drawing.Drawing2D.LineCap.Triangle
                    };

                    if (rbDirigido.Checked)
                    {
                        e.Graphics.DrawLine(new Pen(Brushes.Violet, 2) { CustomEndCap = bigArrow }, NodoOrigen.Posicion, mousePosition);
                    }
                    else
                    {
                        e.Graphics.DrawLine(new Pen(Brushes.Violet, 2), NodoOrigen.Posicion, mousePosition);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cmbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = cmbPaises.SelectedItem.ToString();
            LimpiarNodos();

            switch (selectedCountry)
            {
                case "El Salvador":
                    ptbMapa.Image = Image.FromFile("C:\\Users\\LENOVO\\OneDrive\\Escritorio\\UDB\\PED\\2024\\Desafio_2\\Desafio_2\\src\\El Salvador.png");
                    CargarNodos("El Salvador");
                    break;
                case "Honduras":
                    ptbMapa.Image = Image.FromFile("C:\\Users\\LENOVO\\OneDrive\\Escritorio\\UDB\\PED\\2024\\Desafio_2\\Desafio_2\\src\\Honduras.jpeg");
                    CargarNodos("Honduras");
                    break;
                case "Costa Rica":
                    ptbMapa.Image = Image.FromFile("C:\\Users\\LENOVO\\OneDrive\\Escritorio\\UDB\\PED\\2024\\Desafio_2\\Desafio_2\\src\\Costa_Rica.png");
                    CargarNodos("Costa Rica");
                    break;
                default:
                    ptbMapa.Image = null; // Limpia la imagen si no hay coincidencia
                    break;
            }

            isImageLoaded = (ptbMapa.Image != null); // Actualiza la bandera según si la imagen está cargada
            ptbMapa.Invalidate();
        }

        private void CMSCrearVertice_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void nuevoVérticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoNodo = new Vertice();
            var_control = 2;
        }

        private void eliminarVérticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NodoEliminar = new Vertice();
        }

        private void eliminarArcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var_control = 3;
        }

        private void ptbMapa_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbDepartamentos.SelectedIndex != -1)
            {
                try
                {
                    string nodoValor = cmbDepartamentos.SelectedItem.ToString();
                    grafo.ColorearNodo(nodoValor);
                    Refresh();
                    Thread.Sleep(1000);
                    grafo.ReestablecerColorNodo(nodoValor);
                    Refresh();
                    Thread.Sleep(700);
                }
                catch
                {
                    MessageBox.Show("Nodo no encontrado");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un valor de búsqueda");
            }
        }

        private void btnAnchura_Click(object sender, EventArgs e)
        {
            if (cmbDepartamentos.SelectedIndex != -1)
            {
                try
                {
                    List<Vertice> resultado = new List<Vertice>();
                    Refresh();
                    Queue<Vertice> miCola = new Queue<Vertice>();

                    // Obtener el nodo inicial desde el ComboBox
                    string nodoInicial = cmbDepartamentos.SelectedItem.ToString();
                    Vertice nodo = grafo.BuscarVertice(nodoInicial);
                    miCola.Enqueue(nodo);

                    while (miCola.Count != 0)
                    {
                        nodo = miCola.Dequeue();
                        if (!resultado.Contains(nodo))
                        {
                            resultado.Add(nodo);
                        }
                        foreach (Arco arco in nodo.ListaAdyacencia)
                        {
                            if (!resultado.Contains(arco.nDestino))
                            {
                                miCola.Enqueue(arco.nDestino);
                            }
                        }
                    }

                    int sumarcos = 0, o, d;
                    List<Vertice> listnodos = new List<Vertice>();
                    StringBuilder recorrido = new StringBuilder();

                    foreach (Vertice node in resultado)
                    {
                        recorrido.AppendLine(node.Valor);
                        listnodos.Add(node);
                        grafo.ColorearNodo(node.Valor);
                        Refresh();
                        Thread.Sleep(500);
                        grafo.ReestablecerColorNodo(node.Valor);
                        Refresh();
                        Thread.Sleep(500);
                    }

                    recorrido.AppendLine();

                    for (int i = 1; i < listnodos.Count; i++)
                    {
                        o = grafo.returnindice(listnodos[i - 1]);
                        d = grafo.returnindice(listnodos[i]);
                        sumarcos += grafo.nodosadya[o, d];
                    }

                    recorrido.AppendLine("Distancia: " + sumarcos);

                    // Mostrar el MBAnchura
                    using (MBAnchura messageBox = new MBAnchura(recorrido.ToString(), "Recorrido en Anchura"))
                    {
                        messageBox.ShowDialog();
                    }

                    Refresh();
                }
                catch
                {
                    MessageBox.Show("Error al realizar recorrido");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un nodo inicial del ComboBox");
            }
        }


        private void btnProfundidad_Click(object sender, EventArgs e)
        {
            if (cmbDepartamentos.SelectedIndex != -1)
            {
                try
                {
                    List<Vertice> resultado = new List<Vertice>();
                    Refresh();
                    Stack<Vertice> miPila = new Stack<Vertice>();
                    StringBuilder recorrido = new StringBuilder();

                    // Obtener el nodo inicial desde el ComboBox
                    string nodoInicial = cmbDepartamentos.SelectedItem.ToString();
                    Vertice nodo = grafo.BuscarVertice(nodoInicial);
                    miPila.Push(nodo);

                    while (miPila.Count != 0)
                    {
                        nodo = miPila.Pop();
                        if (!resultado.Contains(nodo))
                        {
                            resultado.Add(nodo);
                        }
                        foreach (Arco arco in nodo.ListaAdyacencia)
                        {
                            if (!resultado.Contains(arco.nDestino))
                            {
                                miPila.Push(arco.nDestino);
                            }
                        }
                    }

                    int sumarcos = 0, o, d;
                    List<Vertice> listnodos = new List<Vertice>();

                    foreach (Vertice node in resultado)
                    {
                        recorrido.AppendLine(node.Valor);
                        listnodos.Add(node);
                        grafo.ColorearNodo(node.Valor);
                        Refresh();
                        Thread.Sleep(500);
                        grafo.ReestablecerColorNodo(node.Valor);
                        Refresh();
                        Thread.Sleep(500);
                    }

                    recorrido.AppendLine();

                    for (int i = 1; i < listnodos.Count; i++)
                    {
                        o = grafo.returnindice(listnodos[i - 1]);
                        d = grafo.returnindice(listnodos[i]);
                        sumarcos += grafo.nodosadya[o, d];
                    }

                    recorrido.AppendLine("Distancia: " + sumarcos);

                    // Mostrar el MBProfundidad
                    using (MBProfundidad messageBox = new MBProfundidad(recorrido.ToString(), "Recorrido en Profundidad"))
                    {
                        messageBox.ShowDialog();
                    }

                    Refresh();
                }
                catch
                {
                    MessageBox.Show("Error al mostrar recorrido");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un nodo inicial del ComboBox");
            }

        }

        private void ConfigurarNodos()
        {
            // Nodos de El Salvador
            nodosElSalvador = new Dictionary<string, Point>
            {
                { "Santa Ana", new Point(150, 103) },
                { "Ahuachapán", new Point(66, 155) },
                { "Sonsonate", new Point(122, 200) },
                { "Chalatenango", new Point(260, 80) },
                { "La Libertad", new Point(192, 210) },
                { "San Salvador", new Point(237, 177) },
                { "Cuscatlán", new Point(263, 145) },
                { "Cabañas", new Point(350, 150) },
                { "San Vicente", new Point(347, 208) },
                { "La Paz", new Point(283, 250) },
                { "Usulután", new Point(390, 275) },
                { "San Miguel", new Point(461, 250) },
                { "Morazán", new Point(488, 180) },
                { "La Unión", new Point(536, 255) }
            };

            // Nodos de Honduras
            nodosHonduras = new Dictionary<string, Point>
            {
                { "Atlántida", new Point(220, 110) },
                { "Colón", new Point(335, 105) },
                { "Comayagua", new Point(183, 177) },
                { "Copán", new Point(70, 170) },
                { "Cortés", new Point(150, 115) },
                { "Choluteca", new Point(233, 285) },
                { "El Paraíso", new Point(290, 227) },
                { "Francisco Morazán", new Point(227, 210) },
                { "Gracias a Dios", new Point(447, 135) },
                { "Intibucá", new Point(140, 200) },
                { "Islas de la Bahía", new Point(320, 50) },
                { "La Paz", new Point(165, 230) },
                { "Lempira", new Point(100, 220) },
                { "Ocotepeque", new Point(65, 200) },
                { "Olancho", new Point(320, 170) },
                { "Santa Bárbara", new Point(120, 140) },
                { "Valle", new Point(185, 270) },
                { "Yoro", new Point(213, 146) }
            };

            //Nodos de Costa Rica
            nodosCostaRica = new Dictionary<string, Point>
            {
                { "Alajuela", new Point(250, 95) },
                { "Cartago", new Point(345, 170) },
                { "Guanacaste", new Point(122, 90) },
                { "Heredia", new Point(310, 90) },
                { "Limón", new Point(415, 180) },
                { "Puntarenas", new Point(405, 260) },
                { "San José", new Point(263, 175) }
            };
        }

        private void CargarNodos(string pais)
        {
            grafo = new Grafo();
            cmbDepartamentos.Items.Clear();
            Dictionary<string, Point> nodos;

            if (pais == "El Salvador")
            {
                nodos = nodosElSalvador;
            }
            else if (pais == "Honduras")
            {
                nodos = nodosHonduras;
            }
            else if (pais == "Costa Rica")
            {
                nodos = nodosCostaRica;
            }
            else
            {
                // Añadir lógica para otros países si es necesario
                return;
            }

            foreach (var kvp in nodos)
            {
                var nodo = new Vertice { Posicion = kvp.Value, Valor = kvp.Key };
                grafo.AgregarVertice(nodo);
                cmbDepartamentos.Items.Add(nodo.Valor);
            }
        }

        private void LimpiarNodos()
        {
            grafo = new Grafo();
            cmbDepartamentos.Items.Clear();
        }


    }
}
