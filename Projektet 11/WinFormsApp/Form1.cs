using BLL;
using Models;
using DAL;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ControllerPodcast controllerPodcast;
        ControllerCategory controllerCategory;

        //string thePod;

        public Form1()
        {
            InitializeComponent();
            controllerPodcast = new ControllerPodcast();
            controllerCategory = new ControllerCategory();
            fillCategory();
            fillPodView();
        }

        private void fillCategory()
        {
            var categoryList = controllerCategory.GetAll();
            lbShowCategorys.Items.Clear();
            cbCategory.Items.Clear();

            foreach (var category in categoryList)
            {
                if (categoryList != null)
                {
                    lbShowCategorys.Items.Add(category.Name);
                    cbCategory.Items.Add(category.Name);
                }
            }
        }

        public void fillEpisodeBox()
        {
            var thePod = lvPodInfo.SelectedItems[0].Text;
            if (lvPodInfo.SelectedItems.Count == 1)
            {
                var podList = controllerPodcast.GetAll();
                foreach (Podcast pod in podList)
                {
                    if (pod.Name.Equals(thePod))
                    {
                        tbPodName.Text = pod.Name;
                        tbURL.Text = pod.Url;
                    }
                }
            }
        }

        private void fillPodView()
        {
            var podcastList = controllerPodcast.GetAll();
            lvPodInfo.Items.Clear();
            foreach (var pod in podcastList)
            {
                if (podcastList != null)
                {
                    string countEpisodes = pod.EpisodeList.Count.ToString();
                    ListViewItem list = new ListViewItem(pod.Name);
                    list.SubItems.Add(pod.Category);
                    list.SubItems.Add(countEpisodes);
                    lvPodInfo.Items.Add(list);

                    lvPodInfo.Refresh();
                }
            }
        }

        private async void btAddPod_Click(object sender, EventArgs e)
        {
            try
            {
                await controllerPodcast.CreatePodcast(tbPodName.Text, tbURL.Text, cbCategory.Text);
                fillPodView();
            }
            catch (Exception)
            {

            }
        }

        private void lvPodInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbPodEpisode.Items.Clear();
            if (lvPodInfo.SelectedItems.Count == 1)
            {
                var thePod = lvPodInfo.SelectedItems[0].Text;

                foreach (Podcast pod in controllerPodcast.GetAll())
                {
                    if (pod.Name.Equals(thePod))
                    {
                        foreach (Episode episode in pod.EpisodeList)
                        {
                            lbPodEpisode.Items.Add(episode.Name);
                            fillEpisodeBox();
                        }
                    }
                }
            }
        }


        private void btAddCategory_Click(object sender, EventArgs e)
        {
            string Name = tbCategory.Text;

            Category category = new Category(Name);
            controllerCategory.CreateCategory(category);

            tbCategory.Clear();

            controllerCategory.GetAll();
            fillCategory();

        }

        private void lbPodEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbEpisodeInfo.SelectedItems.Count == 1)
        }

    }
}