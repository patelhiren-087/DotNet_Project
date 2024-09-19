using CleanArchitecture.Application.ViewModels;
using CoreCleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interface
{
    public interface IProjectService
    {
        ProjectViewModel GetProjects();
    }

}
