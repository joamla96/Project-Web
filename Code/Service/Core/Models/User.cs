using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public enum PermissionLevel
    {
        Student, Teacher, Admin
    };

    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string MyProperty { get; set; }
        public PermissionLevel permissionLevel { get; set; }
    }
}
