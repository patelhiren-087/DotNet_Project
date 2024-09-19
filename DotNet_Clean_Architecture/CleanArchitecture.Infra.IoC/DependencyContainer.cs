using CleanArchitecture.Application.Interface;
using CleanArchitecture.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreCleanArchitecture.Domain.Interface;

namespace CleanArchitecture.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IProjectService, ProjectService>();

            services.AddScoped<IProjectRepository, ProjectRepository>();

        }
    }


}
