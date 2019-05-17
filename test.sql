CREATE TABLE Buyer(
buyer_code varchar(20),
company varchar(50),
address varchar(100),
country varchar(15),
email varchar(100)
CONSTRAINT buyer_pk1 PRIMARY KEY(buyer_code)
);

CREATE TABLE BuyerPhone(
buyer_code varchar(20),
phone varchar(15)
CONSTRAINT pk1_BuyerPhone PRIMARY KEY(buyer_code,phone),
CONSTRAINT fk_BuyerPhone FOREIGN KEY(buyer_code) REFERENCES Buyer(buyer_Code),
);

CREATE TABLE Orders(
ord_id char(10),
buyer_code varchar(20),
ord_date datetime default cast (getdate() as date) NOT NULL,
req_ship_date datetime NOT NULL,
conf_ship_date datetime,
hs_code char(10) NOT NULL,
order_val real NOT NULL,
trans_split varchar(3),
article varchar(100) NOT NULL,
ci_no char(5) CHECK(ci_no LIKE '[0-9][0-9][0-9][0-9][0-9]'),
CONSTRAINT order_pk1 PRIMARY KEY(Ord_id),
CONSTRAINT buyer_fk1 FOREIGN KEY(buyer_code) REFERENCES Buyer(buyer_code) ON DELETE SET NULL,
);

CREATE TABLE Quantity(
ord_id char(10),
size varchar(15),
qty int NOT NULL
CONSTRAINT Quantity_pk1 PRIMARY KEY(ord_id,size),
CONSTRAINT Quanity_fk1 FOREIGN KEY(Ord_id) REFERENCES Orders(Ord_id) ON DELETE CASCADE,
);

CREATE TABLE Measurement(
ord_id char(10),
m_index char(1),
measurement_point varchar(20),
where_to_measure varchar(20),
front_pic varchar(20),
back_pic varchar(20)
CONSTRAINT Measurement_pk1 PRIMARY KEY(ord_id,m_index),
CONSTRAINT Measurement_fk1 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id) ON DELETE CASCADE,
);

CREATE TABLE Measurement_sheet(

mes_id  char(7),
ord_id  char(10),
grade real NOT NULL,
tolernce_p real NOT NULL,
tolernce_m real NOT NULL
CONSTRAINT measuresht_pk1 PRIMARY KEY(mes_id),
CONSTRAINT measuresht_fk1 FOREIGN KEY(Ord_id) REFERENCES Orders(Ord_id) ON DELETE CASCADE,
);

CREATE TABLE GmntPayment(

payment_id  char(7),
ord_id char(10),
buyer_code varchar(20),
val_USD money,
val_LKR money,
paydate datetime DEFAULT CAST(GETDATE() AS date),
payment_terms varchar(300),
CONSTRAINT Gmntpayment_pk1 PRIMARY KEY(payment_id),
CONSTRAINT Gmntpayment_fk1 FOREIGN KEY(Ord_id) REFERENCES Orders(Ord_id) ON DELETE SET NULL,
CONSTRAINT Gmntpayment_fk2 FOREIGN KEY(buyer_code) REFERENCES Buyer(buyer_code) ON DELETE SET NULL,
);

CREATE TABLE shipment(
ship_id varchar(10),
destination_port varchar(50) NOT NULL,
country varchar(15) NOT NULL,
Transport_type char(3) check(Transport_type LIKE 'sea' OR Transport_type LIKE 'air') NOT NULL,
Terms_of_delivery varchar(50) NOT NULL,
pAddress varchar(50) NOT NULL,
sDate datetime NOT NULL,
shpmntstatus bit NOT NULL,
receivedby varchar(50) NOT NULL, 
buyer_code varchar(20),
ord_id char(10)
CONSTRAINT shipment_pk1 PRIMARY KEY(ship_id),
CONSTRAINT shipment_fk1 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id),
CONSTRAINT shipment_fk2 FOREIGN KEY(buyer_code) REFERENCES Buyer(buyer_code) ON DELETE SET NULL,
);

