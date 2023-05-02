public class Solution {
    public string SimplifyPath(string path) {
        if(path=="/." || path=="/..")return "/"; /* Special cases */
        for(int i=0;i<path.Length-1;i++){
            if(path.Substring(i,2)=="//"){ /* Consecutive slashes can be replaced by a single slash*/
                return SimplifyPath(path.Substring(0,i)+path.Substring(i+1));
            }
            if(i<path.Length-2 && path.Substring(i,3)=="/./"){ /* The substring /. can be ignored when contained in /./ */
                return SimplifyPath(path.Substring(0,i)+path.Substring(i+2));
            } 
            if(i<path.Length-3 && path.Substring(i,4)=="/../"){ /* We can ignored "directory/.." in this case */
                int pos=i-1;
                while(pos>=0 && path[pos]!='/')pos--; /* finds the starting position pos of the previous directory*/
                return SimplifyPath(path.Substring(0,pos+1)+path.Substring(i+3));
            }
        }
        /* Our previous simplifications do not take into acccount when path ends in /. or /.., now we do as follows*/
        if(path.Length>2 && path.Substring(path.Length-2)=="/.")return SimplifyPath(path.Substring(0,path.Length-2));
        if(path.Length>3 && path.Substring(path.Length-3)=="/.."){
            int p=path.Length-4;
            while(p>=0 && path[p]!='/')p--;
            return SimplifyPath(path.Substring(0,p+1));
        }
        if(path.Length>1 && path[path.Length-1]=='/')return SimplifyPath(path.Substring(0,path.Length-1));
        return path;
    }
}
