SELECT users.firstname, users.lastname
FROM users, orders
WHERE users.userid = orders.orderid
GROUP BY orderDateTime DESC LIMIT 1