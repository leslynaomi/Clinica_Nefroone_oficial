--Creación de la base de datos
--create database Nefroone3
--use Nefroone3

--Para borrar un trigger completamente de la base de datos
--drop trigger Habitacion_Libre

--PARA DESHABILITAR Y HABILITAR UN TRIGGER
--disable trigger Habitacion_Libre on detalle_habitacion
--enable trigger Habitacion_Libre on detalle_habitacion

--Eliminación de la base de datos
--drop database Nefroone

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
paterno varchar(50) not null,
materno varchar(50) not null,
ci int not null,
fecha_Nac date not null,
nro_Celular int,
tipo varchar(40) not null
)

create table Administrador(
id_empleado int primary key not null,
usuario varchar(50),
contraseña varchar(50),
foreign key(id_empleado) references Empleado (id_empleado),
)

create table Secretario(
id_empleado int primary key not null,
velocidad_Typeo varchar(50),
foreign key (id_empleado) references Empleado(id_empleado),
)

create table Farmaceutico(
id_empleado int primary key not null,
tipo_Farmaceutica varchar(70),
foreign key (id_empleado) references Empleado (id_empleado),
)

create table Medico(
id_empleado int primary key not null,
especialidad varchar(100),
foreign key (id_empleado) references Empleado (id_empleado),
)

create table Enfermera (
id_empleado int primary key not null,
cod_Matricula int
foreign key (id_empleado) references Empleado (id_empleado),
)

create table Sala(
id_sala int primary key identity(1,1) not null,
tipo_Sala varchar(50),
cantidad_Camas int not null,
cantidad_Equipos int not null,
capacidad_Maxima int not null,
)

create table Laboratorio(
id_laboratorio int primary key identity(1,1) not null,
lapso_Entrega_Pruebas int,
)

create table Informe_Medico(
id_informe_Medico int identity(1,1) not null,
cant_Pacientes_Dia int,
detalle_Informe varchar(300),
id_empleado int not null,
primary key (id_empleado,id_informe_Medico),
foreign key (id_empleado) references Empleado(id_empleado),
)

create table Hoja_Medica(
id_hojaM int primary key identity(1,1) not null,
nro_Uso_Filtro varchar(20),
diagnostico varchar(50),
peso_Seco float,
serologia varchar(50),
talla float,
imc float,
vih bit,
acceso_Vascular varchar(50),
grupo_Sanguineo varchar(50),
solucion_Dializante varchar(50),
id_empleado int not null,
foreign key (id_empleado) references Empleado(id_empleado)
)

create table Hoja_Registro(
nro_registro int primary key identity(1,1) not null,
nro_familiar_Contacto int,
formulario_Referencia bit,
carta_Negativa varchar(200),
grado_Intruccion varchar(50),
red varchar(50),
municipio varchar(50),
seguro varchar(50),
fecha_PHemodialisis date,
CI int not null,
id_empleado int not null,
foreign key (CI) references Paciente (CI),
foreign key (id_empleado) references Empleado(id_empleado)
)

create table Consulta_Externa(
id_consulta_externa int primary key identity(1,1) not null,
tipo_Consulta varchar(70) not null,
fecha_Consulta date not null,
nro_registro int not null,
id_empleado int not null,
foreign key (nro_registro) references Hoja_Registro(nro_registro),
foreign key (id_empleado) references Empleado(id_empleado)
)

create table Farmacia(
id_farmacia int primary key identity(1,1) not null,
nombre_Farmacia varchar(100),
id_empleado int not null,
foreign key (id_empleado) references Empleado (id_empleado),
)

create table Medicamento(
id_medicamento int primary key identity(1,1) not null,
nombre_Medicamento varchar(100) not null,
stock int,
id_farmacia int not null,
foreign key (id_farmacia) references Farmacia(id_farmacia),
)

create table Receta(
id_receta int identity(1,1) not null,
fecha date,
hemodialisis_Cateter bit,
hemodialisis_Fistula bit,
id_medicamento int not null,
ci int not null,
id_empleado int not null,
primary key(id_medicamento,id_receta),
foreign key(id_medicamento) references Medicamento(id_medicamento),
foreign key(ci) references Paciente(ci),
foreign key(id_empleado) references Empleado(id_empleado)
)

