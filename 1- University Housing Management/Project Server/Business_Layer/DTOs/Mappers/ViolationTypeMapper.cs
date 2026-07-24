using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class ViolationTypeMapper
    {

        public static ViolationTypeDto ToDto(ViolationType violationType)
        {
            return new ViolationTypeDto
            {
                ViolationTypeId = violationType.ViolationTypeId,
                Name = violationType.Name,
                Description = violationType.Description,
                PenaltyAmount = violationType.PenaltyAmount,
            };
        }

        public static ViolationType ToEntity(ViolationTypeDto violationTypeDto)
        {
            return new ViolationType
            {
                ViolationTypeId = violationTypeDto.ViolationTypeId,
                Name = violationTypeDto.Name,
                Description = violationTypeDto.Description,
                PenaltyAmount = violationTypeDto.PenaltyAmount,
            };
        }

    }
}
