create PROC Sp_Booking_Add
@PatientName nvarchar(250),
@PatientAge int,
@Pemail nvarchar(250),
@Dname nvarchar(250),
@Cno int,
@ApDate datetime
AS
BEGIN
INSERT INTO dbo.book(
PatientName,
PaientAge,
Pemail,
Dname,
Cno,
ApDate
)
VALUES
(
@PatientName,
@PatientAge,
@Pemail,
@Dname,
@Cno,
@ApDate 
)
END

