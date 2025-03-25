using System.IO;
using System.Reflection;
using ModSettings;

namespace GearDecayModifier
{
    internal class GearDecayModifiersSettings : JsonModSettings
    {
        [Section("GENERAL DECAY SETTINGS")]

        [Name("Global decay Rate before pickup")]
        [Description("At what rate the items will decay before being picked up or inspected. For example, 1 is default, 0.5 is half decay, and 0 is no decay until you discover the item.")]
        [Slider(0f, 2f, 1)]
        public float decayBeforePickup = 1f;

        [Name("Bedrolls decay rate")]
        [Description("At what rate the bedroll items decay. Affects both degradation over time and when used.")]
        [Slider(0f, 2f, 1)]
        public float bedrollDecay = 1f;

        [Name("Travois decay rate")]
        [Description("At what rate the travois decay. Affects both degradation over time and when used.")]
        [Slider(0f, 2f, 1)]
        public float travoisDecay = 1f;

        // DECAY OVER TIME
        [Section("DECAY OVER TIME")]
        [Name("Global decay rate")]
        [Description("Base modifier for the rate items will decay over time (doesn't affect items that decay on use). For example, 1 is default, 0 is no decay, 0.5 is half the normal decay and 2 doubles the rate. If advanced decay is on, this rate will only be applied to items not in other categories.")]
        [Slider(0f, 2f, 1)]
        public float generalDecay = 1f;

        [Name("Advanced decay Modifiers")]
        [Description("Turn this on to make decay control more granular.")]
        public bool advDecay = false;

