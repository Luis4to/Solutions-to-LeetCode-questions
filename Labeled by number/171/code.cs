public class Solution {
    /*tpublic int TitleToNumber(string columnTitle) converts the column name of an excel document to a number, starting from
    ** 1.*/
    public int TitleToNumber(string columnTitle) {
        int number=0;/* Stores the resulting column number*/
        int factor=1;/* The columnTitle can be interpreted as a base 26 number, so we store the associated factor*/
        for(int i=columnTitle.Length-1;i>=0;i--){/*We iterate through the positions from the end to the start */
            number+= (Convert.ToInt32(columnTitle[i])-Convert.ToInt32('A')+1)*factor;/* We do the conversion to base 10 */
            factor*=26; /* We increase the power of 26 for the next position*/
        }
        return number; /* We succesfully return the column number*/
    }
}
