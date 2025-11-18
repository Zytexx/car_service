using Car_Service.BL.Interface;
using Car_Service.DL.Interface;
using Car_Service.Models.Dto;

namespace Car_Service.BL
{
    public static class DependencyInjection
    {
        AddDataLayer(this IServiceCollection services)
        {
            services.AddSingleton<ICarService, Services.Car_Service>();
            return services;
        }
    }
}

