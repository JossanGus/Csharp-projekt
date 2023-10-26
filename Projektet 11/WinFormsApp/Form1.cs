using BLL;
using Models;
using DAL;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ControllerPodcast controllerPodcast;
        ControllerCategory controllerCategory;
        validation validation;

        string thePod;


        public Form1()
        {
            InitializeComponent();
            controllerPodcast = new ControllerPodcast();
            controllerCategory = new ControllerCategory();
            validation = new validation();

            DefaultCategory();
            FillCategory();
            FillPodView();
        }

        private void DefaultCategory()
        {
            if (controllerCategory.GetAll().Count <= 0)
            {
                string Name = "Ospecificerat";
                Category category = new Category(Name);
                controllerCategory.CreateCategory(category);
            }
        }

        private void FillCategory()
        {
            var categoryList = controllerCategory.GetAll();
            lbShowCategorys.Items.Clear();
            cbCategory.Items.Clear();
            cbCategoryFilter.Items.Clear();

            try
            {

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
            catch (Exception)
            {

            }
        }
        private void FillPodView()
        {
            var podcastList = controllerPodcast.GetAll();
            lvPodInfo.Items.Clear();

            try { 

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
            catch (Exception)
            {

            }
        }



        private async void btAddPod_Click(object sender, EventArgs e)
        {
            string podName = tbPodName.Text;
            string podURL = tbURL.Text;
            string podCategory = cbCategory.Text;

            try
            {
                if (validation.NotEmpty(podName) && validation.CheckURL(podURL) && validation.NotEmpty(podCategory)) 
                { 
                await controllerPodcast.CreatePodcast(podName, podURL, podCategory);
                FillPodView();
                ClearAllFields();
                }
                else
                {
                    MessageBox.Show("Ett eller flera fält är ej korrekt ifyllda");
                }
            }
            catch (Exception)
            {

            }
        }

        private async void lvPodInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbPodEpisode.Items.Clear();
            tbEpisodeInfo.Clear();

            try { 

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

                        }

                        tbPodName.Text = pod.Name;
                        tbURL.Text = pod.Url;
                        cbCategory.Text = pod.Category;
                    }
                }

            }


        }
            catch (Exception)
            {

            }
        }


        private void btAddCategory_Click(object sender, EventArgs e)
        {
            string Name = tbCategory.Text;

            try { 

            if (validation.NotEmpty(Name))
            {
                Category category = new Category(Name);

                controllerCategory.CreateCategory(category);
                tbCategory.Clear();
                FillCategory();

            }
            else
            {
                MessageBox.Show("Fält får ej va tomt");
            }

            }
            catch (Exception)
            {

            }
        }

        public static string FormatString(string value)
        {
            var step1 = Regex.Replace(value, @"<[^>]+>", "").Trim();
            var step2 = Regex.Replace(step1, @"&nbsp;", " ");
            var step3 = Regex.Replace(step2, @"\s{2,}", " ");

            return step3;
        }
        private void lbPodEpisode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (lbPodEpisode.SelectedItems.Count == 1)
            {
                var theEpisode = lbPodEpisode.SelectedItems[0];

                foreach (var pod in controllerPodcast.GetAll())
                {
                    foreach (var episode in pod.EpisodeList)
                    {
                        if (episode.Name.Equals(theEpisode))
                        {
                            string htmlDescription = episode.Description;

                            string cleanedDescription = FormatString(htmlDescription);

                            tbEpisodeInfo.Text = cleanedDescription;
                        }
                    }

                }
            }
        }
            catch (Exception)
            {

            }
        }

        private void ClearAllFields()
        {
            tbPodName.Clear();
            cbCategory.Text = "Välj Kategori";
            tbURL.Clear();
            tbEpisodeInfo.Clear();
            lbPodEpisode.Items.Clear();
            cbCategoryFilter.Text = "Filtrera podcast";
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
                var podcastList = controllerPodcast.GetAll();
                string oldCategory = lbShowCategorys.SelectedItem.ToString();
                string defaultCategory = lbShowCategorys.Items[0].ToString();

                var defaultCategoryPod = from thePod in podcastList
                                        where thePod.Category.Equals(oldCategory)
                                        select thePod; 

                foreach (Podcast pod in defaultCategoryPod)
                {
                    
                    controllerPodcast.UpdateCategoryPod(pod, defaultCategory);
                }

                controllerCategory.DeleteCategory(lbShowCategorys.SelectedItem.ToString());
                FillCategory();
                lvPodInfo.Items.Clear();
                FillPodView();

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
                string newCategory = tbCategory.Text.ToString();
                int selectedCategory = lbShowCategorys.SelectedIndex;
                string oldCategory = lbShowCategorys.SelectedItem.ToString();
                Category category = new Category(newCategory);
                var podcastList = controllerPodcast.GetAll();

                var changeCategoryPod = from thePod in podcastList
                                        where thePod.Category.Equals(oldCategory)
                                        select thePod;



                if (validation.NotEmpty(newCategory) &&  selectedCategory >= 0)
                {
                    controllerCategory.UpdateCategory(selectedCategory, category);

                    foreach (Podcast pod in changeCategoryPod)
                    {
                        controllerPodcast.UpdateCategoryPod(pod, newCategory);
                    }

                }
                else { MessageBox.Show("Fält får ej va tomma"); }
                tbCategory.Clear();
                lvPodInfo.Items.Clear();
                FillPodView();
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

        private void btRensaListan_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            FillPodView();
        }
    }

}