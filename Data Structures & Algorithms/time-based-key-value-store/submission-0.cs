public class TimeMap {
    private Dictionary<string, List<(int time, string value)>> keyStore;
    public TimeMap() {
        keyStore = new();
    }

    public void Set(string key, string value, int timestamp) {
        if (!keyStore.ContainsKey(key))
            keyStore[key] = new List<(int time, string value)>();
        keyStore[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp) {
        if (!keyStore.ContainsKey(key))
            return null;
        var pairList = keyStore[key];
        int n = pairList.Count;
        if (n == 1)
            return pairList[0].value;
        int l = 0;
        int r = n - 1;
        string res = "";
        while (l <= r) {
            int mid = l + (r - l) / 2;
            if (pairList[mid].time <= timestamp) {
                res = pairList[mid].value;
                l = mid + 1;
            }
            else if (pairList[mid].time > timestamp)
                r = mid - 1;
        }
        return res;
    }
}
