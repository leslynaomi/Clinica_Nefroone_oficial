-----------------------------------------------------------------------------------------------------------
-------------			POBLACIÓN DE TABLAS CON LOS PRODCEDIMIENTOS (PARA TESTEO)		-------------------
-----------------------------------------------------------------------------------------------------------
use Nefroone3
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
exec insertar_hoja_reg 7249399,false,'Esta es una carta negativa','este es un grado instrucción','local','Montero','Este es un seguro','27/09/2021',92452354
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


--Poblando Farmacia
insert into Farmacia values ('Farmacia NEFROONE',1)
SELECT *FROM  Medicamento
SELECT * FROM Farmacia
select*from empleado

insert into empleado values ('Juan','Perez','Alba',123,'12-04-1998',77890212,'Farmaceutico')
insert into Medicamento values ('Gasa','malla','',100,1,1,1,1)
insert into Medicamento values ('Alcohol','','',90,1,0,0,1)
insert into Medicamento values ('Aguja para Fistula nro 16','Par','',150,1,0,0,1)
insert into Medicamento values ('Aguja para Fistula nro 17','Par','',100,1,0,0,1)
insert into Medicamento values ('Micropore','','',90,1,1,1,1)
insert into Medicamento values  ('Guantes Procedimiento','','',110,1,1,0,1)
insert into Medicamento values  ('Jeringa','Pieza','10ML',90,1,1,1,1)
insert into Medicamento values ('Jeringa','Pieza','20ML',80,1,0,1,1)
insert into Medicamento values ('Heparina Sodica','Inyectable','5000UI',90,1,1,1,1)
insert into Medicamento values ('Eritropoyetina','Inyectable','4.000UI',90,1,0,1,1)
insert into Medicamento values ('Eritropoyetina','Inyectable','10.000UI',110,1,0,1,1)
insert into Medicamento values ('Hierro','Inyectale','100Mg.',120,1,0,1,1)
insert into Medicamento values ('Complejo B(B1-B6-B12)','Comprimido','Estandar',120,1,0,0,1)
insert into Medicamento values ('Complejo B(B1-B6-B12)','Inyectable','Estandar',110,1,0,1,1)
insert into Medicamento values ('Povidona','','',90,1,1,1,1)
insert into Medicamento values ('Transductores','Pieza','',70,1,0,1,1)
insert into Medicamento values ('Solucion Fisiologica','Infusor','0,9%(1.000ML)',120,1,0,1,1)
insert into Medicamento values ('Filtro F7','Pieza','',100,1,0,1,1)
insert into Medicamento values ('Filtro F8','Pieza','',120,1,0,1,1)
insert into Medicamento values ('Filtro F10','Pieza','',140,1,0,1,1)
insert into Medicamento values ('Lineas Artereo Venosas','Pieza','',110,1,0,1,1)
insert into Medicamento values ('Acido Paracetico','Solucion','5L',90,1,0,1,1)
insert into Medicamento values ('Solucion Acida','Solucion','Segun disponibilidad',90,1,0,1,1)
insert into Medicamento values ('Solucion Basica','Solucion','Segun disponibilidad',60,1,0,1,1)
insert into Medicamento values ('Equipo de venoclosis con aguja','Pieza','',90,1,0,0,1)
insert into Medicamento values ('Equipo de suero','Pieza','',90,1,0,0,1)

--Sala
exec

--Sesión
