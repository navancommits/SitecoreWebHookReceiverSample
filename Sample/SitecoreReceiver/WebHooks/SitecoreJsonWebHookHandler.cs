using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;

namespace SitecoreReceiver.WebHooks
{
    public class SitecoreJsonWebHookHandler : WebHookHandler
    {
        public SitecoreJsonWebHookHandler()
        {
          this.Receiver = SitecoreJsonWebHookReceiver.ReceiverName;
        }

        public override Task ExecuteAsync(string receiver, WebHookHandlerContext context)
        {
            // Get JSON from WebHook
            JObject jObject = context.GetDataOrDefault<JObject>();
            SitecoreWebhookRoot data = context.GetDataOrDefault<SitecoreWebhookRoot>();

            switch (data.EventName.ToLowerInvariant())
            {
                case "item:deleting":

                    break;
                case "item:deleted":

                    break;
                case "item:added":

                    break;
                case "item:cloneadded":

                    break;
                case "item:copied":

                    break;
                case "item:moved":

                    break;
                case "item:renamed":

                    break;
                case "item:saved":

                    break;
                case "item:locked":

                    break;
                case "item:unlocked":

                    break;
                case "item:versionadded":

                    break;
                case "item:versionremoved":

                    break;
                case "item:templatechanged":

                    break;
                case "item:sortorderchanged":

                    break;
                case "publish:begin":

                    break;
                case "publish:end":

                    break;
                case "publish:fail":

                    break;
                case "publish:statusupdated":

                    break;
                default:
                    break;
            }


            // Get the action for this WebHook coming from the action query parameter in the URI
            string action = context.Actions.FirstOrDefault();

            return Task.FromResult(true);
        }
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

    }
}
