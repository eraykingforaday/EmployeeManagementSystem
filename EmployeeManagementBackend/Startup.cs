public void ConfigureServices(IServiceCollection services)
            {
                services.AddDbContext<EmployeeContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
                services.AddControllers();
            }