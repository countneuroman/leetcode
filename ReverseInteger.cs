public class Solution {
    public int Reverse(int x) {
        
        int sign = x >= 0 ? 1 : -1;
        
        string stringX = x.ToString().Trim('-');
        string reversed = String.Empty;
                
        for(int i = stringX.Length - 1; i > -1; i--)
        {
            reversed += stringX[i];
        }
        
        int result = 0;
        int.TryParse(reversed, out result);
        
        return result * sign;
    }
}