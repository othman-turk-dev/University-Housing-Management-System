namespace Business_Layer.Global.Enums
{

    [Flags]
    public enum UserPermission
    {
        StudentManagement = 1,
        SubscriptionManagement = 2,
        RoomManagement = 4,
        Products = 8,
        Sales = 16,
        Violations = 32,
        UserManagment = 64,
        BankManagment = 128,
        
        Admin = -1
    };
}
