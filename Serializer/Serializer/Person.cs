using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Serializer
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfData;

        [NonSerialized]
        private string SerialNumber;

        public Person()
        {

        }
        public Person(string name, string address, string phone, DateTime dateOfData)
        {
            Name = name;
            Address = address;
            Phone = phone;
            DateOfData = dateOfData;
        }

        public void Serialize(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            DateOfData = DateTime.Now;
            formatter.Serialize(fileStream, this);
            fileStream.Close();
        }

        public static Person Deserialize(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            var person = (Person)formatter.Deserialize(fileStream);
            fileStream.Close();

            return person;
        }
        public void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
