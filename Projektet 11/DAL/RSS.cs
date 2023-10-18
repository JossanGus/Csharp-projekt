using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DAL
{
    public class RSSFeed
    {
        public List<SyndicationItem> RSS(string rssfeed)
        {
            List<SyndicationItem> inData = new List<SyndicationItem>();
            XmlReader reader = XmlReader.Create(rssfeed);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                String title = item.Title.Text;
                String summary = item.Summary.Text;
                inData.Add(item);
            }

            return inData;
        }
    }
}
