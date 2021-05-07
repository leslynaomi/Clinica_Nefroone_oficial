-----------------------------------------------------------------------------------------------------------
-------------			POBLACIÓN DE TABLAS CON LOS PRODCEDIMIENTOS (PARA TESTEO)		-------------------
-----------------------------------------------------------------------------------------------------------
--use Nefroone15
go

--Empleado
--select *from Empleado
--No reciben el id como parámetro, modificar y eliminar específicamente trabajan de forma
--idependiente con el ci del empleado
exec insertar_empleado 'Pepe','Vásquez','Muralla',9239544,'07/05/1978',7584329,'Secretario','pol','123'
--exec modificar_empleado 'Chepeto','Vásquez','Muralla',9239543,'07/05/1978',7584329,'Administrador'
--exec eliminar_empleado 9239544
go
--Paciente
--select *from Paciente
exec insertar_paciente 92452354,'Joaquin','Charles','Flower','13/08/1998',0,'M','Calle Cosorio'
exec insertar_paciente 93467764,'Oliver','Atom','','14/03/1998',0,'M','Calle Ambaibo'
--exec modificar_paciente 92452354,'Pedro','Contra','Barreras','13/08/1998',0,'M','Calle Alemán'
--exec eliminar_paciente 0
go
--Hoja Secretaria
--select *from Hoja_Secretaria
exec insertar_hoja_sec 7249399,1,1,'Profesional','Salud','Montero','SUS','12/03/2020','Cateter',92452354,1
exec insertar_hoja_sec 7545699,0,0,'Profesional','Salud','Montero','SUS','12/03/2020','Dialisis Peritoneal',93467764,1
--exec modificar_hoja_sec 1,7249399,true,'Esta es una carta negativa','este es un grado instrucción','local','Montero','Este es un seguro','27/09/2021',92452354
--exec eliminar_hoja_sec 6,92452354
go

--Nota_Enfermeria
--select *from Nota_Enfermeria
exec insertar_nota_enf 'Paciente ingresa al servicio de hemodiálisis con signos vitales normales'

--Sesion
--select *from Sesion
exec insertar_sesion '10/03/2021',60.7,50,1,1,1
exec insertar_sesion '03/04/2021',62,55,1,1,4

--Super consulta para el formulario de Sesion
/*
select id_sesion,fecha_Sesion,pac.ci,nombre,materno,materno,edad,sexo,seguro,acceso_Vascular,seguro,nro_familiar_Contacto
from Sesion as ses,Paciente as pac,Hoja_Secretaria as sec
where sec.ci = pac.ci and sec.id_hojaS = ses.id_hojaS
*/

--Control Enfermeria
--select *from Control_Enfermeria
exec insertar_control_enfermeria 1,'14:10','15:20','3000 ml','5000 ui','250 mlx','140/70/mHg',30,'68x','98%',1

--Dialisis Peritoneal
--select *from Dialisis_Peritoneal
exec insertar_dialisis_peritoneal 1,'7:00','7:15','2000 ml','08:00','2500 ml','-500 ml','-500 ml','Perito I','Perito I','P/A = 181/83 FC = 97x',8,'4 gr',5
--insert into Dialisis_Peritoneal values (1,'7:00','7:15','2000 ml','08:00','2500 ml','-500 ml','-500 ml','Perito I','Perito I','P/A = 181/83 FC = 97x',8,'4 gr',3)

--Evolución y Tratamiento
--select *from Evolucion_Tratamiento
--Inserción
exec insertar_evolucion_y_tratamiento '4 horas','500 mlxl','Paciente en regular estado general',3,'Insuficiencia Renal Crónica',63,'Hepatitis B y C Negativo',1.54,32,0,'ORH (+)','Bicarbonato',1,1
--Super Consulta para mostrar datos en el DataGridView
^/*
select nro_Sesion_HD,pac.nombre,pac.paterno,pac.materno,pac.ci,edad,sexo,seguro,fecha_Sesion,evolucion_Clinica,duracion,flujo_Efectivo,U_F_Programada,flujo_Dialisis,heparina,acceso_Vascular,nro_Uso_Filtro,diagnostico,peso_Seco,serologia,talla,imc,vih,grupo_Sanguineo,solucion_Dializante,emp.nombre as 'Nombre del Médico',emp.paterno as 'Apellido del Médico'
from Evolucion_Tratamiento as evol,Sesion as ses,Control_Enfermeria as enf,Hoja_Secretaria as sec,Empleado as emp,Paciente as pac
where evol.id_sesion=ses.id_sesion and ses.id_sesion=enf.id_sesion and sec.id_hojaS=ses.id_hojaS and emp.id_empleado=ses.id_empleado and pac.ci = sec.ci
*/



/*
insert into Farmacia values ('Farmacia NEFROONE',1)

insert into empleado values ('Juan','Perez','Alba',123,'12-04-1998',77890212,'Farmaceutico')

insert into Medicamento values (0,'Gasa','malla','',0,1,1,1,1)
insert into Medicamento values (0,'Alcohol','','',0,1,0,0,1)
insert into Medicamento values (0,'Aguja para Fistula nro 16','Par','',0,1,0,0,1)
insert into Medicamento values (0,'Aguja para Fistula nro 17','Par','',0,1,0,0,1)
insert into Medicamento values (0,'Micropore','','',0,1,1,1,1)
insert into Medicamento values (0,'Guantes Procedimiento','','',0,1,1,0,1)
insert into Medicamento values (0,'Jeringa','Pieza','10ML',0,1,1,1,1)
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

*/



--Procedimientos para el Login
--exec sp_login 'pol','123'
--exec encontrar_tipo_usuario 'pol','123'
--exec encontrar_ID_empleado 'pol','123'
