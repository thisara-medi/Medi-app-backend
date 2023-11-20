using AutoMapper;
using PMS.Core.Models;
using PMS.Core.Models.DTO;
using UnitOfWorkDemo.Core.Models;

namespace PMS.Endpoints.Mappings
{
    public class AutoMapperProfiles  :Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<PatientDTO, Patient>().ReverseMap();

            CreateMap<PatientRecord, PatientRecordDTO>().ReverseMap();
            CreateMap<User, LoginDto>().ReverseMap();

        }

    }
}
