using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.WebHooks;
using Newtonsoft.Json.Linq;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Web.Services.Description;

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
            SitecoreWebhookRoot data = null;

            switch (SitecoreJsonWebHookReceiver.ContentType)
            {
                case "application/json":
                    // Get JSON from WebHook
                    JObject jObject = context.GetDataOrDefault<JObject>();
                    data = context.GetDataOrDefault<SitecoreWebhookRoot>();
                    data.CompleteData = jObject.ToString();

                    if (SessionData.SitecoreList == null) { SessionData.SitecoreList = new List<SitecoreWebhookRoot>(); }
                    SessionData.SitecoreList.Add(data);

                    break;
                case "application/xml":
                    //to implement for xml
                    data.CompleteData = context.Request.Content.ToString();

                    if (SessionData.SitecoreList == null) { SessionData.SitecoreList = new List<SitecoreWebhookRoot>(); }
                    SessionData.SitecoreList.Add(data);

                    break;
                default:
                    break;
            }               

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

}
