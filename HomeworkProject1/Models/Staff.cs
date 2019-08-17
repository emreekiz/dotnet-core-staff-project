using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HomeworkProject1.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Title  { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public string Image { get; set; }
        public static List<Staff> GetSampleData()
        {
            var person1 = new Staff
            {
                Id = 1,
                Name = "Emre",
                Surname = "Ekiz",
                Department = "Bilgi İşlem",
                Title = "Bilgisayar Mühendisi",
                Address = "1530 County Rd #155, Post, TX, 79356",
                StartDate = Convert.ToDateTime("01.01.2015"),
                BirthDate = Convert.ToDateTime("26.08.1995"),
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxKlQbecwqKkurzvZ20x6Ta0WCpD97Z1zsUfLZF7HGx-gfd1Mc"
               


            };
            var person2 = new Staff
            {
                Id = 2,
                Name = "Erdem",
                Surname = "Ekiz",
                Department = "Pazarlama",
                Title = "Satış Sorumlusu",
                Address = "742 Aspen Cir, Red Hill, PA, 18076",
                StartDate = Convert.ToDateTime("23.05.2017"),
                BirthDate = Convert.ToDateTime("11.03.1992"),
                Image = "https://image.shutterstock.com/image-vector/man-character-face-avatar-glasses-260nw-542759665.jpg"


            };
            var person3 = new Staff
            {
                Id = 3,
                Name = "Ömer",
                Surname = "Ekiz",
                Department = "Üretim",
                Title = "Üretim Müdürü",
                Address = "742 Aspen Cir, Red Hill, PA, 18076",
                StartDate = Convert.ToDateTime("11.02.2015"),
                BirthDate = Convert.ToDateTime("08.01.1963"),
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS59TrTGVMf7FVScv2aopiEKDWa0U6EMQXiCvQ3b-rr9xuul6ov"


            };
            List<Staff> sampleData=new List<Staff>();
            sampleData.Add(person1);
            sampleData.Add(person2);
            sampleData.Add(person3);

            return sampleData;
        }

    }

   
}
