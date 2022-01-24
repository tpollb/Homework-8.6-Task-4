using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework_8._6_Task_4
{
    public struct Person
    {
        private string fio;
        private string street;
        private int housenumber;
        private int flatnumber;
        private double mobilephone;
        private double flatphone;

        public string Fio { get => fio; set => fio = value; }
        public string Street { get => street; set => street = value; }
        public int Housenumber { get => housenumber; set => housenumber = value; }
        public int Flatnumber { get => flatnumber; set => flatnumber = value; }
        public double Mobilephone { get => mobilephone; set => mobilephone = value; }
        public double Flatphone { get => flatphone; set => flatphone = value; }

        public Person(string fio, string street, int housenumber, int flatnumber, double mobilephone, double flatphone)
        {
            this.fio = fio;
            this.street = street;
            this.housenumber = housenumber;
            this.flatnumber = flatnumber;
            this.mobilephone = mobilephone;
            this.flatphone = flatphone;
        }


        public void SaveToFile()
        {
            string filename = Globals.FilePath;

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer xser = new XmlSerializer(typeof(Person));
                xser.Serialize(fs, this);

                fs.Close();
            }
        }

        /*
        public static Person GetPerson()
        {
            Person person = new();
            string filename = Globals.FilePath;

            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer xser = new XmlSerializer(typeof(Person));
                    person = (Person)xser.Deserialize(fs);
                    fs.Close();
                }
            }
            return person;
        }
        */
    }
}
