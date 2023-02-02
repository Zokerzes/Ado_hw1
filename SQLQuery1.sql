--Название;
--Тип (овощ или фрукт);
--Цвет;
--Калорийность.

--create table Vegetables_Fruits(
--	id int identity(1,1) not null CONSTRAINT PK_Vegetables_Fruits primary key,
--	NameVF nvarchar(30) not null,
--	TypeVF nvarchar(30) not null,
--	ClolorVF nvarchar(30) not null,
--	Caloric_Content decimal not null
--	)


--insert into Vegetables_Fruits 
--values	(N'Картофель',N'Овощи',N'Белый',200),
--		(N'Томаты',N'Овощи',N'Розовый',150),
--		(N'Капуста',N'Овощи',N'Белый',140),
--		(N'Яблоки',N'Фрукты',N'Зелёные',170),
--		(N'Бананы',N'Фрукты',N'Желтые',400)

--select [NameVF],[TypeVF],[ClolorVF],[Caloric_Content] from Vegetables_Fruits
use VegetablesAndFruits
--select DISTINCT [id],[ClolorVF] from Vegetables_Fruits
select top 1 [id],[Caloric_Content],[NameVF] from Vegetables_Fruits
order by [Caloric_Content] desc