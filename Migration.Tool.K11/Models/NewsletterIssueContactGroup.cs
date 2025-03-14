using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace Migration.Tool.K11.Models;

[Table("Newsletter_IssueContactGroup")]
[Index("ContactGroupId", Name = "IX_Newsletter_IssueContactGroup_ContactGroupID")]
public class NewsletterIssueContactGroup
{
    [Key]
    [Column("IssueContactGroupID")]
    public int IssueContactGroupId { get; set; }

    [Column("IssueID")]
    public int IssueId { get; set; }

    [Column("ContactGroupID")]
    public int ContactGroupId { get; set; }

    [ForeignKey("ContactGroupId")]
    [InverseProperty("NewsletterIssueContactGroups")]
    public virtual OmContactGroup ContactGroup { get; set; } = null!;
}