CREATE TABLE Package(

pack_id char(7),
ord_id char(10),
ship_id varchar(10),
no_of_pieces int NOT NULL
CONSTRAINT package_pk1 PRIMARY KEY(pack_id),
CONSTRAINT package_fk1 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id),
CONSTRAINT package_fk2 FOREIGN KEY(ship_id )REFERENCES shipment(ship_id)
);

CREATE TABLE Garment(
Barcode_id char(12),
ord_id char(10),
size varchar(5) NOT NULL,
pack_id char(7)
CONSTRAINT garment_pk1 PRIMARY KEY(Barcode_id),
CONSTRAINT garment_fk1 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id),
CONSTRAINT garment_fk2 FOREIGN KEY(pack_id) REFERENCES Package(pack_id)
);

CREATE TABLE Utilities
(
	ut_no char(7),
	ut_name varchar(20),
	description varchar(100),
	type varchar(10),
	added_date datetime,
	last_modification datetime,
	price real
	CONSTRAINT pk_Machineries PRIMARY KEY (ut_no),
)

CREATE TABLE Line
(
	Line_id char(1),
	CONSTRAINT pk_Line PRIMARY KEY (Line_id),
) 

CREATE TABLE Employee
(
	EmpId char(7),
	fname varchar(15),
	lname varchar (10),
	deptId int,
	designation varchar(30),
	gender char(1),
	NIC varchar(10) CHECK(NIC LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]V'),
	address varchar(100),
	email varchar(300),
	operation_id int,
	Line_id char(1),
	machine_id char(7)
	CONSTRAINT pk_Employee PRIMARY KEY (EmpId), 
	CONSTRAINT fk_1_Employee FOREIGN KEY (machine_id) REFERENCES Utilities(ut_no),
) 

CREATE TABLE Hydro_test(
 
Test_id char(7),
Barcode_id char(12),
htime datetime,
Util_No char(7),
operator char(7),
Hand_tester_rowing real,
duration_under_pressure datetime,
no_of_seams int
CONSTRAINT hydro_pk1 PRIMARY KEY(Test_id),
CONSTRAINT hydro_fk1 FOREIGN KEY(Barcode_id) REFERENCES Garment(Barcode_id) ON DELETE CASCADE,
CONSTRAINT hydro_fk2 FOREIGN KEY(operatOR) REFERENCES Employee(EmpId) ON DELETE SET NULL
);

CREATE TABLE Damaged_items(

dam_ins_id char(7),
Barcode_id char(12),
buyer_code varchar(20),
Inspct_Time datetime NOT NULL,
operator char(7) NOT NULL,
reason varchar(300),
Line_no char(1) NOT NULL,
CONSTRAINT dmgitems_pk1 PRIMARY KEY(dam_ins_id),
CONSTRAINT dmgitems_fk1 FOREIGN KEY(Barcode_id) REFERENCES Garment(Barcode_id),
CONSTRAINT dmgitems_fk2 FOREIGN KEY(buyer_code) REFERENCES Buyer(buyer_code),
CONSTRAINT dmgitems_fk3 FOREIGN KEY(operatOR) REFERENCES Employee(EmpId),
CONSTRAINT dmgitems_fk4 FOREIGN KEY(Line_no) REFERENCES Line(Line_id ),
);

CREATE TABLE Gmnt_sample(
Samp_id char(7),
ord_id char(10),
Buyer_code char(10),
cost_USD money,
cost_LKR money,
Delivered_date datetime,
samp_status varchar(15),
fashion_sketch varchar(500),
CONSTRAINT GmntSample_pk1 PRIMARY KEY(Samp_id),
CONSTRAINT GmntSample_fk1 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id),
);


CREATE TABLE Label(
spec_id char(5),
Quantity int,
Label varchar(15),
Placement varchar(500),
gmntdescription varchar(300),
labelpic varchar(200),
backpic varchar(200),
CONSTRAINT Label_pk1 PRIMARY KEY(spec_id),
);