create table Control_Enfermeria(
id_hoja_enfermeria int primary key identity(1,1) not null,
fecha_Sesion date,
nro_Sesion_HD int,
hora_Inicio time,
hora_Salida time,
peso_Inicial float,
peso_Final float,
U_F_Programada varchar(50),
heparina varchar(50),
flujo_Efectivo varchar(20),
presion_Arterial varchar(50),
temperatura float,
pulso varchar(50),
saturacion varchar(50),
nro_registro int not null,
id_empleado int not null,
foreign key(nro_registro) references Hoja_Registro(nro_registro),
foreign key(id_empleado) references Empleado (id_empleado)
)

create table Evolucion_Tratamiento(
id_evolucion_tratamiento int  identity(1,1) not null,
nro_Seguro int,
ultra_Filtracion varchar(50),
duracion varchar(20),
flujo_Dialisis varchar(50),
evolucion_Clinica varchar(300),
detalles_Medicacion varchar(200),
tipo_Tratamiento varchar(30),
id_hoja_enfermeria int not null,
id_empleado int not null,
primary key (id_hoja_enfermeria,id_evolucion_tratamiento),
foreign key(id_hoja_enfermeria) references Control_Enfermeria(id_hoja_enfermeria),
foreign key(id_empleado) references Empleado(id_empleado)
)

create table Prueba_Laboratorio(
id_prueba_laboratorio int identity(1,1) not null,
detalles varchar(200),
tipo_Hepatitis varchar(30),
id_laboratorio int not null,
id_hoja_enfermeria int not null,
id_evolucion_tratamiento int not null,
primary key(id_hoja_enfermeria,id_evolucion_tratamiento,id_prueba_laboratorio),
foreign key(id_hoja_enfermeria,id_evolucion_tratamiento) references Evolucion_Tratamiento(id_hoja_enfermeria,id_evolucion_tratamiento),
foreign key (id_laboratorio) references Laboratorio(id_laboratorio),
)

create table Sesion(
id_sesion int identity(1,1) not null,
tipo_Sesion varchar(50),
cantidad_Sesiones int,
cantidad_Total_Sesiones int,
horario time,
id_hoja_enfermeria int not null,
id_sala int not null,
primary key(id_hoja_enfermeria,id_sesion),
foreign key(id_hoja_enfermeria) references Control_Enfermeria(id_hoja_enfermeria),
foreign key(id_sala) references Sala(id_sala)
)

create table Cateter(
precio_Sesion_Cateter money,
id_sesion int not null,
id_hoja_enfermeria int not null,
primary key(id_hoja_enfermeria,id_sesion),
foreign key(id_hoja_enfermeria,id_sesion) references Sesion(id_hoja_enfermeria,id_sesion),
)

create table Fistula(
precio_Sesion_Fistula money,
id_hoja_enfermeria int not null,
id_sesion int not null,
primary key(id_hoja_enfermeria,id_sesion),
foreign key(id_hoja_enfermeria,id_sesion) references Sesion(id_hoja_enfermeria,id_sesion),
)

create table Dialisis_Peritoneal(
precio_Sesion_D_Peritoneal money,
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
id_hoja_enfermeria int not null,
id_sesion int not null,
primary key(id_hoja_enfermeria,id_sesion),
foreign key(id_hoja_enfermeria,id_sesion) references Sesion(id_hoja_enfermeria,id_sesion)
)


-------------				Procedimientos Almacenados					-----------------
------------						PACIENTE
--Eliminar un Procedimiento
--drop proc insertar_paciente

--Seleccionar base de datos
--use Clinica

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
@tipo varchar(40)
)as
begin
	begin try
		begin tran
		if ((select count(ci) from Empleado where ci=@ci)=0)
			begin
				insert into Empleado values(@nombre,@paterno,@materno,@ci,@fecha_Nac,@nro_Celular,@tipo)
				commit tran				
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
@tipo varchar(40)
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
				tipo=@tipo
			where id_empleado=@id_emp and ci=@ci
			commit tran
		end
		else
			begin
				print 'El id del empleado no existe en los registros'
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

------------						ADMINISTRADOR
go
--PROCEDIMIENTO INSERTAR ADMINISTRADOR

go
--PROCEDIMIENTO MODIFICAR ADMINISTRADOR

go
--PROCEDIMIENTO ELIMINAR ADMINISTRADOR

------------						SECRETARIO
go
--PROCEDIMIENTO INSERTAR SECRETARIO

go
--PROCEDIMIENTO MODIFICAR SECRETARIO

go
--PROCEDIMIENTO ELIMINAR SECRETARIO

------------						FARMACEUTICO
go
--PROCEDIMIENTO INSERTAR FARMACEUTICO

go
--PROCEDIMIENTO MODIFICAR FARMACEUTICO

go
--PROCEDIMIENTO ELIMINAR FARMACEUTICO

