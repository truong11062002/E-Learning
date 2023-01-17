CREATE DATABASE ELearning
USE ELearning

create table LEARNER
(
	LEARNER_ID char(4),
	LEARNER_NAME nvarchar(100),
	LEARNER_PHONE_NUMBER nvarchar(11),
	LEARNER_ACCOUNT nvarchar(50),
	LEARNER_PASSWORD nvarchar(50),
	LEARNER_ADDRESS nvarchar(200),
	LEARNER_NUMBER_COURSE int,
	LEARNER_COLLEGE nvarchar(200),
	LEARNER_AVT char(4),
	
	
)
go
-- INSERT VALUE FOR LEARNER TABLE
insert into LEARNER values('le01','Nguyen Nhat Truong','0857513339','truongnn','123', 'Ho Chi Minh City', 0, 'UIT', 'av01')
insert into LEARNER values('le02','I am Nhat Truong','0857513339','','', 'Ho Chi Minh City', 0, 'USSH', 'av02')
insert into LEARNER values('le03','I am Nhat Truong','0857513339','name@email.com','Enter your password', 'Ho Chi Minh City', 0, 'HCMUS', 'av03')


SELECT * FROM LEARNER
DROP TABLE LEARNER
TRUNCATE TABLE LEARNER

CREATE TABLE CERTIFICATE
(
	LEARNER_ID char(4),
	course_id char(4), -- ID KHÓA HỌC
)

TRUNCATE TABLE CERTIFICATE
SELECT * FROM CERTIFICATE

insert into CERTIFICATE values('le01', 'co02')

SELECT * FROM COURSE
INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id
WHERE course_detail_completed = 0 and COURSE.course_id = 'co01'


SELECT * FROM COURSE INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id WHERE course_detail_completed = 0 and COURSE.course_id = 'co01'

SELECT DISTINCT LEARNER_NAME, COURSE_NAME
FROM CERTIFICATE
JOIN LEARNER
  ON CERTIFICATE.LEARNER_ID = LEARNER.LEARNER_ID
JOIN COURSE
  ON COURSE.course_id = CERTIFICATE.course_id
WHERE LEARNER.LEARNER_ID = 'le01' and COURSE.course_id = 'co02'

SELECT DISTINCT LEARNER_NAME, COURSE_NAME FROM CERTIFICATE JOIN LEARNER ON CERTIFICATE.LEARNER_ID = LEARNER.LEARNER_ID JOIN COURSE ON COURSE.course_id = CERTIFICATE.course_id WHERE LEARNER.LEARNER_ID = 'le01' and COURSE.course_id = 'co02'

-- TABLE COURSE
create table COURSE
(
	course_id char(4), -- ID KHÓA HỌC
	course_name nvarchar(100), -- TÊN KHÓA HỌC
	course_taught_by nvarchar(100),  -- ĐƯỢC DẠY BỞI
	course_skill nvarchar(1000), -- SKILL TRONG KHÓA HỌC
	course_des nvarchar(500), -- MIÊU TẢ KHÓA HỌC
	course_about nvarchar(4000), -- TỔNG QUAN KHÓA HỌC
	course_language nvarchar(100), -- NGÔN NGỮ SỬ DỤNG
	course_freq int, -- LƯỢT XEM KHÓA HỌC
	course_stars int, -- ĐÁNH GIÁ
	course_level int, -- CẤP ĐỘ KHÓA HỌC
	-- course_discuss nvarchar(1000), -- THẢO LUẬN VỀ KHÓA HỌC
	-- course_completed int, -- KIỂM TRA HOÀN THÀNH KHÓA HỌC
)

SELECT * FROM COURSE
TRUNCATE TABLE COURSE
DROP TABLE COURSE