CREATE TABLE Rejeceted_samples(
Samp_id char(7),
ord_id char(10),
Spec_id char(5),
comments varchar(100),
CONSTRAINT rejected_pk1 PRIMARY KEY(Samp_id,ord_id,Spec_id),
CONSTRAINT rejected_fk1 FOREIGN KEY(Spec_id) REFERENCES Label(Spec_id),
CONSTRAINT rejeceted_fk2 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id),
CONSTRAINT rejeceted_fk3 FOREIGN KEY(Samp_id) REFERENCES Gmnt_sample(Samp_id),
);

CREATE TABLE Order_Spec(
ord_id char(10),
Spec_id char(5),
CONSTRAINT Orderspc_pk1 PRIMARY KEY(ord_id,Spec_id),
CONSTRAINT Orderspc_fk1 FOREIGN KEY(ord_id) REFERENCES Orders(ord_id),
CONSTRAINT Orderspc_fk2 FOREIGN KEY(Spec_id) REFERENCES Label(Spec_id)
);

CREATE TABLE Item(
pSpec_id char(5),
item varchar(15),
g_description varchar(100),
color varchar(20),
CONSTRAINT item_pk1 PRIMARY KEY(pSpec_id),
CONSTRAINT item_fk1 FOREIGN KEY(pSpec_id) REFERENCES Label(Spec_id)
);


 


CREATE TABLE UtSupplier
(
	
	ut_sup_id char(7),
	company varchar(50) NOT NULL,
	address varchar(100) NOT NULL,
	country varchar(30) NOT NULL,
	agent varchar(40) NOT NULL,
	email varchar(80) NOT NULL,
	CONSTRAINT pk_UtSupplier PRIMARY KEY (ut_sup_id)
)


CREATE TABLE UtSupPhone
(

    ut_sup_id char(7),
	phone varchar(16),
	CONSTRAINT pk_UtSupPhone PRIMARY KEY ( ut_sup_id,phone),
	CONSTRAINT fk_UtSupPhone FOREIGN KEY ( ut_sup_id) REFERENCES UtSupplier (ut_sup_id) ON DELETE CASCADE

)

CREATE TABLE SupplyUt
(
	ut_sup_id char(7),
	ut_no char(7),
	CONSTRAINT pk_SupplyUt PRIMARY KEY (ut_sup_id,ut_no ),
	CONSTRAINT fk_1_SupplyUt FOREIGN KEY (ut_sup_id ) REFERENCES UtSupplier (ut_sup_id)  ON DELETE CASCADE,
	CONSTRAINT fk_2_SupplyUt FOREIGN KEY (ut_no) REFERENCES Utilities (ut_no) ON DELETE CASCADE 
)

CREATE TABLE MatSupplier
(
	
	mt_sup_id char(7),
	company varchar(50) NOT NULL,
	address varchar(100) NOT NULL,
	country varchar(30) NOT NULL,
	agent varchar(40) NOT NULL,
	email varchar(80) NOT NULL,
	CONSTRAINT pk_MatSupplier PRIMARY KEY (mt_sup_id)
)

CREATE TABLE MatSupPhone
(

    mt_sup_id char(7),
	phone varchar(16),
	CONSTRAINT pk_MatSupPhone PRIMARY KEY (mt_sup_id,phone),
	CONSTRAINT fk_MatSupPhone FOREIGN KEY (mt_sup_id) REFERENCES MatSupplier (mt_sup_id) ON DELETE CASCADE
)


CREATE TABLE StockItem
(
	int_item_id int IDENTITY,
	item_id AS 'ITEM' + RIGHT('000' + CAST(int_item_id AS varchar(3)),3)PERSISTED,
	item_name varchar(20) NOT NULL,
	item_type varchar(20),
	item_description varchar(30),
	suggested_ROL Integer,
	unit_price Real,
	added_date SmallDateTime  NOT NULL
	CONSTRAINT pk_StockItem PRIMARY KEY (item_id)
	 
)

