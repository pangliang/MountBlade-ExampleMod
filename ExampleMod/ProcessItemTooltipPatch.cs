using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.ViewModelCollection;
using TaleWorlds.CampaignSystem.ViewModelCollection.Inventory;
using TaleWorlds.Core.ViewModelCollection;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace ExampleMod
{
    [HarmonyPatch(typeof(SPInventoryVM), "ProcessItemTooltip")]
    class ProcessItemTooltipPatch
    {
        [HarmonyPostfix]
        private static void ProcessItemTooltipPostfix(SPInventoryVM __instance, ref ItemVM item)
        {
            AddTargetItemProperties(__instance.ItemMenu, new TextObject("{=pangliangtest}111:", null).ToString(), "v1", Color.FromUint(4285250886U));
            __instance.ItemMenu.IsInitializationOver = true;
        }

        private static ItemMenuTooltipPropertyVM AddTargetItemProperties(ItemMenuVM itemMenuVM, string definition, string value, Color color)
        {
            ItemMenuTooltipPropertyVM itemMenuTooltipPropertyVM = new ItemMenuTooltipPropertyVM(definition, value, 0, color, false, null);
            itemMenuVM.TargetItemProperties.Add(itemMenuTooltipPropertyVM);
            return itemMenuTooltipPropertyVM;
        }
    }
}
