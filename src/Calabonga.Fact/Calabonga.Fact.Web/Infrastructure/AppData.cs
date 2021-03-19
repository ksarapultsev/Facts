using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calabonga.Fact.Web.Infrastructure
{
    public static class AppData
    {
        public const string AdministratorRoleName = "Administrator";
        public const string UserRoleName = "User";
        public static IEnumerable<string> Roles
        {
            get
            {
                yield return AdministratorRoleName;
                yield return UserRoleName;
            }
        }
    }
}