CREATE TABLE Stock
(
	int_stock_id int IDENTITY,
	stock_id AS 'ST' + RIGHT('000' + CAST(int_stock_id AS varchar(3)),3)PERSISTED,
	item_id varchar(7),
	rol Integer,
	qty Integer,
	added_date SmallDateTime,
	stored_loc char(10),
	value Real
	CONSTRAINT pk_Stock PRIMARY KEY (stock_id),
	CONSTRAINT fk_Stock FOREIGN KEY (item_id) REFERENCES StockItem (item_id) ON DELETE SET NULL
)



CREATE TABLE Issue
(
	int_issue_id int IDENTITY,
	issue_id AS 'ISS' + RIGHT('000' + CAST(int_issue_id AS varchar(3)),3)PERSISTED,
	stock_id varchar(5),
	issue_type char(4) CHECK(issue_type LIKE 'qty' OR issue_type LIKE 'qlty'),
	issues_description varchar(50),
	excess_lack char(3) CHECK(excess_lack LIKE 'exc' OR excess_lack LIKE 'lac'),
	issueCount int,
	value real,
	CONSTRAINT pk_Issue PRIMARY KEY (issue_id),
	CONSTRAINT fk_Issue FOREIGN KEY (stock_id) REFERENCES Stock (stock_id) ON DELETE SET NULL
)

CREATE TABLE SupplyMat
(
	mt_sup_id char(7),
	item_id varchar(7),
	CONSTRAINT pk_SupplyMat PRIMARY KEY (mt_sup_id,item_id ),
	CONSTRAINT fk_1_SupplyMat FOREIGN KEY (mt_sup_id ) REFERENCES MatSupplier (mt_sup_id),
	CONSTRAINT fk_2_SupplyMat FOREIGN KEY (item_id) REFERENCES StockItem (item_id ),
)

CREATE TABLE PurchaseInvoice
(
	
	invoice_no char(7),
	date datetime NOT NULL,
	unit_price real NOT NULL,
	item_id varchar(7),
	quantity int NOT NULL,
	total_price real NOT NULL,
	paid bit NOT NULL,
	paid_on datetime NOT NULL,
	CONSTRAINT pk_PurchaseInvoice PRIMARY KEY (invoice_no),
	CONSTRAINT fk_PurchaseInvoice FOREIGN KEY (item_id) REFERENCES StockItem(item_id) 
)


CREATE TABLE Mt_Purchase
(
	mt_sup_id char(7) ,
	item_id varchar(7),
	invoice_no char(7) ,
	CONSTRAINT pk_Mt_Purchase  PRIMARY KEY (mt_sup_id,item_id ,invoice_no),
	CONSTRAINT fk_1_Mt_Purchase FOREIGN KEY (mt_sup_id)  REFERENCES MatSupplier (mt_sup_id),
	CONSTRAINT fk_2_Mt_Purchase FOREIGN KEY  (item_id)  REFERENCES StockItem (item_id),
	CONSTRAINT fk_3_Mt_Purchase FOREIGN KEY  (invoice_no) REFERENCES PurchaseInvoice (invoice_no)
)


CREATE TABLE Ut_Purchase
(
	ut_sup_id char(7) ,
	ut_no char(7),
	invoice_no char(7) ,
	CONSTRAINT pk_Ut_Purchase PRIMARY KEY (ut_sup_id,ut_no  ,invoice_no),
	CONSTRAINT fk_1_Ut_Purchase FOREIGN KEY  (ut_sup_id) REFERENCES UtSupplier ( ut_sup_id),
	CONSTRAINT fk_2_Ut_Purchase FOREIGN KEY  (ut_no) REFERENCES Utilities ( ut_no),
	CONSTRAINT fk_3_Ut_Purchase FOREIGN KEY  (invoice_no) REFERENCES PurchaseInvoice (invoice_no)
)


