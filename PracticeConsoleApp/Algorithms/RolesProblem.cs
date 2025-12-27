using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Algorithms
{

    public class Permission
    {
        public Permission() { }
        public Permission(String role, String name, bool active)
        {
            this.Role = role;
            this.Name = name;
            this.Active = active;
        }

        public String Role { get; set; }
        public String Name { get; set; }
        public bool Active { get; set; }
    }

    public class User
    {
        public User() { }
        public User(int id, String name, List<String> roles)
        {
            this.Id = id;
            this.Name = name;
            this.Roles = roles;
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public List<String> Roles { get; set; }
    }

    // see graphic in instructions for visual explanation of the permission and user data structures
    public class Authorization
    {
        public List<Permission> Permissions { get; set; }
        public List<User> Users { get; set; }

        public Authorization(List<Permission> permissions, List<User> users)
        {
            this.Permissions = permissions;
            this.Users = users;
        }
        //   @rtype: list of strings
        //   @returns: a list of all the active permission names that the user with the corresponding user_id has
        //   @note: The order in which the permission names are returned is not important
        //   @example: listPermissions(1) ➡ ["View Orders", "Block User Account"]
        //  (purchased widgets not included since it is not active)
        public List<String> ListPermissions(int userId)
        {
            // TODO: fill this out!

            var user = Users.Where(u => u.Id == userId).FirstOrDefault();

            if (user == null)
            {
                return new List<string>();
            }
            if (user.Roles == null || user.Roles.Count == 0)
                return new List<string>();

            List<String> permissions = new List<String>();

            foreach (string role in user.Roles)
            {
                var currnetPermissions = Permissions.Where(x => String.Compare(x.Role,role, StringComparison.OrdinalIgnoreCase) == 0 && x.Active).ToList();

                if (currnetPermissions != null)
                {
                    permissions.AddRange(currnetPermissions.Select(x => x.Name).ToList());
                }

            }
            permissions = permissions.Distinct().ToList();

            return permissions;
        }

        // @rtype: boolean value
        // @returns: true or false based on if the user with the corresponding user_id has the role that corresponds with the specific permission_name and that particular permission is active
        // @example: Example (Based on data from graphic)
        // checkPermitted("scooters near me", 2) ➡ true
        // checkPermitted("scooters near me", 1) ➡ false
        public bool CheckPermitted(String permissionName, int userId)
        {
            // TODO: fill this out!
            var userPermissions = ListPermissions(userId);

            return userPermissions.Any(role => String.CompareOrdinal(permissionName, permissionName) == 0);
        }
    }
}
