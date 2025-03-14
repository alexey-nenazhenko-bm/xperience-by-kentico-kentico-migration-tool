using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Migration.Tool.KX12.Models;

[Table("CMS_ExternalLogin")]
[Index("UserId", Name = "IX_CMS_ExternalLogin_UserID")]
public class CmsExternalLogin
{
    [Key]
    [Column("ExternalLoginID")]
    public int ExternalLoginId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(200)]
    public string? LoginProvider { get; set; }

    [StringLength(200)]
    public string? IdentityKey { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CmsExternalLogins")]
    public virtual CmsUser User { get; set; } = null!;
}
