﻿using Match3.Services;
using System.Linq;
using System.Runtime.Serialization;
using WaveEngine.Framework;

namespace Match3.Components.Finish
{
    [DataContract]
    public class StarsComponent : Component
    {
        protected override void Initialize()
        {
            base.Initialize();

            var unlockedStars = CustomServices.GameLogic.CurrentUnlockedStars;

            var childStars = this.Owner.FindChildrenByTag("star")
                                       .OrderBy(x => x.Name)
                                       .Select(x => x.FindChild("inner"))
                                       .ToArray();

            for (int i = 0; i < childStars.Length; i++)
            {
                childStars[i].IsVisible = i < unlockedStars;
            }
        }
    }
}
