public class Solution {

    public string Encode(IList<string> strs) 
    {        
        var res = "";
        for (int i = 0; i < strs.Count; i++)
            res +=  strs[i].Length + "#" + strs[i];

        return res;
    }

    public List<string> Decode(string s) {
        var len = s.Length;
        int i = 0;
        var res = new List<string>();
        while (i < len)
        {
            var hashIndex = s.IndexOf('#', i);//1
            if (hashIndex == -1) 
                break;
            var length = int.Parse(s.Substring(i, hashIndex - i));
            var word = s.Substring(hashIndex + 1, length);
            res.Add(word);
            i = hashIndex + 1 + length;
        }
        return res;
   }
}
