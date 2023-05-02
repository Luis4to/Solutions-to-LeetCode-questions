public class Solution {
    /* EvalRPN(tokens) evaluates a math expression in Reverse Polish Notation  with operands +,-,*, and /*/
    public int EvalRPN(string[] tokens) {
        if(tokens.Length==1)return Convert.ToInt32(tokens[0]); /* Trivial math expression*/
        string[] newTokens= new string[tokens.Length-2]; /* newTokens stores the math expression in RPN after 1 step*/
        for(int firstOperand=0;firstOperand<tokens.Length;firstOperand++){
            if(tokens[firstOperand]=="+"){ /* The first Operand encountered is "+"*/
                for(int i=0;i<tokens.Length-2;i++){
                    if(i==firstOperand-2){ /* We include the result of tokens[i]+tokens[i+1] in newTokens[i] */
                        newTokens[i]=Convert.ToString(Convert.ToInt32(tokens[i])+Convert.ToInt32(tokens[i+1]));
                    }
                    else if(i<firstOperand-2)newTokens[i]=tokens[i]; /* These elements are not affected*/
                    else newTokens[i]=tokens[i+2]; /* we ignore tokens[firstOperand-1] and tokens[firstOperand] */
                }
                return EvalRPN(newTokens);/* Rinse and repeat*/
            }
            if(tokens[firstOperand]=="-"){ /* The first Operand encountered is "-" */
                for(int i=0;i<tokens.Length-2;i++){/* We include the result of tokens[i]-tokens[i+1] in newTokens[i] */
                    if(i==firstOperand-2){
                        newTokens[i]=Convert.ToString(Convert.ToInt32(tokens[i])-Convert.ToInt32(tokens[i+1]));
                    }
                    else if(i<firstOperand-2)newTokens[i]=tokens[i];/* These elements are not affected*/
                    else newTokens[i]=tokens[i+2];/* we ignore tokens[firstOperand-1] and tokens[firstOperand] */
                }
                return EvalRPN(newTokens);/* Rinse and repeat*/
            }
            if(tokens[firstOperand]=="*"){ /* The first Operand encountered is  "*" */
                for(int i=0;i<tokens.Length-2;i++){/* We include the result of tokens[i]*tokens[i+1] in newTokens[i] */
                    if(i==firstOperand-2){
                        newTokens[i]=Convert.ToString(Convert.ToInt32(tokens[i])*Convert.ToInt32(tokens[i+1]));
                    }
                    else if(i<firstOperand-2)newTokens[i]=tokens[i];/* These elements are not affected*/
                    else newTokens[i]=tokens[i+2];/* we ignore tokens[firstOperand-1] and tokens[firstOperand] */
                }
                return EvalRPN(newTokens);/* Rinse and repeat*/
            }
            if(tokens[firstOperand]=="/"){ /* The first Operand encountered is "/" */
                for(int i=0;i<tokens.Length-2;i++){/* We include the result of tokens[i]/tokens[i+1] in newTokens[i]*/
                    if(i==firstOperand-2){
                        newTokens[i]=Convert.ToString(Convert.ToInt32(tokens[i])/Convert.ToInt32(tokens[i+1]));
                    }
                    else if(i<firstOperand-2)newTokens[i]=tokens[i];/* These elements are not affected*/
                    else newTokens[i]=tokens[i+2];/* we ignore tokens[firstOperand-1] and tokens[firstOperand] */
                }
                return EvalRPN(newTokens); /* Rinse and repeat*/
            }
        }
        return -1; /* There should be no way to reach this point if the expressions is a valid RPN expression */
    }
}
