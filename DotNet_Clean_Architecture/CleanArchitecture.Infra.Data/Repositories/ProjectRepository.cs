﻿using CleanArchitecture.Infra.Data.Context;
using CoreCleanArchitecture.Domain.Interface;
using CoreCleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infra.Data.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        public ProjectDbContext _context;

        public ProjectRepository(ProjectDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Project> GetProjects()
        {
            return _context.Projects;
        }
    }
}
