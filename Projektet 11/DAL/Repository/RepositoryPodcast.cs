using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
using DAL;
using Models;

namespace DAL.Repository
{
    public class RepositoryPodcast : IRepository<Podcast>
    {
        DataManager dataManager;
        List<Podcast> podcastList;

        public RepositoryPodcast()
        {
            dataManager = new DataManager();
            podcastList = new List<Podcast>();
            podcastList = GetAll();
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(x => x.Name.Equals(name));
        }

        public List<Podcast> GetAll()
        {
            List<Podcast> podcastList = new List<Podcast>();

            return podcastList;
        }
        public void Create(Podcast podcast)
        {
            podcastList.Add(podcast);
        }

        public void Delete(int index)
        {
            podcastList.RemoveAt(index);
        }

        public void Update(int index, Podcast podcast)
        {
            if (index >= 0)
            {
                podcastList[index] = podcast;
            }
        }

        public void SaveChanges()
        {
            dataManager.SerializePodcast(podcastList);
        }
    }
}
