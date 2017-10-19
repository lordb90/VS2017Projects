using System.ComponentModel.DataAnnotations;
using NinjaDomain.Classes.Enums;

namespace NinjaDomain.Classes
{
    public class NinjaEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipmentType Type { get; set; }
        [Required]
        public Ninja Ninja { get; set; }

    }
}
