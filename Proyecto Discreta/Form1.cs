using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Proyecto_Discreta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Arreglo de grafos 
        Grafo[] grafos = new Grafo[2]; 
        static int contador = 0; 

        private void escribirGrafos(int count)
        {
            if(count == 0)
            {
                LbLVertices1.Text = grafos[0].nombreVertices(); 
            }
            if(count == 1)
            {
                LbLVertices1.Text = grafos[0].nombreVertices();
                LBLVertices2.Text = grafos[1].nombreVertices();  
            }
        }

        private void BtCargar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    string line = "";
                    line = reader.ReadLine();
                    List<int> inicios = new List<int> { };
                    List<int> fin = new List<int> { };
                    grafos[contador] = new Grafo(int.Parse(line)); 
                    line = reader.ReadLine(); 
                    while(line != null)
                    {
                        var puntos = line.Split(',');
                        inicios.Add(int.Parse(puntos[0]));
                        fin.Add(int.Parse(puntos[1]));
                        line = reader.ReadLine(); 
                    }

                    grafos[contador].agregarVertices(inicios, fin);
                    escribirGrafos(contador); 
                    
                    if (contador > 1)
                        contador = 0;
                }
            }

            if(contador == 0)
            {
                for (int i = 0; i < grafos[0].getInicioFin(i).final.Count; i++)
                {
                    for (int j = 0; j < grafos[0].getInicioFin(i).final.Count; j++)
                    {
                        Grafo1.Series["Series1"].Points.AddXY(grafos[0].getInicioFin(i).name, grafos[0].getInicioFin(i).final[j]);
                    }

                }
            }
            if(contador == 1)
            {
                for (int i = 0; i < grafos[1].getInicioFin(i).final.Count; i++)
                {
                    for (int j = 0; j < grafos[1].getInicioFin(i).final.Count; j++)
                    {
                        Grafo2.Series["Series1"].Points.AddXY(grafos[1].getInicioFin(i).name, grafos[1].getInicioFin(i).final[j]);
                    }

                }
            }

            contador++;

        }

        private void BtIsomorfismo_Click(object sender, EventArgs e)
        {
            if (grafos[0] != null && grafos[1] != null)
            {
                LbLFuncion.Text = grafos[0].esIsomorfo(grafos[0], grafos[1]);
            }
            else
                MessageBox.Show("No ha ingresado grafos al programa"); 
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            grafos[0] = null;
            grafos[1] = null;
            contador = 0;
            LbLVertices1.Text = "";
            LBLVertices2.Text = "";
            LbLFuncion.Text = "";
            Grafo.IndexG1 = 0; 
        }
    }
}
