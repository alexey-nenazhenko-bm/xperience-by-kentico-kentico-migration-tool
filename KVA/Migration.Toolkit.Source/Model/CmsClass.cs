namespace Migration.Toolkit.Source.Model;
// ReSharper disable InconsistentNaming

using System.Data;
using Migration.Toolkit.Common;

public interface ICmsClass: ISourceModel<ICmsClass>
{
    int ClassID { get; }
    string ClassDisplayName { get; }
    string ClassName { get; }
    bool ClassUsesVersioning { get; }
    bool ClassIsDocumentType { get; }
    bool ClassIsCoupledClass { get; }
    string ClassXmlSchema { get; }
    string ClassFormDefinition { get; }
    string ClassNodeNameSource { get; }
    string? ClassTableName { get; }
    string? ClassFormLayout { get; }
    bool? ClassShowAsSystemTable { get; }
    bool? ClassUsePublishFromTo { get; }
    bool? ClassShowTemplateSelection { get; }
    string? ClassSKUMappings { get; }
    bool? ClassIsMenuItemType { get; }
    string? ClassNodeAliasSource { get; }
    DateTime ClassLastModified { get; }
    Guid ClassGUID { get; }
    bool? ClassCreateSKU { get; }
    bool? ClassIsProduct { get; }
    bool ClassIsCustomTable { get; }
    string? ClassShowColumns { get; }
    string? ClassSearchTitleColumn { get; }
    string? ClassSearchContentColumn { get; }
    string? ClassSearchImageColumn { get; }
    string? ClassSearchCreationDateColumn { get; }
    string? ClassSearchSettings { get; }
    int? ClassInheritsFromClassID { get; }
    bool? ClassSearchEnabled { get; }
    string? ClassSKUDefaultDepartmentName { get; }
    int? ClassSKUDefaultDepartmentID { get; }
    string? ClassContactMapping { get; }
    bool? ClassContactOverwriteEnabled { get; }
    string? ClassSKUDefaultProductType { get; }
    string? ClassConnectionString { get; }
    bool? ClassIsProductSection { get; }
    string? ClassFormLayoutType { get; }
    string? ClassVersionGUID { get; }
    string? ClassDefaultObjectType { get; }
    bool? ClassIsForm { get; }
    int? ClassResourceID { get; }
    string? ClassCustomizedColumns { get; }
    string? ClassCodeGenerationSettings { get; }
    string? ClassIconClass { get; }
    string? ClassURLPattern { get; }    

