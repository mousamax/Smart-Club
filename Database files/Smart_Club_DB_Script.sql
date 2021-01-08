Create Database Smart_Club

go

use Smart_Club

CREATE TABLE Accounts
(
  Username VARCHAR(50) NOT NULL,
  Password VARCHAR(50) NOT NULL,
  Type VARCHAR(1) NOT NULL,
  PRIMARY KEY (Username)
);

CREATE TABLE Members
(
  ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Fname VARCHAR(50) NOT NULL,
  Lname VARCHAR(50) NOT NULL,
  Age INT ,
  Sex char ,
  Status VARCHAR(20) default 'pending',
  Start_Date DATE ,
  End_Date DATE ,
  MemberShip_Price INT ,
  Username VARCHAR(50) ,
  FOREIGN KEY (Username) REFERENCES Accounts(Username)
);

CREATE TABLE Events
(
  Event_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Name VARCHAR (55) NOT NULL,
  Place VARCHAR (70),
  Date DATE ,
  Likes INT DEFAULT 0,
  Fees INT NOT NULL,
  Member_ID INT NOT NULL,
  FOREIGN KEY (Member_ID) REFERENCES Members(ID)
);

CREATE TABLE Reviews
(
  Review_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Comment TEXT,
  Rating INT NOT NULL,
  Date DATE 
);

CREATE TABLE Awards
(
  Award_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Name VARCHAR(50) NOT NULL,
);

CREATE TABLE Activites
(
  ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Name VARCHAR (55) NOT NULL,
  Place VARCHAR (100) ,
  Likes INT DEFAULT 0 NOT NULL,
);

CREATE TABLE Parking
(
  Subscribtion_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Member_ID INT NOT NULL,
  Start_Date DATE ,
  Fees INT ,
  End_Date DATE ,
  Status varchar(55) default 'pending', 
  FOREIGN KEY (Member_ID) REFERENCES Members(ID)
);

CREATE TABLE Teams
(
  ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Training_Time DATE NOT NULL,
  Size INT DEFAULT 0 NOT NULL,
  Level INT ,
);

CREATE TABLE Matches
(
  Match_ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
  Time DATE NOT NULL,
  Place VARCHAR (55) ,
  Team_ID INT,
  FOREIGN KEY (Team_ID) REFERENCES Teams(ID),
);

CREATE TABLE Guest
(
  SSN INT PRIMARY KEY NOT NULL,
  Status VARCHAR (55) NOT NULL,
  Team_ID INT,
  FOREIGN KEY (Team_ID) REFERENCES Teams(ID)
);

CREATE TABLE Events_Reviews
(
  Event_ID INT NOT NULL,
  Review_ID INT NOT NULL,
  Member_ID INT NOT NULL,
  PRIMARY KEY (Event_ID, Review_ID, Member_ID),
  FOREIGN KEY (Event_ID) REFERENCES Events(Event_ID),
  FOREIGN KEY (Review_ID) REFERENCES Reviews(Review_ID),
  FOREIGN KEY (Member_ID) REFERENCES Members(ID)
);

CREATE TABLE Activites_Reviews
(
  Member_ID INT NOT NULL,
  Review_ID INT NOT NULL,
  Activity_ID INT NOT NULL,
  PRIMARY KEY (Member_ID, Review_ID, Activity_ID),
  FOREIGN KEY (Member_ID) REFERENCES Members(ID),
  FOREIGN KEY (Review_ID) REFERENCES Reviews(Review_ID),
  FOREIGN KEY (Activity_ID) REFERENCES Activites(ID)
);

CREATE TABLE Awards_Teams
(
  Team_ID INT NOT NULL,
  Award_ID INT NOT NULL,
  PRIMARY KEY (Team_ID, Award_ID),
  FOREIGN KEY (Team_ID) REFERENCES Teams(ID),
  FOREIGN KEY (Award_ID) REFERENCES Awards(Award_ID)
);



CREATE TABLE Employee
(
  SSN INT ,
  Fname VARCHAR (55) NOT NULL,
  Minit VARCHAR (10) ,
  Lname VARCHAR (55) ,
  Salary INT NOT NULL,
  Sex char NOT NULL,
  Super_SSN INT ,
  Username VARCHAR (50),
  PRIMARY KEY (SSN),
  DNO int,
  FOREIGN KEY (Super_SSN) REFERENCES Employee(SSN),
  FOREIGN KEY (Username) REFERENCES Accounts(Username)
);
CREATE TABLE Department
(
  Name VARCHAR (55) NOT NULL,
  Number INT NOT NULL,
  Manager_SSN INT NOT NULL,
  Mgr_Start_Date date,
  Building VARCHAR (55),
  PRIMARY KEY (Number),
  FOREIGN KEY (Manager_SSN) REFERENCES Employee,
  UNIQUE (Name)
);

