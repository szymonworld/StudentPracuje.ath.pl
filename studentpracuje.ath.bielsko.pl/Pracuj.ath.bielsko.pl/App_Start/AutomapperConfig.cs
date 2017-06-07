using AutoMapper;
using Pracuj.ath.bielsko.pl.ViewModels;
using Pracuj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.App_Start
{
    public static class AutomapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<RegisterViewModel, User>();
                cfg.CreateMap<User, Student>();
                cfg.CreateMap<User, Employer>();
                cfg.CreateMap<AddJobOffertViewModel, Job>();
                cfg.CreateMap<Job, AddJobOffertViewModel>();
            });
        }
    }
}
