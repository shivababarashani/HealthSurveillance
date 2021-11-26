using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HealthSurveillance.Domain.Entities.Company.DataModels;
using HealthSurveillance.Domain.Entities.Company.ViewModel;

namespace HealthSurveillance.Web.Configuration
{
    public class EntityMapping : Profile
    {
        public EntityMapping()
        {


            #region Charity
            CreateMap<Company, CompanyViewModel>().ReverseMap();
            //CreateMap<Domain.Charity.DataModel.CharityDataModel, Domain.Charity.Dto.CharityAddDto>().ReverseMap()
            //    .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
          
            #endregion


        }
    }
}
