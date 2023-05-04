public class Solution {
    /*public IList<string> ReadBinaryWatch(int turnedOn) returns the possible times a binary watch shows when turnedOn
    ** leds are on. There are 8 leds for the minutes and 4 leds for the hours */
    public IList<string> ReadBinaryWatch(int turnedOn) {
        IList<string> possibleTimes=new List<string>(); /*Stores the result */
        for(int minutes=0;minutes<60;minutes++){ /*We iterate through all the possible minutes */ 
            for(int hours=0;hours<12;hours++){ /* We iterate through all the possible hours */
                if(numOnes(minutes)+numOnes(hours)==turnedOn){ /* We check that the corresponding time match the condition */
                    if(minutes>9)possibleTimes.Add(Convert.ToString(hours)+":"+Convert.ToString(minutes));/* Adds time*/
                    else possibleTimes.Add(Convert.ToString(hours)+":0"+Convert.ToString(minutes)); /*Adds extra "0"in time*/
                }
            }
        }
        return possibleTimes; /* Outputs the resulting list*/
    }
    /* public int numOnes(int i) computes the number of ones in the binary representation of i*/
    public int numOnes(int i){
        if (i==0) return 0; /* Base case */
        return i%2+numOnes(i/2); /* i%2 indicates if there is a 1 or not at the last position, numOnes(i/2) checks the rest 
                                ** of positions recursively.*/
    }
}
