 use DBpremier_service_solutions
  go

  Insert into Business
  values('Pandalytics','0833909155','833  Visser St'),
	('Crescent','0841921026','208  Rus St'),
	('Blue Space','0838170187','781  Daffodil Dr'),
	('App Droid','0822234185','1040  President St'),
	('Audiotrix','0843555736','290  Wolmarans St'),
	('Source Code','0849686357','2077  Wattle St'),
	('Debugging Code','0824918427','2279  Dickens St'),
	('TerminalTrend','0839438190','23  Prospect St'),
	('Data Source','0826649411','1951  Ireland St'),
	('Quest Labs','0827733245','253  Kort St')

  go

  Insert into Employees
  values ('Juan Ludick','ludickjuan@gmail.com','0845879611','51  Bo Meul St',''),
	('Kurt Nobrain','exleadsingerofaband@gmail.com','0123544201','720  Barlow Street',''),
	('Martin Leather','deadactivistlol123@gmail.com','0554689212','196  President St',''),
	('Sia Furler','theunkonownartistwithwhitehair@gmail.com','0346595468','2424  Bodenstein St',''),
	('Corey Taylor','ihavetwobandslol@gmail.com','03216496854','145  Akasia St',''),
	('Sean Mendalev','imdatingalatinafromagirlgroupthatbrokeup@gmail.com','0369459865','1718  Amos St',''),
	('Azure Auraelia','bruhwhyisthismyname@gmail.com','0996641379','2298  Plane St',''),
	('Danielle Cannot','yahoo@gmail.com','0465269852','1640  Glyn St',''),
	('James Moriaty','gotkilkledbymynemisislol@gmail.com','0776653321','1128  North Street',''),
	('Sherlock Holmies','ikilledmynemisislol@gmail.com','0699666993','2312  Bo Meul St',''),
	('Cindy Ludick','Cindyludick@gmail.com','0845879611','833  Visser St','')

	go

	Insert into Clients 
	Values
	('Tiaan','Jacobs',1,'U','tiaanjacobs@gmail.com','195  Voortrekker St',1),
	('Etienne','Hores',2,'U','etiennehores@gmail.com','104  Wattle St',2),
	('Jason','Boniface',3,'M','jasonboniface@gmail.com','2187  Oranje St',3),
	('Robert','Patterson',4,'M','robertpatterson@gmail.com','1674  Zigzag Rd',4),
	('Regina','Wajowski',5,'F','reginawajowski@gmail.com','857  Plane St',5),
	('Willy','Stroker',6,'M','willystroker@gmail.com','2194  Bath Rd',1),
	('Jeanette','Doe',7,'F','jeanettedoe@gmail.com','1552  Plane St',2),
	('Lovemore','Sibanda',8,'F','lovemoresibanda@gmail.com','1156  Plane St',3),
	('Charles','Beckham',9,'M','charlesbeckham@gmail.com','1634  Cheriton Dr',4),
	('Tina','Turner',10,'F','tinaturner@gmail.com','843  Plein St',5),
	('Ma','Madea',1,'U','mamadea@gmail.com','495  Union Lane',1),
	('George','Bush',2,'M','george@gmail.com','516  Schoeman St',2),
	('Trevor','Jones',3,'M','trevorjones@gmail.com','2454  Protea St',3),
	('Nina','Roberts',4,'F','ninaroberts@gmail.com','913  Gray Pl',4),
	('Johan','Ramaphosa',5,'M','johanramaphosa@gmail.com','1155  Albert St',5),
	('Christopher','Robin',6,'M','christopher@gmail.com','1446  Plein St',1),
	('Winnie','Pooh',7,'U','winniepooh@gmail.com','2295  Bad St',2),
	('Kim','Jonson',8,'M','kimjonson@gmail.com','2118  Burger St',3),
	('Abe','Helfer',9,'F','abehelfer@gmail.com','75  Plane St',4),
	('Ghengis','Khan',10,'M','ghengis@gmail.com','1033  Cheriton Dr',5),
	('Atilla','Hunterson',1,'F','atilla@gmail.com','1418  Barlow Street',1),
	('Vlad','Tepesche',2,'U','vladtepesche@gmail.com','2437  Thomas St',2),
	('Joan','Arch',3,'M','joanarch@gmail.com','2180  Mosman Rd',3),
	('Dorothy','Oz',4,'F','dorothyoz@gmail.com','357  Thomas St',4),
	('Belle','Delphine',5,'F','belledelphine@gmail.com','409  Stanley Rd',5),
	('Yoda','Layhehoo',6,'U','yodalayhehoo@gmail.com','1116  Ireland St',1),
	('Freddie','Fasbear',7,'M','freddie@gmail.com','2114  Zigzag Rd',2),
	('Stephan','Notwakin',8,'M','stephan@gmail.com','1668  Sandown Rd',3),
	('Gabe','Itches',9,'F','gabeitches@gmail.com','136  Ireland St',5),
	('Fredd','Le Staire',10,'M','freddlestaire@gmail.com','327  Morgan Rd',4),
	('Jacob','Zoomer',1,'M','jacobzoomer@gmail.com','84  Doreen St',5),
	('Fixer','Uupper',2,'U','fixeruupper@gmail.com','1186  Wolmarans St',1),
	('Ben','Lauden',3,'M','benlauden@gmail.com','1103  Main Rd',2),
	('El','Quisha',4,'F','elquisha@gmail.com','1614  Zigzag Rd',3),
	('Ei','Cys',5,'F','eicys@gmail.com','1530  Robertson Ave',4)

	go
	insert into tbl_Services
	values
	(1,'1 free checup monthly','Active'),
	(2,'Free repair','Cancle'),
	(3,'Weekly cleaning','Upcoming'),
	(1,'Free maintenice on mondays','Canceld'),
	(2,'Free Montly maintenice','Canceld'),
	(3,'Half price repairs onf wensdays','Active')
	

	go
	insert into Jobs
	values
	(1,'Repair',convert(datetime,'21-01-12 10:05:00 AM',5),convert(datetime,'21-01-12 10:25:00 AM',5),20),
	(2,'Maintenace',convert(datetime,'21-01-13 11:32:00 AM',5),convert(datetime,'21-01-13 12:03:00 PM',5),31),
	(3,'Clean',convert(datetime,'21-01-14 9:16:00 AM',5),convert(datetime,'21-01-14 9:50:00 AM',5),34),
	(4,'Clean',convert(datetime,'21-01-15 1:45:00 PM',5),convert(datetime,'21-01-15 2:18:00 PM',5),32),
	(5,'Mothly Maintenace',convert(datetime,'21-01-16 4:11:00 PM',5),convert(datetime,'21-01-16 4:43:00 PM',5),32),
	(6,'Clean',convert(datetime,'21-01-17 2:09:00 PM',5),convert(datetime,'21-01-17 2:44:00 PM',5),35),
	(7,'Maintenace',convert(datetime,'21-01-18 10:27:00 AM',5),convert(datetime,'21-01-18 10:59:00 AM',5),32),
	(8,'Repair',convert(datetime,'21-01-19 9:53:00 AM',5),convert(datetime,'21-01-19 10:27:00 AM',5),33),
	(9,'Clean',convert(datetime,'21-01-20 3:37:00 PM',5),convert(datetime,'21-01-20 3:56:00 PM',5),19),
	(10,'Clean',convert(datetime,'21-01-21 10:34:00 AM',5),convert(datetime,'21-01-21 11:09:00 AM',5),34),
	(11,'Mothly Maintenace',convert(datetime,'21-01-22 4:17:00 PM',5),convert(datetime,'21-01-22 4:48:00 PM',5),31),
	(9,'Maintenace',convert(datetime,'21-01-23 12:43:00 PM',5),convert(datetime,'21-01-23 1:11:00 PM',5),28),
	(10,'Repair',convert(datetime,'21-01-24 1:48:00 PM',5),convert(datetime,'21-01-24 2:32:00 PM',5),44)

		/* CALLS:: call ID(1) | Client ID(2) | Client Name(3) | Call Type(4) | Employee ID(5) | Employee Name(6) | Start Time(7) | End Time(8) | Duration (have fun juan(9))*/
  Insert into Calls
  values (2,'Ettien','Service request',11,'Cindy Ludick',convert(datetime,'21-01-12 10:34:09 AM',5),convert(datetime,'21-01-12 10:49:31 AM',5),NULL),
	(3,'Jason','Service request',2,'Kurt Nobrain',convert(datetime,'21-01-12 10:29:17 AM',5),convert(datetime,'21-01-12 11:11:07 AM',5),NULL),
	(2,'Ettien','Follow up',5,'Corey Taylor',convert(datetime,'21-01-13 09:30:00 AM',5),convert(datetime,'21-01-12 09:32:30 AM',5),NULL),
	(4,'Robert','Service request',5,'Corey Taylor',convert(datetime,'21-01-13 09:32:46 AM',5),convert(datetime,'21-01-13 09:57:41 AM',5),NULL),
	(6,'Willy','Service request',3,'Martin Leather',convert(datetime,'21-01-13 09:44:03 AM',5),convert(datetime,'21-01-12 10:02:01 AM',5),NULL),
	(7,'Jeanette','Service request',9,'James Moriaty',convert(datetime,'21-01-13 11:37:51 AM',5),convert(datetime,'21-01-12 12:22:39 PM',5),NULL),
	(6,'Willy','Follow up',6,'Sean Mendalev',convert(datetime,'21-01-13 04:00:00 PM',5),convert(datetime,'21-01-12 04:15:41 PM',5),NULL),
	(10,'Tina','Service request',7,'Azure Auraelia',convert(datetime,'21-01-13 04:02:11 PM',5),convert(datetime,'21-01-13 04:57:12 PM',5),NULL),
	(10,'Tina','Follow up',10,'Sherlock Holmies',convert(datetime,'21-01-14 08:03:33 AM',5),convert(datetime,'21-01-14 08:59:02 AM',5),NULL),
	(13,'Trevor','Service request',7,'Azure Auraelia',convert(datetime,'21-01-14 08:47:12 AM',5),convert(datetime,'21-01-14 09:07:07 AM',5),NULL),
	(14,'Nina','Service request',9,'James Moriaty',convert(datetime,'21-01-14 10:02:24 AM',5),convert(datetime,'21-01-14 10:42:51 AM',5),NULL);
	go

	/* CONTRACTS:: ContractID(1) | Contract details(2) | Start Date(3) | End Date(4) | Status(5) | Package ID(6)*/
	Insert into Contracts
    values('Includes all the basic essential coverage','2019-12-20','2022-01-01','Active',1),
	('Includes basic service coverage','2018-12-20','2020-01-01','Finished',2),
	('Default standard service package','2018-01-01','2025-01-01','Active',1),
	('Component insurance and replacement package','2020-01-01','2024-01-01','Active',1),
	('Expantion package','2021-07-01','2022-07-01','Planned',3);
	go

	/* TICKETS:: Ticket ID(1) | Call ID(2) | Job ID(3) | feedback(4) | Start time(5) | End time(6) | Duration(Enjoy juan)*/
		Insert into Tickets
    values(1,1,'Request made','12:00:00','13:00:00',Null),
	(3,2,'Request made','12:00:00','13:00:00',Null),
	(4,3,'Request made','14:00:00','15:00:00',Null),
	(6,4,'Request made','10:00:00','12:00:00',Null),
	(7,5,'Request made','12:30:00','13:22:33',Null);
	go

	/* PACKAGES:: Package ID(1) | Package Priotirty(2) | Package Status(3)*/
			Insert into Packages
    values('High','Active'),
	('Low','Active'),
	('Medium','Active');