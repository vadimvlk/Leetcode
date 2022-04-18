-- Table: Employee
-- 
-- +-------------+------+
-- | Column Name | Type |
-- +-------------+------+
-- | id          | int  |
-- | salary      | int  |
-- +-------------+------+
-- id is the primary key column for this table.
-- Each row of this table contains information about the salary of an employee.
--  
-- 
-- Write an SQL query to report the nth highest salary from the Employee table. If there is no nth highest salary, the query should report null.
-- 
-- The query result format is in the following example.


CREATE FUNCTION getNthHighestSalary(N INT) RETURNS INT
BEGIN
    set N = N-1;
RETURN (
    # Write your MySQL query statement below.
      select distinct Salary from Employee order by Salary desc limit 1 offset N

    );
END
