using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;

namespace ExampleMod
{
    class MySubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            Module.CurrentModule.AddInitialStateOption(new InitialStateOption("Message",
                new TextObject("测试按钮 TestMsg"),
                9990,
                () => { InformationManager.DisplayMessage(new InformationMessage("Hello World!")); },
                false));

            Harmony harmony = new Harmony("com.test.examplemod");
            harmony.PatchAll();
            base.OnSubModuleLoad();
        }

        protected override void OnGameStart(Game game, IGameStarter iGameStarter)
        {
            CampaignGameStarter gameStarterObject = (CampaignGameStarter)iGameStarter;
            gameStarterObject.AddBehavior(new MyBehavior());
        }
    }
}
