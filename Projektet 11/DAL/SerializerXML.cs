using System.Xml.Serialization;
using Models;
using System.ServiceModel.Syndication;
using System.Xml;

namespace DAL
{
    internal class SerializerXML
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
            try
            {
                List<Podcast> returned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Podcast>));
            using (FileStream fileStreamIn = new FileStream("Podcast.xml", FileMode.Open, FileAccess.Read))
            {
                returned = (List<Podcast>)xmlSerializer.Deserialize(fileStreamIn);
            }

            return returned;
            }
            catch (Exception)
            {
                throw;
            }

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



        public void SerializeEpisode(List<Episode> items)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Episode>));
            using (FileStream fileStreamOut = new FileStream("Episodes.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fileStreamOut, items);
            }

        }

        public List<Episode> DeserializeEpisodes()
        {
            try
            {
                List<Episode> returned;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Episode>));
                using (FileStream fileStreamIn = new FileStream("Episodes.xml", FileMode.Open, FileAccess.Read))
                {
                    returned = (List<Episode>)xmlSerializer.Deserialize(fileStreamIn);
                }

                return returned;
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}