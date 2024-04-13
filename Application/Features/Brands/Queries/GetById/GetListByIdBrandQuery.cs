using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetById;

public class GetListByIdBrandQuery : IRequest<GetByIdBrandResponse>
{
    public Guid Id { get; set; }

    public class GetListByIdBrandHandler : IRequestHandler<GetListByIdBrandQuery, GetByIdBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public GetListByIdBrandHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public async Task<GetByIdBrandResponse> Handle(GetListByIdBrandQuery request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);
            GetByIdBrandResponse response = _mapper.Map<GetByIdBrandResponse>(brand);
            return response;
        }
    }


}
