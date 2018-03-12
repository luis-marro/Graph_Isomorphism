using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Discreta
{
    class Grafo
    {
        private Vertice[] vertices;
        private int[,] matriz;
        public static int IndexG1 = 0;


        public string nombreVertices()
        {
            string nombres = ""; 
            for(int i = 0; i < vertices.Length; i++)
            {
                nombres += i.ToString() + " , " ; 
            }
            return nombres; 
        }

        public int[,] getMatrix()
        {
            return this.matriz; 
        }

        public Grafo(int cantidadVertices)
        {
            vertices = new Vertice[cantidadVertices];
            for(int i = 0; i < cantidadVertices; i++)
            {
                vertices[i] = new Vertice(); 
                vertices[i].name = i; 
            }
            matriz = new int[cantidadVertices, cantidadVertices];
        }

        /// <summary>
        /// Devuelve la cantidad de Vertices
        /// </summary>
        /// <returns></returns>
        public int getCantidadVertices()
        {
            return this.vertices.Length; 
        }

        /// <summary>
        /// Este método devuelve el vertice en la posicion del arreglo indicada en el parametro 
        /// Usarlo para evaluar un vértice individual
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        public Vertice getInicioFin(int posicion)
        {
            return this.vertices[posicion]; 
        }

        /// <summary>
        /// ESte método ingresa los vertices leidos en el archibvo a un 
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="final"></param>
        public void agregarVertices(List<int> inicio, List<int> final) //Arreglo "inicio" contiene los nombres de los vertices, "fin" el destino de cada arista
        {
            for(int i = 0; i < inicio.Count; i++)
            {
                vertices[inicio[i]].final.Add(final[i]); //Vertices[posicion del nombre del vertice inicio le asigna 
                                                         //el valor correspondiente de destino de la arista 
                vertices[final[i]].final.Add(inicio[i]); 
            }

            foreach(Vertice v in vertices)
            {
                for(int i = 0; i < v.final.Count; i++)
                {
                    vertices[v.name].verticesDestino.Add(vertices[v.final[i]]); 
                }
            }
            generarMatriz(); 
        }
        

        /// <summary>
        /// Método que comprueba si ambos grafos tienen la misma cantidad de vertices con el mismo grado. 
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        int[] gradoPorVertice(Grafo g)
        {
            int[] ordenado = new int[g.vertices.Length]; 
            
            for(int i = 0; i < ordenado.Length; i++)
            {
                ordenado[i] = g.vertices[i].getGrado(); 
            }

            Array.Sort(ordenado);
            return ordenado; 
        }

        bool igualGrado(int[] a, int[] b)
        {
            
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                    continue;
                else
                    return false; 
            }
            return true; 
            
                        
        }
            
             
        

        bool igualAristas(Grafo g1, Grafo g2)
        {
            int total1 = 0;
            int total2 = 0; 

            foreach (Vertice v in g1.vertices)
            {
                total1 += v.getGrado();
            }

            foreach (Vertice v in g2.vertices)
            {
                total2 += v.getGrado();
            }

            if ((total1 / 2) == (total2 / 2))
                return true;
            else
                return false; 

        }


        bool mismaCantidadVertices(Grafo g1, Grafo g2)
        {
            if (g1.vertices.Length == g2.vertices.Length)
                return true;
            else
                return false; 
        }

        /// <summary>
        /// Este método comprueba con todos los filtros el isomorfismo de un par de grafos. 
        /// </summary>
        /// <param name="g1"></param>
        /// <param name="g2"></param>
        /// <returns></returns>
        public string esIsomorfo(Grafo g1, Grafo g2)
        {
            if (!mismaCantidadVertices(g1, g2))
                return "No tienen la misma cantidad de vertices"; 
            else
            {
                if (!igualGrado(g1.gradoPorVertice(g1), g2.gradoPorVertice(g2)))
                    return "No Concuerdan los grados de los vertices";
                else
                {
                    if (!igualAristas(g1, g2))
                        return "No tienen la misma cantidad de aristas";
                    else
                    {
                        if(IsKComplete(g1.vertices, g2.vertices))
                        {
                            return funcionGrafoCompleto(g1, g2); 
                        }
                        else
                        {
                            return ""; 
                        }
                        //string aRetornar = "";
                        //for (int i = 0; i < vertices.Length; i++)
                        //{
                        //    aRetornar += "("+FuntionCorrespondTo(g1.matriz, g2.matriz)+")"+" ";
                        //}

                        //if (aRetornar.Contains("Isomorfismo"))
                        //{
                        //    return "No Hay Isomorfismo";
                        //}
                        //else
                        //    return aRetornar; 
                    }
                }
            }
        }


        private void generarMatriz()
        {
            foreach (Vertice v in this.vertices)
            {
                for (int i = 0; i < v.final.Count; i++)
                {
                    this.matriz[v.name, v.final[i]] = 1;
                }
            }
        }

        

        //public string FuntionCorrespondTo(int[,] G1, int[,] G2)
        //{
        //    int aux = 0;
        //    int indexG2 = 0;
        //    int same = G1.GetLength(0);
        //    int comparison = 0;
        //    string cad = "";

            
                
        //            for (int i = 0; i < G1.GetLength(0); i++)
        //            {
        //            if (IndexG1 < G1.GetLength(0) && indexG2 < G1.GetLength(0))
        //            {
        //                if (G1[IndexG1, aux] == G2[indexG2, i])
        //                {
        //                    comparison++;
        //                    aux++;
        //                }
        //                else
        //                {
        //                    indexG2++;
        //                    i = -1;
        //                    comparison = 0;
        //                    aux = 0;
        //                }
        //                if (comparison == G1.GetLength(0))
        //                {

        //                    cad = IndexG1.ToString() + "," + indexG2.ToString();
        //                    IndexG1++;
        //                    return cad;
        //                }
        //            }
        //    }
        //        for (int i = 0; i < G2.GetLength(0); i++)
        //        {
        //            int zeroValue = 0;
        //            indexG2 = 0;
        //            if (G2[indexG2, i] == 0)
        //            {
        //                zeroValue++;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //            if (zeroValue == G2.GetLength(0))
        //            {
        //                G2[indexG2, zeroValue] = 1;
        //            }
        //        }

                
            
        //    return "No hay Isomomorfismo";
        //}

        //public string funcionIsomorfismo(Grafo g1, Grafo g2)
        //{
        //    Stack<Vertice> funcion = new Stack<Vertice>();
        //    int g1count = 0;
        //    int g2count = 0; 
        //    string[] respuesta = new string[2]; 
            
        //    funcion.Push(g2.vertices[0]); 

        //    while(funcion.Count < g1.vertices.Length)
        //    {
        //        if(g1.vertices[g1count].getGrado() == g2.vertices[g2count+1].getGrado())
        //        {
        //            funcion.Push(g2.vertices[++g2count]); 
        //        }
        //        else
        //        {
        //            g1count++;
        //            g2count++;
        //        }
        //    }
        //}

        string funcionGrafoCompleto(Grafo g1, Grafo g2)
        {
            string funcion = ""; 

            for(int i = 0; i < g1.vertices.Length; i++)
            {
                funcion += "(" + g1.vertices[i].name + "," + g2.vertices[i].name + ") , ";  
            }

            return funcion; 
        }

        public bool IsKComplete(Vertice[] G1, Vertice[] G2)
        {
            bool flag = true;
            int gradKomplete = G1.Length - 1;

            for (int i = 0; i < G2.Length; i++)
            {
                if (G1[i].getGrado() == gradKomplete)
                {
                    if (G2[i].getGrado() == gradKomplete)
                    {
                        flag = true;
                    }
                }
                else
                {
                    flag = false;
                    return flag;
                }
        
            }
            return flag;
        }

    }
}
