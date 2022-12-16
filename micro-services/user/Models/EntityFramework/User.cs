using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace User.Models.EntityFramework
{
    [Table("t_e_user_usr")]
    public class User
    {
        [Key]
        [Column("usr_id")]
        public int UtilisateurId { get; set; }

        [Column("usr_nom", TypeName = "varchar")]
        [StringLength(50)]
        public string? Nom { get; set; }

        [Column("usr_prenom", TypeName = "varchar")]
        [StringLength(50)]
        public string? Prenom { get; set; }

        [Column("usr_mobile", TypeName = "char")]
        [StringLength(10)]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Le format du numéro de téléphone est invalide")]

        public string? Mobile { get; set; }

        [Column("usr_mail", TypeName = "varchar")]
        [StringLength(100, ErrorMessage = "La longueur d’un email doit être de 100 caractères maximum.")]
        public string? Mail { get; set; }

        [Column("usr_pwd", TypeName = "varchar")]
        [StringLength(64)]
        public string? Pwd { get; set; }

        [Column("usr_datecreation", TypeName = "date")]
        public DateTime DateCreation { get; set; }

        [Column("usr_userrole", TypeName = "varchar")]
        [DefaultValue("User")]
        public string UserRole { get; set; }
    }
}
