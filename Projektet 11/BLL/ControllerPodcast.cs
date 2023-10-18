using Models;
using DAL.Repository;

namespace BLL
{
    public class ControllerPodcast
    {
        RepositoryPodcast repositoryPodcast;
        List<Podcast> podcastList;


        public ControllerPodcast()
        {
            repositoryPodcast = new RepositoryPodcast();
            podcastList = repositoryPodcast.GetAll();
        }

        public List<Podcast> GetAll()
        {
            return repositoryPodcast.GetAll();
        }

        public async Task<Podcast> CreatePodcast(string name, string url, string category)
        {
            Podcast pod = new Podcast();
            await Task.Run(async () =>
            {
                //Podcast podcast = new Podcast(name, url, category);
                //repositoryPodcast.Create(podcast);*/
            });

            return pod;
        }

    }

}