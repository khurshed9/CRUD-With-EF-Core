using CrudWithEfCore.DataContext;
using CrudWithEfCore.Services;

namespace CrudWithEfCore.ExtensionMethods;

public static class AddRegisterService
{
    public static void AddService(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>();
        serviceCollection.AddScoped<IPersonService, PersonService>();
    }
}