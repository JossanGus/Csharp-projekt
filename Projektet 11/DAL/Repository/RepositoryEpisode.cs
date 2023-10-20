using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Xml;
using System.Data;
using System.ServiceModel.Syndication;

namespace DAL.Repository
{
    public class RepositoryEpisode : IGetEpisode <Episode>
    {
        SerializerXML dataManager;
        List<Episode> episodeList;

        public RepositoryEpisode()
        {
            episodeList = new List<Episode>();
            dataManager = new SerializerXML();
        }

        public async Task<List<Episode>> AllEpisodes(string url)
        {

            XmlReader xmlReader = XmlReader.Create(url);
            SyndicationFeed feed = await Task.Run(() => SyndicationFeed.Load(xmlReader));

            List<Episode> episodeList = new List<Episode>();

            foreach (var item in feed.Items) 
            { 
                Episode episode = new Episode();
                episode.Name = item.Title.Text;
                episode.Description = item.Summary.Text;
                
                episodeList.Add(episode);
            }
            return episodeList;
        }

        //public void Update(int index, Episode episode)
        //{
        //    if (index >= 0)
        //    {
        //        episodeList[index] = episode;
        //    }
        //    SaveChanges();
        //}

        //public void SaveChanges()
        //{
        //    dataManager.SerializeEpisode(episodeList);
        //}

    }
}
