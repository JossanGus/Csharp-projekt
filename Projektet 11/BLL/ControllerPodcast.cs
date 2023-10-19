using Models;
using DAL.Repository;

namespace BLL
{
    public class ControllerPodcast
    {
        RepositoryPodcast repositoryPodcast;
        RepositoryEpisode repositoryEpisode;
        List<Podcast> podcastList;


        public ControllerPodcast()
        {
            repositoryPodcast = new RepositoryPodcast();
            repositoryEpisode = new RepositoryEpisode();
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
                List<Episode> episodeList = await repositoryEpisode.AllEpisodes(url);

                Podcast podcast = new Podcast(name, url, category, episodeList);
                repositoryPodcast.Create(podcast);
            });

            return pod;
        }

        public void DeletePodcast(string name)
        {
            int index = repositoryPodcast.GetIndex(name);
            repositoryPodcast.Delete(index);
        }

    }

}