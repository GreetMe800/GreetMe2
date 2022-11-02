/* Create Test Data Locally */

USE [WEXO_GreetMe]
GO

--layouts
insert into layouts (layout_name) values ('Senger-Hane layout');
insert into layouts (layout_name) values ('Harber-Bruen layout');
insert into layouts (layout_name) values ('Kassulke, White and Heidenreich layout');
insert into layouts (layout_name) values ('Ritchie, Ullrich and Romaguera layout');
insert into layouts (layout_name) values ('Macejkovic, Stroman and Wilkinson layout');
insert into layouts (layout_name) values ('hjkl llc layout');
insert into layouts (layout_name) values ('allinone layout');
insert into layouts (layout_name) values ('allinoneshuffled layout');
GO

--views
insert into [views] (view_name, layout_id) values ('birthday view', 1);
insert into [views] (view_name, layout_id) values ('birthdayAnniversery view', 2);
insert into [views] (view_name, layout_id) values ('Anniversery view', 3);
insert into [views] (view_name, layout_id) values ('Menu view', 4);
insert into [views] (view_name, layout_id) values ('BirthdayMenu view', 5);
insert into [views] (view_name, layout_id) values ('AnniverseryMenu view', 6);
insert into [views] (view_name, layout_id) values ('BirthdayAnniverseryMenu view', 7);
insert into [views] (view_name, layout_id) values ('MenuBirthdayAnniversery view', 8);
GO

--components
insert into components (component_name) values ('birthday');
insert into components (component_name) values ('anniversary');
insert into components (component_name) values ('menu');
insert into components (component_name) values ('calender');
GO

--component_positions
	--view1 1
insert into component_positions (position, component_id) values (1, 1);
	--view2 2 3
insert into component_positions (position, component_id) values (1, 1);
insert into component_positions (position, component_id) values (2, 2);
	--view3 4
insert into component_positions (position, component_id) values (1, 2);
	--view4 5
insert into component_positions (position, component_id) values (1, 3);
	--view5 6 7
insert into component_positions (position, component_id) values (1, 1);
insert into component_positions (position, component_id) values (2, 3);
	--view6 8 9
insert into component_positions (position, component_id) values (1, 2);
insert into component_positions (position, component_id) values (2, 3);
	--view7 10 11 12
insert into component_positions (position, component_id) values (1, 1);
insert into component_positions (position, component_id) values (2, 2);
insert into component_positions (position, component_id) values (3, 3);
	--view8 13 14 15
insert into component_positions (position, component_id) values (1, 3);
insert into component_positions (position, component_id) values (2, 1);
insert into component_positions (position, component_id) values (3, 2);
GO

--component_view (brigde)
	--view1
insert into component_view (component_id, view_id) values (1, 1);
	--view2
insert into component_view (component_id, view_id) values (1, 2);
insert into component_view (component_id, view_id) values (2, 2);
	--view3
insert into component_view (component_id, view_id) values (2, 3);
	--view4
insert into component_view (component_id, view_id) values (3, 4);
	--view5
insert into component_view (component_id, view_id) values (1, 5);
insert into component_view (component_id, view_id) values (3, 5);
	--view6
insert into component_view (component_id, view_id) values (2, 6);
insert into component_view (component_id, view_id) values (3, 6);
	--view7
insert into component_view (component_id, view_id) values (1, 7);
insert into component_view (component_id, view_id) values (2, 7);
insert into component_view (component_id, view_id) values (3, 7);
	--view8
insert into component_view (component_id, view_id) values (1, 8);
insert into component_view (component_id, view_id) values (2, 8);
insert into component_view (component_id, view_id) values (3, 8);
GO

--layout_component_position (brigde)
insert into layout_component_position (layout_id, component_position_id) values (1, 1);

insert into layout_component_position (layout_id, component_position_id) values (2, 2);
insert into layout_component_position (layout_id, component_position_id) values (2, 3);

insert into layout_component_position (layout_id, component_position_id) values (3, 4);

insert into layout_component_position (layout_id, component_position_id) values (4, 5);

insert into layout_component_position (layout_id, component_position_id) values (5, 6);
insert into layout_component_position (layout_id, component_position_id) values (5, 7);

insert into layout_component_position (layout_id, component_position_id) values (6, 8);
insert into layout_component_position (layout_id, component_position_id) values (6, 9);

insert into layout_component_position (layout_id, component_position_id) values (7, 10);
insert into layout_component_position (layout_id, component_position_id) values (7, 11);
insert into layout_component_position (layout_id, component_position_id) values (7, 12);

insert into layout_component_position (layout_id, component_position_id) values (8, 13);
insert into layout_component_position (layout_id, component_position_id) values (8, 14);
insert into layout_component_position (layout_id, component_position_id) values (8, 15);
GO

--people
insert into people (full_name, date_of_birth, hiring_date, email) values ('Reidar Holsall', '6/18/1979', '11/17/1991', 'rholsall0@moonfruit.com');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Gwennie Wethered', '6/28/1973', '4/17/2001', 'gwethered1@google.de');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Cecilius Matei', '9/10/1977', '7/11/1990', 'cmatei2@vkontakte.ru');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Fedora O''Corrigane', '10/21/1969', '2/10/1995', 'focorrigane3@usda.gov');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Milt Fawdrie', '12/8/1999', '9/6/1997', 'mfawdrie4@fema.gov');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Fidel Ruit', '10/4/1985', '2/16/2002', 'fruit5@google.com.hk');
GO

--menus
insert into menus (menu_name, start_date, end_date, description) values ('Sticky Whiteleaf Manzanita', '4/15/2023', null, 'PT87 0165 5408 2200 7189 6720 9');
insert into menus (menu_name, start_date, end_date, description) values ('Molokai Peperomia', '1/1/2024', '1/18/2021', 'DO93 T4AH 1703 8062 3395 7062 6571');
insert into menus (menu_name, start_date, end_date, description) values ('Sulphur-flower Buckwheat', '9/26/2024', null, 'AZ40 XNRR INVY X9NZ 4SUZ 4GG1 2RY0');
insert into menus (menu_name, start_date, end_date, description) values ('Oneflower Fringed Gentian', '3/7/2023', null, 'SI98 4327 5007 7159 780');
insert into menus (menu_name, start_date, end_date, description) values ('Fir Dwarf Mistletoe', '7/22/2023', '10/28/2021', 'BG74 YWQO 2032 818S 82YP UR');
insert into menus (menu_name, start_date, end_date, description) values ('Small Evening Primrose', '1/9/2022', null, 'FR98 0068 2008 24WD FXUN ZCSH S94');
GO
​

