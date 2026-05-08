-- Write your query below
select name from customers as c
full join orders as o on c.id = o.customer_id
where o.customer_id is NULL