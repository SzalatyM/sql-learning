SELECT users.firstname, users.lastname, COUNT(orders.orderid) AS count
FROM users LEFT JOIN orders
ON users.userid = orders.orderid 
GROUP BY users.lastname
HAVING COUNT(orders.orderid) < 1;