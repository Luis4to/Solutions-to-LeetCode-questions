# Write your MySQL query statement below
/*This query returns the employees that earn the most among the people in their own department */
SELECT D.name Department, E1.name Employee, E1.salary Salary
FROM Employee E1
INNER JOIN Department D
ON E1.departmentId=D.id
/*Next, we need to compute the max salary for each department and check if the employee has that salary */
WHERE E1.salary=(
  SELECT MAX(E2.salary)
  FROM Employee E2
  WHERE E2.departmentId=E1.departmentId
);
