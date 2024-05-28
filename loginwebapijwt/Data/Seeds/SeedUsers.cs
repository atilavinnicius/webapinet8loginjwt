using loginwebapijwt.Enums;
using loginwebapijwt.Models;
using Microsoft.EntityFrameworkCore;

namespace loginwebapijwt.Data.Seeds
{
    public static class SeedUsers
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    id = 1,
                    name = "Admin Dev Atila",
                    email = "admin@devatila.com.br",
                    password = BCrypt.Net.BCrypt.HashPassword("123456"),
                    role = EnumRole.Admin
                },
                new User
                {
                    id = 2,
                    name = "Cliente Sicreno do Tal",
                    email = "cliente@devatila.com.br",
                    password = BCrypt.Net.BCrypt.HashPassword("123456"),
                    role = EnumRole.Customer
                },
                new User
                {
                    id = 3,
                    name = "Usuario Funcionario de Tal",
                    email = "funcionario@devatila.com.br",
                    password = BCrypt.Net.BCrypt.HashPassword("123456"),
                    role = EnumRole.Employee
                }
            );
        }
    }
}