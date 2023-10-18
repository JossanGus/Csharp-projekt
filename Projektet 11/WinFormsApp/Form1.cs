using BLL;
using Models;
using DAL;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ControllerPodcast controllerPodcast;
        ControllerCategory controllerCategory;

        public Form1()
        {
            InitializeComponent();
            controllerPodcast = new ControllerPodcast();
            controllerCategory = new ControllerCategory();
            fillCategory();
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

        public void fillPodcast()
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
                    ListViewItem list = new ListViewItem(pod.Name);
                    lvPodInfo.Items.Add(list);

                    lvPodInfo.Refresh();
                }
            }
        }

        private async void btAddPod_Click(object sender, EventArgs e)
        {
            await controllerPodcast.CreatePodcast(tbPodName.Text, tbURL.Text, cbCategory.Text);
            fillPodView();
        }

        private void lvPodInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPodcast();
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
    }
}