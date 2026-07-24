using System;

namespace University_Housing_Management_Project.Global
{
    public static class CurrentUser
    {

        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static int Permissions { get; set; }
        public static bool IsActive { get; set; }
        public static string AccessToken { get; set; }
        public static string RefreshToken { get; set; }
        public static DateTime? RefreshTokenExpiresAt { get; set; }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            Permissions = 0;
            IsActive = false;

            AccessToken = null;
            RefreshToken = null;
            RefreshTokenExpiresAt = null;
        }

    }
}

