public class Solution {
    /* Finds out  if we can win the regular Nim game with one heap of stones, and removing 1,2, or 3    
    **stones*/
    public bool CanWinNim(int n) {
        return (n%4)!=0;/* n=0 is a losing condition, and if n%4!=0 then we can choose 1,2,3 to make n%4=0
                        ** next turn- Hence, each pair of turns the heap is reduced by 4.*/
    }
}
