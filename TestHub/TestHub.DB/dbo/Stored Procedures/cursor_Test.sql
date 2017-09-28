
CREATE procedure cursor_Test
as
begin
	declare @product_id int, @product_type_description nvarchar(100)
	
	declare product_cursor CURSOR for
	select ProductTypeID, Description from ProductType 

	open product_cursor
	
	fetch next from product_cursor into @product_id, @product_type_description 

	while @@FETCH_STATUS = 0
	begin
		print cast(@product_id as varchar(50)) + ': ' + @product_type_description

		fetch next from product_cursor into @product_id, @product_type_description 
	end

	close product_cursor
	deallocate product_cursor
end