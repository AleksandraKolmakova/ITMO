using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebPumpsApp.Models
{
    public class Bid
    {
        // ID заявки
        public virtual int BidId { get; set; }

        [Required]
        [DisplayName("Имя покупателя/название организации")]
        public virtual string Name { get; set; }

        [DisplayName("Тип насоса")]
        public virtual string PumpHead { get; set; }

        [DisplayName("Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        [Required]
        public virtual DateTime bidDate { get; set; }
    }
}
