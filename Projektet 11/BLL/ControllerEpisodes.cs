using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repository;

namespace BLL
{
    public class ControllerEpisodes
    {
        IGetEpisode<Episode> repositoryEpisode;


        public ControllerEpisodes()
        { 
            repositoryEpisode = new RepositoryEpisode();
        }

        public async Task<List<Episode>> AllEpisodes(string url)
        {
            return await repositoryEpisode.AllEpisodes(url);
        }
    }
}
 