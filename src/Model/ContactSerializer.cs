using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace Model
{
    public static class ContactSerializer
    {
        public static void Serialize(ObservableCollection<Contact> contacts, string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (var writer = new StreamWriter(path))
            {
                writer.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        public static ObservableCollection<Contact> Deserialize(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            if (!File.Exists(path)) return new ObservableCollection<Contact>();
            using (var reader = new StreamReader(path))
            {
                var contacts = JsonConvert.
                    DeserializeObject<ObservableCollection<Contact>>(reader.ReadToEnd()) ?? 
                    new ObservableCollection<Contact>();
                return contacts;
            }
        }
    }
}
