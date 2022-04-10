-- +-------------+---------+
-- | Column Name | Type    |
-- +-------------+---------+
-- | id          | int     |
-- | num         | varchar |
-- +-------------+---------+
-- id is the primary key for this table.
--  
-- 
-- Write an SQL query to find all numbers that appear at least three times consecutively.
-- 
-- Return the result table in any order.
-- 
-- The query result format is in the following example.

select distinct l1.Num as ConsecutiveNums
from Logs as l1
         inner join Logs as l2 on l1.Id = l2.Id-1
         inner join Logs as l3 on l2.Id = l3.Id-1
where l1.Num = l2.Num AND l2.Num = l3.Num