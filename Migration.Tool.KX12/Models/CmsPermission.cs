using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Migration.Tool.KX12.Models;

[Table("CMS_Permission")]
[Index("ClassId", "PermissionName", Name = "IX_CMS_Permission_ClassID_PermissionName")]
[Index("ResourceId", "PermissionName", Name = "IX_CMS_Permission_ResourceID_PermissionName")]
public class CmsPermission
{
    [Key]
    [Column("PermissionID")]
    public int PermissionId { get; set; }

    [StringLength(100)]
    public string PermissionDisplayName { get; set; } = null!;

    [StringLength(100)]
    public string PermissionName { get; set; } = null!;

    [Column("ClassID")]
    public int? ClassId { get; set; }

    [Column("ResourceID")]
    public int? ResourceId { get; set; }

    [Column("PermissionGUID")]
    public Guid PermissionGuid { get; set; }

    public DateTime PermissionLastModified { get; set; }

    public string? PermissionDescription { get; set; }

    public bool? PermissionDisplayInMatrix { get; set; }

    public int? PermissionOrder { get; set; }

    public bool? PermissionEditableByGlobalAdmin { get; set; }

    [ForeignKey("ClassId")]
    [InverseProperty("CmsPermissions")]
    public virtual CmsClass? Class { get; set; }

    [InverseProperty("Permission")]
    public virtual ICollection<CmsWidgetRole> CmsWidgetRoles { get; set; } = [];

    [InverseProperty("Permission")]
    public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermissions { get; set; } = [];

    [InverseProperty("Permission")]
    public virtual ICollection<ForumsForumRole> ForumsForumRoles { get; set; } = [];

    [InverseProperty("Permission")]
    public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermissions { get; set; } = [];

    [ForeignKey("ResourceId")]
    [InverseProperty("CmsPermissions")]
    public virtual CmsResource? Resource { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("Permissions")]
    public virtual ICollection<CmsRole> Roles { get; set; } = [];
}
