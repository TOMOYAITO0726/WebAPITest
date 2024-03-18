using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPITest.Model
{
    public class HogeResultModel
    {
        [Key]
        public string Text { get; set; }

        [NotMapped]
        public int Status { get; set; }
    }
}
