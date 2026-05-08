using System;

namespace Krypton_Test
{
    public static class FakeDatabase
    {
        // These hold the data between screens. 
        // We leave a default admin account here just so you don't have to sign up every single time you test!
        public static string FullName = "Admin User";
        public static string Email = "admin@cyberbites.com";
        public static string Username = "admin";
        public static string Password = "1234";
        public static string SeatNumber = "PC-01";
    }
}