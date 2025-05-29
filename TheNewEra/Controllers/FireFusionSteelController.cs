using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheNewEra.Models.FireFusionSteel.SmallArms;
using TheNewEra.Data;

namespace TheNewEra.Controllers
{

    public class FireFusionSteelController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FireFusionSteelController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Views for Fire, Fusion, and Steel
        public IActionResult AircraftList()
        {
            return View();
        }

        public IActionResult GroundVehiclesList()
        {
            return View();
        }

        public IActionResult LiftVehiclesList()
        {
            return View();
        }

        public IActionResult SmallArmsList()
        {
            return View();
        }

        public IActionResult StarshipsList()
        {
            return View();
        }
        public IActionResult SmallArmsCreate()
        {
            return View();
        }

        // Create, Edit, Delete actions for Fire, Fusion, and Steel entities

        // Dropdown lists for Fire, Fusion, and Steel

        // Aircraft Dropdowns

        // Ground Vehicles Dropdowns

        // Lift Vehicles Dropdowns

        // Small Arms Dropdowns
        [HttpGet]
        public JsonResult GetSmallArmsAmmoTypes()
        {
            var types = _context.Set<SmallArmsAmmoTypeDropdownModel>()
                .Select(x => new SmallArmsAmmoTypeDropdownModel
                {
                    Id = x.Id,
                    Text = x.Text,
                    Modifier = x.Modifier,
                    TextModifier = x.TextModifier
                })
                .ToList();

            return Json(types);
        }

        [HttpGet]
        public JsonResult GetSmallArmsAmmoTypeModifiers()
        {
            var modifiers = _context.Set<SmallArmsAmmoTypeModifierDropdownModel>()
                .Select(x => new SmallArmsAmmoTypeModifierDropdownModel
                {
                    Id = x.Id,
                    Text = x.Text,
                    Modifier = x.Modifier,
                    TextModifier = x.TextModifier
                })
                .ToList();
            return Json(modifiers);
        }

        [HttpGet]
        public JsonResult GetSmallArmsAmmoTLTypeModifiers()
        {
            var modifiers = _context.Set<SmallArmsAmmoTLModifierDropdownModel>()
                .Select(x => new SmallArmsAmmoTLModifierDropdownModel
                {
                    Id = x.Id,
                    Text = x.Text,
                    Modifier = x.Modifier,
                    TextModifier = x.TextModifier
                })
                .ToList();
            return Json(modifiers);
        }

        [HttpGet]
        public JsonResult GetSmallArmsAmmoCartridgeTypeModifiers()
        {
            var modifiers = _context.Set<SmallArmsAmmoCartridgeTypeModifierDropdownModel>()
                .Select(x => new SmallArmsAmmoCartridgeTypeModifierDropdownModel
                {
                    Id = x.Id,
                    Text = x.Text,
                    Modifier = x.Modifier,
                    TextModifier = x.TextModifier
                })
                .ToList();
            return Json(modifiers);
        }

        [HttpGet]
        public JsonResult GetSmallArmsAmmoSpecialModifiers()
        {
            var modifiers = _context.Set<SmallArmsAmmoSpecialModifierDropdownModel>()
                .Select(x => new SmallArmsAmmoSpecialModifierDropdownModel
                {
                    Id = x.Id,
                    Text = x.Text,
                    Modifier = x.Modifier,
                    TextModifier = x.TextModifier
                })
                .ToList();
            return Json(modifiers);
        }

        // Starships Dropdowns


    }
}
