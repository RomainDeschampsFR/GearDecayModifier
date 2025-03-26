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
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float decayBeforePickup = 1f;

        [Name("Bedrolls")]
        [Description("At what rate the bedroll items decay. Affects both degradation over time and when used.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float bedrollDecay = 1f;

        [Name("Travois")]
        [Description("At what rate the travois decay. Affects both degradation over time and when used.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float travoisDecay = 1f;

        // DECAY OVER TIME
        [Section("DECAY OVER TIME")]
        [Name("Global")]
        [Description("Base modifier for the rate items will decay over time (doesn't affect items that decay on use). For example, 1 is default, 0 is no decay, 0.5 is half the normal decay and 2 doubles the rate. If advanced decay is on, this rate will only be applied to items not in other categories.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float generalDecay = 1f;

        [Name("Advanced decay Modifiers")]
        [Description("Turn this on to make decay control more granular.")]
        public bool advDecay = false;

        [Name("Flare Gun Ammunition")]
        [Description("At what rate the flare gun ammo will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float flareGunAmmoSingleDecay = 1f;

        [Name("Arrows")]
        [Description("Modifies how much decay is applied when to arrows when shot.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float arrowDecay = 1f;

        [Name("Snare")]
        [Description("At what rate the snares will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float snareDecay = 1f;

        [Name("Cooking pots")]
        [Description("At what rate recylced Can, Cooking Pot and skillet will decay when left emptied on a fire. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float cookingPotDecay = 1f;

        [Name("Coffee Tins & Herbal Tea Packages")]
        [Description("At what rate the coffee tin & herbal tea package will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float coffeeTeaDecay = 1f;

        [Name("Cooking Ingredients")]
        [Description("At what rate the cooking ingredients will decay. Raw Potatoes, Carrots, Old Mill Flour & Running River Oats")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float ingredientsDecay = 1f;

        [Name("Clothing")]
        [Description("At what rate the clothing will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float clothingDecay = 1f;

        [Name("Quarter bags & Rabbit/Ptarmigan Carcasses")]
        [Description("At what rate the quarter bags & Rabbit/Ptarmigan Carcasses items decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float bodyHarvestDecay = 1f;

        [Name("Fresh hides")]
        [Description("At what rate the fresh hides/pelts items decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float hideDecay = 1f;

        [Name("First aid items")]
        [Description("At what rate the medicine items decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float firstAidDecay = 1f;

        [Name("Water Purification Tablets")]
        [Description("At what rate the Water Purification Tablets will decay. For example, 1 is default, 0.5 is half decay, and 0 is no decay at all.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float waterPurifierDecay = 1f;

        [Section("FOOD SETTINGS")]
        [Name("Food")]
        [Description("At what rate the food items decay. This value will be ignored if Advanced Food Decay Modifier is enabled")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float foodDecay = 1f;

        [Name("Advanced food decay Modifiers")]
        [Description("Turn this on to make food decay control more granular.")]
        public bool advFoodDecay = false;

        [Name("Animal Fat")]
        [Description("This affects the rate at which animal fat will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float fatDecay = 1f;

        [Name("Raw meat")]
        [Description("This affects the rate at which raw meat and fish will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float rawMeatDecay = 1f;

        [Name("Cooked meat")]
        [Description("This affects the rate at which cooked meat and fish will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float cookedMeatDecay = 1f;

        [Name("Cured Meat")]
        [Description("This affects the rate at which cured meat will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float curedMeatDecay = 1f;

        [Name("Raw fish")]
        [Description("This affects the rate at which raw fish and fish will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float rawFishDecay = 1f;

        [Name("Cooked fish")]
        [Description("This affects the rate at which cooked fish and fish will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float cookedFishDecay = 1f;

        [Name("Cured Fish")]
        [Description("This affects the rate at which cured fish will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float curedFishDecay = 1f;

        [Name("Drinks")]
        [Description("This affects the rate at which sodas will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float drinksDecay = 1f;

        [Name("Packaged food")]
        [Description("This affects the rate at which packaged foods will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float packagedFoodDecay = 1f;

        [Name("Canned food")]
        [Description("This affects the rate at which non-opened canned foods will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float cannedFoodDecay = 1f;

        [Name("Other food")]
        [Description("This affects the rate at which cooked meals and opened canned food will decay.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float otherFoodDecay = 1f;

        // DECAY ON USE
        [Section("DECAY ON USE")]
        [Name("Global On Use")]
        [Description("Modifier for how much tools will decay after uses. Setting this to 0.5 would make them last twice as long, while setting this to 2 will make them last half as long.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float onUseDecay = 1f;

        [Name("Advanced on use decay Modifiers")]
        [Description("Turn this on to make on use decay control more granular.\nGlobal decay on use setting will still be applied for anything not covered by the foloowing categories")]
        public bool advOnUseDecay = false;

        [Name("Guns")]
        [Description("Modifies how much decay is applied when firing any gun (rifles, revolvers and flare gun).")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float gunDecay = 1f;

        [Name("Bows")]
        [Description("Modifies how much decay is applied when shooting with a bow.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float bowDecay = 1f;

        [Name("Fire starting gear")]
        [Description("Modifies how much decay is applied to the fire starting gear when used.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float firestartingDecay = 1f;

        [Name("Whetstone")]
        [Description("Modifies how much decay is applied to whetstones when used.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float whetstoneDecay = 1f;

        [Name("Can opener")]
        [Description("Modifies how much decay is applied to can openers when used.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float canOpenerDecay = 1f;

        [Name("Prybar")]
        [Description("Modifies how much decay is applied to prybars when used.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
        public float prybarDecay = 1f;

        [Name("Tools")]
        [Description("Modifies how much decay is applied to tools when used, this includes knives or hatchets among others.")]
        [Slider(0f, 2f, 41, NumberFormat = "{0:0.00}")]
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

            SetFieldVisible(nameof(clothingDecay), advDecay);
            SetFieldVisible(nameof(bodyHarvestDecay), advDecay);
            SetFieldVisible(nameof(firstAidDecay), advDecay);
            SetFieldVisible(nameof(flareGunAmmoSingleDecay), advDecay);
            SetFieldVisible(nameof(arrowDecay), advDecay);
            SetFieldVisible(nameof(coffeeTeaDecay), advDecay);
            SetFieldVisible(nameof(foodDecay), advDecay);
            SetFieldVisible(nameof(advFoodDecay), advDecay);
            SetFieldVisible(nameof(fatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(rawMeatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(cookedMeatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(curedMeatDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(rawFishDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(cookedFishDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(curedFishDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(drinksDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(packagedFoodDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(cannedFoodDecay), advDecay && advFoodDecay);
            SetFieldVisible(nameof(otherFoodDecay), advDecay && advFoodDecay);
            // ON USE DECAY
            SetFieldVisible(nameof(gunDecay), advOnUseDecay);
            SetFieldVisible(nameof(bowDecay), advOnUseDecay);
            SetFieldVisible(nameof(firestartingDecay), advOnUseDecay);
            SetFieldVisible(nameof(whetstoneDecay), advOnUseDecay);
            SetFieldVisible(nameof(canOpenerDecay), advOnUseDecay);
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
