using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<TransportCard, TransportCardDto>();
            CreateMap<Transaction, TransactionDto>();
        }

    }
}