-----------------------------------------------------------------------------------------------------------
-------------			POBLACIÓN DE TABLAS CON LOS PRODCEDIMIENTOS (PARA TESTEO)		-------------------
-----------------------------------------------------------------------------------------------------------
use Nefroone4
go

--Empleado
select *from Empleado
--No reciben el id como parámetro, modificar y eliminar específicamente trabajan de forma
--idependiente con el ci del empleado
exec insertar_empleado 'Pepe','Vásquez','Muralla',9239544,'07/05/1978',7584329,'Enfermero'
exec modificar_empleado 'Chepeto','Vásquez','Muralla',9239543,'07/05/1978',7584329,'Administrador'
exec eliminar_empleado 9239544
go
--Paciente
select *from Paciente
exec insertar_paciente 92452354,'Joaquin','Charles','Flower','13/08/1998',0,'M','Calle Cosorio'
exec modificar_paciente 92452354,'Pedro','Contra','Barreras','13/08/1998',0,'M','Calle Alemán'
exec eliminar_paciente 0
go
--Hoja Registro
select *from Hoja_Registro
exec insertar_hoja_reg 7249399,false,'Esta es una carta negativa','este es un grado instrucción','local','Montero','Este es un seguro','27/09/2021',92452354,1
exec modificar_hoja_reg 1,7249399,true,'Esta es una carta negativa','este es un grado instrucción','local','Montero','Este es un seguro','27/09/2021',92452354
exec eliminar_hoja_reg 6,92452354

--Hoja Médica
select *from Hoja_Medica
exec insertar_hoja_medica 23,'Fiebre y mucho cansancio',42.5,'esta es una serologia',1.70,23,true,'Cateter','O-RH Negativo','Esta es una solución dializante',1
exec modificar_hoja_medica 1,23,'Tos y fiebre',42.5,'esta es una serologia',1.70,23,true,'Cateter','O-RH Negativo','Esta es una solución dializante',1
exec eliminar_hoja_medica 2,1 --Funciona con el id de la hoja médica
go
--Hoja Control de Enfermería
select *from Control_Enfermeria
exec insertar_control_enfermeria '12/05/2021',1,'14:10','15:20',60.6,58.8,'Esta es una UF programada','Esta es una heparina',670.70,'Presión de 210',26.5,'Este es un pulso','Esta es una saturación',1,1
exec modificar_control_enfermeria 2,'17/05/2021',19,'14:10','15:20',60.6,58.8,'Esta es una UF programada','Esta es una heparina',670.70,'Presión de 210',26.5,'Este es un pulso','Esta es una saturación',3,1
exec eliminar_control_enfermeria 2,3,1
go
--Evolución y Tratamiento
--Esta tabla es tremenda, roba de varios!!
select *from Evolucion_Tratamiento
exec insertar_evolucion_y_tratamiento 4252389,'esta es una ultra filtración','4 horas','Este es un flujo de dialisis','El paciente evoluciona favorablemente','Se le ha recetado al paciente un paracetamol','Tratamiento normal',1,1
exec modificar_evolucion_y_tratamiento 
exec eliminar_evolucion_y_tratamiento 


SELECT *FROM  Medicamento
SELECT * FROM Farmacia
select*from empleado

insert into Farmacia values ('Farmacia NEFROONE',1)

insert into empleado values ('Juan','Perez','Alba',123,'12-04-1998',77890212,'Farmaceutico')

insert into Medicamento values (0,'Gasa','malla','',0,1,1,1,1)
insert into Medicamento values (0,'Alcohol','','',0,1,0,0,1)
insert into Medicamento values (0,'Aguja para Fistula nro 16','Par','',0,1,0,0,1)
insert into Medicamento values (0,'Aguja para Fistula nro 17','Par','',0,1,0,0,1)
insert into Medicamento values (0,'Micropore','','',0,1,1,1,1)
insert into Medicamento values  (0,'Guantes Procedimiento','','',0,1,1,0,1)
insert into Medicamento values  (0,'Jeringa','Pieza','10ML',0,1,1,1,1)
insert into Medicamento values (0,'Jeringa','Pieza','20ML',0,1,0,1,1)
insert into Medicamento values (0,'Heparina Sodica','Inyectable','5000UI',0,1,1,1,1)
insert into Medicamento values (0,'Eritropoyetina','Inyectable','4.000UI',0,1,0,1,1)
insert into Medicamento values (0,'Eritropoyetina','Inyectable','10.000UI',0,1,0,1,1)
insert into Medicamento values (0,'Hierro','Inyectale','100Mg.',0,1,0,1,1)
insert into Medicamento values (0,'Complejo B(B1-B6-B12)','Comprimido','Estandar',0,1,0,0,1)
insert into Medicamento values (0,'Complejo B(B1-B6-B12)','Inyectable','Estandar',0,1,0,1,1)
insert into Medicamento values (0,'Povidona','','',0,1,1,1,1)
insert into Medicamento values (0,'Transductores','Pieza','',0,1,0,1,1)
insert into Medicamento values (0,'Solucion Fisiologica','Infusor','0,9%(1.000ML)',0,1,0,1,1)
insert into Medicamento values (0,'Filtro F7','Pieza','',0,1,0,1,1)
insert into Medicamento values (0,'Filtro F8','Pieza','',0,1,0,1,1)
insert into Medicamento values (0,'Filtro F10','Pieza','',0,1,0,1,1)
insert into Medicamento values (0,'Lineas Artereo Venosas','Pieza','',0,1,0,1,1)
insert into Medicamento values (0,'Acido Paracetico','Solucion','5L',0,1,0,1,1)
insert into Medicamento values (0,'Solucion Acida','Solucion','Segun disponibilidad',0,1,0,1,1)
insert into Medicamento values (0,'Solucion Basica','Solucion','Segun disponibilidad',0,1,0,1,1)
insert into Medicamento values (0,'Equipo de venoclosis con aguja','Pieza','',0,1,0,0,1)
insert into Medicamento values (0,'Equipo de suero','Pieza','',0,1,0,0,1)

--Si la tabla medicamento tiene solo un atributo para definir el tipo de acceso
--insert into Medicamento values (0,'Cloruro Benzalconio (DG-6)','Solucion','1,2G/100ML',0,'F',1)
--insert into Medicamento values (0,'Hipoclorito de Sodio','Solucion','0,8%/250ML.',0,'F',1)
--insert into Medicamento values (0,'Nifedipino','Comprimido','10 Mg.',0,'F',1)
--insert into Medicamento values (0,'Calcio(Carbonato o citrato)','Comprimido','500 Mg',0,'F',1)
--insert into Medicamento values (0,'Lozartan','Comprimido','50 Mg',0,'F',1)


select *from Receta
insert into Receta values('12-04-2021',1,12,92452354,1)





