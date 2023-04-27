# Write your MySQL query statement below
/* This query returns the name and bonus amount (from the Bonus table) for each employee of the table Employee if the bonus amount is less than 1000*/
SELECT E.name, B.bonus /* Relevant columns */
FROM Employee E 
LEFT OUTER JOIN Bonus B /*We need LEFT OUTER JOIN because there may be employees with no bonus*/
ON E.empId=B.empId
WHERE B.bonus<1000 OR B.bonus IS NULL; /*Filtering condition */
