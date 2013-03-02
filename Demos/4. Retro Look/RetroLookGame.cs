﻿using System;
using System.Dom;
using System.Html;
using Ventajou.Gaming;
using Ventajou.Gaming.Config;
using Ventajou.Gaming.Config.UI;
using Ventajou.Gaming.Config.Settings;

namespace Ventajou.Demos
{
    public class RetroLookGame : Game
    {
        protected override string Name
        {
            get { return "Retro Look"; }
        }

        protected override GameSettings defaultSettings
        {
            get
            {
                return new GameSettings
                {
                    resolution = new Resolution(160, 100, "160x100"),
                    fitToContainer = true,
                    fullScreen = false,
                    blockyPixels = true
                };
            }
        }

        public RetroLookGame(HTMLElement element)
            : base(element)
        {
            loadScene(new RetroLookScene(this));
        }

        public override Menu[] buildMenus()
        {
            return new[] 
				{
					new Menu("Display", "display", 
						new Setting[]
						{
							new FullScreenSetting(),
							new StretchToWindowSetting()
						})
				};
        }
    }
}