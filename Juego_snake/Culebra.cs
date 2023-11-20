using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_snake
{
    public class Culebra
    {
        public int escala = 10;
        public int longmap = 30;
        private int[,] cuadros;
        private List<Scuad> Snake;

        public enum Direccion { derecha, abajo, izquierda, arriba}
        public Direccion DireccionActual = Direccion.derecha;
        private Scuad Comida = null;
        private Random oRandom = new Random();
        private int Puntos = 0 ;

        PictureBox oPictureBox;
        Label labelPuntos;

        //funcion que me da la posicion en x de la cabeza de la culebra 
        private int PosInicialx
        {
            get
            {
                return longmap / 2;
            }
        }

        //funcion que me da la posicion en y de la cabeza de la culebra 
        private int PosInicialy
        {
            get
            {
                return longmap / 2;
            }
        }

        //funcion que hace que perdamos cuando un cuadro de la culebra este en la misma posicion de otro 
        public bool GameOver
        {
            get
            {
                foreach (var oscuad in Snake)
                {
                    if(Snake.Where(d=> d.y== oscuad.y && d.x== oscuad.x && oscuad!=d).Count()>0)
                        return true;

                    if (Snake.Where(d => d.y == 0 || d.x == 0 ).Count() > 0)
                        return true;
                }
                return false;
            }
        }


        public Culebra(PictureBox oPictureBox, Label labelPuntos)
        {
            this.oPictureBox = oPictureBox;
            this.labelPuntos = labelPuntos;
            Reiniciar();
        }

        //funcion para reiniciar el juego, la cabeza vuelve a la posicion unicial 
        public void Reiniciar()
        {
            Snake = new List<Scuad>();
            Scuad ocuadinicial = new Scuad(PosInicialx, PosInicialy);
            Snake.Add(ocuadinicial);

            cuadros = new int[longmap, longmap];
            for (int j=0; j<longmap; j++)
            {
                for (int i=0; i<longmap; i++)
                {
                    cuadros[i, j] = 0;
                }
            }

            Puntos = 0 ;
        }

        //funcion para ir pintando la culebra y la comida 
        public void Show()
        {
            Bitmap bmp = new Bitmap(oPictureBox.Width, oPictureBox.Height);
            for (int j = 0; j< longmap; j++)
            {
                for (int i = 0; i< longmap; i ++)
                {
                    if (Snake.Where(d => d.x == i && d.y == j).Count() > 0)
                        PintarPixel(bmp, i, j, Color.Black);
                    else
                        PintarPixel(bmp, i, j, Color.DarkSeaGreen);
                }

            }

            if (Comida != null)
                PintarPixel(bmp, Comida.x, Comida.y, Color.Red);

            oPictureBox.Image = bmp;

            labelPuntos.Text = Puntos.ToString(); 
        }

        //funcion para el movimiento de la culebra 
        public void Next()
        {

            GetMoviSnake();

            if (Comida == null)
            {
                GetComida();
            }

            switch (DireccionActual)
            {
                case Direccion.derecha:
                    {
                        if (Snake[0].x == (longmap -1))
                            Snake[0].x = 0;
                        else
                            Snake[0].x++;
                        break;

                    }

                case Direccion.izquierda:
                    {
                        if (Snake[0].x == 0)
                            Snake[0].x = longmap-1;
                            
                        else
                            Snake[0].x--;
                        break;

                    }

                case Direccion.abajo:
                    {
                        if (Snake[0].y == (longmap - 1))
                            Snake[0].y = 0;
                        else
                            Snake[0].y++;
                        break;

                    }

                case Direccion.arriba:
                    {
                        if (Snake[0].y == 0)
                            Snake[0].y = longmap-1;
                        else
                            Snake[0].y--;
                        break;

                    }
            }

            GetProxMovSnake();

            SnakeEating();
        }

        //funcion que asigna cada cuadro de la culebra a su nueva posicion para poder ir alargando 
        private void GetProxMovSnake()
        {
            if (Snake.Count > 1)
            {
                for (int i = 1; i< Snake.Count; i++)
                {
                    Snake[i].x = Snake[i - 1].x_pas;
                    Snake[i].y = Snake[i - 1].y_pas;
                }
            }

        }

        //funcion para saber la ultima posicion en la que estuvo la culebra
        private void GetMoviSnake()
        {
            foreach ( var oscuad in Snake )
            {
                oscuad.x_pas = oscuad.x;
                oscuad.y_pas = oscuad.y;
            }
        }

        //funcion para que la culebra se coma la comida y cada que se coma una manzana se suma un punto y se suma
        //un cuadro a la culebra 
        private void SnakeEating ()
        {
            if (Snake[0].x == Comida.x && Snake[0].y == Comida.y)
            {
                Comida = null;
                Puntos++;
                Scuad Lastscuad = Snake[Snake.Count - 1];
                Scuad oscuad = new Scuad(Lastscuad.x_pas, Lastscuad.y_pas);
                Snake.Add(oscuad);
            }
        }

        // funcion para que aparezca la comida aleatoriamente
        private void GetComida()
        {
            int x = oRandom.Next(0,longmap-1);
            int y = oRandom.Next(0,longmap-1);

            Comida = new Scuad(x,y);    
        }


        // funcion que pinta los pixeles de la culebra (cada cuadro de la culebra mide 10*10 pixeles)
        private void PintarPixel(Bitmap bmp, int x,int y, Color color)
        {
            for (int j = 0; j< escala; j++)
            {
                for (int i=0; i < escala; i++)
                {
                    bmp.SetPixel(i + (x*escala), j + (y * escala), color);
                }
            }
        } 

    }
    public class Scuad
    {
        public int x, y, x_pas, y_pas;
        public Scuad(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.x_pas = x;
            this.y_pas = y;
        }
    }
}
