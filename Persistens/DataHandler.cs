using System.IO;
using System.Globalization;
namespace Persistens
{
    public class DataHandler
    {
        private string _dataFileName;
        public string DataFileName { get; }

        public DataHandler(string dataFileName)
        {
            DataFileName = dataFileName;
        }

        public void SavePerson(Person person)
        {
            StreamWriter wr = new StreamWriter("Data.txt");
            wr.WriteLine($"{person.Name}, {person.BirthDate},{person.Height},{person.IsMarried},{person.NoOfChildren}");
            wr.Close();
        }

        public Person LoadPerson()
        {
            StreamReader sr = new StreamReader("Data.txt");
            string line = sr.ReadLine();
            if (line != null)
            {
                string[] split = line.Split(",");
                Person person = new Person(split[0], DateTime.Parse(split[1]), double.Parse(split[2]), bool.Parse(split[3]), int.Parse(split[4]));
                sr.Close();
                return person;
            }
            else
            {
                return null;
            }
        }
    }
}
