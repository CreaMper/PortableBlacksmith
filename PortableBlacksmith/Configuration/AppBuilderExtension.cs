using PortableBlacksmith.WebAPI.Services;

namespace PortableBlacksmith.WebAPI.Configuration
{
    public static class AppBuilderExtension
    {
        public static void FillMemoryDatabaseWithData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                var fillingService = scope.ServiceProvider.GetRequiredService<DatabaseInitializationService>();
                if (fillingService == null)
                    throw new ApplicationException("In-memory database failed with the data initialization!");

                fillingService.FillWithData();
            }
        }
    }
}
