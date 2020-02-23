using System;
using System.ComponentModel.DataAnnotations;
namespace _01_Luniakina.Models
{
    public class Person
    {

        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }


        public Person()
        {
        }
    }
}
