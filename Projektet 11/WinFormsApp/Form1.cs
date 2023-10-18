using BLL;
using Models;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        ControllerPodcast controllerPodcast;

        public Form1()
        {
            InitializeComponent();
            controllerPodcast = new ControllerPodcast();
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
    }
}