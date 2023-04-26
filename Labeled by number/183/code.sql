# Write your MySQL query statement below
/* This query outputs the names of the customers who never make an order*/
SELECT name Customers 
FROM Customers /* Table which contains the id's of the customers and names*/
WHERE id NOT IN (
    SELECT customerId 
    FROM Orders /* Table that contains the id's of the customer and the id of the corresponding order*/
);
