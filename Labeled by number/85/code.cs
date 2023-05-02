public class Solution {
    /* MaximalRectangle(matrix) Finds the rectangle of 1's with maximal area in binary matrix "matrix" */ 
    public int MaximalRectangle(char[][] matrix) {
        int[,] areasRectangles=new int[matrix.Length+1,matrix[0].Length+1]; /*Stores the number of 1's in rectangle
                                                                            ** with a corner in matrix[0][0] */
        if(matrix[0][0]=='0')areasRectangles[1,1]=0; /* Filling corner*/
        else areasRectangles[1,1]=1;                   /*Filling corner*/
        for(int i=1; i<matrix.Length;i++){ /* Filling first column*/
            areasRectangles[i+1,1]=areasRectangles[i,1];
            if(matrix[i][0]=='1')areasRectangles[i+1,1]++; 
        }
        for(int j=1;j<matrix[0].Length;j++){ /*Filling first row */
            areasRectangles[1,j+1]=areasRectangles[1,j];
            if(matrix[0][j]=='1')areasRectangles[1,j+1]++;
        }
        for(int i=1;i<matrix.Length;i++){ /* Filling the rest of values of areasRectangles*/
            for(int j=1;j<matrix[0].Length;j++){
                /* areasRectangles[i,j+1] and areasRectangles[i+1,j] overlap on areasRectangles[i,j]*/
                areasRectangles[i+1,j+1]=areasRectangles[i,j+1]+areasRectangles[i+1,j]-areasRectangles[i,j];
                if(matrix[i][j]=='1')areasRectangles[i+1,j+1]++; /* we add the corner if there is a one there */
            }
        }
        int ans=0; /* Stores the largest area thus far*/

        /* A rectangle is defined by any pair of opposite vertices (i1,j1) and (i2,j2). So, we iterate over all of those */
        for(int i1=0;i1<matrix.Length;i1++){
            for(int j1=0; j1<matrix[0].Length;j1++){
                for(int i2=i1;i2<matrix.Length; i2++){
                    for(int j2=j1; j2<matrix[0].Length;j2++){
                        int area=areasRectangles[i2+1,j2+1]; /* Computes the area of the corresponding rectangle step by    
                                                            ** step using areasRectangles */
                        area-=areasRectangles[i1,j2+1];
                        area-=areasRectangles[i2+1,j1];
                        area+=areasRectangles[i1,j1];
                        if(area==(j2-j1+1)*(i2-i1+1)){
                            ans=Math.Max(ans, area); /*Updates largest area if there is a better candidate */
                        }
                        else break; /* The width of this rectangle cannot be increased further so we break*/
                    }
                }
            }
        }
        return ans; /* Succesfully returns the result*/
    }
}
