-- Active: 1712529475297@@20.172.0.16@8080@jtgulick1
--CREATING TABLES
CREATE TABLE Student(
    studentID INT,
    studentName VARCHAR(50) NOT NULL,
    PRIMARY KEY(studentID)
);

CREATE TABLE Course(
    courseID INT,
    courseName VARCHAR(50) NOT NULL,
    courseCredit INT NOT NULL,
    PRIMARY KEY(courseID)
);

CREATE TABLE Enrollment(
    studentID INT NOT NULL,
    courseID INT NOT NULL,
    grade VARCHAR(20) NOT NULL,
    PRIMARY KEY(studentID, courseID),
    FOREIGN KEY(studentID) REFERENCES Student(studentID),
    FOREIGN KEY(courseID) REFERENCES Course(courseID)
);

-- INSERTING DATA
INSERT INTO Course(courseID, courseName, courseCredit) VALUES(2315, 'C#',3);
INSERT INTO Course VALUES (4360, 'OOAD', 3);
INSERT INTO Student VALUES (111,'Alice'), (222, 'Bob');
INSERT INTO Enrollment VALUES 
(111,2315,'Fall2022'),(222,4360,'Fall2022');

-- SELECT ALL FROM TABLES
SELECT * FROM `Course` LIMIT 100;
SELECT * FROM `Student` LIMIT 100;
SELECT * FROM Enrollment LIMIT 100;

-- JOIN TABLES WITH KEYS PRIMARY AND FOREIGN
-- JOINING Course, Student, Enrollment
SELECT * FROM Course, Student, Enrollment
WHERE
    Course.courseID = Enrollment.courseID 
    AND
    Student.studentID = Enrollment.studentID;

-- UPDATING EXSISTING DATA
UPDATE Course
SET CourseName = 'Business App Development'
WHERE CourseID = 2315;

-- SQL View
CREATE VIEW StudentCourse 
AS
SELECT studentName, courseName FROM Course, Student, Enrollment
WHERE
    Course.courseID = Enrollment.courseID 
    AND
    Student.studentID = Enrollment.studentID;
    
-- SELECT FROM VIEW CREATED ABOVE
SELECT * FROM StudentCourse;