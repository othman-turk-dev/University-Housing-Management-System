using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class RoomMapper
    {
        public static RoomDto ToDto(Room room)
        {
            return new RoomDto
            {
                RoomId = room.RoomId,
                RoomLocation = room.RoomLocation
            };
        }

        public static Room ToEntity(RoomDto roomDto)
        {
            return new Room
            {
                RoomId = roomDto.RoomId,
                RoomLocation = roomDto.RoomLocation
            };
        }
    }
}
