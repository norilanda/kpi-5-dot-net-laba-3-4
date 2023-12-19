using AutoMapper;
using TheatreBoxOffice.Common.DTO.PerformanceTickets;
using TheatreBoxOffice.DAL.Entities;

namespace TheatreBoxOffice.BLL.MappingProfiles;

public class TicketPriceTypeProfile : Profile
{
    public TicketPriceTypeProfile()
    {
        CreateMap<PerformanceTicketsCreateDto, TicketPriceType>();
        CreateMap<PerformanceTicketsUpdateDto, TicketPriceType>();
    }
}
