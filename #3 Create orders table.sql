CREATE TABLE orders(
o_id INT,
order_Date date,
order_Time time,
userid INT,
PRIMARY KEY (o_id),
FOREIGN KEY(userid) REFERENCES users (userid));