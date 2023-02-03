SELECT users.firstname, users.lastname, orders.orderid AS nullvalue
FROM users LEFT JOIN orders
ON users.userid = orders.userid
WHERE orders.orderid is null
ORDER BY users.firstname, users.lastname ASC;