using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myApp.Data
{
   public abstract class Entity
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [ScaffoldColumn(false)]
        public long Id { get; set; }
        public Guid Guid { get; set; }= Guid.NewGuid(); 

        public bool IsDeleted { get; set; }

        public DateTime RecordDate { get; set; }

    }
}
