using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Security;
using MusicStore.Models;

namespace MusicStore.Providers
{
    public class CustomRoleProvider: RoleProvider
    {
        MusicStoreEntities db = new MusicStoreEntities();
        public override bool IsUserInRole(string username, string roleName)
        {
            var user = db.Users.Include(user1 => user1.Role).FirstOrDefault(user1 => user1.Name == username);
            if (user != null && user.Role.Name == username)
                return true;
            return false;
        }

        public override string[] GetRolesForUser(string username)
        {
            var userDb = db.Users.Include(user => user.Role).FirstOrDefault(user => user.Name == username);
            if (userDb != null)
                return new[]
                    {userDb.Role.Name};
            return new string[0];
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName { get; set; }
    }
}