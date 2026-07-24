using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class SpecializationMapper
    {

        public static SpecializationDto ToDto(Specialization specialization)
        {
            return new SpecializationDto
            {
                SpecializationId = specialization.SpecializationId,
                Name = specialization.Name
            };
        }

        public static Specialization ToEntity(SpecializationDto specializationDto)
        {
            return new Specialization
            {
                SpecializationId = specializationDto.SpecializationId,
                Name = specializationDto.Name
            };
        }
    }
}
