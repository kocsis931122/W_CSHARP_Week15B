using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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

        public Person(string name, string address, string phone, DateTime dateOfData)
        {
            Name = name;
            Address = address;
            Phone = phone;
            DateOfData = dateOfData;
        }

        public void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
