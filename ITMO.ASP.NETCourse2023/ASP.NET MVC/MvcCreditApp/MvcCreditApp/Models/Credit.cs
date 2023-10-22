using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcCreditApp.Models
{
    public class Credit
    {
        // ID кредита
        [Required]
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Название")]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        [DisplayName("Период, на который выдается кредит")]
        [Required]
        public virtual int Period { get; set; }

        // Максимальная сумма кредита
        [DisplayName("Максимальная сумма кредита")]
        [Required]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [DisplayName("Процентная ставка")]
        [Required]
        public virtual int Procent { get; set; }
    }
}
