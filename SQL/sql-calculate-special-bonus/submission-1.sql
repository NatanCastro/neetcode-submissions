-- Write your query below
select 
    e.employee_id,
    CASE
        WHEN e.employee_id % 2 != 0
             AND e.name NOT LIKE 'M%'
        THEN e.salary
        ELSE 0
    END AS bonus
from employees as e
ORDER BY e.employee_id;