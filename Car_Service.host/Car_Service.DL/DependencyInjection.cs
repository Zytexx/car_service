using Car_Service.DL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Service.DL
{
    public static class DependencyInjection
    {
        AddDataLayer (this IServiceCollection services)
        {
            services.AddSingleton<ICarRepository, CarLocalRepository>();
            return services;
        }
    }
}
