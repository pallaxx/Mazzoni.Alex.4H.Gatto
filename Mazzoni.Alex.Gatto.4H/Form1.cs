using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mazzoni.Alex.Gatto._4H.Models;

namespace Mazzoni.Alex.Gatto._4H
{
    public partial class Form1 : Form
    {
        const int LATO_X = 200; //DICHIARAZIONE DEI MARGINI DEL FOGLIO
        const int LATO_Y = 300;

        const int MARGINE_SINISTRO = 100;
        const int MARGINE_DESTRO = 100;
        const int MARGINE_SUPERIORE = 100;
        const int MARGINE_INFERIORE = 100;


        const int LATO_X_FORM = (MARGINE_SINISTRO + LATO_X + MARGINE_DESTRO);
        const int LATO_Y_FORM = (MARGINE_SUPERIORE + LATO_Y + MARGINE_INFERIORE);

        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
            this.MaximumSize = new Size(LATO_X_FORM, LATO_Y_FORM);
        }
        private int X(double x)
        {
            int xLogico = 0;
            xLogico = (int)(x) + MARGINE_SINISTRO;
            return xLogico;
        }
        private int Y(double y)
        {
            int yLogico = 0;
            yLogico = (MARGINE_SUPERIORE + LATO_Y - (int)(y));
            return yLogico;
        }

        private void btnCalcola_Click_1(object sender, EventArgs e)
        {
            int i;
            Graphics dc = this.CreateGraphics();
            Pen BlackPen = new Pen(Color.Black, 1); //PENNA NERA
            
            Punto[] contornocorpo = new Punto[13]; //CREA CORPO DEL GATTO

            contornocorpo[0] = new Punto(0, 0); //DICHIARAZIONE DI TUTTI I PUNTI DEI CONTORNI
            contornocorpo[1] = new Punto(40, 0);
            contornocorpo[2] = new Punto(60, 20);
            contornocorpo[3] = new Punto(100, 20);
            contornocorpo[4] = new Punto(120, 0);
            contornocorpo[5] = new Punto(120, 20);
            contornocorpo[6] = new Punto(140, 0);
            contornocorpo[7] = new Punto(140, 20);
            contornocorpo[8] = new Punto(100, 60);
            contornocorpo[9] = new Punto(60, 60);
            contornocorpo[10] = new Punto(40, 40);
            contornocorpo[11] = new Punto(20, 40);
            contornocorpo[12] = new Punto(20, 20);

            for (i = 0; i < 13; i++) //linea continua per disegnare i controni
            {
                int j = i + 1;
                if (j == 13) j = 0;
                dc.DrawLine(BlackPen, X(contornocorpo[i].X), Y(contornocorpo[i].Y), X(contornocorpo[j].X), Y(contornocorpo[j].Y));
            }
            
            //Dettagli Contorni
            Punto[] dettaglicorpo = new Punto[4];

            dettaglicorpo[0] = new Punto(20, 0); //stacco fra le due zampette iniziali
            dettaglicorpo[1] = new Punto(40, 20);

            dettaglicorpo[2] = new Punto(100, 20); //stacco fra le zampette dietro
            dettaglicorpo[3] = new Punto(120, 20);

            for (i=0;i<4;i=i+2) //Disegna le prime due line e poi salta nell'array alle linee successive
                dc.DrawLine(BlackPen, X(dettaglicorpo[i].X), Y(dettaglicorpo[i].Y), X(dettaglicorpo[i+1].X), Y(dettaglicorpo[i+1].Y));
            //-------------------------------------------------------------------------

            Punto[] contornotesta = new Punto[8]; //TESTA DEL GATTO

            contornotesta[0] = new Punto(20, 40); //DICHIARAZIONE DI TUTTI I PUNTI DEI CONTORNI
            contornotesta[1] = new Punto(0, 60);
            contornotesta[2] = new Punto(0, 100);
            contornotesta[3] = new Punto(20, 80);
            contornotesta[4] = new Punto(40, 80);
            contornotesta[5] = new Punto(60, 100);
            contornotesta[6] = new Punto(60, 60);
            contornotesta[7] = new Punto(40, 40);

            for (i = 0; i < 8; i++) //linea continua per disegnare i controni
            {
                int j = i + 1;
                if (j == 8) j = 0;
                dc.DrawLine(BlackPen, X(contornotesta[i].X), Y(contornotesta[i].Y), X(contornotesta[j].X), Y(contornotesta[j].Y));
            }
            //-------------------------------------------------------------------------

            Punto[] contornocoda = new Punto[8]; //CODA DEL GATTO

            contornocoda[0] = new Punto(120, 40); //DICHIARAZIONE DI TUTTI I PUNTI DEI CONTORNI
            contornocoda[1] = new Punto(120, 60);
            contornocoda[2] = new Punto(140, 60);
            contornocoda[3] = new Punto(160, 40);
            contornocoda[4] = new Punto(160, 60);
            contornocoda[5] = new Punto(140, 80);
            contornocoda[6] = new Punto(120, 80);
            contornocoda[7] = new Punto(100, 60);

            for (i = 0; i < 8; i++) //linea continua per disegnare i controni
            {
                int j = i + 1;
                if (j == 8) j = 0;
                dc.DrawLine(BlackPen, X(contornocoda[i].X), Y(contornocoda[i].Y), X(contornocoda[j].X), Y(contornocoda[j].Y));
            }
        }

        private void button3_Click(object sender, EventArgs e) //CREA MARGINE E QUADRETTI GUIDA PER PRENDERE I PUNTI DELLA FIGURA
        {
            int Opacita=40; //Opacita' dei quadretti
            int i=0;
            Graphics dc = this.CreateGraphics();
            Pen BluePen = new Pen(Color.Blue, 1);
            Pen TransparentPen = new Pen(Color.FromArgb(Opacita, 255, 0, 0), 1); //ARGB(Opacita, ROSSO, VERDE, BLU, SPESSORE)

            //MARGINE CON PENNA BLU
            dc.DrawRectangle(BluePen, MARGINE_SINISTRO + 0, MARGINE_SUPERIORE + 0, LATO_X, LATO_Y);

            //ISTANZIARE PUNTI PER FARE I QUADRETTI CON PENNA ROSSA
            Punto QuadrettiX = new Punto(0, 0);
            Punto QuadrettiY = new Punto(0, 0);

            //RIGHE VERTICALI 
            QuadrettiY.Y = LATO_Y; //poiche' le linee deveno arrivare sempre da 0 a 300 (marginidelfoglio)
            for(i=0;i<9;i++)
            {
                QuadrettiX.X += 20;
                QuadrettiY.X += 20;
                dc.DrawLine(TransparentPen, X(QuadrettiX.X), Y(QuadrettiX.Y), X(QuadrettiY.X), Y(QuadrettiY.Y));
            }


            //poiche' le variabili son tutte sfasate con valori del precedente for le inizializzo 
            //per creare le linee dei quadretti in orizzontale
            QuadrettiX.X = 0;
            QuadrettiX.Y = 0;
            QuadrettiY.X = LATO_X;
            QuadrettiY.Y = 0;

            //RIGHE ORIZZONTALI
            for (i=0;i<14;i++)
            {
                QuadrettiX.Y += 20;
                QuadrettiY.Y += 20;
                dc.DrawLine(TransparentPen, X(QuadrettiX.X), Y(QuadrettiX.Y), X(QuadrettiY.X), Y(QuadrettiY.Y));
            }
        }

    }
}
