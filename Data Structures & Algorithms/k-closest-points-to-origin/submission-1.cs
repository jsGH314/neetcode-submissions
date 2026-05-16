public class Solution 
{
    public int[][] KClosest(int[][] points, int k) 
    {
        Array.Sort(points, (p1, p2) => 
        {
            return EuclidDistance(p1[0], 0, p1[1], 0).CompareTo(EuclidDistance(p2[0], 0, p2[1], 0));
        });

        return points.Take(k).ToArray();
    }

    public double EuclidDistance(int x1, int x2, int y1, int y2)
    {
        return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    }
}