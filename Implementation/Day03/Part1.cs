using Implementation.Day03;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    public class Part1
    {

        public static int FindClosetIntersectionManhattenDistanceV2(List<string> path1moves, List<string> path2moves)
        {
            int minDistance = int.MaxValue;

            Dictionary<(int, int), Point> path1 = FindPathPoints(path1moves);
            Dictionary<(int, int), Point> path2 = FindPathPoints(path2moves);

            List<(int, int)> overlapping = path1.Keys.Where(x => path2.ContainsKey(x)).ToList();


            foreach ((int, int) o in overlapping)
            {
                Point p1 = path1[o];
                Point p2 = path2[o];

                int dist = p1.ManhattenDistance();
                if (minDistance > dist)
                    minDistance = dist;
            }

            return minDistance;
        }
        
        private static Dictionary<(int, int), Point> FindPathPoints(List<string> moves)
        {
            Dictionary<(int, int), Point> points = new Dictionary<(int, int), Point>();
            int x = 0;
            int y = 0;
            int steps = 0;

            foreach (string move in moves)
            {
                string dir = move.Substring(0, 1);
                int len = int.Parse(move.Replace(dir, ""));

                for (int i = 0; i < len; i++)
                {
                    switch(dir)
                    {
                        case "L":
                            x--;
                            break;
                        case "R":
                            x++;
                            break;
                        case "D":
                            y--;
                            break;
                        case "U":
                            y++;
                            break;
                        default:
                            throw new ArgumentException();
                    }
                    steps++;
                    //points.Add(new Point(x, y, steps));
                    points.TryAdd((x, y), new Point(x, y, steps));
                }
            }
            return points;
        }
    }
}
