-- +-------------+---------+
-- | Column Name | Type    |
-- +-------------+---------+
-- | student     | varchar |
-- | class       | varchar |
-- +-------------+---------+
-- (student, class) is the primary key column for this table.
-- Each row of this table indicates the name of a student and the class in which they are enrolled.
--  
-- 
-- Write an SQL query to report all the classes that have at least five students.
-- 
-- Return the result table in any order.
-- 
-- The query result format is in the following example.
select class from courses
group by class
having count(distinct student)>=5