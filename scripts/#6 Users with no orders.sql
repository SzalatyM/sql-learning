SELECT users.firstname, users.lastname,orders.orderid, COUNT(orders.orderid) AS count 
FROM users LEFT JOIN orders
ON users.userid = orders.userid
GROUP BY users.lastname ASC
HAVING COUNT(orders.orderid) < 1;