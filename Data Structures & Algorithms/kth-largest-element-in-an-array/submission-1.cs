public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> maxHeap = new PriorityQueue<int,int>();
        foreach(int num in nums){
            maxHeap.Enqueue(-num,-num);
        }
        int i = 1;
        while(i<k){
            maxHeap.Dequeue();
            i++;
        }

        return maxHeap.Peek() > 0 ? -maxHeap.Peek() : Math.Abs(maxHeap.Peek()); 
    }
}
