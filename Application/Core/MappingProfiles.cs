using AutoMapper;
using Domain;

namespace Application.Core
{

    class Class1
    {
        public int MyProperty { get; set; }
    }

    class Class2
    {
        public int MyProperty2 { get; set; }
    }

    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
            CreateMap<Class1, Class2>();
        }
    }
}