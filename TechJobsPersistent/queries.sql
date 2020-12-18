--Part 1

SELECT COLUMN_NAME,DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'jobs';

--Part 2

SELECT Name 
FROM techjobs.employers
Where Location="St. Louis City";

--Part 3

