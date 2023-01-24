CREATE TABLE orders(
orderid INT,
orderDateTime DATETIME,
userid INT,
PRIMARY KEY (orderid),
FOREIGN KEY(userid) REFERENCES users (userid));