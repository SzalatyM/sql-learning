SELECT users.firstname, users.lastname,orders.orderDateTime
FROM users LEFT JOIN orders
ON users.userid = orders.userid
GROUP BY orders.orderDateTime DESC
LIMIT 1;