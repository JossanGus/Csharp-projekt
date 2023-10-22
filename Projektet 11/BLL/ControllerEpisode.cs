using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repository;

namespace BLL
{
    public class ControllerEpisode /*: IGetEpisode<Episode> */
    {
        //private IGetEpisode<Episode> repositoryEpisode;
        private RepositoryEpisode repositoryEpisode;

        public ControllerEpisode()
        { 
            repositoryEpisode = new RepositoryEpisode();
        }

        public async Task<List<Episode>> AllEpisodes(string url)
        {
            return await repositoryEpisode.AllEpisodes(url);
        }
    }
}
 