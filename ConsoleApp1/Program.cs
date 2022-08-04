
using ITMonitoring.Domain.Models;
using ITMonitoring.Domain.Services;
using ITMonitoring.EntityFramework;
using ITMonitoring.EntityFramework.Services;
using Microsoft.AspNet.Identity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IPasswordHasher hasher = new PasswordHasher();

            var passTest = "admin";

            string hashPass = hasher.HashPassword(passTest);

            IDataService<User> userService = new GenericDataService<User>(new ITMonitoringDbContextFactory());
            userService.Create(new User { Username = "TEST", Password = hashPass }).Wait();
            //Console.Write(userService.GetAll().Result.Count());
            //Console.Write(userService.Update(2, new User() { Username = "UPDATETEST", Password="UPDATEPASS"}).Result);
            //Console.Write(userService.Delete(2).Result);
        }
    }
}