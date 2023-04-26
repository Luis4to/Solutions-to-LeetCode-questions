# Write your MySQL query statement below

/* Query outputs all the duplicate emails in the column email of the table Person*/
SELECT email Email /* We relabel the column name from email to Email*/
FROM Person 
GROUP BY email 
HAVING COUNT(*)>=2; /* COUNT(*) counts the number of rows that contain the same email*/
