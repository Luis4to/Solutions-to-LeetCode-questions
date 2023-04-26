# Write your MySQL query statement below

/*This query returns the distinct numbers that appear at least 3 times in a row in table Logs*/
SELECT DISTINCT l1.num ConsecutiveNums /*Selecting the relevant column */
FROM Logs l1 /*We do two SELF JOINS with Logs*/
INNER JOIN Logs l2
ON l1.id+1=l2.id /* Each row should contain the triples of numbers corresponding to consecutive id's*/
INNER JOIN Logs l3
ON l2.id+1=l3.id
WHERE l1.num=l2.num && l2.num=l3.num; /* Filtering numbers that are repeated 3 times */
