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
        SerializerXML dataManager;
        List<Podcast> podcastList;

        public RepositoryPodcast()
        {
            dataManager = new SerializerXML();
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

            try
            {
                podcastList = dataManager.DeserializePodcast();
            }

            catch (Exception)
            { 
            
            }

            return podcastList;
        }
        public void Create(Podcast podcast)
        {
            podcastList.Add(podcast);
            SaveChanges();
        }

        public void Delete(int index)
        {
            podcastList.RemoveAt(index);
            SaveChanges();
        }

        public void Update(int index, Podcast podcast)
        {
            if (index >= 0)
            {
                podcastList[index] = podcast;
            }

            SaveChanges();
        }

        //public void UpdateCategoryPodcast(string name, string newCategory)
        //{ 
        //    int index = GetIndex(name);
        //    if (index >= 0)
        //    {
        //        Podcast existingPodcast = podcastList[index];
        //        existingPodcast.Category = newCategory;
        //    } 
        //SaveChanges();
        //}

        public void SaveChanges()
        {
            dataManager.SerializePodcast(podcastList);
        }
    }
}
