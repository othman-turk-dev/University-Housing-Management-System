using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class ViolationMapper
    {

        public static ViolationDto ToDto(Violation violation)
            => new ViolationDto
            {
                CreatedByUserId = violation.CreatedByUserId,
                Fine = violation.Fine,
                IsPaid = violation.IsPaid,
                StudentId = violation.StudentId,
                ViolationId = violation.ViolationId,
                ViolationTypeId = violation.ViolationTypeId 
            };

    }
}
