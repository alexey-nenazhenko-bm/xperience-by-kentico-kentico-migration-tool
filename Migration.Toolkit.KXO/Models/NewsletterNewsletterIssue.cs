﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Migration.Toolkit.KXO.Models
{
    [Table("Newsletter_NewsletterIssue")]
    [Index("IssueNewsletterId", Name = "IX_Newsletter_NewsletterIssue_IssueNewsletterID")]
    [Index("IssueScheduledTaskId", Name = "IX_Newsletter_NewsletterIssue_IssueScheduledTaskID")]
    [Index("IssueSiteId", Name = "IX_Newsletter_NewsletterIssue_IssueSiteID")]
    [Index("IssueTemplateId", Name = "IX_Newsletter_NewsletterIssue_IssueTemplateID")]
    [Index("IssueVariantOfIssueId", Name = "IX_Newsletter_NewsletterIssue_IssueVariantOfIssueID")]
    public partial class NewsletterNewsletterIssue
    {
        public NewsletterNewsletterIssue()
        {
            InverseIssueVariantOfIssue = new HashSet<NewsletterNewsletterIssue>();
            NewsletterAbtestTestWinnerIssues = new HashSet<NewsletterAbtest>();
            NewsletterEmails = new HashSet<NewsletterEmail>();
            NewsletterLinks = new HashSet<NewsletterLink>();
            NewsletterOpenedEmails = new HashSet<NewsletterOpenedEmail>();
            NewsletterUnsubscriptions = new HashSet<NewsletterUnsubscription>();
        }

        [Key]
        [Column("IssueID")]
        public int IssueId { get; set; }
        [StringLength(450)]
        public string IssueSubject { get; set; } = null!;
        public string IssueText { get; set; } = null!;
        public int IssueUnsubscribed { get; set; }
        [Column("IssueNewsletterID")]
        public int IssueNewsletterId { get; set; }
        [Column("IssueTemplateID")]
        public int? IssueTemplateId { get; set; }
        public int IssueSentEmails { get; set; }
        public DateTime? IssueMailoutTime { get; set; }
        [Column("IssueGUID")]
        public Guid IssueGuid { get; set; }
        public DateTime IssueLastModified { get; set; }
        [Column("IssueSiteID")]
        public int IssueSiteId { get; set; }
        public int? IssueOpenedEmails { get; set; }
        public int? IssueBounces { get; set; }
        public int? IssueStatus { get; set; }
        [Column("IssueIsABTest")]
        public bool? IssueIsAbtest { get; set; }
        [Column("IssueVariantOfIssueID")]
        public int? IssueVariantOfIssueId { get; set; }
        [StringLength(200)]
        public string? IssueVariantName { get; set; }
        [StringLength(200)]
        public string? IssueSenderName { get; set; }
        [StringLength(254)]
        public string? IssueSenderEmail { get; set; }
        [Column("IssueScheduledTaskID")]
        public int? IssueScheduledTaskId { get; set; }
        [Column("IssueUTMSource")]
        [StringLength(200)]
        public string? IssueUtmsource { get; set; }
        [Column("IssueUseUTM")]
        public bool IssueUseUtm { get; set; }
        [Column("IssueUTMCampaign")]
        [StringLength(200)]
        public string? IssueUtmcampaign { get; set; }
        [StringLength(200)]
        public string IssueDisplayName { get; set; } = null!;
        public string? IssueWidgets { get; set; }
        public string? IssuePreheader { get; set; }
        public string? IssuePlainText { get; set; }
        public bool IssueForAutomation { get; set; }

        [ForeignKey("IssueNewsletterId")]
        [InverseProperty("NewsletterNewsletterIssues")]
        public virtual NewsletterNewsletter IssueNewsletter { get; set; } = null!;
        [ForeignKey("IssueSiteId")]
        [InverseProperty("NewsletterNewsletterIssues")]
        public virtual CmsSite IssueSite { get; set; } = null!;
        [ForeignKey("IssueTemplateId")]
        [InverseProperty("NewsletterNewsletterIssues")]
        public virtual NewsletterEmailTemplate? IssueTemplate { get; set; }
        [ForeignKey("IssueVariantOfIssueId")]
        [InverseProperty("InverseIssueVariantOfIssue")]
        public virtual NewsletterNewsletterIssue? IssueVariantOfIssue { get; set; }
        [InverseProperty("TestIssue")]
        public virtual NewsletterAbtest NewsletterAbtestTestIssue { get; set; } = null!;
        [InverseProperty("IssueVariantOfIssue")]
        public virtual ICollection<NewsletterNewsletterIssue> InverseIssueVariantOfIssue { get; set; }
        [InverseProperty("TestWinnerIssue")]
        public virtual ICollection<NewsletterAbtest> NewsletterAbtestTestWinnerIssues { get; set; }
        [InverseProperty("EmailNewsletterIssue")]
        public virtual ICollection<NewsletterEmail> NewsletterEmails { get; set; }
        [InverseProperty("LinkIssue")]
        public virtual ICollection<NewsletterLink> NewsletterLinks { get; set; }
        [InverseProperty("OpenedEmailIssue")]
        public virtual ICollection<NewsletterOpenedEmail> NewsletterOpenedEmails { get; set; }
        [InverseProperty("UnsubscriptionFromIssue")]
        public virtual ICollection<NewsletterUnsubscription> NewsletterUnsubscriptions { get; set; }
    }
}
