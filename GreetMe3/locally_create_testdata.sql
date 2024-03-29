﻿/* Create Test Data Locally */

USE [WEXO_GreetMe]
GO

--views
insert into [views] (view_name, has_birthday, has_anniversary) values ('birthday view', 1, 0);
insert into [views] (view_name, has_birthday, has_anniversary) values ('birthday view2', 1, 0);
insert into [views] (view_name, has_birthday, has_anniversary) values ('birthdayAnniversery view', 1, 1);
insert into [views] (view_name, has_birthday, has_anniversary) values ('birthdayAnniversery view2', 1, 1);
insert into [views] (view_name, has_birthday, has_anniversary) values ('Anniversery view', 0, 1);
insert into [views] (view_name, has_birthday, has_anniversary) values ('Anniversery view2', 0, 1);
GO

--people
insert into people (full_name, date_of_birth, hiring_date, email) values ('Tvilling Ib',  '1/16/1996', '1/16/1996', 'TIB@google.de');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Tvilling Dennis',  '1/16/1996', '1/16/1996', 'TD@google.de');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Kollega Tina',  '12/15/1996', '1/16/1996', 'KT@google.de');
GO

--menus
insert into menus (menu_name, start_date, end_date, description) values ('Sticky Whiteleaf Manzanita', '11/2/2023', null, 'PT87 0165 5408 2200 7189 6720 9');
insert into menus (menu_name, start_date, end_date, description) values ('Molokai Peperomia', '11/3/2024', '11/6/2021', 'DO93 T4AH 1703 8062 3395 7062 6571');
insert into menus (menu_name, start_date, end_date, description) values ('Sulphur-flower Buckwheat', '11/7/2024', null, 'AZ40 XNRR INVY X9NZ 4SUZ 4GG1 2RY0');
insert into menus (menu_name, start_date, end_date, description) values ('Oneflower Fringed Gentian', '11/8/2023', null, 'SI98 4327 5007 7159 780');
insert into menus (menu_name, start_date, end_date, description) values ('Fir Dwarf Mistletoe', '11/9/2023', '10/15/2021', 'BG74 YWQO 2032 818S 82YP UR');
insert into menus (menu_name, start_date, end_date, description) values ('Small Evening Primrose', '11/16/2022', null, 'FR98 0068 2008 24WD FXUN ZCSH S94');
GO
