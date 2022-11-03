/* Create Test Data Locally */

USE [WEXO_GreetMe]
GO

--views
insert into [views] (view_name) values ('birthday view');
insert into [views] (view_name) values ('birthdayAnniversery view');
insert into [views] (view_name) values ('Anniversery view');
insert into [views] (view_name) values ('Menu view');
insert into [views] (view_name) values ('BirthdayMenu view');
insert into [views] (view_name) values ('AnniverseryMenu view');
insert into [views] (view_name) values ('BirthdayAnniverseryMenu view');
insert into [views] (view_name) values ('MenuBirthdayAnniversery view');
GO

--layouts
insert into layouts (view_id, layout_name) values (1, 'Senger-Hane layout');
insert into layouts (view_id, layout_name) values (2, 'Harber-Bruen layout');
insert into layouts (view_id, layout_name) values (3, 'Kassulke, White and Heidenreich layout');
insert into layouts (view_id, layout_name) values (4, 'Ritchie, Ullrich and Romaguera layout');
insert into layouts (view_id, layout_name) values (5, 'Macejkovic, Stroman and Wilkinson layout');
insert into layouts (view_id, layout_name) values (6, 'hjkl llc layout');
insert into layouts (view_id, layout_name) values (7, 'allinone layout');
insert into layouts (view_id, layout_name) values (8, 'allinoneshuffled layout');
GO

--components
insert into components (component_name) values ('birthday');
insert into components (component_name) values ('anniversary');
insert into components (component_name) values ('menu');
insert into components (component_name) values ('calender');
GO

--component_positions
	--view1 1
insert into component_positions (position, component_id, width, height) values (1, 1, null, null);
	--view2 2 3
insert into component_positions (position, component_id, width, height) values (1, 1, null, null);
insert into component_positions (position, component_id, width, height) values (2, 2, null, null);
	--view3 4
insert into component_positions (position, component_id, width, height) values (1, 2, null, null);
	--view4 5
insert into component_positions (position, component_id, width, height) values (1, 3, null, null);
	--view5 6 7
insert into component_positions (position, component_id, width, height) values (1, 1, null, null);
insert into component_positions (position, component_id, width, height) values (2, 3, null, null);
	--view6 8 9
insert into component_positions (position, component_id, width, height) values (1, 2, null, null);
insert into component_positions (position, component_id, width, height) values (2, 3, null, null);
	--view7 10 11 12
insert into component_positions (position, component_id, width, height) values (1, 1, null, null);
insert into component_positions (position, component_id, width, height) values (2, 2, null, null);
insert into component_positions (position, component_id, width, height) values (3, 3, null, null);
	--view8 13 14 15
insert into component_positions (position, component_id, width, height) values (1, 3, null, null);
insert into component_positions (position, component_id, width, height) values (2, 1, null, null);
insert into component_positions (position, component_id, width, height) values (3, 2, null, null);
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
insert into people (full_name, date_of_birth, hiring_date, email) values ('Reidar Holsall', '11/2/1979', '11/4/1991', 'rholsall0@moonfruit.com');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Gwennie Wethered', '11/2/1973', '11/4/2001', 'gwethered1@google.de');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Cecilius Matei', '11/3/1977', '11/3/1990', 'cmatei2@vkontakte.ru');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Fedora O''Corrigane', '11/3/1969', '11/3/1995', 'focorrigane3@usda.gov');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Milt Fawdrie', '11/4/1999', '11/2/1997', 'mfawdrie4@fema.gov');
insert into people (full_name, date_of_birth, hiring_date, email) values ('Fidel Ruit', '11/4/1985', '11/2/2002', 'fruit5@google.com.hk');
GO

--menus
insert into menus (menu_name, start_date, end_date, description) values ('Sticky Whiteleaf Manzanita', '11/2/2023', null, 'PT87 0165 5408 2200 7189 6720 9');
insert into menus (menu_name, start_date, end_date, description) values ('Molokai Peperomia', '11/3/2024', '11/6/2021', 'DO93 T4AH 1703 8062 3395 7062 6571');
insert into menus (menu_name, start_date, end_date, description) values ('Sulphur-flower Buckwheat', '11/7/2024', null, 'AZ40 XNRR INVY X9NZ 4SUZ 4GG1 2RY0');
insert into menus (menu_name, start_date, end_date, description) values ('Oneflower Fringed Gentian', '11/8/2023', null, 'SI98 4327 5007 7159 780');
insert into menus (menu_name, start_date, end_date, description) values ('Fir Dwarf Mistletoe', '11/9/2023', '10/15/2021', 'BG74 YWQO 2032 818S 82YP UR');
insert into menus (menu_name, start_date, end_date, description) values ('Small Evening Primrose', '11/16/2022', null, 'FR98 0068 2008 24WD FXUN ZCSH S94');
GO
