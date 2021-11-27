--Creación de la base de datos
--create database Nefroone16
--use Nefroone16

--Eliminar un Procedimiento
--drop proc insertar_paciente

--Para borrar un trigger completamente de la base de datos
--drop trigger Habitacion_Libre

--PARA DESHABILITAR Y HABILITAR UN TRIGGER
--disable trigger Habitacion_Libre on detalle_habitacion
--enable trigger Habitacion_Libre on detalle_habitacion

--Eliminación de la base de datos
--drop database Nefroone16

--Consulta para ver todas las tablas en una base de datos
--SELECT CAST(table_name as varchar)  FROM INFORMATION_SCHEMA.TABLES

------------------------ Tablas ------------------------ 
create table Paciente(
ci int primary key not null,
nombre varchar(50) not null,
paterno varchar(50) not null,
materno varchar(50) not null,
fecha_Nac date not null,
edad int,
sexo varchar(20) not null,
direccion varchar(200)
)

create table Empleado(
id_empleado int primary key identity(1,1) not null,
nombre varchar(50) not null,
paterno varchar(20) not null,
materno varchar(20) not null,
ci int not null,
fecha_Nac date not null,
nro_Celular int,
tipo varchar(40) not null,
usuario varchar(30) not null,
passwd varchar(30) not null
)

create table Hoja_Secretaria(
id_hojaS int primary key identity(1,1) not null,
nro_familiar_Contacto int,
formulario_Referencia bit,
carta_Negativa bit,
grado_Intruccion varchar(200),
red varchar(50),
municipio varchar(50),
seguro varchar(50),
fecha_PHemodialisis date,
acceso_Vascular varchar(50),
CI int not null,
id_empleado int not null,
foreign key (CI) references Paciente (CI),
foreign key (id_empleado) references Empleado(id_empleado)
)

create table Nota_Enfermeria(
id_nota int primary key identity(1,1) not null,
descripcion varchar(200)
)

create table Sesion(
id_sesion int primary key identity(1,1) not null,
fecha_Sesion date,
peso_Inicial float,
peso_Final float,
id_empleado int not null,
id_nota int not null,
id_hojaS int not null,
foreign key (id_hojaS) references Hoja_Secretaria(id_hojaS),
foreign key(id_empleado) references Empleado(id_empleado),
foreign key (id_nota) references Nota_Enfermeria(id_nota)
)

create table Control_Enfermeria(
id_HojaE int primary key identity(1,1) not null,
nro_Sesion_HD int,
hora_Inicio time,
hora_Salida time,
U_F_Programada varchar(50),
heparina varchar(50),
flujo_Efectivo varchar(50),
presion_Arterial varchar(50),
temperatura float,
pulso varchar(50),
saturacion varchar(50),
id_sesion int not null,
foreign key (id_sesion) references Sesion(id_sesion)
)

create table Dialisis_Peritoneal(
id_hojaDP int primary key identity(1,1) not null,
nro_Dialisis int,
infucion_Inicio time,
infucion_Final time,
infucion_Volumen varchar(50),
drenaje_Inicio date,
drenaje_Volumen varchar (50),
balance_Parcial varchar(50),
balance_Total varchar(50), 
solucion_Usada1 varchar(50),
solucion_Usada2 varchar(50),
observacion_Balance varchar(100),
total_Dialisis int,
variedad_De_Peso varchar(50),
id_sesion int not null,
foreign key(id_sesion) references Sesion(id_sesion),
)

create table Evolucion_Tratamiento(
id_hojaEvolT int primary key identity(1,1) not null,
duracion varchar(20),
flujo_Dialisis varchar(50),
evolucion_Clinica varchar(300),
nro_Uso_Filtro int,
diagnostico varchar(50),
peso_Seco float,
serologia varchar(50),
talla float,
imc float,
vih bit,
grupo_Sanguineo varchar(50),
solucion_Dializante varchar(50),
id_sesion int,
id_empleado int not null,
foreign key(id_empleado) references Empleado(id_empleado),
foreign key(id_sesion) references Sesion(id_sesion)
)

