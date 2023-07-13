using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitecoreReceiver.WebHooks
{
    public static class SessionData
    {
        public static List<SitecoreWebhookRoot> SitecoreList { get; set; }
    }
    public class PublisherOptions
    {
        public bool CompareRevisions { get; set; }
        public bool Deep { get; set; }
        public DateTime FromDate { get; set; }
        public string Mode { get; set; }
        public DateTime PublishDate { get; set; }
        public List<string> PublishingTargets { get; set; }
        public bool RepublishAll { get; set; }
        public string RecoveryId { get; set; }
        public string SourceDatabaseName { get; set; }
        public string TargetDatabaseName { get; set; }
        public string RootItemId { get; set; }
        public string UserName { get; set; }
        public bool WillBeQueued { get; set; }
        public List<string> Languages { get; set; }
    }

    public class SharedFields
    {
        public string Id { get; set; }
        public string Value { get; set; }

    }
    public class UnversionedFields
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public string Language { get; set; }

    }
    public class VersionedFields
    {
        public string Id { get; set; }
        public string Value { get; set; }
        public int Version { get; set; }
        public string Language { get; set; }

    }
    public class Source
    {
        public string Language { get; set; }
        public int Version { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string TemplateId { get; set; }
        public string MasterId { get; set; }
        public IList<SharedFields> SharedFields { get; set; }
        public IList<UnversionedFields> UnversionedFields { get; set; }
        public IList<VersionedFields> VersionedFields { get; set; }
        public IList<string> BaseIDs { get; set; }
        public IList<string> CustomValues { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public string ID { get; set; }
        public IList<string> StandardValueHolderId { get; set; }

    }

    public class Copy
    {
        public string Language { get; set; }
        public int Version { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string TemplateId { get; set; }
        public string MasterId { get; set; }
        public IList<SharedFields> SharedFields { get; set; }
        public IList<UnversionedFields> UnversionedFields { get; set; }
        public IList<VersionedFields> VersionedFields { get; set; }

    }

    public class Status
    {
        public string CurrentLanguageName { get; set; }
        public string CurrentTargetName { get; set; }
        public bool Expired { get; set; }
        public bool Failed { get; set; }
        public bool IsDone { get; set; }
        public IList<string> Messages { get; set; }
        public int Processed { get; set; }
        public int State { get; set; }

    }

    public class Item
    {
        public string Language { get; set; }
        public int Version { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string ParentId { get; set; }
        public string TemplateId { get; set; }
        public string MasterId { get; set; }
        public IList<SharedFields> SharedFields { get; set; }
        public IList<UnversionedFields> UnversionedFields { get; set; }
        public IList<VersionedFields> VersionedFields { get; set; }

    }
    public class Template
    {
        public IList<string> BaseIDs { get; set; }
        public IList<string> CustomValues { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public IList<string> StandardValueHolderId { get; set; }

    }

    public class SourceField
    {
        public string DefaultValue { get; set; }
        public string HelpLink { get; set; }
        public string Icon { get; set; }
        public string ID { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsSharedLanguageFallbackEnabled { get; set; }
        public bool IsShared { get; set; }
        public bool IsUnversioned { get; set; }
        public bool IsVersioned { get; set; }
        public string Key { get; set; }
        public bool IsBlob { get; set; }
        public string Name { get; set; }
        public bool ResetBlank { get; set; }
        public int Sortorder { get; set; }
        public string Source { get; set; }
        public string Style { get; set; }
        public Template Template { get; set; }
        public string Type { get; set; }
        public string TypeKey { get; set; }
        public string Validation { get; set; }
        public bool ExcludeFromTextSearch { get; set; }
        public bool IgnoreDictionaryTranslations { get; set; }

    }
    public class Changes
    {
        public int Action { get; set; }
        public SourceField SourceField { get; set; }
        public IList<object> TargetField { get; set; }

    }
    public class PreferredLanguage
    {
        public string Name { get; set; }

    }
    public class PreferredVersion
    {
        public int Number { get; set; }

    }
    public class Target
    {
        public IList<string> BaseIDs { get; set; }
        public IList<string> CustomValues { get; set; }
        public string FullName { get; set; }
        public string Icon { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string StandardValueHolderId { get; set; }

    }
    public class TemplateChanges
    {
        public IList<Changes> Changes { get; set; }
        public PreferredLanguage PreferredLanguage { get; set; }
        public PreferredVersion PreferredVersion { get; set; }
        public Source Source { get; set; }
        public Target Target { get; set; }

    }
    public class SitecoreWebhookRoot
    {
        public string EventName { get; set; }
        public Item Item { get; set; }
        public TemplateChanges TemplateChanges { get; set; }
        public Status Status { get; set; }
        public PublisherOptions PublisherOptions { get; set; }
        public Source Source { get; set; }
        public Copy Copy { get; set; }
        public string WebhookItemId { get; set; }
        public string OldName { get; set; }
        public string WebhookItemName { get; set; }
        public string CompleteJson { get; set; }
    }
}