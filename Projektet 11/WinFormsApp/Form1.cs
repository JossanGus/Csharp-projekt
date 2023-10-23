using BLL;
using Models;
using DAL;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ControllerPodcast controllerPodcast;
        ControllerCategory controllerCategory;

        string thePod;


        public Form1()
        {
            InitializeComponent();
            controllerPodcast = new ControllerPodcast();
            controllerCategory = new ControllerCategory();
            FillCategory();
            FillPodView();
        }

        private void FillCategory()
        {
            var categoryList = controllerCategory.GetAll();
            lbShowCategorys.Items.Clear();
            cbCategory.Items.Clear();

            lbShowCategorys.Items.Add("Ospecificerat");
            cbCategory.Items.Add("Ospecificerat");

            foreach (var category in categoryList)
            {
                if (categoryList != null)
                {
                    lbShowCategorys.Items.Add(category.Name);
                    cbCategory.Items.Add(category.Name);
                    cbCategoryFilter.Items.Add(category.Name);
                }
            }
        }

        public void FillEpisodeBox()
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

        private void FillPodView()
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
                FillPodView();
                ClearAllFields();
            }
            catch (Exception)
            {

            }
        }

        private void lvPodInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbPodEpisode.Items.Clear();
            tbEpisodeInfo.Clear();
            if (lvPodInfo.SelectedItems.Count == 1)
            {
                thePod = lvPodInfo.SelectedItems[0].Text;

                foreach (Podcast pod in controllerPodcast.GetAll())
                {
                    if (pod.Name.Equals(thePod))
                    {
                        foreach (Episode episode in pod.EpisodeList)
                        {
                            lbPodEpisode.Items.Add(episode.Name);
                            FillEpisodeBox();

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
            FillCategory();

        }

        private void lbPodEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbPodEpisode.SelectedItems.Count == 1)
            {
                var theEpisode = lbPodEpisode.SelectedItems[0];

                foreach (var pod in controllerPodcast.GetAll())
                {
                    foreach (var episode in pod.EpisodeList)
                    {
                        if (episode.Name.Equals(theEpisode))
                        {
                            tbEpisodeInfo.Text = episode.Description;
                        }
                    }

                }
            }
        }

        private void ClearAllFields()
        {
            tbPodName.Clear();
            cbCategory.Text = "V�lj Kategori";
            tbURL.Clear();
            tbEpisodeInfo.Clear();
            lbPodEpisode.Items.Clear();
        }

        private void btDeletePod_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = lvPodInfo.SelectedItems.Count - 1; i >= 0; i--)
                {
                    controllerPodcast.DeletePodcast(thePod);
                    FillPodView();
                    ClearAllFields();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedCategory = lbShowCategorys.SelectedItem.ToString();

                foreach (ListViewItem item in lvPodInfo.Items)
                {
                    if (item.SubItems[1].Text == selectedCategory)
                    {
                        item.SubItems[1].Text = "Ospecificerat";
                    }
                }


                controllerCategory.DeleteCategory(lbShowCategorys.SelectedItem.ToString());
                FillCategory();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btChangeCategory_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCategory = lbShowCategorys.SelectedIndex - 1;
                Category category = new Category(tbCategory.Text.ToString());
                //string oldCategory = lbShowCategorys.SelectedItem.ToString();



                if (selectedCategory >= 0)
                {
                    controllerCategory.UpdateCategory(selectedCategory, category);
                    //foreach(Podcast podcast in )
                    //{
                    //    if (podcast.Category == lbShowCategorys.SelectedItem.ToString()) 
                    //    {
                    //        podcast.Category = category;
                    //    }
                    //}

                }
                tbCategory.Clear();
                FillCategory();


            }
            catch (Exception) { throw; }
        }

        private void btChangePod_Click(object sender, EventArgs e)
        {
            var selectedItem = lvPodInfo.SelectedItems[0];
            int index = selectedItem.Index;

            string name = tbPodName.Text;
            string url = tbURL.Text;
            string category = cbCategory.Text;

            controllerPodcast.UpdatePodcast(index, name, url, category);
            FillPodView();
            tbURL.Clear();
            tbPodName.Clear();

        }

        private void cbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            var podcastList = controllerPodcast.GetAll();
            string theCategory = cbCategoryFilter.SelectedItem.ToString();

            var filteredPodcast = from thePod in podcastList
                                  where thePod.Category.Equals(theCategory) //&& thePod != null
                                  let episode = thePod.EpisodeList.Count.ToString()
                                  let selectedCategory = new ListViewItem(thePod.Name)
                                  select new { thePod, episode, selectedCategory };


            lvPodInfo.Items.Clear();
            foreach (var pod in filteredPodcast)
            {
                pod.selectedCategory.SubItems.Add(pod.thePod.Category);
                pod.selectedCategory.SubItems.Add(pod.episode);

                lvPodInfo.Items.Add(pod.selectedCategory);
            }

        }
    }

}