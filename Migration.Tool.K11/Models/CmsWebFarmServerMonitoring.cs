using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migration.Tool.K11.Models;

[Table("CMS_WebFarmServerMonitoring")]
public class CmsWebFarmServerMonitoring
{
    [Key]
    [Column("WebFarmServerMonitoringID")]
    public int WebFarmServerMonitoringId { get; set; }

    [Column("ServerID")]
    public int ServerId { get; set; }

    public DateTime? ServerPing { get; set; }
}
