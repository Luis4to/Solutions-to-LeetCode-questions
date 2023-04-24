public class Solution {
    /* Solves sudoku of size 9x9 recursively */
    public void SolveSudoku(char[][] board){
        SolveSudokuFrom(board, 0);
        return;
    }
    public void SolveSudokuFrom(char[][] board,int a) {
        /*We first find the first empty space, labeled with '.' */
        for(int s=a;s<81;s++){
            int i= s%9; /* row number*/
            int j= s/9; /*column number*/
            if(board[i][j]=='.'){
                /*Now, we try each possibility from 1 to 9.*/
                for(int k=0;k<9;k++){
                    board[i][j]= Convert.ToChar(Convert.ToInt32('1')+k);
                    /*We check if it is possible to use this value given Sudoku's rules*/
                    if(isSudokuValidAtXY(board,i,j)){
                        /* If so, we solve the same problem for the updated sudoku, recursively*/
                        SolveSudokuFrom(board,a+1);
                        /* If a solution was found, there should be no empty cell '.' in the rest of cells*/
                        if(isComplete(board,s+1))return;
                        /* Otherwise, we need to try another value for board[i][j]*/
                    }  
                }
                board[i][j]='.'; /* If all possibilities fail, we need to leave the cell empty*/
                return;
            }
        }
        return;
    }

    /* isComplete checks if board has any empty cells, labeled with '.'*/
    public bool isComplete(char[][] board, int a){
        for(int s=a;s< 81 ; s++){
            int i=s%9;
            int j=s/9;
            if(board[i][j]=='.')return false;    
        }
        return true;
    }
    /*Checks a non-empty cell board[x][y] is repeated in a row, a column, or a 3x3 group of cells */
    public bool isSudokuValidAtXY(char[][] board, int x, int y){
        if(board[x][y]=='.')return true; /*If it is empty there is no need to check */
        
        for(int i=0; i<9;i++){
            if(i!=x && board[i][y]==board[x][y])return false; /* Checking column y */
            if(i!=y && board[x][i]==board[x][y])return false; /* Checking row x*/
        }

        /* Now, we check the 3x3 cell that contains board[x][y], by using integer division */
        for(int i=0; i< 3;i++){
            for(int j=0;j<3;j++){ 
                int k=i+3*(x/3);
                int l=j+3*(y/3);
                if( (k!= x || l!= y) && board[k][l]==board[x][y])return false;
            }
        }
        return true;
    }
}