CREATE TABLE Parts
(
	part_no char(7),
	part_name varchar(20),
	date_issued datetime NOT NULL,
	issued_by char(7) NOT NULL,
	fixed_by  char(7) NOT NULL,
	cost real NOT NULL,
	CONSTRAINT pk_Parts PRIMARY KEY (part_no),
	CONSTRAINT fk_1_Parts FOREIGN KEY (issued_by) REFERENCES Employee (EmpId),
	CONSTRAINT fk_2_Parts FOREIGN KEY (fixed_by) REFERENCES Employee (EmpId)
)


CREATE TABLE Mac_Inspection
(
	mac_ins_id char(8),
	line_no char(1),
	date datetime NOT NULL,
	time datetime NOT NULL,
	ut_no char(7),
	type char(6) NOT NULL,
	description varchar(100),
	safty_officer char(7),
	employee char(7), 
	CONSTRAINT pk_Mac_Inspection PRIMARY KEY (mac_ins_id),
	CONSTRAINT fk_1_Mac_Inspection FOREIGN KEY (ut_no) REFERENCES Utilities (ut_no),
	CONSTRAINT fk_2_Mac_Inspection FOREIGN KEY (safty_officer) REFERENCES Employee (EmpId),
	CONSTRAINT fk_3_Mac_Inspection FOREIGN KEY (employee) REFERENCES Employee (EmpId),
	CONSTRAINT fk_4_Mac_Inspection FOREIGN KEY (line_no) REFERENCES Line (Line_id)
	)

	CREATE TABLE Needle
(
	needle_id char(7),
	needle_type char(5),
	size real NOT NULL,
	CONSTRAINT pk_Needle PRIMARY KEY (needle_id) 
		 
)

	CREATE TABLE Ned_Inspection
(
	
    ned_ins_id char(8),
	line_no char(1),
	date datetime NOT NULL,
	time datetime NOT NULL,
	needle_id char(7),
	type char(6) NOT NULL,
	description varchar(100),
	safty_officer char(7),
	employee char(7), 
	CONSTRAINT pk_Ned_Inspection PRIMARY KEY (ned_ins_id),
	CONSTRAINT fk_1_Ned_Inspection FOREIGN KEY (needle_id) REFERENCES Needle (needle_id),
	CONSTRAINT fk_2_Ned_Inspection FOREIGN KEY (safty_officer) REFERENCES Employee (EmpId),
	CONSTRAINT fk_3_Ned_Inspection FOREIGN KEY (employee) REFERENCES Employee (EmpId),
	CONSTRAINT fk_4_Ned_Inspection FOREIGN KEY (line_no) REFERENCES Line (Line_id)
	)
	

CREATE TABLE Operation
(
	
    operation_id char(7),
	description varchar(50),
	CONSTRAINT pk_Operation PRIMARY KEY (operation_id)
)

CREATE TABLE OperationDateTime
(
	date datetime,
	time datetime,
	operation_id char(7),
	CONSTRAINT pk_OperationDateTime PRIMARY KEY (date,time),
	CONSTRAINT fk_OperationDateTime FOREIGN KEY (operation_id) REFERENCES Operation(operation_id )
)

CREATE TABLE orderOperation
(
	order_id char(10),
	operation_id varchar(7),
	CONSTRAINT pk_orderOperation PRIMARY KEY (ORder_id,operation_id),
	CONSTRAINT fk_1_orderOperation FOREIGN KEY (ORder_id) REFERENCES Orders (Ord_id)
)

CREATE TABLE EmpTrack
(
	track_id int,
	emp_id char(7),
	operation_id char(7),
	target int NOT NULL,
	covered bit NOT NULL,
	CONSTRAINT pk_EmpTrack PRIMARY KEY (track_id ),
	CONSTRAINT fk_1_EmpTrack FOREIGN KEY (emp_id) REFERENCES Employee (EmpId) ON DELETE CASCADE,
	CONSTRAINT fk_2_EmpTrack FOREIGN KEY (operation_id) REFERENCES Operation (operation_id) ON DELETE CASCADE,
)


CREATE TABLE Expenditures
(
	
    ex_id char(7),
	date datetime NOT NULL,
	type varchar(20) NOT NULL,
	description varchar(70),
	price real NOT NULL,
	paid bit NOT NULL,
	CONSTRAINT pk_Expenditures PRIMARY KEY (ex_id)
)


