using UserServiceTests.Models;

namespace UserServiceTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestRegister()
        {
            UserService userService = new UserService();
            string username = "username";
            string password = "password";

            userService.Register(username, password);

            Assert.Equal(1, userService.Users.Count);
        }

        [Fact]
        public void TestRegisterDuplicate()
        {
            UserService userService = new UserService();
            string username = "username";
            string password = "password";
            userService.Register(username, password);
            string newUsername = "username";
            string newPassword = "password";

            Assert.NotEqual(2, userService.Users.Count);
        }

        [Fact]
        public void TestLogin()
        {
            UserService userService = new UserService();
            string username = "username";
            string password = "password";
            string password2 = "pass";
            string result1 = "Welcome back!";
            string result2 = "User not found";
            userService.Register(username, password);

            string message = userService.Login(username, password);
            string message2 = userService.Login(username, password2);

            Assert.Equal(result1, message);
            Assert.Equal(result2, message2);

        }

        [Fact]
        public void TestChangePasswordCorrect()
        {
            UserService userService = new UserService();
            string username = "username";
            string password = "password";
            userService.Register(username, password);
            string newPassword = "password123";

            userService.ChangePassword(username, password, newPassword);

            Assert.Equal(newPassword, userService.Users[0].Password);
        }

        [Fact]
        public void TestChangePasswordIncorrect()
        {
            UserService userService = new UserService();
            string username = "username";
            string password = "password";
            userService.Register(username, password);
            string oldPasswordWrong = "pass";
            string newPassword = "password123";

            userService.ChangePassword(username, oldPasswordWrong, newPassword);

            Assert.NotEqual(newPassword, userService.Users[0].Password);
        }

    }
}