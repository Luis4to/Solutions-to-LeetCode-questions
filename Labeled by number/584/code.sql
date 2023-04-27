# Write your MySQL query statement below
/*This query returns the names of the customers that where not referred by the customer with id 2 */
SELECT C.name /* Relevant column */
FROM Customer C 
WHERE C.referee_id IS NULL OR  C.referee_id<> 2; /* Customers satisfying the condition may have null referee_id */