        [Name("Flare Gun Ammo decay rate")]
        [Description("At what rate the flare gun ammo will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 1)]
        public float flareGunAmmoSingleDecay = 1f;

        [Name("Torch decay rate")]
        [Description("At what rate the torch is burning. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 1)]
        public float torchDecay = 1f;

        [Name("Coffee Tins & Herbal Tea packages decay rate")]
        [Description("At what rate the coffee tin & herbal tea package will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 1)]
        public float coffeeTeaDecay = 1f;

        [Name("Cooking ingredients decay rate")]
        [Description("At what rate the cooking ingredients will decay. Raw Potatoes, Carrots, Old Mill Flour & Running River Oats")]
        [Slider(0f, 2f, 1)]
        public float ingredientsDecay = 1f;

        [Name("Clothing decay rate")]
        [Description("At what rate the clothing will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 1)]
        public float clothingDecay = 1f;

        [Name("Rabbit/Ptarmigan carcass decay rate")]
        [Description("At what rate the Rabbit/Ptarmigan carcasses decay.")]
        [Slider(0f, 2f, 1)]
        public float carcassDecay = 1f;

        [Name("Quarter bags decay rate")]
        [Description("At what rate the quarter bag items decay.")]
        [Slider(0f, 2f, 1)]
        public float quartersDecay = 1f;

        [Name("Food decay rate")]
        [Description("At what rate the food items decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 1)]
        public float foodDecay = 1f;

        [Name("Advanced food decay Modifiers")]
        [Description("Turn this on to make food decay control more granular.")]
        public bool advFoodDecay = false;

        [Name("Animal Fat decay rate")]
        [Description("This affects the rate at which animal fat will decay.")]
        [Slider(0f, 2f, 1)]
        public float fatDecay = 1f;

        [Name("Drinks decay rate")]
        [Description("This affects the rate at which sodas will decay.")]
        [Slider(0f, 2f, 1)]
        public float drinksDecay = 1f;

        [Name("Raw meat decay rate")]
        [Description("This affects the rate at which raw meat and fish will decay.")]
        [Slider(0f, 2f, 1)]
        public float rawMeatDecay = 1f;

        [Name("Cooked meat decay rate")]
        [Description("This affects the rate at which cooked meat and fish will decay.")]
        [Slider(0f, 2f, 1)]
        public float cookedMeatDecay = 1f;

        [Name("Cured Meat decay rate")]
        [Description("This affects the rate at which cured meat will decay.")]
        [Slider(0f, 2f, 1)]
        public float curedMeatDecay = 1f;

        [Name("Raw fish decay rate")]
        [Description("This affects the rate at which raw fish and fish will decay.")]
        [Slider(0f, 2f, 1)]
        public float rawFishDecay = 1f;

        [Name("Cooked fish decay rate")]
        [Description("This affects the rate at which cooked fish and fish will decay.")]
        [Slider(0f, 2f, 1)]
        public float cookedFishDecay = 1f;

        [Name("Cured Fish decay rate")]
        [Description("This affects the rate at which cured fish will decay.")]
        [Slider(0f, 2f, 1)]
        public float curedFishDecay = 1f;

        [Name("Packaged food decay rate")]
        [Description("This affects the rate at which packaged foods and drinks will decay.")]
        [Slider(0f, 2f, 1)]
        public float packagedFoodDecay = 1f;

        [Name("Packaged food decay rate when opened")]
        [Description("This affects the rate at which packaged foods will decay while they are open.")]
        [Slider(0f, 2f, 1)]
        public float openedFoodDecay = 1f;

        [Name("First aid items decay rate")]
        [Description("At what rate the medicine items decay.")]
        [Slider(0f, 2f, 1)]
        public float firstAidDecay = 1f;

        [Name("Fresh hide decay rate")]
        [Description("At what rate freshly harvested hide decay.")]
        [Slider(0f, 2f, 1)]
        public float freshHideDecay = 1f;

        // DECAY ON USE
        [Section("DECAY ON USE")]
        [Name("Global On Use decay rate")]
        [Description("Modifier for how much tools will decay after uses. Setting this to 0.5 would make them last twice as long, while setting this to 2 will make them last half as long.")]
        [Slider(0f, 2f, 1)]
        public float onUseDecay = 1f;

        [Name("Advanced on use decay Modifiers")]
        [Description("Turn this on to make on use decay control more granular.\nGlobal decay on use setting will still be applied for anything not covered by the foloowing categories")]
        public bool advOnUseDecay = false;

        [Name("Guns decay rate")]
        [Description("Modifies how much decay is applied when firing any gun (rifle or revolver).")]
        [Slider(0f, 2f, 1)]
        public float gunDecay = 1f;

        [Name("Bows decay rate")]
        [Description("Modifies how much decay is applied when shooting with a bow.")]
        [Slider(0f, 2f, 1)]
        public float bowDecay = 1f;

        [Name("Arrows decay rate")]
        [Description("Modifies how much decay is applied when to arrows when shot.")]
        [Slider(0f, 2f, 1)]
        public float arrowDecay = 1f;

        [Name("Fire starting gear decay rate")]
        [Description("Modifies how much decay is applied to the fire starting gear when used.")]
        [Slider(0f, 2f, 1)]
        public float firestartingDecay = 1f;

        [Name("Whetstone decay rate")]
        [Description("Modifies how much decay is applied to whetstones when used.")]
        [Slider(0f, 2f, 1)]
        public float whetstoneDecay = 1f;

        [Name("Can opener decay rate")]
        [Description("Modifies how much decay is applied to can openers when used.")]
        [Slider(0f, 2f, 1)]
        public float canOpenerDecay = 1f;

        [Name("Prybar decay rate")]
        [Description("Modifies how much decay is applied to prybars when used.")]
        [Slider(0f, 2f, 1)]
        public float prybarDecay = 1f;

        [Name("Tools decay rate")]
        [Description("Modifies how much decay is applied to tools when used, this includes knives or hatchets among others.")]
        [Slider(0f, 2f, 1)]
        public float toolsDecay = 1f;

        protected override void OnChange(FieldInfo field, object oldValue, object newValue)
        {
            if (field.Name == nameof(advDecay) || field.Name == nameof(advFoodDecay) || field.Name == nameof(advOnUseDecay))
            {
                RefreshFields();
            }
        }

        internal void RefreshFields()
        {
            SetFieldVisible(nameof(foodDecay), advDecay);
            SetFieldVisible(nameof(advFoodDecay), advDecay);
            SetFieldVisible(nameof(rawMeatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(cookedMeatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(curedMeatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(rawFishDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(cookedFishDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(curedFishDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(packagedFoodDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(openedFoodDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(clothingDecay), advDecay);
            SetFieldVisible(nameof(quartersDecay), advDecay);
            SetFieldVisible(nameof(firstAidDecay), advDecay);
            SetFieldVisible(nameof(flareGunAmmoSingleDecay), advDecay);
            SetFieldVisible(nameof(coffeeTeaDecay), advDecay);
            SetFieldVisible(nameof(gunDecay), advOnUseDecay);
            SetFieldVisible(nameof(bowDecay), advOnUseDecay);
            SetFieldVisible(nameof(arrowDecay), advOnUseDecay);
            SetFieldVisible(nameof(firestartingDecay), advOnUseDecay);
            SetFieldVisible(nameof(whetstoneDecay), advOnUseDecay);
            SetFieldVisible(nameof(prybarDecay), advOnUseDecay);
            SetFieldVisible(nameof(toolsDecay), advOnUseDecay);
        }
    }

    internal static class Settings
    {
        public static GearDecayModifiersSettings settings = new() ;

        public static void OnLoad()
        {
            settings.AddToModSettings("Gear Decay Modifier");
            settings.RefreshFields();
        }
    }
}
