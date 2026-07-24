using Business_Layer.Authorization;
using Business_Layer.DTOs;
using Business_Layer.Global.Enums;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace University_Housing_Management_Project.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/Rooms")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.RoomManagement)]
    public class RoomsController : ControllerBase
    {

        private readonly IRoomService _roomService;
        private readonly IStudentService _studentService;
        public RoomsController(IRoomService roomService, IStudentService studentService)
        {
            _roomService = roomService;
            _studentService = studentService;
        }



        [HttpPost()]
        public async Task<ActionResult<RoomDto>> AddRoom([FromBody] RoomDto room)
        {

            if(room == null || string.IsNullOrWhiteSpace(room.RoomLocation))
                return BadRequest("Room data is invalid.");

            if (await _roomService.GetRoomByLocationAsync(room.RoomLocation) != null)
                return BadRequest("Room with the same location already exists.");

            var addedRoom = await _roomService.AddRoomAsync(room);

            if (addedRoom == null)
                return BadRequest("Failed to add the room.");


            return CreatedAtRoute("GetRoomById", new { roomId = addedRoom.RoomId }, addedRoom );
        }


        [HttpPut()]
        public async Task<ActionResult<RoomDto>> UpdateRoom([FromBody] RoomDto room)
        {
            
            if (room == null || string.IsNullOrWhiteSpace(room.RoomLocation))
                return BadRequest("Room data is invalid.");

            if (room.RoomId <= 0)
                return BadRequest("Invalid room ID.");

            if (!await _roomService.IsRoomExistAsync(room.RoomId))
                return NotFound($"Room with ID {room.RoomId} not found.");


            var updatedRoom = await _roomService.UpdateRoomAsync(room);
            if (updatedRoom == null)
                return NotFound($"Room with ID {room.RoomId} update failed.");
            
            return Ok(updatedRoom);
        }


        [HttpDelete("{roomId}")]
        public async Task<IActionResult> DeleteRoom(int roomId)
        {
            
            if (roomId <= 0)
                return BadRequest("Invalid room ID.");
            
            if (!await _roomService.IsRoomExistAsync(roomId))
                return NotFound($"Room with ID {roomId} not found.");
            
            var result = await _roomService.DeleteRoomAsync(roomId);
            
            if (!result)
                return NotFound($"Room with ID {roomId} deletion failed.");
            
            return NoContent();
        }

        
        [AllowAnonymous]
        [HttpGet("{roomId}", Name = "GetRoomById")]
        public async Task<ActionResult<RoomDto>> GetRoomById(int roomId)
        {

            if (roomId <= 0)
                return BadRequest("Invalid room ID.");

            var room = await _roomService.GetRoomByIdAsync(roomId);

            if (room == null)
                return NotFound($"Room with ID {roomId} not found.");

            return Ok(room);
        }


        [AllowAnonymous]
        [HttpGet("location/{roomLocation}")]
        public async Task<ActionResult<RoomDto>> GetRoomByLocation(string roomLocation)
        {

            if (string.IsNullOrWhiteSpace(roomLocation))
                return BadRequest("Invalid room location.");

            var room = await _roomService.GetRoomByLocationAsync(roomLocation);

            if (room == null)
                return NotFound($"Room with location {roomLocation} not found.");

            return Ok(room);
        }


        [AllowAnonymous]
        [HttpGet("IsExist/Id/{roomId}")]
        public async Task<ActionResult<bool>> IsRoomExist(int roomId)
        {
            
            if (roomId <= 0)
                return BadRequest("Invalid room ID.");
            
            var exists = await _roomService.IsRoomExistAsync(roomId);

            if (!exists)
                return NotFound($"Room with ID {roomId} does not exist.");

            return Ok(exists);
        }


        [AllowAnonymous]
        [HttpGet("IsExist/RoomLocation/{roomLocation}")]
        public async Task<ActionResult<bool>> IsRoomLocationExist(string roomLocation)
        {

            if (string.IsNullOrWhiteSpace(roomLocation))
                return BadRequest("Invalid room location.");

            var exists = await _roomService.IsRoomLocationExistAsync(roomLocation);

            if (!exists)
                return NotFound($"Room with {roomLocation} does not exist.");

            return Ok(exists);
        }


        [AllowAnonymous]
        [HttpGet("TotalNumber")]
        public async Task<ActionResult<int>> GetTolalRoomsNumber()
        {

            return Ok(await _roomService.
                GetTolalRoomsNumberAsync());
        }

        
        [HttpGet("TotalNumberFull")]
        public async Task<ActionResult<int>> GetTolalRoomsNumberFull()
        {

            return Ok(await _roomService.
                GetTolalRoomsNumberFullAsync());
        }


        [HttpGet("TotalNumberAvailable")]
        public async Task<ActionResult<int>> GetTotalRoomsNumberAvailable()
        {

            return Ok(await _roomService.
                GetTotalRoomsNumberAvailableAsync());
        }


        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<RoomStatusDto>>> Filter([FromQuery] RoomFilterDto roomFilter)
        {

            return Ok(await _roomService.RoomFilterAsync(roomFilter));
        }


        [AllowAnonymous]
        [HttpGet("AllAvailable")]
        public async Task<ActionResult<IEnumerable<string>>> GetAllRoomsAvailable()
        {

            return Ok(await _roomService.
                GetAllRoomsAvailableAsync());
        }


        [HttpGet("AllWithDetails")]
        public async Task<ActionResult<IEnumerable<RoomStatusDto>>> GetAllRoomsWithDetails()
        {

            return Ok(await _roomService.
                GetAllRoomsWithDetailsAsync());
        }


        [HttpGet("CurrentAndAllAvailable/{UniversityNumber}")]
        public async Task<ActionResult<IEnumerable<string>>> GetCurrentRoomAndAllRoomsAvailable
            (string UniversityNumber)
        {

            if (string.IsNullOrWhiteSpace(UniversityNumber))
                return BadRequest("Invalid University Number.");

            if (!await _studentService.IsStudentExistAsync(UniversityNumber))
                return NotFound($"Student with University Number {UniversityNumber} not found.");

            return Ok(await _roomService.
                GetCurrentRoomAndAllRoomsAvailableAsync(UniversityNumber));
        }


    }
}