------------						MEDICO
go
--PROCEDIMIENTO INSERTAR MEDICO

go
--PROCEDIMIENTO MODIFICAR MEDICO

go
--PROCEDIMIENTO ELIMINAR MEDICO

------------						ENFERMERA
go
--PROCEDIMIENTO INSERTAR ENFERMERA

go
--PROCEDIMIENTO MODIFICAR ENFERMERA

go
--PROCEDIMIENTO ELIMINAR ENFERMERA

------------						SALA
go
--PROCEDIMIENTO INSERTAR SALA

go
--PROCEDIMIENTO MODIFICAR SALA

go
--PROCEDIMIENTO ELIMINAR SALA

------------						LABORATORIO
go
--PROCEDIMIENTO INSERTAR LABORATORIO

go
--PROCEDIMIENTO MODIFICAR LABORATORIO

go
--PROCEDIMIENTO ELIMINAR LABORATORIO

------------						INFORME MEDICO
go
--PROCEDIMIENTO INSERTAR INFORME MEDICO

go
--PROCEDIMIENTO MODIFICAR INFORME MEDICO

go
--PROCEDIMIENTO ELIMINAR INFORME MEDICO

------------						HOJA MEDICA
go
--PROCEDIMIENTO INSERTAR HOJA MEDICA
create proc insertar_hoja_medica(
@nro_Uso_Filtro varchar(20),
@diagnostico varchar(50),
@peso_Seco float,
@serologia varchar(50),
@talla float,
@imc float,
@vih bit,
@acceso_Vascular varchar(50),
@grupo_Sanguineo varchar(50),
@solucion_Dializante varchar(50),
@id_empleado int
)as
begin
	begin try
		begin tran		
			insert into Hoja_Medica values(@nro_Uso_Filtro,@diagnostico,@peso_Seco,@serologia,@talla,@imc,@vih,@acceso_Vascular,@grupo_Sanguineo,@solucion_Dializante,@id_empleado)
			commit tran
	end try
	begin catch
		raiserror('Error insertando hoja médica',16,1) 
		rollback tran
	end catch
end
go
--PROCEDIMIENTO MODIFICAR HOJA MEDICA
create proc modificar_hoja_medica(
@id_hojaM int,
@nro_Uso_Filtro varchar(20),
@diagnostico varchar(50),
@peso_Seco float,
@serologia varchar(50),
@talla float,
@imc float,
@vih bit,
@acceso_Vascular varchar(50),
@grupo_Sanguineo varchar(50),
@solucion_Dializante varchar(50),
@id_empleado int
)as
begin
	begin try
		begin tran
			update Hoja_Medica
			set nro_Uso_Filtro=@nro_Uso_Filtro,
				diagnostico=@diagnostico,
				peso_Seco=@peso_Seco,
				serologia=@serologia,
				talla=@talla,
				imc=@imc,
				vih=vih,
				acceso_Vascular=@acceso_Vascular,
				grupo_Sanguineo=@grupo_Sanguineo,
				solucion_Dializante=@solucion_Dializante,
				id_empleado=@id_empleado
			where id_hojaM=@id_hojaM and id_empleado=@id_empleado
			commit tran
	end try
	begin catch
		raiserror('Error modificando hoja medica',16,1) 
		rollback tran
	end catch
end
go
--PROCEDIMIENTO ELIMINAR HOJA MEDICA
create proc eliminar_hoja_medica(
@id_hojaM int,
@id_empleado int
)as
begin
	begin try
		begin tran
			delete Hoja_Medica			
			where id_hojaM=@id_hojaM and id_empleado=@id_empleado
			commit tran
	end try
	begin catch
		raiserror('Error eliminando hoja medica',16,1) 
		rollback tran
	end catch
end
------------						HOJA REGISTRO
go
--PROCEDIMIENTO INSERTAR HOJA REGISTRO
create proc insertar_hoja_reg(
@nro_familiar_Contacto int,
@formulario_Referencia bit,
@carta_Negativa varchar(200),
@grado_Intruccion varchar(50),
@red varchar(50),
@municipio varchar(50),
@seguro varchar(50),
@fecha_PHemodialisis date,
@CI int,
@id_empleado int
)as
begin
	begin try
		begin tran
		if exists(select ci from Hoja_Registro where CI=@CI)
		begin
			print 'Ya existe una hoja registro del CI de este paciente'
			rollback tran return			
		end
		else
		begin			
			insert into Hoja_Registro values(@nro_familiar_Contacto,@formulario_Referencia,@carta_Negativa,@grado_Intruccion,@red,@municipio,@seguro,@fecha_PHemodialisis,@CI,@id_empleado)
			commit tran
		end
	end try
	begin catch
		raiserror('Error insertando hoja registro',16,1) 
		rollback tran
	end catch
