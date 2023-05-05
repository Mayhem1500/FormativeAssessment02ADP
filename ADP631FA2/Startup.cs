using System;

public class Class1
{
	public Class1()
	{
        services.AddDbContext<ProductContext>(o => o.UseSqlServer(Configuration.GetConnectionString("ProductDB")));

        services.AddTransient<IProductRepository, ProductRepository>();
    }
}
