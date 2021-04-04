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
