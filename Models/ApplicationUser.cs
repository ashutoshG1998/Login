namespace Login.Models
{
    public class ApplicationUser: AuditableEntity
    {
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; }=null!;
        public bool Isactive { get; set; } = true;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
        public ICollection<Userpermission> Userpermissions { get; set; } = new List<Userpermission>();

       // public ICollection<Role> Roles { get; set; } = new HashSet<Role>();
    }
    public class  Role:AuditableEntity
    {
        public string Name { get; set;} = null!;
        public string? Description { get; set; }=null!;
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

        public ICollection<Rolepermission> RolePermissions { get; set; }=new List<Rolepermission>();

        //public override bool Equals(object? obj)
        //{
        //    return base.Equals(obj);
        //}
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

    }
    public class Permission : AuditableEntity
    {
        public string Code { get; set; } = null!;//Category created
        public string? description { get; set; }

        public ICollection<Userpermission> Userpermissions{ get; set; }= new List<Userpermission>();

        public ICollection<Rolepermission> RolePermissions { get; set; } = new List<Rolepermission>();
    }
    public class UserRole : AuditableEntity
    {

        public Guid UserId { get; set; }

        public ApplicationUser user { get; set; } = null!;


        public Role Role { get; set; } = null!;
        public Guid RoleId { get; set; }





    }
    public class Rolepermission:AuditableEntity
    {
        public Guid RolePermissionId { get; set; }

        public Permission permission { get; set; } = null!;

        public Guid RoleId { get; set; }

        public Role Role { get; set; } = null!;

    }

    public class Userpermission : AuditableEntity
    {
        public Guid PermissionId { get; set; }

        public Permission permission { get; set; } = null!;

        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

    }

    //public class UserRolepermission : AuditableEntity
    //{

}
