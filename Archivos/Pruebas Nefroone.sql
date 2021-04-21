-----------------------------------------------------------------------------------------------------------
-------------			POBLACI�N DE TABLAS CON LOS PRODCEDIMIENTOS (PARA TESTEO)		-------------------
-----------------------------------------------------------------------------------------------------------
use Nefroone4
go
--Usuario
select *from Usuario
exec insertar_usuario 'pol','123'

--Empleado
select *from Empleado
--No reciben el id como par�metro, modificar y eliminar espec�ficamente trabajan de forma
--idependiente con el ci del empleado
exec insertar_empleado 'Pepe','V�squez','Muralla',9239544,'07/05/1978',7584329,'Enfermero',1
exec modificar_empleado 'Chepeto','V�squez','Muralla',9239543,'07/05/1978',7584329,'Administrador'
exec eliminar_empleado 9239544
/*
go
--Paciente
select *from Paciente
exec insertar_paciente 92452354,'Joaquin','Charles','Flower','13/08/1998',0,'M','Calle Cosorio'
exec modificar_paciente 92452354,'Pedro','Contra','Barreras','13/08/1998',0,'M','Calle Alem�n'
exec eliminar_paciente 0
go
--Hoja Registro
select *from Hoja_Secretaria
exec insertar_hoja_sec 7249399,false,'Esta es una carta negativa','este es un grado instrucci�n','local','Montero','Este es un seguro','27/09/2021',92452354,1
exec modificar_hoja_sec 1,7249399,true,'Esta es una carta negativa','este es un grado instrucci�n','local','Montero','Este es un seguro','27/09/2021',92452354
exec eliminar_hoja_sec 6,92452354

/*
--Hoja M�dica
select *from Hoja_Medica
exec insertar_hoja_medica 23,'Fiebre y mucho cansancio',42.5,'esta es una serologia',1.70,23,true,'Cateter','O-RH Negativo','Esta es una soluci�n dializante',1
exec modificar_hoja_medica 1,23,'Tos y fiebre',42.5,'esta es una serologia',1.70,23,true,'Cateter','O-RH Negativo','Esta es una soluci�n dializante',1
exec eliminar_hoja_medica 2,1 --Funciona con el id de la hoja m�dica
go
--Hoja Control de Enfermer�a
select *from Control_Enfermeria
exec insertar_control_enfermeria '12/05/2021',1,'14:10','15:20',60.6,58.8,'Esta es una UF programada','Esta es una heparina',670.70,'Presi�n de 210',26.5,'Este es un pulso','Esta es una saturaci�n',1,1
exec modificar_control_enfermeria 2,'17/05/2021',19,'14:10','15:20',60.6,58.8,'Esta es una UF programada','Esta es una heparina',670.70,'Presi�n de 210',26.5,'Este es un pulso','Esta es una saturaci�n',3,1
exec eliminar_control_enfermeria 2,3,1
go
--Evoluci�n y Tratamiento
--Esta tabla es tremenda, roba de varios!!
select *from Evolucion_Tratamiento
exec insertar_evolucion_y_tratamiento 4252389,'esta es una ultra filtraci�n','4 horas','Este es un flujo de dialisis','El paciente evoluciona favorablemente','Se le ha recetado al paciente un paracetamol','Tratamiento normal',1,1
exec modificar_evolucion_y_tratamiento 
exec eliminar_evolucion_y_tratamiento 


SELECT *FROM  Medicamento
SELECT * FROM Farmacia
select*from empleado

insert into Farmacia values ('Farmacia NEFROONE',1)

insert into empleado values ('Juan','Perez','Alba',123,'12-04-1998',77890212,'Farmaceutico')

insert into Medicamento values ('Acido Folico','Comprimido','5Mg.',100,'F')
insert into Medicamento values ('Acido Acetilsalicilico','Comprimido','100Mg.',100,'F')
insert into Medicamento values ('Atorvastatina','Comprimido','10Mg.',100,'F')
insert into Medicamento values ('Nifedipino','Comprimido','20Mg.',100,'F')
insert into Medicamento values ('Calcio(carbonato o citrato)','Comprimido','500Mg.',100,'F')
insert into Medicamento values ('Colecalciferol (vitamina D3)','Comprimido','0,25Mg.',100,'F')
insert into Medicamento values ('Complejo B (B1-B6-B12)','Comprimido','Estandar',100,'F')
insert into Medicamento values ('Complejo B(B1-B6-B12)','Inyectable','Estandar',100,'F')
insert into Medicamento values ('Carvedilol','Comprimido','12,5Mg.',100,'F')
insert into Medicamento values ('Eritropoyetina','Inyectable','4000 UI',100,'F')
insert into Medicamento values ('Eritropoyetina','Inyectable','10000  UI',100,'F')
insert into Medicamento values ('Hierro','Inyectable','100Mg',100,'F')
insert into Medicamento values ('Heparina Sodica','Inyectable','5000 UI',100,'F')
insert into Medicamento values ('Losartan','Comprimido','50Mg.',100,'F')
insert into Medicamento values ('Omeprazol','Comprimido','20Mg.',100,'F')
insert into Medicamento values ('Solucion Acida','Solucion','Segun disponibilidad',100,'F')
insert into Medicamento values ('Solucion Basica','Solucion','Segun disponibilidad',100,'F')
insert into Medicamento values ('Solucion Fisiologica','Infusor','0,9%(1000ML)',100,'F')
insert into Medicamento values ('Acido Citrico','Polvo','200Mg.',100,'F')
insert into Medicamento values ('Acido Paracetico','Solucion','5L',100,'F')
insert into Medicamento values ('Aguja para Fistula','par','',100,'F')
insert into Medicamento values ('Cloruro Benzalconio (DG-6)','Solucion','1,2 G/100ML.',100,'F')
insert into Medicamento values ('Equipo de venoclosis con aguja','Pieza','',100,'F')
insert into Medicamento values ('Filtro F6','Pieza','',100,'F')
insert into Medicamento values ('Filtro F7','Pieza','',100,'F')
insert into Medicamento values ('Filtro F8','Pieza','',100,'F')
insert into Medicamento values ('Filtro F10','Pieza','',100,'F')
insert into Medicamento values ('Guantes quirurgicos descartables','Par','',100,'F')
insert into Medicamento values ('Hipoclorito de Sodio','Solucion','0,8%/250 ML.',100,'F')
insert into Medicamento values ('Jeringas descartables','Pieza','20ML.',100,'F')
insert into Medicamento values ('Lineas Arterio Venosas','Pieza','',100,'F')
insert into Medicamento values ('Transductores','Pieza','.',100,'F')
insert into Medicamento values ('Yodopovidona','Tubo','10 G.',100,'F')


----------cateter-----------------------
insert into Medicamento values ('Acido Folico','Comprimido','5Mg.',100,'C')
insert into Medicamento values ('Acido Acetilsalicilico','Comprimido','100Mg.',100,'C')
insert into Medicamento values ('Atorvastatina','Comprimido','10Mg.',100,'C')
insert into Medicamento values ('Nifedipino','Comprimido','20Mg.',100,'C')
insert into Medicamento values ('Calcio(carbonato o citrato)','Comprimido','500Mg.',100,'C')
insert into Medicamento values ('Colecalciferol (vitamina D3)','Comprimido','0,25Mg.',100,'C')
insert into Medicamento values ('Complejo B (B1-B6-B12)','Comprimido','Estandar',100,'C')
insert into Medicamento values ('Complejo B(B1-B6-B12)','Inyectable','Estandar',100,'C')
insert into Medicamento values ('Carvedilol','Comprimido','12,5Mg.',100,'C')
insert into Medicamento values ('Eritropoyetina','Inyectable','4000 UI',100,'C')
insert into Medicamento values ('Eritropoyetina','Inyectable','10000  UI',100,'C')
insert into Medicamento values ('Hierro','Inyectable','100Mg',100,'C')
insert into Medicamento values ('Heparina Sodica','Inyectable','5000 UI',100,'C')
insert into Medicamento values ('Losartan','Comprimido','50Mg.',100,'C')
insert into Medicamento values ('Omeprazol','Comprimido','20Mg.',100,'C')
insert into Medicamento values ('Solucion Acida','Solucion','Segun disponibilidad',100,'C')
insert into Medicamento values ('Solucion Basica','Solucion','Segun disponibilidad',100,'C')
insert into Medicamento values ('Solucion Fisiologica','Infusor','0,9%(1000ML)',100,'C')
insert into Medicamento values ('Acido Citrico','Polvo','200Mg.',100,'C')
insert into Medicamento values ('Acido Paracetico','Solucion','5L',100,'C')
insert into Medicamento values ('Cloruro Benzalconio (DG-6)','Solucion','1,2 G/100ML.',100,'C')
insert into Medicamento values ('Equipo de venoclosis con aguja','Pieza','',100,'C')
insert into Medicamento values ('Filtro F6','Pieza','',100,'C')
insert into Medicamento values ('Filtro F7','Pieza','',100,'C')
insert into Medicamento values ('Filtro F8','Pieza','',100,'C')
insert into Medicamento values ('Filtro F10','Pieza','',100,'C')
insert into Medicamento values ('Guantes quirurgicos descartables','Par','',100,'C')
insert into Medicamento values ('Hipoclorito de Sodio','Solucion','0,8%/250 ML.',100,'C')
insert into Medicamento values ('Jeringas descartables','Pieza','20ML.',100,'C')
insert into Medicamento values ('Lineas Arterio Venosas','Pieza','',100,'C')
insert into Medicamento values ('Transductores','Pieza','.',100,'C')
insert into Medicamento values ('Yodopovidona','Tubo','10 G.',100,'C')



insert into Medicamento values ('Acido Folico','Comprimido','5Mg.',100,'P')
insert into Medicamento values ('Acido Acetilsalicilico','Comprimido','100Mg.',100,'P')
insert into Medicamento values ('Atorvastatina','Comprimido','10Mg.',100,'P')
insert into Medicamento values ('Nifedipino','Comprimido','20Mg.',100,'P')
insert into Medicamento values ('Calcio(carbonato o citrato)','Comprimido','500Mg.',100,'P')
insert into Medicamento values ('Colecalciferol (vitamina D3)','Comprimido','0,25Mg.',100,'P')
insert into Medicamento values ('Complejo B (B1-B6-B12)','Comprimido','Estandar',100,'P')
insert into Medicamento values ('Complejo B(B1-B6-B12)','Inyectable','Estandar',100,'P')
insert into Medicamento values ('Carvedilol','Comprimido','12,5Mg.',100,'P')
insert into Medicamento values ('Eritropoyetina','Inyectable','4000 UI',100,'P')
insert into Medicamento values ('Eritropoyetina','Inyectable','10000  UI',100,'P')
insert into Medicamento values ('Hierro','Inyectable','100Mg',100,'P')
insert into Medicamento values ('Heparina Sodica','Inyectable','5000 UI',100,'P')
insert into Medicamento values ('Losartan','Comprimido','50Mg.',100,'P')
insert into Medicamento values ('Omeprazol','Comprimido','20Mg.',100,'P')
insert into Medicamento values ('Solucion Acida','Solucion','Segun disponibilidad',100,'P')
insert into Medicamento values ('Solucion Basica','Solucion','Segun disponibilidad',100,'P')
insert into Medicamento values ('Solucion Fisiologica','Infusor','0,9%(1000ML)',100,'P')
insert into Medicamento values ('Acido Citrico','Polvo','200Mg.',100,'P')
insert into Medicamento values ('Acido Paracetico','Solucion','5L',100,'P')
insert into Medicamento values ('Cloruro Benzalconio (DG-6)','Solucion','1,2 G/100ML.',100,'P')
insert into Medicamento values ('Equipo de venoclosis con aguja','Pieza','',100,'P')
insert into Medicamento values ('Filtro F6','Pieza','',100,'P')
insert into Medicamento values ('Filtro F7','Pieza','',100,'P')
insert into Medicamento values ('Filtro F8','Pieza','',100,'P')
insert into Medicamento values ('Filtro F10','Pieza','',100,'P')
insert into Medicamento values ('Guantes quirurgicos descartables','Par','',100,'P')
insert into Medicamento values ('Hipoclorito de Sodio','Solucion','0,8%/250 ML.',100,'P')
insert into Medicamento values ('Jeringas descartables','Pieza','20ML.',100,'P')
insert into Medicamento values ('Lineas Arterio Venosas','Pieza','',100,'P')
insert into Medicamento values ('Transductores','Pieza','.',100,'P')
insert into Medicamento values ('Yodopovidona','Tubo','10 G.',100,'P')




select *from Receta
insert into Receta values('12-04-2021',1,12,92452354,1)

*/



