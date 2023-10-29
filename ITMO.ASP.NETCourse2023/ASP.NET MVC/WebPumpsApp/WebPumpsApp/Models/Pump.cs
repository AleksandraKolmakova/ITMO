using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebPumpsApp.Models
{
    public class Pump
    {
        // ID насоса
        public virtual int PumpId { get; set; }

        [DisplayName("Тип")]
        [Required]
        public virtual string Head { get; set; }

        [DisplayName("Подача, м3/ч")]
        [Required]
        public virtual int Flow { get; set; }

        [DisplayName("Напор, м")]
        [Required]
        public virtual int Pressure { get; set; }

        [DisplayName("Мощность, кВт")]
        [Required]
        public virtual double Power { get; set; }

        [DisplayName("Размер входного патрубка, мм")]
        [Required]
        public virtual int IntDiam { get; set; }

        [DisplayName("Размер выходного патрубка, мм")]
        [Required]
        public virtual int OutdDiam { get; set; }

        [DisplayName("Масса, кг")]
        [Required]
        public virtual double Weight { get; set; }
    }
}