    static string ISourceModel<ICmsClass>.GetPrimaryKeyName(SemanticVersion version)
    {
        return version switch
        {
            { Major: 11 } => CmsClassK11.GetPrimaryKeyName(version),
            { Major: 12 } => CmsClassK12.GetPrimaryKeyName(version),
            { Major: 13 } => CmsClassK13.GetPrimaryKeyName(version),
            _ => throw new InvalidCastException($"Invalid version {version}")
        };
    }
    static bool ISourceModel<ICmsClass>.IsAvailable(SemanticVersion version)
    {
        return version switch
        {
            { Major: 11 } => CmsClassK11.IsAvailable(version),
            { Major: 12 } => CmsClassK12.IsAvailable(version),
            { Major: 13 } => CmsClassK13.IsAvailable(version),
            _ => throw new InvalidCastException($"Invalid version {version}")
        };
    }
    static string ISourceModel<ICmsClass>.TableName => "CMS_Class";
    static string ISourceModel<ICmsClass>.GuidColumnName => "ClassGUID"; //assumtion, class Guid column doesn't change between versions
    static ICmsClass ISourceModel<ICmsClass>.FromReader(IDataReader reader, SemanticVersion version)
    {
        return version switch
        {
            { Major: 11 } => CmsClassK11.FromReader(reader, version),
            { Major: 12 } => CmsClassK12.FromReader(reader, version),
            { Major: 13 } => CmsClassK13.FromReader(reader, version),
            _ => throw new InvalidCastException($"Invalid version {version}")
        };
    }
}
public partial record CmsClassK11(int ClassID, string ClassDisplayName, string ClassName, bool ClassUsesVersioning, bool ClassIsDocumentType, bool ClassIsCoupledClass, string ClassXmlSchema, string ClassFormDefinition, string? ClassEditingPageUrl, string? ClassListPageUrl, string ClassNodeNameSource, string? ClassTableName, string? ClassViewPageUrl, string? ClassPreviewPageUrl, string? ClassFormLayout, string? ClassNewPageUrl, bool? ClassShowAsSystemTable, bool? ClassUsePublishFromTo, bool? ClassShowTemplateSelection, string? ClassSKUMappings, bool? ClassIsMenuItemType, string? ClassNodeAliasSource, int? ClassDefaultPageTemplateID, DateTime ClassLastModified, Guid ClassGUID, bool? ClassCreateSKU, bool? ClassIsProduct, bool ClassIsCustomTable, string? ClassShowColumns, string? ClassSearchTitleColumn, string? ClassSearchContentColumn, string? ClassSearchImageColumn, string? ClassSearchCreationDateColumn, string? ClassSearchSettings, int? ClassInheritsFromClassID, bool? ClassSearchEnabled, string? ClassSKUDefaultDepartmentName, int? ClassSKUDefaultDepartmentID, string? ClassContactMapping, bool? ClassContactOverwriteEnabled, string? ClassSKUDefaultProductType, string? ClassConnectionString, bool? ClassIsProductSection, int? ClassPageTemplateCategoryID, string? ClassFormLayoutType, string? ClassVersionGUID, string? ClassDefaultObjectType, bool? ClassIsForm, int? ClassResourceID, string? ClassCustomizedColumns, string? ClassCodeGenerationSettings, string? ClassIconClass, bool? ClassIsContentOnly, string? ClassURLPattern): ICmsClass, ISourceModel<CmsClassK11>
{
    public static bool IsAvailable(SemanticVersion version) => true;
    public static string GetPrimaryKeyName(SemanticVersion version) => "ClassID";   
    public static string TableName => "CMS_Class";
    public static string GuidColumnName => "ClassGUID";
    static CmsClassK11 ISourceModel<CmsClassK11>.FromReader(IDataReader reader, SemanticVersion version)
    {
        return new CmsClassK11(
            reader.Unbox<int>("ClassID"), reader.Unbox<string>("ClassDisplayName"), reader.Unbox<string>("ClassName"), reader.Unbox<bool>("ClassUsesVersioning"), reader.Unbox<bool>("ClassIsDocumentType"), reader.Unbox<bool>("ClassIsCoupledClass"), reader.Unbox<string>("ClassXmlSchema"), reader.Unbox<string>("ClassFormDefinition"), reader.Unbox<string?>("ClassEditingPageUrl"), reader.Unbox<string?>("ClassListPageUrl"), reader.Unbox<string>("ClassNodeNameSource"), reader.Unbox<string?>("ClassTableName"), reader.Unbox<string?>("ClassViewPageUrl"), reader.Unbox<string?>("ClassPreviewPageUrl"), reader.Unbox<string?>("ClassFormLayout"), reader.Unbox<string?>("ClassNewPageUrl"), reader.Unbox<bool?>("ClassShowAsSystemTable"), reader.Unbox<bool?>("ClassUsePublishFromTo"), reader.Unbox<bool?>("ClassShowTemplateSelection"), reader.Unbox<string?>("ClassSKUMappings"), reader.Unbox<bool?>("ClassIsMenuItemType"), reader.Unbox<string?>("ClassNodeAliasSource"), reader.Unbox<int?>("ClassDefaultPageTemplateID"), reader.Unbox<DateTime>("ClassLastModified"), reader.Unbox<Guid>("ClassGUID"), reader.Unbox<bool?>("ClassCreateSKU"), reader.Unbox<bool?>("ClassIsProduct"), reader.Unbox<bool>("ClassIsCustomTable"), reader.Unbox<string?>("ClassShowColumns"), reader.Unbox<string?>("ClassSearchTitleColumn"), reader.Unbox<string?>("ClassSearchContentColumn"), reader.Unbox<string?>("ClassSearchImageColumn"), reader.Unbox<string?>("ClassSearchCreationDateColumn"), reader.Unbox<string?>("ClassSearchSettings"), reader.Unbox<int?>("ClassInheritsFromClassID"), reader.Unbox<bool?>("ClassSearchEnabled"), reader.Unbox<string?>("ClassSKUDefaultDepartmentName"), reader.Unbox<int?>("ClassSKUDefaultDepartmentID"), reader.Unbox<string?>("ClassContactMapping"), reader.Unbox<bool?>("ClassContactOverwriteEnabled"), reader.Unbox<string?>("ClassSKUDefaultProductType"), reader.Unbox<string?>("ClassConnectionString"), reader.Unbox<bool?>("ClassIsProductSection"), reader.Unbox<int?>("ClassPageTemplateCategoryID"), reader.Unbox<string?>("ClassFormLayoutType"), reader.Unbox<string?>("ClassVersionGUID"), reader.Unbox<string?>("ClassDefaultObjectType"), reader.Unbox<bool?>("ClassIsForm"), reader.Unbox<int?>("ClassResourceID"), reader.Unbox<string?>("ClassCustomizedColumns"), reader.Unbox<string?>("ClassCodeGenerationSettings"), reader.Unbox<string?>("ClassIconClass"), reader.Unbox<bool?>("ClassIsContentOnly"), reader.Unbox<string?>("ClassURLPattern")                
        );
    }
    public static CmsClassK11 FromReader(IDataReader reader, SemanticVersion version)
    {
        return new CmsClassK11(
            reader.Unbox<int>("ClassID"), reader.Unbox<string>("ClassDisplayName"), reader.Unbox<string>("ClassName"), reader.Unbox<bool>("ClassUsesVersioning"), reader.Unbox<bool>("ClassIsDocumentType"), reader.Unbox<bool>("ClassIsCoupledClass"), reader.Unbox<string>("ClassXmlSchema"), reader.Unbox<string>("ClassFormDefinition"), reader.Unbox<string?>("ClassEditingPageUrl"), reader.Unbox<string?>("ClassListPageUrl"), reader.Unbox<string>("ClassNodeNameSource"), reader.Unbox<string?>("ClassTableName"), reader.Unbox<string?>("ClassViewPageUrl"), reader.Unbox<string?>("ClassPreviewPageUrl"), reader.Unbox<string?>("ClassFormLayout"), reader.Unbox<string?>("ClassNewPageUrl"), reader.Unbox<bool?>("ClassShowAsSystemTable"), reader.Unbox<bool?>("ClassUsePublishFromTo"), reader.Unbox<bool?>("ClassShowTemplateSelection"), reader.Unbox<string?>("ClassSKUMappings"), reader.Unbox<bool?>("ClassIsMenuItemType"), reader.Unbox<string?>("ClassNodeAliasSource"), reader.Unbox<int?>("ClassDefaultPageTemplateID"), reader.Unbox<DateTime>("ClassLastModified"), reader.Unbox<Guid>("ClassGUID"), reader.Unbox<bool?>("ClassCreateSKU"), reader.Unbox<bool?>("ClassIsProduct"), reader.Unbox<bool>("ClassIsCustomTable"), reader.Unbox<string?>("ClassShowColumns"), reader.Unbox<string?>("ClassSearchTitleColumn"), reader.Unbox<string?>("ClassSearchContentColumn"), reader.Unbox<string?>("ClassSearchImageColumn"), reader.Unbox<string?>("ClassSearchCreationDateColumn"), reader.Unbox<string?>("ClassSearchSettings"), reader.Unbox<int?>("ClassInheritsFromClassID"), reader.Unbox<bool?>("ClassSearchEnabled"), reader.Unbox<string?>("ClassSKUDefaultDepartmentName"), reader.Unbox<int?>("ClassSKUDefaultDepartmentID"), reader.Unbox<string?>("ClassContactMapping"), reader.Unbox<bool?>("ClassContactOverwriteEnabled"), reader.Unbox<string?>("ClassSKUDefaultProductType"), reader.Unbox<string?>("ClassConnectionString"), reader.Unbox<bool?>("ClassIsProductSection"), reader.Unbox<int?>("ClassPageTemplateCategoryID"), reader.Unbox<string?>("ClassFormLayoutType"), reader.Unbox<string?>("ClassVersionGUID"), reader.Unbox<string?>("ClassDefaultObjectType"), reader.Unbox<bool?>("ClassIsForm"), reader.Unbox<int?>("ClassResourceID"), reader.Unbox<string?>("ClassCustomizedColumns"), reader.Unbox<string?>("ClassCodeGenerationSettings"), reader.Unbox<string?>("ClassIconClass"), reader.Unbox<bool?>("ClassIsContentOnly"), reader.Unbox<string?>("ClassURLPattern")                
        );
    }
};
public partial record CmsClassK12(int ClassID, string ClassDisplayName, string ClassName, bool ClassUsesVersioning, bool ClassIsDocumentType, bool ClassIsCoupledClass, string ClassXmlSchema, string ClassFormDefinition, string? ClassEditingPageUrl, string? ClassListPageUrl, string ClassNodeNameSource, string? ClassTableName, string? ClassViewPageUrl, string? ClassPreviewPageUrl, string? ClassFormLayout, string? ClassNewPageUrl, bool? ClassShowAsSystemTable, bool? ClassUsePublishFromTo, bool? ClassShowTemplateSelection, string? ClassSKUMappings, bool? ClassIsMenuItemType, string? ClassNodeAliasSource, int? ClassDefaultPageTemplateID, DateTime ClassLastModified, Guid ClassGUID, bool? ClassCreateSKU, bool? ClassIsProduct, bool ClassIsCustomTable, string? ClassShowColumns, string? ClassSearchTitleColumn, string? ClassSearchContentColumn, string? ClassSearchImageColumn, string? ClassSearchCreationDateColumn, string? ClassSearchSettings, int? ClassInheritsFromClassID, bool? ClassSearchEnabled, string? ClassSKUDefaultDepartmentName, int? ClassSKUDefaultDepartmentID, string? ClassContactMapping, bool? ClassContactOverwriteEnabled, string? ClassSKUDefaultProductType, string? ClassConnectionString, bool? ClassIsProductSection, int? ClassPageTemplateCategoryID, string? ClassFormLayoutType, string? ClassVersionGUID, string? ClassDefaultObjectType, bool? ClassIsForm, int? ClassResourceID, string? ClassCustomizedColumns, string? ClassCodeGenerationSettings, string? ClassIconClass, bool? ClassIsContentOnly, string? ClassURLPattern): ICmsClass, ISourceModel<CmsClassK12>
{
    public static bool IsAvailable(SemanticVersion version) => true;
    public static string GetPrimaryKeyName(SemanticVersion version) => "ClassID";   
    public static string TableName => "CMS_Class";
    public static string GuidColumnName => "ClassGUID";
    static CmsClassK12 ISourceModel<CmsClassK12>.FromReader(IDataReader reader, SemanticVersion version)
    {
        return new CmsClassK12(
            reader.Unbox<int>("ClassID"), reader.Unbox<string>("ClassDisplayName"), reader.Unbox<string>("ClassName"), reader.Unbox<bool>("ClassUsesVersioning"), reader.Unbox<bool>("ClassIsDocumentType"), reader.Unbox<bool>("ClassIsCoupledClass"), reader.Unbox<string>("ClassXmlSchema"), reader.Unbox<string>("ClassFormDefinition"), reader.Unbox<string?>("ClassEditingPageUrl"), reader.Unbox<string?>("ClassListPageUrl"), reader.Unbox<string>("ClassNodeNameSource"), reader.Unbox<string?>("ClassTableName"), reader.Unbox<string?>("ClassViewPageUrl"), reader.Unbox<string?>("ClassPreviewPageUrl"), reader.Unbox<string?>("ClassFormLayout"), reader.Unbox<string?>("ClassNewPageUrl"), reader.Unbox<bool?>("ClassShowAsSystemTable"), reader.Unbox<bool?>("ClassUsePublishFromTo"), reader.Unbox<bool?>("ClassShowTemplateSelection"), reader.Unbox<string?>("ClassSKUMappings"), reader.Unbox<bool?>("ClassIsMenuItemType"), reader.Unbox<string?>("ClassNodeAliasSource"), reader.Unbox<int?>("ClassDefaultPageTemplateID"), reader.Unbox<DateTime>("ClassLastModified"), reader.Unbox<Guid>("ClassGUID"), reader.Unbox<bool?>("ClassCreateSKU"), reader.Unbox<bool?>("ClassIsProduct"), reader.Unbox<bool>("ClassIsCustomTable"), reader.Unbox<string?>("ClassShowColumns"), reader.Unbox<string?>("ClassSearchTitleColumn"), reader.Unbox<string?>("ClassSearchContentColumn"), reader.Unbox<string?>("ClassSearchImageColumn"), reader.Unbox<string?>("ClassSearchCreationDateColumn"), reader.Unbox<string?>("ClassSearchSettings"), reader.Unbox<int?>("ClassInheritsFromClassID"), reader.Unbox<bool?>("ClassSearchEnabled"), reader.Unbox<string?>("ClassSKUDefaultDepartmentName"), reader.Unbox<int?>("ClassSKUDefaultDepartmentID"), reader.Unbox<string?>("ClassContactMapping"), reader.Unbox<bool?>("ClassContactOverwriteEnabled"), reader.Unbox<string?>("ClassSKUDefaultProductType"), reader.Unbox<string?>("ClassConnectionString"), reader.Unbox<bool?>("ClassIsProductSection"), reader.Unbox<int?>("ClassPageTemplateCategoryID"), reader.Unbox<string?>("ClassFormLayoutType"), reader.Unbox<string?>("ClassVersionGUID"), reader.Unbox<string?>("ClassDefaultObjectType"), reader.Unbox<bool?>("ClassIsForm"), reader.Unbox<int?>("ClassResourceID"), reader.Unbox<string?>("ClassCustomizedColumns"), reader.Unbox<string?>("ClassCodeGenerationSettings"), reader.Unbox<string?>("ClassIconClass"), reader.Unbox<bool?>("ClassIsContentOnly"), reader.Unbox<string?>("ClassURLPattern")                
        );
    }
    public static CmsClassK12 FromReader(IDataReader reader, SemanticVersion version)
    {
        return new CmsClassK12(
            reader.Unbox<int>("ClassID"), reader.Unbox<string>("ClassDisplayName"), reader.Unbox<string>("ClassName"), reader.Unbox<bool>("ClassUsesVersioning"), reader.Unbox<bool>("ClassIsDocumentType"), reader.Unbox<bool>("ClassIsCoupledClass"), reader.Unbox<string>("ClassXmlSchema"), reader.Unbox<string>("ClassFormDefinition"), reader.Unbox<string?>("ClassEditingPageUrl"), reader.Unbox<string?>("ClassListPageUrl"), reader.Unbox<string>("ClassNodeNameSource"), reader.Unbox<string?>("ClassTableName"), reader.Unbox<string?>("ClassViewPageUrl"), reader.Unbox<string?>("ClassPreviewPageUrl"), reader.Unbox<string?>("ClassFormLayout"), reader.Unbox<string?>("ClassNewPageUrl"), reader.Unbox<bool?>("ClassShowAsSystemTable"), reader.Unbox<bool?>("ClassUsePublishFromTo"), reader.Unbox<bool?>("ClassShowTemplateSelection"), reader.Unbox<string?>("ClassSKUMappings"), reader.Unbox<bool?>("ClassIsMenuItemType"), reader.Unbox<string?>("ClassNodeAliasSource"), reader.Unbox<int?>("ClassDefaultPageTemplateID"), reader.Unbox<DateTime>("ClassLastModified"), reader.Unbox<Guid>("ClassGUID"), reader.Unbox<bool?>("ClassCreateSKU"), reader.Unbox<bool?>("ClassIsProduct"), reader.Unbox<bool>("ClassIsCustomTable"), reader.Unbox<string?>("ClassShowColumns"), reader.Unbox<string?>("ClassSearchTitleColumn"), reader.Unbox<string?>("ClassSearchContentColumn"), reader.Unbox<string?>("ClassSearchImageColumn"), reader.Unbox<string?>("ClassSearchCreationDateColumn"), reader.Unbox<string?>("ClassSearchSettings"), reader.Unbox<int?>("ClassInheritsFromClassID"), reader.Unbox<bool?>("ClassSearchEnabled"), reader.Unbox<string?>("ClassSKUDefaultDepartmentName"), reader.Unbox<int?>("ClassSKUDefaultDepartmentID"), reader.Unbox<string?>("ClassContactMapping"), reader.Unbox<bool?>("ClassContactOverwriteEnabled"), reader.Unbox<string?>("ClassSKUDefaultProductType"), reader.Unbox<string?>("ClassConnectionString"), reader.Unbox<bool?>("ClassIsProductSection"), reader.Unbox<int?>("ClassPageTemplateCategoryID"), reader.Unbox<string?>("ClassFormLayoutType"), reader.Unbox<string?>("ClassVersionGUID"), reader.Unbox<string?>("ClassDefaultObjectType"), reader.Unbox<bool?>("ClassIsForm"), reader.Unbox<int?>("ClassResourceID"), reader.Unbox<string?>("ClassCustomizedColumns"), reader.Unbox<string?>("ClassCodeGenerationSettings"), reader.Unbox<string?>("ClassIconClass"), reader.Unbox<bool?>("ClassIsContentOnly"), reader.Unbox<string?>("ClassURLPattern")                
        );
    }
};
public partial record CmsClassK13(int ClassID, string ClassDisplayName, string ClassName, bool ClassUsesVersioning, bool ClassIsDocumentType, bool ClassIsCoupledClass, string ClassXmlSchema, string ClassFormDefinition, string ClassNodeNameSource, string? ClassTableName, string? ClassFormLayout, bool? ClassShowAsSystemTable, bool? ClassUsePublishFromTo, bool? ClassShowTemplateSelection, string? ClassSKUMappings, bool? ClassIsMenuItemType, string? ClassNodeAliasSource, DateTime ClassLastModified, Guid ClassGUID, bool? ClassCreateSKU, bool? ClassIsProduct, bool ClassIsCustomTable, string? ClassShowColumns, string? ClassSearchTitleColumn, string? ClassSearchContentColumn, string? ClassSearchImageColumn, string? ClassSearchCreationDateColumn, string? ClassSearchSettings, int? ClassInheritsFromClassID, bool? ClassSearchEnabled, string? ClassSKUDefaultDepartmentName, int? ClassSKUDefaultDepartmentID, string? ClassContactMapping, bool? ClassContactOverwriteEnabled, string? ClassSKUDefaultProductType, string? ClassConnectionString, bool? ClassIsProductSection, string? ClassFormLayoutType, string? ClassVersionGUID, string? ClassDefaultObjectType, bool? ClassIsForm, int? ClassResourceID, string? ClassCustomizedColumns, string? ClassCodeGenerationSettings, string? ClassIconClass, string? ClassURLPattern, bool ClassUsesPageBuilder, bool ClassIsNavigationItem, bool ClassHasURL, bool ClassHasMetadata, int? ClassSearchIndexDataSource): ICmsClass, ISourceModel<CmsClassK13>
{
    public static bool IsAvailable(SemanticVersion version) => true;
    public static string GetPrimaryKeyName(SemanticVersion version) => "ClassID";   
    public static string TableName => "CMS_Class";
    public static string GuidColumnName => "ClassGUID";
    static CmsClassK13 ISourceModel<CmsClassK13>.FromReader(IDataReader reader, SemanticVersion version)
    {
        return new CmsClassK13(
            reader.Unbox<int>("ClassID"), reader.Unbox<string>("ClassDisplayName"), reader.Unbox<string>("ClassName"), reader.Unbox<bool>("ClassUsesVersioning"), reader.Unbox<bool>("ClassIsDocumentType"), reader.Unbox<bool>("ClassIsCoupledClass"), reader.Unbox<string>("ClassXmlSchema"), reader.Unbox<string>("ClassFormDefinition"), reader.Unbox<string>("ClassNodeNameSource"), reader.Unbox<string?>("ClassTableName"), reader.Unbox<string?>("ClassFormLayout"), reader.Unbox<bool?>("ClassShowAsSystemTable"), reader.Unbox<bool?>("ClassUsePublishFromTo"), reader.Unbox<bool?>("ClassShowTemplateSelection"), reader.Unbox<string?>("ClassSKUMappings"), reader.Unbox<bool?>("ClassIsMenuItemType"), reader.Unbox<string?>("ClassNodeAliasSource"), reader.Unbox<DateTime>("ClassLastModified"), reader.Unbox<Guid>("ClassGUID"), reader.Unbox<bool?>("ClassCreateSKU"), reader.Unbox<bool?>("ClassIsProduct"), reader.Unbox<bool>("ClassIsCustomTable"), reader.Unbox<string?>("ClassShowColumns"), reader.Unbox<string?>("ClassSearchTitleColumn"), reader.Unbox<string?>("ClassSearchContentColumn"), reader.Unbox<string?>("ClassSearchImageColumn"), reader.Unbox<string?>("ClassSearchCreationDateColumn"), reader.Unbox<string?>("ClassSearchSettings"), reader.Unbox<int?>("ClassInheritsFromClassID"), reader.Unbox<bool?>("ClassSearchEnabled"), reader.Unbox<string?>("ClassSKUDefaultDepartmentName"), reader.Unbox<int?>("ClassSKUDefaultDepartmentID"), reader.Unbox<string?>("ClassContactMapping"), reader.Unbox<bool?>("ClassContactOverwriteEnabled"), reader.Unbox<string?>("ClassSKUDefaultProductType"), reader.Unbox<string?>("ClassConnectionString"), reader.Unbox<bool?>("ClassIsProductSection"), reader.Unbox<string?>("ClassFormLayoutType"), reader.Unbox<string?>("ClassVersionGUID"), reader.Unbox<string?>("ClassDefaultObjectType"), reader.Unbox<bool?>("ClassIsForm"), reader.Unbox<int?>("ClassResourceID"), reader.Unbox<string?>("ClassCustomizedColumns"), reader.Unbox<string?>("ClassCodeGenerationSettings"), reader.Unbox<string?>("ClassIconClass"), reader.Unbox<string?>("ClassURLPattern"), reader.Unbox<bool>("ClassUsesPageBuilder"), reader.Unbox<bool>("ClassIsNavigationItem"), reader.Unbox<bool>("ClassHasURL"), reader.Unbox<bool>("ClassHasMetadata"), reader.Unbox<int?>("ClassSearchIndexDataSource")                
        );
    }
    public static CmsClassK13 FromReader(IDataReader reader, SemanticVersion version)
    {
        return new CmsClassK13(
            reader.Unbox<int>("ClassID"), reader.Unbox<string>("ClassDisplayName"), reader.Unbox<string>("ClassName"), reader.Unbox<bool>("ClassUsesVersioning"), reader.Unbox<bool>("ClassIsDocumentType"), reader.Unbox<bool>("ClassIsCoupledClass"), reader.Unbox<string>("ClassXmlSchema"), reader.Unbox<string>("ClassFormDefinition"), reader.Unbox<string>("ClassNodeNameSource"), reader.Unbox<string?>("ClassTableName"), reader.Unbox<string?>("ClassFormLayout"), reader.Unbox<bool?>("ClassShowAsSystemTable"), reader.Unbox<bool?>("ClassUsePublishFromTo"), reader.Unbox<bool?>("ClassShowTemplateSelection"), reader.Unbox<string?>("ClassSKUMappings"), reader.Unbox<bool?>("ClassIsMenuItemType"), reader.Unbox<string?>("ClassNodeAliasSource"), reader.Unbox<DateTime>("ClassLastModified"), reader.Unbox<Guid>("ClassGUID"), reader.Unbox<bool?>("ClassCreateSKU"), reader.Unbox<bool?>("ClassIsProduct"), reader.Unbox<bool>("ClassIsCustomTable"), reader.Unbox<string?>("ClassShowColumns"), reader.Unbox<string?>("ClassSearchTitleColumn"), reader.Unbox<string?>("ClassSearchContentColumn"), reader.Unbox<string?>("ClassSearchImageColumn"), reader.Unbox<string?>("ClassSearchCreationDateColumn"), reader.Unbox<string?>("ClassSearchSettings"), reader.Unbox<int?>("ClassInheritsFromClassID"), reader.Unbox<bool?>("ClassSearchEnabled"), reader.Unbox<string?>("ClassSKUDefaultDepartmentName"), reader.Unbox<int?>("ClassSKUDefaultDepartmentID"), reader.Unbox<string?>("ClassContactMapping"), reader.Unbox<bool?>("ClassContactOverwriteEnabled"), reader.Unbox<string?>("ClassSKUDefaultProductType"), reader.Unbox<string?>("ClassConnectionString"), reader.Unbox<bool?>("ClassIsProductSection"), reader.Unbox<string?>("ClassFormLayoutType"), reader.Unbox<string?>("ClassVersionGUID"), reader.Unbox<string?>("ClassDefaultObjectType"), reader.Unbox<bool?>("ClassIsForm"), reader.Unbox<int?>("ClassResourceID"), reader.Unbox<string?>("ClassCustomizedColumns"), reader.Unbox<string?>("ClassCodeGenerationSettings"), reader.Unbox<string?>("ClassIconClass"), reader.Unbox<string?>("ClassURLPattern"), reader.Unbox<bool>("ClassUsesPageBuilder"), reader.Unbox<bool>("ClassIsNavigationItem"), reader.Unbox<bool>("ClassHasURL"), reader.Unbox<bool>("ClassHasMetadata"), reader.Unbox<int?>("ClassSearchIndexDataSource")                
        );
    }
};

