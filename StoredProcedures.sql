create procedure GetEmployeeFromSSN @SSN int
As 
begin 
select * from Employee
where SSN=@SSN
end
go

create procedure AdjustSalary @SSN int, @Salary int
as 
begin
Update Employee
set Salary = @Salary
where SSN=@SSN
end 
go


create procedure AddEvents @Event_id INT  ,
  @Name VARCHAR (55) ,
  @Place VARCHAR (70),
  @Date DATE ,
  @Likes INT ,
  @Fees INT ,
  @Member_ID INT 
as 
begin 
Insert into Events(Name,Place,Date,Likes,Fees,Member_ID)
values (@Name,@Place,@Date,@Likes,@Fees,@Member_ID) 
end 
go




create procedure GetEmployeeInfo
as 
begin
Select * from Employee
end 
go

create procedure InsertEmployee
  @SSN INT ,
  @Fname VARCHAR (55) ,
  @Minit VARCHAR (10) ,
  @Lname VARCHAR (55) ,
  @Salary INT ,
  @Sex char ,
  @Super_SSN INT ,
  @Username VARCHAR (50),
  @DNO int
  as
  begin
  Insert into Employee(SSN,Fname,Minit,Lname,Salary,Sex,Super_SSN,Username,DNO)
  values
  (@SSN,@Fname,@Minit,@Lname,@Salary,@Sex,@Super_SSN,@Username,@Dno)
  end
  go

create Procedure RemoveEmployee @SSN int
as 
BEGIN
delete  from Employee where
Employee.SSN=@SSN
end 
go


create procedure AddActivity @ID int,
@Name varchar(50),
@Place varchar(50)
as
begin
Insert into Activites(ID,Name,Place)
Values(@ID,@Name,@Place)
end 
go

