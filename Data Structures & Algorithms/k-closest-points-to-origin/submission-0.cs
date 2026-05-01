public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],double> minHeap = new PriorityQueue<int[],double>();
        foreach(var xy in points){
            int x = xy[0];
            int y = xy[1];

            double So = Math.Sqrt((0-x) * (0-x) + (0-y) * (0-y));
            minHeap.Enqueue(xy,So); 
        }
        int[][] res = new int[k][];
        int i=0;

        while(minHeap.Count > 0 && i < k){
            res[i] = minHeap.Dequeue();
            i++;
        }

        return res;
    }
}
