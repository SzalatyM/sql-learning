SELECT lastname, count(*)
FROM users
GROUP BY lastname 
HAVING count(*) > 1;