public class Solution {
    public bool[,] visited; /* To store the positions that have already been visited in board*/
    
    /* Exist(board,word) outputs true if word can be found in the 2D array board as a sequence of letters in distinct positions, where each consecutive pair of letters is adjacent */
    public bool Exist(char[][] board, string word) {
        visited=new bool[board.Length,board[0].Length]; /* Setting the size of visited */
        bool ans=false; /* default answer*/
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                ans=ans||ExistAux(board, word, i,j); /*Answer is modified if a match is found at pos(i,j)*/
            }
        }
        return ans; /* returns final result*/
    }

    /* ExistAux(board, word, i, j) checks whether a match is found starting at pos (i,j), recursively */
    public bool ExistAux(char[][] board, string word, int i, int j){
        if(word=="")return true; /* Base case */
        if(i<0 || i>=board.Length) return false; /* Out of bounds, word non-empty, hence false */
        if(j<0 || j>=board[0].Length) return false;  /* Out of bounds, word non-empty, hence false */
        if(visited[i,j]) return false; /* Already visited, so invalid match, hence false */
        if(word[0]!=board[i][j])return false;/* First letter of word does not match pos(i,j), hence false*/
        visited[i,j]=true; /*At this point there is a match up until pos(i,j), so we mark it as visited */
        string wordWithoutFirstLetter=word.Substring(1); /* We do the same for the rest of the word */
        bool ans=ExistAux(board, wordWithoutFirstLetter,i+1,j);/* Check if there is a match to the top*/
        ans=ans|| ExistAux(board,wordWithoutFirstLetter,i-1,j);/* Check if there is a match to the bottom*/
        ans=ans|| ExistAux(board,wordWithoutFirstLetter,i,j+1);/* Check if there is a match to the right*/
        ans=ans|| ExistAux(board,wordWithoutFirstLetter,i,j-1); /* Check if there is a match to the left*/
        visited[i,j]=false; /* We unvisited pos(i,j) to avoid miscalculations in different iterations*/
        return ans; /* returns final answer successfully*/
    }
}