end
go
--PROCEDIMIENTO MODIFICAR HOJA REGISTRO
create proc modificar_hoja_reg(
@nro_registro int,
@nro_familiar_Contacto int,
@formulario_Referencia bit,
@carta_Negativa varchar(200),
@grado_Intruccion varchar(50),
@red varchar(50),
@municipio varchar(50),
@seguro varchar(50),
@fecha_PHemodialisis date,
@CI int,
@id_empleado int
)as
begin
	begin try
		begin tran
			update Hoja_Registro
			set nro_familiar_Contacto=@nro_familiar_Contacto,
				formulario_Referencia=@formulario_Referencia,
				carta_Negativa=@carta_Negativa,
				grado_Intruccion=@grado_Intruccion,
				red=@red,
				municipio=@municipio,
				seguro=@seguro,
				fecha_PHemodialisis=@fecha_PHemodialisis,
				CI=@CI,
				id_empleado=@id_empleado
			where nro_registro=@nro_registro and CI=@CI and id_empleado=@id_empleado
			commit tran
	end try
	begin catch
		raiserror('Error modificando hoja de registro',16,1) 
		rollback tran
	end catch
end

go
--PROCEDIMIENTO ELIMINAR HOJA REGISTRO
create proc eliminar_hoja_reg(
@nro_reg int,
@CI int,
@id_empleado int
)as
begin
	begin try
		begin tran
			delete Hoja_Registro
			where nro_registro=@nro_reg and CI=@CI and id_empleado=@id_empleado
			commit tran
	end try
	begin catch
		raiserror('Error eliminando hoja de registro',16,1) 
		rollback tran
	end catch
end

------------						CONSULTA EXTERNA
go
--PROCEDIMIENTO INSERTAR CONSULTA EXTERNA

go
--PROCEDIMIENTO MODIFICAR CONSULTA EXTERNA

go
--PROCEDIMIENTO ELIMINAR CONSULTA EXTERNA

------------						FARMACIA
go
--PROCEDIMIENTO INSERTAR CONSULTA FARMACIA

go
--PROCEDIMIENTO MODIFICAR CONSULTA FARMACIA

go
--PROCEDIMIENTO ELIMINAR CONSULTA FARMACIA


------------						MEDICAMENTO
go
--PROCEDIMIENTO INSERTAR CONSULTA MEDICAMENTO

go
--PROCEDIMIENTO MODIFICAR CONSULTA MEDICAMENTO

go
--PROCEDIMIENTO ELIMINAR CONSULTA MEDICAMENTO


------------						RECETA
go
--PROCEDIMIENTO INSERTAR RECETA

go
--PROCEDIMIENTO MODIFICAR RECETA

go
--PROCEDIMIENTO ELIMINAR RECETA


