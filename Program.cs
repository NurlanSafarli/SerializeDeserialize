using Newtonsoft.Json;

namespace SerializeDeserializeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = @"C:\\Users\\nurla\\OneDrive\\Desktop\\AB202 task\\SerializeDeserializeTask\\Files\\nurlan.json";
          

            List<string> namesList = new List<string>();

            namesList.Add("nurlan");
            namesList.Add("nurlan");
            namesList.Add("nurlan");
            namesList.Add("nurlan");
            namesList.Add("nurlan2");
            namesList.Remove("nurlan2");





            File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(namesList));

            void Add(string name)
            {
                string jsonData = File.ReadAllText(jsonFilePath);

                List<string> existingNames = JsonConvert.DeserializeObject<List<string>>(jsonData);

                existingNames.Add(name);

                File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(existingNames));
            }

             bool Search(string name, Predicate<string> match)
            {
                string jsonData = File.ReadAllText(jsonFilePath);

                List<string> existingNames = JsonConvert.DeserializeObject<List<string>>(jsonData);

                return existingNames.Exists(match);
            }
             void Delete(string name)
            {
                string jsonData = File.ReadAllText(jsonFilePath);

                List<string> existingNames = JsonConvert.DeserializeObject<List<string>>(jsonData);

                existingNames.Remove(name);

                File.WriteAllText(jsonFilePath, JsonConvert.SerializeObject(existingNames));
            }


        }
    }
}