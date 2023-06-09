using Newtonsoft.Json;

namespace LibrariMain
{
    public class SerDeser
    {
        public static void MySerialize<T>(T zametochi)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = JsonConvert.SerializeObject(zametochi);
            File.WriteAllText(desktop + "\\MyFile.json", json);
        }
        public static T MyDeserialize<T>()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string json = File.ReadAllText(desktop + "\\MyFile.json");
            T zametochi = JsonConvert.DeserializeObject<T>(json);
            return zametochi;
        }
    }
}