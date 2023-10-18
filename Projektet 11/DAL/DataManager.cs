using System.Xml.Serialization;
using Models;
using System.ServiceModel.Syndication;
using System.Xml;

namespace DAL
{
    public class DataManager
    {
        public void SerializePodcast(List<Podcast> items)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream fileStreamOut = new FileStream("Podcast.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStreamOut, items);
            }

        }

        public List<Podcast> DeserializePodcast()
        {
            List<Podcast> returned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream fileStreamIn = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
            {
                returned = (List<Podcast>)xmlSerializer.Deserialize(fileStreamIn);
            }

            return returned;

        }


        public void SerializeCategory(List<Category> items)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
            using (FileStream fileStreamOut = new FileStream("Category.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStreamOut, items);
            }

        }

        public List<Category> DeserializeCategory()
        {
            try
            {
                List<Category> returned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Category>));
                using (FileStream fileStreamIn = new FileStream("Category.xml", FileMode.Open, FileAccess.Read))
                {
                    returned = (List<Category>)xmlSerializer.Deserialize(fileStreamIn);
                }

                return returned;
            }
            catch (Exception ex)
            {
                //throw new ExceptionSerializer("Category.xml", "Fungerar inte");
                Console.WriteLine("Fel vid deserialisering: " + ex.Message);

                throw;
            }
        }



        public void SerializeEpisodes(List<Episodes> items)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Episodes>));
            using (FileStream fileStreamOut = new FileStream("Episodes.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStreamOut, items);
            }

        }

        public List<Episodes> DeserializeEpisodes()
        {
            List<Episodes> returned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Episodes>));
            using (FileStream fileStreamIn = new FileStream("Episodes.xml", FileMode.Open, FileAccess.Read))
            {
                returned = (List<Episodes>)xmlSerializer.Deserialize(fileStreamIn);
            }

            return returned;

        }

        public List<SyndicationItem> RSS(string rssfeed)
        {
            List<SyndicationItem> inData = new List<SyndicationItem>();
            XmlReader reader = XmlReader.Create(rssfeed);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            foreach (SyndicationItem item in feed.Items)
            {
                String title = item.Title.Text;
                String summary = item.Summary.Text;
                inData.Add(item);
            }

            return inData;
        }

    }
}