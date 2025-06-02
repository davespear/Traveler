using System.ComponentModel.DataAnnotations.Schema;

namespace TheNewEra.Models.FireFusionSteel.SmallArms
{
    [Table("SmallArmsAmmoTypeDropdown")]
    public class SmallArmsAmmoTypeDropdownModel : SmallArmsAmmoDropdownsModel { }

    [Table("SmallArmsTypeModifierDropdown")]
    public class SmallArmsAmmoManufacturingModifierDropdownModel : SmallArmsAmmoDropdownsModel { }

    [Table("SmallArmsAmmoTLModifierDropdown")]
    public class SmallArmsAmmoTLModifierDropdownModel : SmallArmsAmmoDropdownsModel { }

    [Table("SmallArmsSpecialModifierDropdown")]
    public class SmallArmsAmmoSpecialModifierDropdownModel : SmallArmsAmmoDropdownsModel { }

    public class SmallArmsAmmoDropdownsModel
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public string? TextModifier { get; set; }
        public double? Modifier { get; set; }
    }
}
