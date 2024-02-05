

create table Persons(
PersonID int  primary key ,
FirstName nvarchar(30) not null,
LastName nvarchar(30) not null,
Address nvarchar(50)  null,
NationalIdentificationNumber nvarchar(15) not null)

--Phone Table


create table Phones(
PhoneID int Identity(1,1) primary key ,
PersonID int Foreign Key references Persons(PersonID),
PhoneNumber nvarchar(15) not null
)

--Member Ship Status Table


create table MemberShipStatus(
MemberShipStatusID int Identity(1,1) primary key ,
Status nvarchar(20) not null
)


--Coustomers Table


create table Coustomers(
CoustomerID int Identity(1,1) primary key ,
PersonID int Foreign Key references Persons(PersonID),
MemberShipStatusID int Foreign Key references MemberShipStatus(MemberShipStatusID)
)

--Users Table



create table Users(
UserID int Identity(1,1) primary key ,
PersonID int Foreign Key references Persons(PersonID),
Permession int not null
)


--Facility Serveses

create table FacilityServeses(
FacilityServesesID int Identity(1,1) primary key ,
ServesName nvarchar(25) not null,
NumOfBalles tinyint not null,
NumOfTishirts tinyint not null
)

--Facility Table

create table Facility(
FacilityID int Identity(1,1) primary key ,
FacilityServesesID int Foreign Key references FacilityServeses(FacilityServesesID),
FacilityName nvarchar(50) not null,
PlayersCapacity tinyint not null,
FacilityStatus bit not null,
FacilityAmountPerRes float not null
)

--payment status table
create table PaymentStatus(
PaymentStatusID int Identity(1,1) primary key ,
Status nvarchar(20) not null
)

--Payments Table
create table Payments(
PaymentID int Identity(1,1) primary key ,
CoustomerID int Foreign Key references Coustomers(CoustomerID),
DateOfInitPay datetime not null,
DateOfFinalPay datetime null,
TotalPay smallmoney not null,
InitialPay smallmoney  null ,
RemainingPay smallmoney  not null,
PaymentStatusID int Foreign Key references Payments(PaymentID)
)


--Reseed Identity

DBCC CHECKIDENT(Payments,Reseed,0)

truncate table Facility

DELETE FROM Facility


DELETE FROM Facility
DBCC CHECKIDENT (Facility, RESEED, 0)

--Some Queries 

select * from PaymentStatus where PaymentStatusID = 3;

select * from CoustomerInfo

select * from MemberShipStatus

select * from Coustomers

select * from Phones

select * from Users

select * from Persons

select * from Booking

select * from Payments

select * from PaymentStatus



select PaymentID,CoustomerID,DateOfInitPay,DateOfFinalPay,TotalPay,InitialPay,RemainingPay,PaymentStatus.Status 
from Payments join PaymentStatus on PaymentStatus.PaymentStatusID =  Payments.PaymentStatusID
Order by PaymentID

select BookingID,CoustomerID,Facility.FacilityName,StartTime,BookingStatus.Status,PaymentStatus.Status 
from Booking inner join Facility on Booking.FacilityID = Facility.FacilityID
inner join BookingStatus on Booking.BookingStatusID = BookingStatus.BookingStatusID
inner join PaymentStatus on PaymentStatus.PaymentStatusID = (select Payments.PaymentStatusID from Payments where PaymentID = Booking.PaymentID)
order by BookingID