CREATE TABLE Coaches
(
  SSN INT NOT NULL,
  Activity_ID INT NOT NULL,
  PRIMARY KEY (SSN, Activity_ID),
  FOREIGN KEY (SSN) REFERENCES Employee(SSN),
  FOREIGN KEY (Activity_ID) REFERENCES Activites(ID)
);

CREATE TABLE Team_Activity
(
  Team_ID INT NOT NULL,
  SSN INT NOT NULL,
  Activity_ID INT NOT NULL,
  PRIMARY KEY (Team_ID, SSN, Activity_ID),
);

ALTER TABLE [dbo].[Team_Activity]  WITH CHECK ADD FOREIGN KEY([Team_ID])
REFERENCES [dbo].[Teams] ([ID])
GO
ALTER TABLE [dbo].[Team_Activity]  WITH CHECK ADD  CONSTRAINT [FK__Team_Activi__SSN_Activity] FOREIGN KEY([SSN], [Activity_ID])
REFERENCES [dbo].[Coaches] ([SSN], [Activity_ID])
GO
ALTER TABLE [dbo].[Team_Activity] CHECK CONSTRAINT [FK__Team_Activi__SSN_Activity]
GO

alter table Employee add foreign key (DNO) references Department(Number)

alter table Events add Status varchar(20) default 'pending';


/****** Object:  Table [dbo].[Members_Teams]    Script Date: 1/7/2021 11:29:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members_Teams](
	[Member_ID] [int] NOT NULL,
	[Team_ID] [int] NOT NULL,
 CONSTRAINT [PK_Members_Teams] PRIMARY KEY CLUSTERED 
(
	[Member_ID] ASC,
	[Team_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


ALTER TABLE [dbo].[Members_Teams]  WITH CHECK ADD  CONSTRAINT [FK_Members_Teams_Members] FOREIGN KEY([Member_ID])
REFERENCES [dbo].[Members] ([ID])
GO
ALTER TABLE [dbo].[Members_Teams] CHECK CONSTRAINT [FK_Members_Teams_Members]
GO
ALTER TABLE [dbo].[Members_Teams]  WITH CHECK ADD  CONSTRAINT [FK_Members_Teams_Teams] FOREIGN KEY([Team_ID])
REFERENCES [dbo].[Teams] ([ID])
GO
ALTER TABLE [dbo].[Members_Teams] CHECK CONSTRAINT [FK_Members_Teams_Teams]
GO


---------------Inserting values into tables----------------
insert into Accounts(Username,Password,Type)
values
('john101','1234','E'),
('frank','1234','E'),
('joy','1234','E'),
('nara','1234','E'),
('james','1234','E'),
('jen','1234','E')

insert into Employee(Fname,Minit,Lname,SSN,Username,Sex,Salary,Super_SSN,DNO)
values
('John','B','Smith',123456789,'john101','M',30000,null,null),
('Franklin','T','Wong',333445555,'frank','M',40000,null,null),
('Joyce','A','English',453453453,'joy','F',25000,null,null),
('Ramesh','K','Narayan',666884444,'nara','M',38000,null,null),
('James','E','Borg',888665555,'james','M',55000,null,null),
('Jennifer','S','Wallace',987654321,'jen','F',43000,null,null)



insert into Department
values
('Training',2,888665555,'2020-06-19',null),
('Administration',1,987654321,'2020-01-01',null),
('Services',3,333445555,'2020-05-22',null)

insert into Members(Fname,Lname,Age,Sex,Start_Date,End_Date,MemberShip_Price,Status,Username)
Values
('Mousa','Mohammed',20,'M',null,null,null,'pending',null),
('Mostafa','Usama',20,'M',null,null,null,'pending',null),
('Ahmed','Ehab',20,'M',null,null,null,'pending',null),
('Yousef','Qadry',20,'M',null,null,null,'pending',null)

insert into Events(Name,Date,Fees,Member_ID,Place,Status)
  values
  ('Birthday','2021-01-15',150,1,'Cafe','pending'),
  ('Khotoba','2021-01-16',150,2,'Hall1','pending'),
  ('Birthday','2021-01-17',150,2,'Hall2','pending'),
  ('Wedding','2021-01-20',150,3,'Pool','pending')
