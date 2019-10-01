using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuschussAntragHelfer
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public DateTime Geburtsdatum { get; set; }
        public string Adresse { get; set; }
        public string Ort { get; set; }
        public int getAge()
        {
            var now = DateTime.Now;
            int age = now.Year - Geburtsdatum.Year;

            if (now.Month < Geburtsdatum.Month || (now.Month == Geburtsdatum.Month && now.Day < Geburtsdatum.Day))
                age--;

            return age;
        }
    }
}
