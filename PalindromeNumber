public class Solution {
    public bool IsPalindrome(int x) {
        
        //Dont used convert to string.     
        int rev = 0;
        int tmp = x;

        int sign = x >= 0 ? 1 : -1;
               
        while (tmp != 0)
        {
            int pop =  tmp % 10;
            tmp /= 10;
            rev = rev * 10 + pop;
        }
        
        return x * sign == rev ? true : false;        
    }
}