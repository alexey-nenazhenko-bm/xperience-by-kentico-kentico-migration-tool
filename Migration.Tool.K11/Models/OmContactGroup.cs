using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration.Tool.K11.Models;

[Table("OM_ContactGroup")]
public class OmContactGroup
{
    [Key]
    [Column("ContactGroupID")]
    public int ContactGroupId { get; set; }

    [StringLength(200)]
    public string ContactGroupName { get; set; } = null!;

    [StringLength(200)]
    public string ContactGroupDisplayName { get; set; } = null!;

    public string? ContactGroupDescription { get; set; }

    public string? ContactGroupDynamicCondition { get; set; }

    public bool? ContactGroupEnabled { get; set; }

    public DateTime? ContactGroupLastModified { get; set; }

    [Column("ContactGroupGUID")]
    public Guid? ContactGroupGuid { get; set; }

    public int? ContactGroupStatus { get; set; }

    [InverseProperty("ContactGroup")]
    public virtual ICollection<NewsletterIssueContactGroup> NewsletterIssueContactGroups { get; set; } = new List<NewsletterIssueContactGroup>();

    [InverseProperty("ContactGroupMemberContactGroup")]
    public virtual ICollection<OmContactGroupMember> OmContactGroupMembers { get; set; } = new List<OmContactGroupMember>();
}
