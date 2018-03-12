using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discreta
{
    class Vertice
    {
        public int name; //Numero (nombre) del vertice 
        public List<int> final = new List<int>(); //Lista de vertices finales (aristas) sirve para obtener el grado de un vertice 
        public List<Vertice> verticesDestino = new List<Vertice>(); 
        
        public Vertice(int name, int final)
        {
            this.name = name;
            this.final.Add(final); 
        }
        public Vertice()
        {

        }


        void agregarFinal(int final)
        {
            this.final.Add(final); 
        }

        public int getGrado()
        {
            return this.final.Count; 
        }

    }
}