CREATE TABLE DETAIL_COURSE
(
	course_detail_id char(7), -- ID TỪNG VIDEO KHÓA HỌC
	course_detail_name nvarchar(100), -- NAME TỪNG VIDEO
	course_detail_time nvarchar(20), -- THỜI LƯỢNG VIDEO
	course_detail_note nvarchar(1000), -- NOTE CHO TỪNG VIDEO
	course_id char(4), -- ID KHÓA HỌC
	course_detail_like int, -- YÊU THÍCH TỪNG VIDEO
	course_report_issue nvarchar(1000), -- BÁO CÁO VIDEO BỊ HƯ HẠI
	course_detail_completed int, -- KIỂM TRA HOÀN THÀNH TỪNG VIDEO
	
)
SELECT * FROM DETAIL_COURSE
TRUNCATE TABLE DETAIL_COURSE
DROP TABLE DETAIL_COURSE
-- QUERY
SELECT * FROM COURSE INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id WHERE DETAIL_COURSE.course_id = 'co01' order by course_detail_id asc
SELECT DETAIL_COURSE.course_detail_name, DETAIL_COURSE.course_detail_time FROM COURSE INNER JOIN DETAIL_COURSE ON COURSE.course_id = DETAIL_COURSE.course_id WHERE DETAIL_COURSE.course_id = 'co01'

SELECT course_id, COUNT(course_id) as numOfCourseDetail  FROM DETAIL_COURSE GROUP BY course_id


SELECT course_id, COUNT(course_id) as numOfCourseDetail FROM DETAIL_COURSE WHERE course_detail_completed = 1 GROUP BY course_id HAVING COUNT(course_id) <> 3

SELECT course_id, COUNT(course_id) as numOfCourseDetail FROM DETAIL_COURSE WHERE course_detail_completed = 1 GROUP BY course_id HAVING COUNT(course_id) = 3


create table COMMENT (
	COMMENT_COURSE_ID char(4),
	LEARNER_ID char(4),
	COMMENT_TEXT nvarchar(100),
	COMMENT_TIME datetime,
)
SELECT * FROM COMMENT
DROP TABLE COMMENT
TRUNCATE TABLE COMMENT

set dateformat mdy

insert into COMMENT values('co01', 'le01', N'Khóa học khá hay', '12-16-2002 15:45:21')
insert into COMMENT values('co01', 'le02', N'Tốt', '12-17-2002 15:45:21')
insert into COMMENT values('co01', 'le03', N'7 điểm', '12-17-2002 15:45:21')

SELECT * FROM COMMENT INNER JOIN LEARNER ON COMMENT.LEARNER_ID = LEARNER.LEARNER_ID



SELECT course_id, LEARNER_NAME
FROM COMMENT
JOIN LEARNER
  ON COMMENT.LEARNER_ID = LEARNER.LEARNER_ID
JOIN COURSE
  ON COURSE.course_id = COMMENT.COMMENT_COURSE_ID
WHERE COURSE.course_id = 'co01'


SELECT course_id, LEARNER_NAME, COMMENT_TIME, COMMENT_TEXT FROM COMMENT JOIN LEARNER ON COMMENT.LEARNER_ID = LEARNER.LEARNER_ID JOIN COURSE ON COURSE.course_id = COMMENT.COMMENT_COURSE_ID WHERE COURSE.course_id = 'co01' order by COMMENT_TIME desc;


SELECT course_name, LEARNER_NAME FROM COMMENT JOIN LEARNER ON COMMENT.LEARNER_ID = LEARNER.LEARNER_ID JOIN COURSE ON COURSE.course_id = COMMENT.COMMENT_COURSE_ID WHERE COURSE.course_id = 'co01';
 
create table DISCUSS (
	DISCUSS_COURSE_ID char(4),
	DISCUSS_NAME nvarchar(100),
	DISCUSS_TEXT nvarchar(100),
	DISCUSS_SUBJECT nvarchar(100),
	DISCUSS_TIME datetime,
)

SELECT * FROM DISCUSS
DROP TABLE DISCUSS
insert into DISCUSS values('co01', 'Truong', N'Agile la gi','Agile',  '12-16-2002 15:45:21')
insert into DISCUSS values('co01', 'Hai', N'Machine learning la gi', 'Machine Learning','12-17-2002 15:45:21')
insert into DISCUSS values('co01', 'Kiet', N'Deep learning la gi', 'Deep learning ','12-17-2002 15:45:21')

 -- Convert languague
CREATE FUNCTION [dbo].[LanguageComprehension](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN    
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
   
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
 
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
 
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
   
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN  
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN          
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)      
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
    RETURN @inputVar
END
go
