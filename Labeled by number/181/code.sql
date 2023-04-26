# Write your MySQL query statement below

/* This query outputs the names of the employees from the table employee who earn more than their manager*/
SELECT e1.name Employee /* We select the column with the names*/
FROM employee e1 /* We do an INNER JOIN of employee with itself on the id's of the managers*/
INNER JOIN employee e2
ON e1.managerId=e2.id
WHERE e1.salary> e2.salary; /* Filtering by comparing the salaries */
