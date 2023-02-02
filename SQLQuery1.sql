--Название;
--Тип (овощ или фрукт);
--Цвет;
--Калорийность.

create table Vegetables_Fruits(
	id int identity(1,1) not null CONSTRAINT PK_Vegetables_Fruits primary key,
	NameVF nvarchar(30) not null,
	TypeVF nvarchar(30) not null,
	ClolorVF nvarchar(30) not null,
	Caloric_Content decimal not null
	)