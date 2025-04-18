﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration.Tool.KX12.Models;

[Table("CMS_SearchIndex")]
public class CmsSearchIndex
{
    [Key]
    [Column("IndexID")]
    public int IndexId { get; set; }

    [StringLength(200)]
    public string IndexName { get; set; } = null!;

    [StringLength(200)]
    public string IndexDisplayName { get; set; } = null!;

    [StringLength(200)]
    public string? IndexAnalyzerType { get; set; }

    public bool IndexIsCommunityGroup { get; set; }

    public string? IndexSettings { get; set; }

    [Column("IndexGUID")]
    public Guid IndexGuid { get; set; }

    public DateTime IndexLastModified { get; set; }

    public DateTime? IndexLastRebuildTime { get; set; }

    [StringLength(200)]
    public string IndexType { get; set; } = null!;

    [StringLength(200)]
    public string? IndexStopWordsFile { get; set; }

    [StringLength(200)]
    public string? IndexCustomAnalyzerAssemblyName { get; set; }

    [StringLength(200)]
    public string? IndexCustomAnalyzerClassName { get; set; }

    public int? IndexBatchSize { get; set; }

    [StringLength(10)]
    public string? IndexStatus { get; set; }

    public DateTime? IndexLastUpdate { get; set; }

    [StringLength(200)]
    public string? IndexCrawlerUserName { get; set; }

    [StringLength(200)]
    public string? IndexCrawlerFormsUserName { get; set; }

    [StringLength(200)]
    public string? IndexCrawlerUserPassword { get; set; }

    [StringLength(200)]
    public string? IndexCrawlerDomain { get; set; }

    public bool? IndexIsOutdated { get; set; }

    [StringLength(200)]
    public string IndexProvider { get; set; } = null!;

    [StringLength(200)]
    public string? IndexSearchServiceName { get; set; }

    [StringLength(200)]
    public string? IndexAdminKey { get; set; }

    [StringLength(200)]
    public string? IndexQueryKey { get; set; }

    [ForeignKey("IndexId")]
    [InverseProperty("Indices")]
    public virtual ICollection<CmsCulture> IndexCultures { get; set; } = new List<CmsCulture>();

    [ForeignKey("IndexId")]
    [InverseProperty("Indices")]
    public virtual ICollection<CmsSite> IndexSites { get; set; } = new List<CmsSite>();
}
