using CMS.Membership;

using Microsoft.Extensions.Logging;

using Migration.Tool.Common.Abstractions;
using Migration.Tool.Common.MigrationProtocol;
using Migration.Tool.Core.K11.Contexts;
using Migration.Tool.K11.Models;

namespace Migration.Tool.Core.K11.Mappers;

public class RoleInfoMapper(
    ILogger<RoleInfoMapper> logger,
    PrimaryKeyMappingContext primaryKeyMappingContext,
    IProtocol protocol)
    : EntityMapperBase<CmsRole, RoleInfo>(logger, primaryKeyMappingContext, protocol)
{
    protected override RoleInfo? CreateNewInstance(CmsRole source, MappingHelper mappingHelper, AddFailure addFailure) => new();

    protected override RoleInfo MapInternal(CmsRole source, RoleInfo target, bool newInstance, MappingHelper mappingHelper, AddFailure addFailure)
    {
        target.RoleDisplayName = source.RoleDisplayName;
        target.RoleName = source.RoleName;
        target.RoleDescription = source.RoleDescription;
        target.RoleGUID = source.RoleGuid;
        target.RoleLastModified = source.RoleLastModified;
        return target;
    }
}
