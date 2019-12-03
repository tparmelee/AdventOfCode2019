using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    public class WirePathCalculator
    {

        public static int FindClosetIntersectionManhattenDistance(List<string> path1moves, List<string> path2moves)
        {
            Dictionary<(int, int), int> path1 = FindPathPoints(path1moves);
            Dictionary<(int, int), int> path2 = FindPathPoints(path2moves);

            List<(int, int)> overlapping = path1.Keys.Where(x => path2.ContainsKey(x)).ToList();

            int minDistance = int.MaxValue;
            foreach ((int, int) overlap in overlapping)
            {

                int dist = ManhattenDistance(overlap);
                if (minDistance > dist)
                    minDistance = dist;
            }

            return minDistance;
        }

        public static int FindIntersectionWithShortestNumberOfSteps(List<string> path1moves, List<string> path2moves)
        {
            Dictionary<(int, int), int> path1 = FindPathPoints(path1moves);
            Dictionary<(int, int), int> path2 = FindPathPoints(path2moves);

            List<(int, int)> overlapping = path1.Keys.Where(x => path2.ContainsKey(x)).ToList();

            int minSteps = int.MaxValue;
            foreach ((int, int) o in overlapping)
            {
                int s1 = path1[o];
                int s2 = path2[o];

                int steps = s1 + s2;
                if (minSteps > steps)
                    minSteps = steps;
            }

            return minSteps;
        }

        private static Dictionary<(int, int), int> FindPathPoints(List<string> moves)
        {
            Dictionary<(int, int), int> points = new Dictionary<(int, int), int>();
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
                    points.TryAdd((x, y), steps);
                }
            }
            return points;
        }

        private static int ManhattenDistance((int, int) p)
        {
            return Math.Abs(p.Item1) + Math.Abs(p.Item2);
        }
    }
}
