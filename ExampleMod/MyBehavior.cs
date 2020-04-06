using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameMenus;
using static TaleWorlds.CampaignSystem.InventoryManager;

namespace ExampleMod
{
    class MyBehavior : CampaignBehaviorBase
    {
        public override void RegisterEvents()
        {
            CampaignEvents.OnGameLoadedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>((CampaignGameStarter campaignGameStarter) => {
                campaignGameStarter.AddGameMenuOption("town", "trade"
                    , "{=VN4ctHIU}Automatically trade goods"
                    , new GameMenuOption.OnConditionDelegate((MenuCallbackArgs args) => {
                        return true;
                    })
                    , new GameMenuOption.OnConsequenceDelegate((MenuCallbackArgs args) => {
                        InventoryManager.OpenScreenAsTrade(Settlement.CurrentSettlement.ItemRoster, Settlement.CurrentSettlement.GetComponent<Town>(), InventoryCategoryType.Goods, null);
                        return;
                    })
                    , false, 7, false);
            }));
        }

        public override void SyncData(IDataStore dataStore)
        {
            
        }
    }
}
