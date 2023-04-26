# Please write a DELETE statement and DO NOT write a SELECT statement.
# Write your MySQL query statement below
/*This query deletes the duplicate emails from the table person, leaving the one with smallest id*/
DELETE P1 FROM Person P1
INNER JOIN (/*This table contains each email and the minimum id that contains that email */
    SELECT P2.email,MIN(P2.id) minId
    FROM Person P2
    GROUP BY P2.email
) P3 
ON P1.email=P3.email
WHERE P1.id <> P3.minId; /*We filter out to avoid eliminating all the rows */
