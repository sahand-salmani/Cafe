using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Infrastructure.Common
{
    public static class ClaimStore
    {
        public static List<Claim> Claims = new List<Claim>()
        {
                new Claim("Restaurant", "Restaurant"),
                new Claim("Contract", "Contract"),
                new Claim("Meeting", "Meeting"),
                new Claim("Product", "Product"),
                new Claim("Stants", "Stants"),
                new Claim("Employee", "Employee"),
                new Claim("Spend", "Spend"),
                new Claim("EmployeePayment", "EmployeePayment"),
                new Claim("Fail", "Fail"),
                new Claim("Position", "Position"),
                new Claim("Intern", "Intern"),
                new Claim("Role", "Role"),
        };
    }
}
