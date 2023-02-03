SELECT users.firstname, users.lastname,orders.orderDateTime
FROM users LEFT JOIN orders
ON users.userid = orders.userid
ORDER BY orders.orderDateTime DESC
LIMIT 1;