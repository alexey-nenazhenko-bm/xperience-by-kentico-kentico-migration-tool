namespace Migration.Toolkit.Core.K11.Mappers;

using CMS.Globalization;
using Microsoft.Extensions.Logging;
using Migration.Toolkit.Common.Abstractions;
using Migration.Toolkit.Common.MigrationProtocol;
using Migration.Toolkit.Core.K11.Contexts;
using Migration.Toolkit.K11.Models;

public class StateInfoMapper(ILogger<StateInfoMapper> logger, PrimaryKeyMappingContext pkContext, IProtocol protocol) : EntityMapperBase<CmsState, StateInfo>(logger, pkContext, protocol)
{
    protected override StateInfo? CreateNewInstance(CmsState source, MappingHelper mappingHelper, AddFailure addFailure)
        => StateInfo.New();

    protected override StateInfo MapInternal(CmsState source, StateInfo target, bool newInstance, MappingHelper mappingHelper, AddFailure addFailure)
    {
        target.StateName = source.StateName;
        target.StateDisplayName = source.StateDisplayName;
        target.StateLastModified = source.StateLastModified;
        target.StateGUID = source.StateGuid;
        target.StateCode = source.StateCode;

        if (mappingHelper.TranslateRequiredId<CmsCountry>(k => k.CountryId, source.CountryId, out var countryId))
        {
            target.CountryID = countryId;
        }

        return target;
    }
}