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

