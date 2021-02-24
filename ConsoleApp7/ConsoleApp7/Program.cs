using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new Input { };
            var db = new Entities();
            var query = db.Users
                //.Include(u=>u.UserRoles.Select(ur=>ur.Role)) 
                //.Include(u=>u.WorkspaceUsers.Select(wu=>wu.Workspace))
                .Where(predicate =>
                    string.IsNullOrEmpty(input.Filter) ||
                    predicate.fullname.Contains(input.Filter) ||
                                 predicate.Email.Contains(input.Filter));

            var join = (from u in query
                    join ur in db.UserRoles
                        on u.UserId equals ur.UserId
                    join r in db.Roles
                        on ur.RoleId equals r.RoleId
                    join wu in db.WorkspaceUsers
                            on u.UserId equals wu.UserId
                        join w in db.WorkSpaces
                            on wu.WorkspaceId equals w.WorkspaceId
                        select new {u, r, w}
                );


            
            var usersCount = query.Count();
            var users = query.ToList();

        }
    }

    internal class Input
    {
        public string Filter { get; set; }
        public string SortDirection { get; set; } = "asc";
        public string SortBy { get; set; } = "";
    }

    public class Entities : DbContext
    {
        public DbSet<User> Users;

        public DbSet<Role> Roles { get; set; }
        public DbSet<Workspace> WorkSpaces { get; set; }
        public DbSet<WorkspaceUser> WorkspaceUsers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }

    public class WorkspaceUser
    {
        public int WorkspaceId { get; set; }
        public Guid UserId { get; set; }

        public virtual Workspace Workspace { get; set; }
        public virtual User User { get; set; }

    }
    public class Workspace
    {
        public int WorkspaceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<WorkspaceUser> WorkspaceUsers { get; set; } = new List<WorkspaceUser>();

    }
    public class Role 
    {
        public int RoleId { get; set; }
        public bool IsSystemDefault { get; set; } = false;

        //public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();

        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }

    public class UserRole 
    {
        public Guid UserId { get; set; }
        public int RoleId { get; set; }
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
    public class User 
    {
        public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public virtual ICollection<WorkspaceUser> WorkspaceUsers { get; set; } = new List<WorkspaceUser>();
        public string fullname { get; set; }

        public string Email { get; set; }
        public Guid UserId { get; set; }
    }
}
