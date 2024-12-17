using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Role
    {
        private String roleDescription;
        private String roleName;
        private int roleId;

        public String RoleDescription { get { return roleDescription; } set { roleDescription = value; } } 
        public String RoleName { get { return roleName; } set {roleName = value; } }    
        public int RoleId { get { return roleId; } set {RoleId = value; } }

    }
}