create table Medicamento(
id_medicamento int primary key identity(1,1) not null,
nombre_Medicamento varchar(100) not null,
presentacion varchar(100),
concentracion varchar(100),
stock int,
tipo_Acceso char(1),
)

create table Receta(
id_receta int primary key identity(1,1) not null,
fecha date,
ci int not null,
id_empleado int not null,
id_hojaEvolT int,
foreign key(ci) references Paciente(ci),
foreign key(id_empleado) references Empleado(id_empleado),
foreign key (id_hojaEvolT) references Evolucion_Tratamiento(id_hojaEvolT)
)

create table Detalle_Receta(
id_medicamento int,
id_receta int,
cant_Recetada int,
primary key(id_medicamento,id_receta),
foreign key(id_medicamento) references Medicamento(id_medicamento),
foreign key (id_receta) references Receta(id_receta)
)

-------------				Procedimientos Almacenados					-----------------
------------						PACIENTE
go
--PROCEDIMIENTO INSERTAR PACIENTE
create proc insertar_paciente(
@ci int,
@nombre varchar(50),
@paterno varchar(50),
@materno varchar(50),
@fecha_Nac date,
@edad int,
@sexo varchar(20),
@direccion varchar(200)
)as
begin
	begin try
		begin tran
		--Para verificar si el paciente ingresado existe ya en la base de datos
		if( (select count(ci) from Paciente where @ci=ci) =0)
		begin
			insert into Paciente values(@ci,@nombre,@paterno,@materno,@fecha_Nac,@edad,@sexo,@direccion)
			commit tran
		end
		else
		begin
			print 'El paciente ya existe en los registros'
			rollback tran return
		end
	end try
	begin catch
		raiserror('Error insertando paciente',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO MODIFICAR PACIENTE
create proc modificar_paciente(
@ci int,
@nombre varchar(50),
@paterno varchar(50),
@materno varchar(50),
@fecha_Nac date,
@edad int,
@sexo varchar(20),
@direccion varchar(200)
)as
begin
	begin try
		begin tran
			update Paciente
			set ci=@ci,
				nombre=@nombre,
				paterno=@paterno,
				materno=@materno,
				fecha_Nac=@fecha_Nac,
				edad=@edad,
				sexo=@sexo,
				direccion=@direccion
			where ci=@ci
		commit tran
	end try
	begin catch
		raiserror('Error modificando paciente',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO ELIMINAR PACIENTE
create proc eliminar_paciente(
@ci int
)as
begin
	begin try
		begin tran
			delete Paciente
			where ci=@ci
		commit tran
	end try
	begin catch
		raiserror('Error eliminando paciente',16,1) 
		rollback tran
	end catch	
end

------------						EMPLEADO
go
--PROCEDIMIENTO INSERTAR EMPLEADO
create proc insertar_empleado(
@nombre varchar(50),
@paterno varchar(50),
@materno varchar(50),
@ci int,
@fecha_Nac date,
@nro_Celular int,
@tipo varchar(40),
@usuario varchar(40),
@passwd varchar(40)
)as
begin
	begin try
		begin tran
		if ((select count(ci) from Empleado where ci=@ci)=0)
			begin
			if ((select count(id_empleado) from Empleado where usuario=@usuario)=0)
				begin
					insert into Empleado values(@nombre,@paterno,@materno,@ci,@fecha_Nac,@nro_Celular,@tipo,@usuario,@passwd)
					commit tran				
				end
			else
				begin
					print 'El nombre de usuario ingresado ya existe en los registros'
					rollback tran return
				end
			end
		else
			begin
				print 'El CI del empleado ya existe en los registros'
				rollback tran return
			end
	end try
	begin catch
		raiserror('Error insertando empleado',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO MODIFICAR EMPLEADO
create proc modificar_empleado(
@nombre varchar(50),
@paterno varchar(50),
@materno varchar(50),
@ci int,
@fecha_Nac date,
@nro_Celular int,
@tipo varchar(40),
@usuario varchar(40),
@passwd varchar(40)
)as
begin
	--Esta variable va a guardar el id del empleado a modificar
	declare @id_emp int
	begin try
		begin tran

		--Encontrando el id del empleado a modificar
		set @id_emp=(select id_empleado from Empleado where ci=@ci)
		
		--Verificando que el id existe en los registros
		if exists(select *from Empleado where @id_emp=id_empleado)
		begin
			update Empleado
			set nombre=@nombre,
				paterno=@paterno,
				materno=@materno,
				ci=@ci,
				fecha_Nac=@fecha_Nac,
				nro_Celular=@nro_Celular,
				tipo=@tipo,
				usuario=@usuario,
				passwd=@passwd
			where id_empleado=@id_emp and ci=@ci
			commit tran
		end
		else
			begin
				print 'El empleado ingresado no existe en los registros'
				rollback tran return
			end
	end try
	begin catch
		raiserror('Error modificando empleado',16,1) 
		rollback tran
	end catch	
end

go
--PROCEDIMIENTO ELIMINAR EMPLEADO
create proc eliminar_empleado(
@ci int
)as
begin
	begin try
		begin tran
			delete Empleado
			where ci=@ci
		commit tran
	end try
	begin catch
		raiserror('Error eliminando empleado',16,1) 
		rollback tran
	end catch	
end

------------						HOJA SECRETARIA
go
--PROCEDIMIENTO INSERTAR HOJA SECRETARIA
create proc insertar_hoja_sec(
@nro_familiar_Contacto int,
@formulario_Referencia bit,
@carta_Negativa bit,
@grado_Intruccion varchar(50),
@red varchar(50),
@municipio varchar(50),
@seguro varchar(50),
@fecha_PHemodialisis date,
@acceso_Vascular varchar(50),
@CI int,
@id_empleado int
)as
begin
	begin try
		begin tran
		if exists(select ci from Hoja_Secretaria where CI=@CI)
		begin
			print 'Ya existe una hoja registro del CI de este paciente'
			rollback tran return			
		end
		else
		begin			
			insert into Hoja_Secretaria values(@nro_familiar_Contacto,@formulario_Referencia,@carta_Negativa,@grado_Intruccion,@red,@municipio,@seguro,@fecha_PHemodialisis,@acceso_vascular,@CI,@id_empleado)
			commit tran
		end
	end try
	begin catch
		raiserror('Error insertando hoja registro',16,1) 
		rollback tran
	end catch
end
go
--PROCEDIMIENTO MODIFICAR HOJA SECRETARIA
create proc modificar_hoja_sec(
@id_hojaS int,
@nro_familiar_Contacto int,
@formulario_Referencia bit,
@carta_Negativa bit,
@grado_Intruccion varchar(50),
@red varchar(50),
@municipio varchar(50),
@seguro varchar(50),
@fecha_PHemodialisis date,
@acceso_Vascular varchar(50),
@CI int,
@id_empleado int
)as
begin
	begin try
		begin tran
			update Hoja_Secretaria
			set nro_familiar_Contacto=@nro_familiar_Contacto,
				formulario_Referencia=@formulario_Referencia,
				carta_Negativa=@carta_Negativa,
				grado_Intruccion=@grado_Intruccion,
				red=@red,
				municipio=@municipio,
				seguro=@seguro,
				fecha_PHemodialisis=@fecha_PHemodialisis,
				acceso_Vascular=@acceso_Vascular,
				CI=@CI,
				id_empleado=@id_empleado
			where id_hojaS=@id_hojaS and CI=@CI and id_empleado=@id_empleado
			commit tran
	end try
	begin catch
		raiserror('Error modificando hoja de registro',16,1) 
		rollback tran
	end catch
end

go
--PROCEDIMIENTO ELIMINAR HOJA SECRETARIA
create proc eliminar_hoja_sec(
@nro_reg int,
@CI int,
@id_empleado int
)as
begin
	begin try
		begin tran
			delete Hoja_Secretaria
			where id_hojaS=@nro_reg and CI=@CI and id_empleado=@id_empleado
			commit tran
	end try
	begin catch
		raiserror('Error eliminando hoja de registro',16,1) 
		rollback tran
	end catch
end

------------						MEDICAMENTO
go
--PROCEDIMIENTO INSERTAR MEDICAMENTO
/*create proc insertar_medicamento(
@nombre_Medicamento varchar(100),
@presentacion varchar(100),
@concentracion varchar(100),
@stock int,
@tipo_diagnostico  char(1),
@id_farmacia int
)as
begin
	begin try
		begin tran 
			insert into Medicamento values(@nombre_Medicamento,@presentacion,@concentracion,@stock,@tipo_diagnostico,@id_farmacia)
			commit tran
	end try
	begin catch
		raiserror('Error eliminando hoja de registro',16,1) 
		rollback tran
	end catch
end
*/
go
--PROCEDIMIENTO MODIFICAR MEDICAMENTO

go
--PROCEDIMIENTO ELIMINAR MEDICAMENTO


/* FALTA CORREGIR PROCEDIMIENTOS, POR ESO LOS COMENTO

------------						RECETA
go
--PROCEDIMIENTO INSERTAR RECETA
create proc insertar_receta(
@fecha date,
@cantidad_Recetada int,
@id_medicamento int,
@ci int,
@id_empleado int
)as
begin tran 
insert into Receta values(@fecha,@cantidad_Recetada,@id_medicamento,@ci,@id_empleado)
commit tran 			
go
--PROCEDIMIENTO MODIFICAR RECETA

go
--PROCEDIMIENTO ELIMINAR RECETA



*/


------------					NOTA ENFERMERIA
go
--PROCEDIMIENTO INSERTAR NOTA ENFERMERIA
create proc insertar_nota_enf(
@descripcion varchar(200)
)as
begin
	begin try
		begin tran
			insert into Nota_Enfermeria values(@descripcion)
			commit tran
	end try
	begin catch		
		raiserror('Error insertando Nota de Enfermería',16,1) 
		rollback tran
	end catch
end

------------						SESION
go
--PROCEDIMIENTO INSERTAR SESION
create proc insertar_sesion(
@fecha_Sesion date,
@peso_Inicial float,
@peso_Final float,
@id_empleado int,
@id_nota int,
@id_hojaS int
)as
begin
	begin try
		begin tran
			insert into Sesion values(@fecha_Sesion,@peso_Inicial,@peso_Final,@id_empleado,@id_nota,@id_hojaS)
			commit tran
	end try
	begin catch		
		raiserror('Error al insertar el registro de la sesión',16,1) 
		rollback tran
	end catch
end
go
--PROCEDIMIENTO MODIFICAR SESION

go
--PROCEDIMIENTO ELIMINAR SESION

------------						CONTROL ENFERMERIA (Hoja enfermería)
go
--PROCEDIMIENTO INSERTAR CONTROL ENFERMERIA
create proc insertar_control_enfermeria(
@nro_Sesion_HD int,
@hora_Inicio time,
@hora_Salida time,
@U_F_Programada varchar(50),
@heparina varchar(50),
@flujo_Efectivo varchar(50),
@presion_Arterial varchar(50),
@temperatura float,
@pulso varchar(50),
@saturacion varchar(50),
@id_sesion int
)as
begin
	begin try
		begin tran
			--insert into Control_Enfermeria values(@nro_Sesion_HD,@hora_Inicio,@hora_Salida,@U_F_Programada,@heparina,@flujo_Efectivo,@presion_Arterial,@temperatura,@pulso,@saturacion,@id_sesion)
			insert into Control_Enfermeria values(@nro_Sesion_HD,@hora_Inicio,@hora_Salida,@U_F_Programada,@heparina,@flujo_Efectivo,@presion_Arterial,@temperatura,@pulso,@saturacion,@id_sesion)			
			commit tran
	end try
	begin catch
		raiserror('Error insertando hoja de control de enfermería',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO MODIFICAR CONTROL ENFERMERIA
create proc modificar_control_enfermeria(
@id_hojaE int,
@nro_Sesion_HD int,
@hora_Inicio time,
@hora_Salida time,
@U_F_Programada varchar(50),
@heparina varchar(50),
@flujo_Efectivo varchar(50),
@presion_Arterial varchar(50),
@temperatura float,
@pulso varchar(50),
@saturacion varchar(50),
@id_sesion int
)as
begin
	begin try
		begin tran
			update Control_Enfermeria
			set nro_Sesion_HD=@nro_Sesion_HD,
				hora_Inicio=@hora_Inicio,
				hora_Salida=@hora_Salida,
				U_F_Programada=@U_F_Programada,
				heparina=@heparina,
				flujo_Efectivo=@flujo_Efectivo,
				presion_Arterial=@presion_Arterial,
				temperatura=@temperatura,
				pulso=@pulso,
				saturacion=@saturacion,
				id_sesion=@id_sesion
			where id_sesion=@id_sesion and id_HojaE=@id_hojaE
		commit tran
	end try
	begin catch
		raiserror('Error modificando hoja de control de enfermería',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO ELIMINAR CONTROL ENFERMERIA
create proc eliminar_control_enfermeria(
@id_hojaE int
)as
begin
	begin try
		begin tran
			delete Control_Enfermeria
			where id_hojaE=@id_hojaE
		commit tran
	end try
	begin catch
		raiserror('Error eliminando registro de la hoja de control de enfermería',16,1) 
		rollback tran
	end catch	
end

------------						EVOLUCION TRATAMIENTO
go
--PROCEDIMIENTO INSERTAR EVOLUCION TRATAMIENTO
create proc insertar_evolucion_y_tratamiento(
@duracion varchar(20),
@flujo_Dialisis varchar(50),
@evolucion_Clinica varchar(300),
@nro_Uso_Filtro int,
@diagnostico varchar(50),
@peso_Seco float,
@serologia varchar(50),
@talla float,
@imc float,
@vih bit,
@grupo_Sanguineo varchar(50),
@solucion_Dializante varchar(50),
@id_sesion int,
@id_empleado int
)as
begin
	begin try
		begin tran
			insert into Evolucion_Tratamiento values(@duracion,@flujo_Dialisis,@evolucion_Clinica,@nro_Uso_Filtro,@diagnostico,@peso_Seco,@serologia,@talla,@imc,@vih,@grupo_Sanguineo,@solucion_Dializante,@id_sesion,@id_empleado)
		commit tran
	end try
	begin catch
		raiserror('Error insertando hoja de evolución y tratamiento',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO MODIFICAR EVOLUCION TRATAMIENTO
create proc modificar_evolucion_y_tratamiento(
@id_hojaEvolT int,
@duracion varchar(20),
@flujo_Dialisis varchar(50),
@evolucion_Clinica varchar(300),
@nro_Uso_Filtro int,
@diagnostico varchar(50),
@peso_Seco float,
@serologia varchar(50),
@talla float,
@imc float,
@vih bit,
@grupo_Sanguineo varchar(50),
@solucion_Dializante varchar(50),
@id_sesion int,
@id_empleado int
)as
begin
	begin try
		begin tran
			update Evolucion_Tratamiento
			set duracion=@duracion,
				flujo_Dialisis=@flujo_Dialisis,
				evolucion_Clinica=@evolucion_Clinica,
				nro_Uso_Filtro=@nro_Uso_Filtro,
				diagnostico=@diagnostico,
				peso_Seco=@peso_Seco,
				serologia=@serologia,
				talla=@talla,
				imc=@imc,
				vih=@vih,
				grupo_Sanguineo=@grupo_Sanguineo,
				solucion_Dializante=@solucion_Dializante,
				id_sesion=@id_sesion,
				id_empleado=@id_empleado
			where id_hojaEvolT=@id_hojaEvolT and id_empleado=@id_empleado and id_sesion=@id_sesion
		commit tran
	end try
	begin catch
		raiserror('Error modificando hoja de evolución y tratamiento',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO ELIMINAR EVOLUCION TRATAMIENTO
create proc eliminar_evolucion_y_tratamiento(
@id_hojaEvolT int
)as
begin
	begin try
		begin tran
			delete Evolucion_Tratamiento
			where id_hojaEvolT=@id_hojaEvolT
		commit tran
	end try
	begin catch
		raiserror('Error eliminando hoja de evolución y tratamiento',16,1) 
		rollback tran
	end catch	
end

------------						DIALISIS PERITONEAL
go

--PROCEDIMIENTO INSERTAR DIALISIS PERITONEAL
create proc insertar_dialisis_peritoneal(
@nro_Dialisis int,
@infucion_Inicio time,
@infucion_Final time,
@infucion_Volumen varchar(50),
@drenaje_Inicio date,
@drenaje_Volumen varchar (50),
@balance_Parcial varchar(50),
@balance_Total varchar(50),
@solucion_Usada1 varchar(50),
@solucion_Usada2 varchar(50),
@observacion_Balance varchar(100),
@total_Dialisis int,
@variedad_De_Peso varchar(50),
@id_sesion int
)as
begin
	begin try
		begin tran
			insert into Dialisis_Peritoneal values(@nro_Dialisis,@infucion_Inicio,@infucion_Final,@infucion_Volumen,@drenaje_Inicio,@drenaje_Volumen,@balance_Parcial,@balance_Total,@solucion_Usada1,@solucion_Usada2,@observacion_Balance,@total_Dialisis,@variedad_De_Peso,@id_sesion)
		commit tran
	end try
	begin catch
		raiserror('Error insertando registros de diálisis peritoneal',16,1) 
		rollback tran
	end catch	
end
go
/*
--PROCEDIMIENTO MODIFICAR DIALISIS PERITONEAL
create proc modificar_dialisis_peritoneal(
@precio_Sesion_D_Peritoneal money,
@infucion_Inicio time,
@infucion_Final time,
@infucion_Volumen varchar(50),
@drenaje_Inicio date,
@drenaje_Volumen varchar (50),
@balance_Parcial varchar(50),
@balance_Total varchar(50), 
@solucion_Usada1 varchar(50),
@solucion_Usada2 varchar(50),
@observacion_Balance varchar(100),
@id_hojaE int,
@id_sesion int
)as
begin
	begin try
		begin tran
			update Dialisis_Peritoneal 
			set precio_Sesion_D_Peritoneal=@precio_Sesion_D_Peritoneal,
				infucion_Inicio=@infucion_Inicio,
				infucion_Final=@infucion_Final,
				infucion_Volumen=@infucion_Volumen,
				drenaje_Inicio=@drenaje_Inicio,
				drenaje_Volumen=@drenaje_Volumen,
				balance_Parcial=@balance_Parcial,
				balance_Total=@balance_Total,
				solucion_Usada1=@solucion_Usada1,
				solucion_Usada2=@solucion_Usada2,
				observacion_Balance=@observacion_Balance
			where @id_hojaE=id_hojaE and @id_sesion=id_sesion
		commit tran
	end try
	begin catch
		raiserror('Error modificando registros de diálisis peritoneal',16,1) 
		rollback tran
	end catch	
end
go
--PROCEDIMIENTO ELIMINAR DIALISIS PERITONEAL
create proc eliminar_dialisis_peritoneal(
@id_hojaE int,
@id_sesion int
)as
begin
	begin try
		begin tran
			delete Dialisis_Peritoneal 
			where @id_hojaE=id_hojaE and @id_sesion=id_sesion
		commit tran
	end try
	begin catch
		raiserror('Error eliminando registros de diálisis peritoneal',16,1) 
		rollback tran
	end catch	
end
go
---listar medicamentos para médico
create proc ListarMedic
as
select nombre_Medicamento,presentacion,concentracion,cantidad_Recetada
from Medicamento,Receta
where Medicamento.id_medicamento=Receta.id_medicamento
go
create proc ListarMedicP
as
select nombre_Medicamento,presentacion,concentracion
from Medicamento
where  diagnosticoP=1
go
create proc ListarMedicF
as
select nombre_Medicamento,presentacion,concentracion
from Medicamento
where  diagnosticoF=1
go
create proc ListarMedicC
as
select nombre_Medicamento,presentacion,concentracion
from Medicamento
where  diagnosticoC=1
go
---listar medicamentos
create proc ListarMedicamentos
as
select id_medicamento,nombre_Medicamento,presentacion,concentracion,stock
from Medicamento
*/

go
--Procedimiento que valida la existencia de un usuario y contraseña en los registros
create proc sp_login(
@user varchar(30),
@passwd varchar(30)
)as
begin
	begin try
		begin tran
			select id_empleado
			from Empleado
			where usuario=@user and passwd=@passwd
		commit tran
	end try
	begin catch		
		raiserror('Error en el usuario o la contraseña',16,1) 
		rollback tran
	end catch
end
/* AUN FALTA TERMINAR
-----------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------		REPORTES		-------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------------
--MOSTRAR REPORTE DE "DATOS DEL PACIENTE"
--Procedimiento Datos del Paciente
go
create proc mostrar_datos_del_paciente(
@ci int
)as
begin
	begin try
		begin tran									
			select ci,nombre,paterno,materno,fecha_Nac,edad,sexo,diagnostico,peso_Seco,talla,imc,serologia,vih,grado_Intruccion,direccion,seguro,acceso_Vascular,grupo_Sanguineo,solucion_Dializante,fecha_PHemodialisis
			from Paciente,Hoja_Medica,Hoja_Secretaria
			where Paciente.ci=@ci
			--Falta igualar más ID's
			select *from Paciente
	end try
	begin catch		
		raiserror('Error en ',16,1) 
		rollback tran
	end catch
end
go

--Procedimiento Control de Enfermería
create proc mostrar_control_enfermeria(
@ci int
)as
begin
	begin try
		begin tran									
			select ci,nombre,paterno,materno,fecha_Nac,edad,sexo,diagnostico,peso_Seco,talla,imc,serologia,vih,grado_Intruccion,direccion,seguro,acceso_Vascular,grupo_Sanguineo,solucion_Dializante,fecha_PHemodialisis
			from Paciente,Hoja_Medica,Hoja_Secretaria
			where ci=@ci
	end try
	begin catch		
		raiserror('Error en ',16,1) 
		rollback tran
	end catch
end
go
--Procedimiento Evolución y Tratamiento
create proc mostrar_evol_y_tratam(
@ci int
)as
begin
	begin try
		begin tran									
			select ci,nombre,paterno,materno,fecha_Nac,edad,sexo,diagnostico,peso_Seco,talla,imc,serologia,vih,grado_Intruccion,direccion,seguro,acceso_Vascular,grupo_Sanguineo,solucion_Dializante,fecha_PHemodialisis
			from Paciente,Hoja_Medica,Hoja_Secretaria
			where ci=@ci
			select *from Hoja_Secretaria
	end try
	begin catch		
		raiserror('Error en ',16,1) 
		rollback tran
	end catch
end


-- PROCEDIMIENTO MOSTRAR REPORTE DE "RECIBO RECETARIO"
create proc name_proc(

)as
begin
	begin try
		begin tran
			
	end try
	begin catch		
		raiserror('Error en ',16,1) 
		rollback tran
	end catch
end

-- PROCEDIMIENTO MOSTRAR REPORTE DE "CONSOLIDADO MENSUAL" DE SESIONES
create proc name_proc(

)as
begin
	begin try
		begin tran
			
	end try
	begin catch		
		raiserror('Error en ',16,1) 
		rollback tran
	end catch
end

*/

--Consulta para mostrar el Tipo de Usuario que está iniciando sesión
go
create proc encontrar_tipo_usuario(
@user varchar(40),
@passwd varchar(40)
)as
begin
	begin try
		begin tran
			select tipo from Empleado where usuario=@user and passwd=@passwd
		commit tran
	end try
	begin catch		
		raiserror('Error encontrando el usuario en la base de datos',16,1) 
		rollback tran
	end catch
end
go
--Devuelve el ID de un empleado con el user y contraseña de parámetros
create proc encontrar_ID_empleado(
@user varchar(40),
@passwd varchar(40)
)as
begin
	begin try
		begin tran
			select id_empleado from Empleado where usuario=@user and passwd=@passwd
		commit tran
	end try
	begin catch		
		raiserror('Error encontrando el usuario en la base de datos',16,1) 
		rollback tran
	end catch
end

-------------						TRIGGERS							-----------------
go
--Colocar la edad respectiva del paciente en el registro insertado de sus datos de forma automática
create trigger calcular_edad
on Paciente
for Insert
as
begin
	update Paciente
	set edad=(select DATEDIFF(YEAR,fecha_Nac,GetDate()) from Paciente where ci=(select ci from inserted))
	where ci=(select ci from inserted)
end
go
--Permite la inserción de un registro de diálisis peritoneal si es que corresponde con el tipo de acceso de Hoja Secretaria
create trigger verificar_dialisis_p
on Dialisis_Peritoneal
for INSERT
as
begin
	declare @tipo_acces  varchar(20)
	select @tipo_acces = (select acceso_Vascular from Sesion, Hoja_Secretaria,inserted where Hoja_Secretaria.id_hojaS =Sesion.id_hojaS and Sesion.id_sesion = inserted.id_sesion)
	if(@tipo_acces)='Dialisis Peritoneal'
		begin
			print 'formulario creado'
		end
	else
		begin
			print 'El registro no corresponde a la tabla "Dialisis Peritoneal" por el tipo de acceso'
			raiserror('no pertenece a este formulario',16,1) 	
			ROLLBACK TRANSACTION
		end
end
go
--Permite la inserción de un registro de control de enfermería si es que corresponde con el tipo de acceso de Hoja Secretaria
create trigger verificar_ctrl_enf
on Control_Enfermeria
for INSERT
as
begin
	declare @tipo_acces varchar(20)
	select @tipo_acces = (select acceso_Vascular from Sesion, Hoja_Secretaria,inserted where Hoja_Secretaria.id_hojaS =Sesion.id_hojaS and Sesion.id_sesion = inserted.id_sesion)
	if(@tipo_acces='Cateter' or @tipo_acces='Fistula')
		begin
			print 'formulario creado'
		end
	else
		begin
			print 'El registro no corresponde a la tabla "Control Enfermería" por el tipo de acceso'
			raiserror('no pertenece a este formulario',16,1) 
			ROLLBACK TRANSACTION
		end
end
go
--Trigger para actualizar Número de Sesión de Hemodiálisis de Control de Enfermería
--de forma incremental y automática
create trigger incrementar_Nro_Sesion_HD
on Control_Enfermeria
for Insert
as
begin
	--Variable que guarda la cantidad de sesiones ya registradas en la tabla Sesion
	--con una misma Hoja_Secretaria
	declare @cant int
	declare @id_sesion int
	declare @id_hojaS int

	select @id_sesion = (select id_sesion from inserted)
	select @id_hojaS = (select id_hojaS from Sesion where id_sesion = @id_sesion)
	select @cant = (select count(id_sesion) from Sesion where id_hojaS = @id_hojaS)

	/* Solo para mostrar los datos en pantalla (TESTING)
	print @id_sesion 
	print @id_hojaS 
	print @cant
	*/

	if(@cant <= 1)
		begin
			--Incrementa el número de sesión HD al último registro que se está insertando
			update Control_Enfermeria
			set nro_Sesion_HD = 1
			where id_sesion = (select id_sesion from inserted)
		end
	else
		begin
			--Incrementa el número de sesión HD al último registro que se está insertando
			update Control_Enfermeria
			set nro_Sesion_HD = @cant
			where id_sesion = (select id_sesion from inserted)
		end	
end