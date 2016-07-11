using OrientXpress_Umbraco.Models;
using System;
using System.Collections.Generic;
using Umbraco.Core;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.WebApi;

namespace OrientXpress_Umbraco.Controllers
{
    public class EventsController : UmbracoApiController
    {
        private IContentService _fetchContentService = ApplicationContext.Current.Services.ContentService;

        public IList<EventViewModel> GetEventsOverview(string alias)
        {
            var events = new List<EventViewModel>();
            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            var allContents = umbracoHelper.ContentQuery.TypedContentAtRoot();
            foreach(var content in allContents)
            {
                if(content.Children != null)
                {
                    foreach(var child in content.Children)
                    {
                        if(child.DocumentTypeAlias == alias)
                        {
                            events.Add(new EventViewModel { Title = child.GetPropertyValue<string>("title"), Content = child.GetPropertyValue<string>("content"), Date = child.GetPropertyValue<DateTime>("date") });
                        }
                    }
                }
            }

            return events;
        }
    }
}