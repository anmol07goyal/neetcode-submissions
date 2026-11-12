public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int[][] pair = new int [position.Length][];
        for (int i = 0; i < position.Length; i++) 
            pair[i] = [position[i], speed[i]];

        Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));
        
        int fleets = 1;
        double prevTime = (double)(target - pair[0][0]) / pair[0][1];
        for (int i = 0; i < position.Length; i++) {
            double curTime = (double)(target - pair[i][0]) / pair[i][1];
            if (curTime > prevTime) {
                fleets++;
                prevTime = curTime;
            }
        }
        return fleets;
    }
}
