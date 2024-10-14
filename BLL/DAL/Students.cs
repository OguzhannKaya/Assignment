using System.ComponentModel.DataAnnotations;

namespace BLL.DAL
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)] //Saati göz ardı etmek için öğrenip uyguladım.
        public DateTime BirthDate { get; set; }
        public decimal GPA { get; set; }
    }
}
