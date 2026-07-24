namespace University_Housing_Management_Project.DTOs
{
    public class CustomUserDto
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }

        public bool StudentManager { get; set; }
        public bool StudentSubscription { get; set; }
        public bool RoomManager { get; set; }
        public bool ProductManager { get; set; }
        public bool SaleManager { get; set; }
        public bool ViolationManager { get; set; }
        public bool UserManager { get; set; }
        public bool BankSystem { get; set; }

    }
}
