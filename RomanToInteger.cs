public class Solution {
    
    public int getRomanValue(char c)
    {
        switch (c)
        {
            case 'M': return 1000;
            case 'D': return 500;
            case 'C': return 100;
            case 'L': return 50;
            case 'X': return 10;
            case 'V': return 5;
            case 'I': return 1;
        }
        
        return 0;
    }
    
    public int RomanToInt(string s) {
        
        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int value = getRomanValue(s[i]);
            int nextValue = 0;
            
            if (i < s.Length - 1)
            {
                nextValue = getRomanValue(s[i + 1]);
            }
            
            if (value >= nextValue)
            {
                total += value;
            }
            else 
            {
                total -= value;
            }
        }
        
        return total;
    }
}