CREATE TABLE deduction(
DedID int PRIMARY KEY,
DedType char(20),
Amount float,
EPF real,
loanAmnt real,
leavededuction real,
)

CREATE TABLE salary (
id int identity(1,1),
sal_id as 'SAL' + right ('0000' + cast (id as varchar(4)),4) persisted,
EmpId char(7),
deductionId int ,
bonus real,
allowance real,
amount real,
OTratePerHour real,
OTAmnt real,
TotalsalaryAmnt float,
CONSTRAINT pk_1 PRIMARY KEY (sal_id),
CONSTRAINT FK_1 FOREIGN KEY (EmpId) REFERENCES Employee(EmpId) ON UPDATE CASCADE,
CONSTRAINT FK_2 FOREIGN KEY (deductionId) REFERENCES deduction(DedID) ON UPDATE CASCADE,
)

CREATE TABLE department(
deptId int IDENTITY (10,1) PRIMARY KEY,
name varchar(20),
)

CREATE TABLE supervisor(
supervisorId int PRIMARY KEY,
EmpId char(7),
DeptId int,
yearsOfExperience int , 
CONSTRAINT FK_sup1 FOREIGN KEY (EmpId) REFERENCES Employee(EmpId) ON UPDATE CASCADE,
CONSTRAINT FK_sup2 FOREIGN KEY (DeptId) REFERENCES department(deptId) ON DELETE CASCADE
)

CREATE TABLE training(
trainingID int IDENTITY(1,1) PRIMARY KEY,
daysoftraining int,
supId int,
traintype varchar(30),
duration int,
moduleName char(20),
location varchar(50),
CONSTRAINT fk_tr FOREIGN KEY (supId) REFERENCES supervisOR(supervisORId) ON UPDATE CASCADE
)


CREATE TABLE payment(
payment_id char(7),
sal_id varchar(7),
DatePaid DATE,
BankName varchar(30),
status char(10),
CONSTRAINT pk_Spay PRIMARY KEY (payment_id),
CONSTRAINT fk_Spay FOREIGN KEY(sal_id) REFERENCES salary(sal_id) ON UPDATE CASCADE
)

CREATE TABLE Income
(
	
    in_id char(7),
	date datetime NOT NULL,
	tyop varchar(20),
	gross_value real,
	net_value real,
	payment_id char(7),
	CONSTRAINT pk_income PRIMARY KEY (in_id),
	CONSTRAINT fk_income FOREIGN KEY (payment_id) REFERENCES payment (payment_id)
)







CREATE TABLE Insurance_Administration
(
DisasterNo int NOT NULL PRIMARY KEY,
PolicyNo varchar(10) NOT NULL,
Disaster char(40),
DisDate datetime,
Status varchar(50),
InsdDate datetime,
LostInventory varchar(255),
AccDate datetime,
LateDate datetime
)


CREATE TABLE Login(
	
	user_name varchar(15),
	user_id char(7),
	desig varchar(30),
	password varchar(20),
	img varchar(100),
	CONSTRAINT login_pk PRIMARY KEY (user_name),

	
)
CREATE TABLE country(
  id int NOT NULL  PRIMARY KEY,
  iso varchar (10)NOT NULL,
  name varchar(30) NOT NULL,
  nicename varchar(30) NOT NULL,
  iso3 varchar(10) DEFAULT NULL,
  numcode int DEFAULT NULL,
  phonecode int NOT NULL,
  )

  CREATE TABLE Profit
  (
	prf_id int,
	ex_id char(7),
	in_id char(7),
	profit real,
	CONSTRAINT Profit_pk PRIMARY KEY (prf_id),
	CONSTRAINT Profit_fk1 FOREIGN KEY (ex_id) REFERENCES Expenditures(ex_id),
	CONSTRAINT Profit_fk2 FOREIGN KEY (in_id) REFERENCES Income(in_id),

  )

