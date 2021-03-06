﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_A_StarAlgo
{
    class Program
    {
        public static void unitTest_AStar()
        {
            char[][] matrix = new char[][] { new char[] {'-', 'S', '-', '-', 'X'},
                                         new char[] {'-', 'X', 'X', '-', '-'},
                                         new char[] {'-', '-', '-', 'X', '-'},
                                         new char[] {'X', '-', 'X', 'E', '-'},
                                         new char[] {'-', '-', '-', '-', 'X'}};

            //looking for shortest path from 'S' at (0,1) to 'E' at (3,3)
            //obstacles marked by 'X'
            int fromX = 0, fromY = 1, toX = 3, toY = 3;
            matrixNode endNode = AStar(matrix, fromX, fromY, toX, toY);

            //looping through the Parent nodes until we get to the start node
            Stack<matrixNode> path = new Stack<matrixNode>();

            while (endNode.x != fromX || endNode.y != fromY)
            {
                path.Push(endNode);
                endNode = endNode.parent;
            }
            path.Push(endNode);

            Console.WriteLine("The shortest path from  " +
                              "(" + fromX + "," + fromY + ")  to " +
                              "(" + toX + "," + toY + ")  is:  \n");

            while (path.Count > 0)
            {
                matrixNode node = path.Pop();
                Console.WriteLine("(" + node.x + "," + node.y + ")");
            }
        }

        public class matrixNode
        {
            public int fr = 0, to = 0, sum = 0;
            public int x, y;
            public matrixNode parent;
        }

        public static matrixNode AStar(char[][] matrix, int fromX, int fromY, int toX, int toY)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // in this version an element in a matrix can move left/up/right/down in one step, two steps for a diagonal move.
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //the keys for greens and reds are x.ToString() + y.ToString() of the matrixNode 
            Dictionary<string, matrixNode> greens = new Dictionary<string, matrixNode>(); //open 
            Dictionary<string, matrixNode> reds = new Dictionary<string, matrixNode>(); //closed 

            matrixNode startNode = new matrixNode { x = fromX, y = fromY };
            string key = startNode.x.ToString() + startNode.x.ToString();
            greens.Add(key, startNode);

            Func<KeyValuePair<string, matrixNode>> smallestGreen = () =>
            {
                KeyValuePair<string, matrixNode> smallest = greens.ElementAt(0);

                foreach (KeyValuePair<string, matrixNode> item in greens)
                {
                    if (item.Value.sum < smallest.Value.sum)
                        smallest = item;
                    else if (item.Value.sum == smallest.Value.sum
                            && item.Value.to < smallest.Value.to)
                        smallest = item;
                }

                return smallest;
            };


            //add these values to current node's x and y values to get the left/up/right/bottom neighbors
            List<KeyValuePair<int, int>> fourNeighbors = new List<KeyValuePair<int, int>>()
                                            { new KeyValuePair<int, int>(-1,0),
                                              new KeyValuePair<int, int>(0,1),
                                              new KeyValuePair<int, int>(1, 0),
                                              new KeyValuePair<int, int>(0,-1) };

            int maxX = matrix.GetLength(0);
            if (maxX == 0)
                return null;
            int maxY = matrix[0].Length;

            while (true)
            {
                if (greens.Count == 0)
                    return null;

                KeyValuePair<string, matrixNode> current = smallestGreen();
                if (current.Value.x == toX && current.Value.y == toY)
                    return current.Value;

                greens.Remove(current.Key);
                reds.Add(current.Key, current.Value);

                foreach (KeyValuePair<int, int> plusXY in fourNeighbors)
                {
                    int nbrX = current.Value.x + plusXY.Key;
                    int nbrY = current.Value.y + plusXY.Value;
                    string nbrKey = nbrX.ToString() + nbrY.ToString();
                    if (nbrX < 0 || nbrY < 0 || nbrX >= maxX || nbrY >= maxY
                        || matrix[nbrX][nbrY] == 'X' //obstacles marked by 'X'
                        || reds.ContainsKey(nbrKey))
                        continue;

                    if (greens.ContainsKey(nbrKey))
                    {
                        matrixNode curNbr = greens[nbrKey];
                        int from = Math.Abs(nbrX - fromX) + Math.Abs(nbrY - fromY);
                        if (from < curNbr.fr)
                        {
                            curNbr.fr = from;
                            curNbr.sum = curNbr.fr + curNbr.to;
                            curNbr.parent = current.Value;
                        }
                    }
                    else
                    {
                        matrixNode curNbr = new matrixNode { x = nbrX, y = nbrY };
                        curNbr.fr = Math.Abs(nbrX - fromX) + Math.Abs(nbrY - fromY);
                        curNbr.to = Math.Abs(nbrX - toX) + Math.Abs(nbrY - toY);
                        curNbr.sum = curNbr.fr + curNbr.to;
                        curNbr.parent = current.Value;
                        greens.Add(nbrKey, curNbr);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            unitTest_AStar();
        }
    }
}
