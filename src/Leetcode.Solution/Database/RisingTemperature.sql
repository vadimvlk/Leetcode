-- +---------------+---------+
-- | Column Name   | Type    |
-- +---------------+---------+
-- | id            | int     |
-- | recordDate    | date    |
-- | temperature   | int     |
-- +---------------+---------+
-- id is the primary key for this table.
-- This table contains information about the temperature on a certain day.
--  
-- 
-- Write an SQL query to find all dates' Id with higher temperatures compared to its previous dates (yesterday).
-- 
-- Return the result table in any order.
-- 
-- The query result format is in the following example.

select w1.Id
from Weather w1, Weather w2
where (DATEDIFF(w1.recordDate, w2.recordDate) = 1) and (w1.Temperature > w2.Temperature);