------------						CONTROL ENFERMERIA (Hoja enfermería)
go
--PROCEDIMIENTO INSERTAR CONTROL ENFERMERIA
create proc insertar_control_enfermeria(
@fecha_Sesion date,
@nro_Sesion_HD int,
@hora_Inicio time,
@hora_Salida time,
@peso_Inicial float,
@peso_Final float,
@U_F_Programada varchar(50),
@heparina varchar(50),
@flujo_Efectivo varchar(20),
@presion_Arterial varchar(50),
@temperatura float,
@pulso varchar(50),
@saturacion varchar(50),
@nro_registro int,
@id_empleado int
)as
begin
	begin try
		begin tran
			insert into Control_Enfermeria values(@fecha_Sesion,@nro_Sesion_HD,@hora_Inicio,@hora_Salida,@peso_Inicial,@peso_Final,@U_F_Programada,@heparina,@flujo_Efectivo,@presion_Arterial,@temperatura,@pulso,@saturacion,@nro_registro,@id_empleado)
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
@id_hoja_enfermeria int,
@fecha_Sesion date,
@nro_Sesion_HD int,
@hora_Inicio time,
@hora_Salida time,
@peso_Inicial float,
@peso_Final float,
@U_F_Programada varchar(50),
@heparina varchar(50),
@flujo_Efectivo varchar(20),
@presion_Arterial varchar(50),
@temperatura float,
@pulso varchar(50),
@saturacion varchar(50),
@nro_registro int,
@id_empleado int
)as
begin
	begin try
		begin tran
			update Control_Enfermeria
			set fecha_Sesion=@fecha_Sesion,
				nro_Sesion_HD=@nro_Sesion_HD,
				hora_Inicio=@hora_Inicio,
				hora_Salida=@hora_Salida,
				peso_Inicial=@peso_Inicial,
				peso_Final=@peso_Final,
				U_F_Programada=@U_F_Programada,
				heparina=@heparina,
				flujo_Efectivo=@flujo_Efectivo,
				presion_Arterial=@presion_Arterial,
				temperatura=@temperatura,
				pulso=@pulso,
				saturacion=@saturacion,
				nro_registro=@nro_registro,
				id_empleado=@id_empleado
			where id_empleado=@id_empleado and id_hoja_enfermeria=@id_hoja_enfermeria and nro_registro=@nro_registro
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
@id_hoja_enfermeria int,
@nro_registro int,
@id_empleado int
)as
begin
	begin try
		begin tran
			delete Control_Enfermeria
			where id_hoja_enfermeria=@id_hoja_enfermeria and nro_registro=@nro_registro and id_empleado=@id_empleado
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
@nro_Seguro int,
@ultra_Filtracion varchar(50),
@duracion varchar(20),
@flujo_Dialisis varchar(50),
@evolucion_Clinica varchar(300),
@detalles_Medicacion varchar(200),
@tipo_Tratamiento varchar(30),
@id_hoja_enfermeria int,
@id_empleado int
)as
begin
	begin try
		begin tran
			insert into Evolucion_Tratamiento values(@nro_Seguro,@ultra_Filtracion,@duracion,@flujo_Dialisis,@evolucion_Clinica,@detalles_Medicacion,@tipo_Tratamiento,@id_hoja_enfermeria,@id_empleado)
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
@id_evolucion_tratamiento int,
@nro_Seguro int,
@ultra_Filtracion varchar(50),
@duracion varchar(20),
@flujo_Dialisis varchar(50),
@evolucion_Clinica varchar(300),
@detalles_Medicacion varchar(200),
@tipo_Tratamiento varchar(30),
@id_hoja_enfermeria int,
@id_empleado int
)as
begin
	begin try
		begin tran
			update Evolucion_Tratamiento
			set nro_Seguro=@nro_Seguro,
				ultra_Filtracion=@ultra_Filtracion,
				duracion=@duracion,
				flujo_Dialisis=@flujo_Dialisis,
				evolucion_Clinica=@evolucion_Clinica,
				detalles_Medicacion=@detalles_Medicacion,
				tipo_Tratamiento=@tipo_Tratamiento,
				id_hoja_enfermeria=@id_hoja_enfermeria,
				id_empleado=@id_empleado
			where id_empleado=@id_empleado and id_evolucion_tratamiento=@id_evolucion_tratamiento and id_empleado=@id_empleado
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
@id_evolucion_tratamiento int,
@id_hoja_enfermeria int,
@id_empleado int
)as
begin
	begin try
		begin tran
			delete Evolucion_Tratamiento
			where id_evolucion_tratamiento=@id_evolucion_tratamiento and id_hoja_enfermeria=@id_hoja_enfermeria and id_empleado=@id_empleado
		commit tran
	end try
	begin catch
		raiserror('Error eliminando hoja de evolución y tratamiento',16,1) 
		rollback tran
	end catch	
end
------------						PRUEBA LABORATORIO
go
--PROCEDIMIENTO INSERTAR PRUEBA LABORATORIO

go
--PROCEDIMIENTO MODIFICAR PRUEBA LABORATORIO

go
--PROCEDIMIENTO ELIMINAR PRUEBA LABORATORIO

------------						SESION
go
--PROCEDIMIENTO INSERTAR SESION

go
--PROCEDIMIENTO MODIFICAR SESION

go
--PROCEDIMIENTO ELIMINAR SESION

------------						CATETER
go
--PROCEDIMIENTO INSERTAR CATETER

go
--PROCEDIMIENTO MODIFICAR CATETER

go
--PROCEDIMIENTO ELIMINAR CATETER
------------						FISTULA
go
--PROCEDIMIENTO INSERTAR FISTULA

go
--PROCEDIMIENTO MODIFICAR FISTULA

go
--PROCEDIMIENTO ELIMINAR FISTULA
------------						DIALISIS PERITONEAL
go
--PROCEDIMIENTO INSERTAR DIALISIS PERITONEAL

go
--PROCEDIMIENTO MODIFICAR DIALISIS PERITONEAL

go
--PROCEDIMIENTO ELIMINAR DIALISIS PERITONEAL


-------------						TRIGGERS							-----------------











