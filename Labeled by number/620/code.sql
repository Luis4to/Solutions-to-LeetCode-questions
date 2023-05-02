# Write your MySQL query statement below
/* Returns the largest number that only appears once in table MyNumbers, or null if there is no such number*/
SELECT MAX(num) num  
FROM ( /* This query returns all the numbers that appears once in the table MyNumbers*/
  SELECT num
  FROM MyNumbers
  GROUP BY num
  HAVING COUNT(num)=1 /* Filtering by number of occurrences */
) MySingleNumbers;
