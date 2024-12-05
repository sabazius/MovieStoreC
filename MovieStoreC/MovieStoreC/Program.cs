<<<<<<< HEAD
using Mapster;
using MovieStoreC.BL;
using MovieStoreC.BL.Interfaces;
using MovieStoreC.DL;

=======
>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
namespace MovieStoreC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
<<<<<<< HEAD
            builder.Services
                .RegisterRepositories()
                .RegisterServices();

            builder.Services.AddMapster();

            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


=======

            builder.Services.AddControllers();

            var app = builder.Build();

>>>>>>> 5aa0808bae28cbe8b1c2c36a9262fcf921944919
            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
