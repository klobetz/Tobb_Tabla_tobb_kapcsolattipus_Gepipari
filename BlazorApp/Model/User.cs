using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Model
{
    public class User
    {        
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? UserName { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }

        //a kapcsolatok kialakítása
        //egy-egy kapcsolat kialakítása a UserSetting osztállyal
        public virtual UserProfil? UserProfil { get; set; }

        //egy a többhöz kapcsolat kialakítása a post osztály felé:
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        //Több a többhöz kapcsolat kiépítése a role-felé
        public virtual List<Role> Roles { get; set; } = new List<Role>();
    }
}
