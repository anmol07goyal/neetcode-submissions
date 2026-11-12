public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair = new int [position.Length][];
        for (int i = 0; i < position.Length; i++) 
            pair[i] = [position[i], speed[i]];

        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        
        Stack<double> stack = new();
        for (int i = 0; i < position.Length; i++) {
            double time = (double)(target - pair[i][0])/pair[i][1];
            if (stack.Count == 0 || time > stack.Peek())
                stack.Push(time);
        }
        return stack.Count;
    }
}
