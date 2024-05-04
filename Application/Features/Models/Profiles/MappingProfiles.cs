using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistance.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;


public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Model, GetListModelListItemDto>()
            .ForMember(destinationMember: c => c.BrandName, memberOptions: opt => opt.MapFrom(c => c.Brand.Name))
            .ForMember(c => c.TransmissionName, opt => opt.MapFrom(c => c.Transmission.Name))
           .ForMember(c => c.FuelName, opt => opt.MapFrom(c => c.Fuel.Name))
            .ReverseMap();


        CreateMap<Model, GetListByDynamicModelListItemDto>()
           .ForMember(destinationMember: c => c.BrandName, memberOptions: opt => opt.MapFrom(c => c.Brand.Name))
           .ForMember(c => c.TransmissionName, opt => opt.MapFrom(c => c.Transmission.Name))
          .ForMember(c => c.FuelName, opt => opt.MapFrom(c => c.Fuel.Name))
           .ReverseMap();

        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();

        CreateMap<Paginate<Model>, GetListResponse<GetListByDynamicModelListItemDto>>().ReverseMap();

    }

}