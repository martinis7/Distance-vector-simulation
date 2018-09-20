using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DistanceVector
{
    public class Router
    {
        private static int _counter = -1;
        public int Id { get; set; }    
        // -1 = i save
        // -2 = nera ar nepazymetas
        public int[] NextHop { get; set; }
        public int[] ValuesToLinks { get; set; }
        public List<Router> Neighbors { get; set; }
        public int[,] Vector { get; set; }

        public Router()
        {
            Id = Interlocked.Increment(ref _counter);
        }

        public void InitializeBeforeStart()
        {
            // susirasom distance vektorius
            foreach (var neighbor in Neighbors)
            {
                int id = neighbor.Id;
                for (int i = 0; i < _counter+1; i++)
                {
                    Vector[id, i] = neighbor.Vector[neighbor.Id, i];
                }
            }
        }
        public void Run()
        {
            BellmanFord();
        }

        public void SendVector()
        {
            int[] thisVector = GenerateVector();
            foreach (var neighbor in Neighbors)
            {
                neighbor.GetVector(thisVector);
            }
        }

        private int[] GenerateVector()
        {
            int n = NextHop.Length;
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Vector[Id, i];
            }
            return x;
        }

        public void GetVector(int[] neighborVector)
        {
            // gauname vektoriu is kaimyno (kaimynu) 
            // 1. persikopijuot kaimyno vektoriu
            // 2. atnaujint savo vektoriu (jei ivyksta atnaujinimas, vel reikia kviest send)

            // Persikopijuojam kaimyno vektoriu
            int neighborId = -1;
            for (int i = 0; i < neighborVector.Length; i++)
            {
                if (neighborVector[i] == 0) neighborId = i;
            }
            if (neighborId >= 0)
            {
                for (int i = 0; i < neighborVector.Length; i++)
                {
                    Vector[neighborId, i] = neighborVector[i];
                }
            }
            // Paziurim ar reikia atnaujint savo vektoriu          
            BellmanFord();
        }

        public void BellmanFord()
        {
            int n = NextHop.Length;
            int[] newVector = new int[n];
            int[] newNextHop = new int[n];
            newVector[Id] = 0;
            newNextHop[Id] = 0;
            
            for (int i = 0; i < n; i++)
            {
                List<DistanceHop> distanceAndNextHop = new List<DistanceHop>();
                if (i != Id)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (j != Id)
                        {
                            int x = Vector[Id, j];
                            int y = Vector[j, i];
                            distanceAndNextHop.Add(new DistanceHop(x+y,j));
                        }
                    }
                    int a = distanceAndNextHop.Select(x => Convert.ToInt32(x.Distance)).Min();
                    int hop = -1;
                    foreach (var distance in distanceAndNextHop)
                    {
                        hop = distance.GetHopByDistance(a);
                        if (hop != -1) break;
                    }
                    newVector[i] = a;
                    newNextHop[i] = hop;
                }
            }

            bool changed = false;
           
            for (int i = 0; i < n; i++)
            {
                if (Vector[Id,i] > newVector[i])
                {
                    Vector[Id, i] = newVector[i];
                    NextHop[i] = newNextHop[i];
                    changed = true;
                }
            }
            if (changed) SendVector();
        }
    }
}
