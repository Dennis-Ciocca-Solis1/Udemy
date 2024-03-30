--Crear procedure que liste la información de la tabla tb_categorias

create procedure usp_listado_ca
@cTexto varchar(30)=''
as
	select codigo_ca,descripcion_ca 
	from TB_CATEGORIAS where estado=1 and upper(trim(descripcion_ca)) like '%'+upper(trim(@cTexto))+'%'
	order by codigo_ca;
go