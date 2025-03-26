using System.Reflection;
using UnityEngine;
using MelonLoader;
using Il2Cpp;

namespace GearDecayModifier
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Settings.OnLoad();
        }

        public static float ApplyDecayModifier(GearItem gi)
        {
            float decay_multiplier = 1f;

            //Before pickup decay
            if (!gi.m_BeenInspected && !gi.m_BeenInPlayerInventory) decay_multiplier *= Settings.settings.decayBeforePickup;

            if (gi.m_Bed)
            {
                decay_multiplier *= Settings.settings.bedrollDecay;
            }
            else if (gi.m_Travois)
            {
                decay_multiplier *= Settings.settings.travoisDecay;
            }
            else
            {
                if (!gi.m_DegradeOnUse)
                {
                    //Natural degrade
                    //if advanced decay
                    if (Settings.settings.advDecay)
                    {
                        if (gi.m_FlareGunRoundItem)
                        {
                            decay_multiplier *= Settings.settings.flareGunAmmoSingleDecay;
                        }
                        else if (gi.m_SnareItem)
                        {
                            decay_multiplier *= Settings.settings.snareDecay;
                        }
                        else if (gi.m_PurifyWater)
                        {
                            decay_multiplier *= Settings.settings.waterPurifierDecay;
                        }
                        else if (gi.m_CookingPotItem)
                        {
                            decay_multiplier *= Settings.settings.cookingPotDecay;
                        }
                        else if (gi.name == "GEAR_CoffeeTin" || gi.name == "GEAR_GreenTeaPackage")
                        {
                            decay_multiplier *= Settings.settings.coffeeTeaDecay;
                        }
                        else if (gi.name == "GEAR_Potato" || gi.name == "GEAR_Carrot" || gi.name == "GEAR_Flour" || gi.name == "GEAR_OatsTin")
                        {
                            decay_multiplier *= Settings.settings.ingredientsDecay;
                        }
                        else if (gi.m_ClothingItem)
                        {
                            decay_multiplier *= Settings.settings.clothingDecay;
                        }
                        else if (gi.m_BodyHarvest)
                        {
                            decay_multiplier *= Settings.settings.bodyHarvestDecay;
                        }
                        else if (gi.m_EvolveItem)
                        {
                            decay_multiplier *= Settings.settings.hideDecay;
                        }
                        else if (gi.m_ArrowItem)
                        {
                            decay_multiplier *= Settings.settings.arrowDecay;
                        }
                        else if (gi.m_FirstAidItem)
                        {
                            decay_multiplier *= Settings.settings.firstAidDecay;
                        }
                        else if (gi.m_FoodItem)
                        {
                            //if advanced food
                            if (Settings.settings.advFoodDecay)
                            {
                                if (gi.m_FoodItem.m_IsNatural)
                                {
                                    if (gi.m_FoodItem.m_IsFat)
                                    {
                                        decay_multiplier *= Settings.settings.fatDecay;
                                    }
                                    else if (gi.m_FoodItem.m_IsMeat)
                                    {
                                        if (gi.name == "GEAR_CuredMeat")
                                        {
                                            decay_multiplier *= Settings.settings.curedMeatDecay;
                                        }
                                        else if (gi.m_FoodItem.m_IsRawMeat)
                                        {
                                            decay_multiplier *= Settings.settings.rawMeatDecay;
                                        }
                                        else
                                        {
                                            decay_multiplier *= Settings.settings.cookedMeatDecay;
                                        }
                                    }
                                    else if (gi.m_FoodItem.m_IsFish)
                                    {
                                        if (gi.name == "GEAR_CuredFish")
                                        {
                                            decay_multiplier *= Settings.settings.curedFishDecay;
                                        }
                                        else if (gi.m_FoodItem.m_IsRawMeat)
                                        {
                                            decay_multiplier *= Settings.settings.rawFishDecay;
                                        }
                                        else
                                        {
                                            decay_multiplier *= Settings.settings.cookedFishDecay;
                                        }
                                    }
                                    else
                                    {
                                        decay_multiplier *= Settings.settings.otherFoodDecay;
                                    }
                                }
                                else
                                {
                                    if (gi.m_FoodItem.m_IsDrink)
                                    {
                                        decay_multiplier *= Settings.settings.drinksDecay;
                                    }
                                    else if (gi.m_FoodItem.m_Packaged)
                                    {
                                        decay_multiplier *= Settings.settings.packagedFoodDecay;
                                    }
                                    else if (gi.m_FoodItem.m_GearRequiredToOpen)
                                    {
                                        decay_multiplier *= Settings.settings.cannedFoodDecay;
                                    }
                                    else
                                    {
                                        decay_multiplier *= Settings.settings.otherFoodDecay;
                                    }
                                }
                            }
                            else
                            {
                                decay_multiplier *= Settings.settings.foodDecay;
                            }
                        }
                        else
                        {
                            decay_multiplier *= Settings.settings.generalDecay;
                        }
                    }
                    else
                    {
                        decay_multiplier *= Settings.settings.generalDecay;
                    }
                }
                else
                {
                    //Items that degrade on use
                    //if advanced decay on use
                    if (Settings.settings.advOnUseDecay)
                    {
                        if (gi.m_GunItem)
                        {
                            decay_multiplier *= Settings.settings.gunDecay;
                        }
                        else if (gi.m_BowItem)
                        {
                            decay_multiplier *= Settings.settings.bowDecay;
                        }
                        else if (gi.m_FireStarterItem)
                        {
                            decay_multiplier *= Settings.settings.firestartingDecay;
                        }
                        else if (gi.m_ToolsItem)
                        {
                            if (gi.name == "GEAR_SharpeningStone")
                            {
                                decay_multiplier *= Settings.settings.whetstoneDecay;
                            }
                            else if (gi.name == "GEAR_CanOpener")
                            {
                                decay_multiplier *= Settings.settings.canOpenerDecay;
                            }
                            else if (gi.name == "GEAR_Prybar")
                            {
                                decay_multiplier *= Settings.settings.prybarDecay;
                            }
                            else
                            {
                                decay_multiplier *= Settings.settings.toolsDecay;
                            }
                        }
                        else
                        {
                            decay_multiplier *= Settings.settings.onUseDecay;
                        }
                    }
                    else
                    {
                        decay_multiplier *= Settings.settings.onUseDecay;
                    }
                }
            }
            return decay_multiplier;
        }
    }
} 