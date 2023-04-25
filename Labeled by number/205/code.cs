public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!= t.Length)return false; /* This is unnecessary due to the problem's constraints*/
        int[] mapsTo=new int[1000]; /* Maybe overkill, size can be reduced. mapsTo stores where does
                                    ** each letter mapsTo by the isomorphism*/
        for(int i=0;i<s.Length;i++){
            if(mapsTo[Convert.ToInt32(s[i])]!=0){ /* The letter has already been assigned a mapping*/
                if(mapsTo[Convert.ToInt32(s[i])]!=Convert.ToInt32(t[i]))return false;
            }
            else mapsTo[Convert.ToInt32(s[i])]=Convert.ToInt32(t[i]);/* There is no mapping assigned,
                                                                     ** so we assigned one*/
        }
        /* We need to check that no two letters are mapped to the same letter */
        Array.Sort(mapsTo); /* Duplicates in a sorted array are adjacent */
        for(int i=1;i<mapsTo.Length;i++){
            if(mapsTo[i]==mapsTo[i-1] && mapsTo[i]!=0)return false; /* Checking adjacent elements */
        }
        return true;/*If we reach this point then the mapping can be constructed for all the letters of s */
    }
}
