using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSimProject.General
{
    public class User
    {
        public static long IdPk {  get; set; }
        public static string Username { get; set; } = string.Empty;
        public static string FirstName { get; set; } = string.Empty;
        public static string LastName { get; set; } = string.Empty;
        public static string Email { get; set; } = string.Empty;

    }
}
