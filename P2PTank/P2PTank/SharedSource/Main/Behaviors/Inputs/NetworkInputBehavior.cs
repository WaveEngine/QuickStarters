﻿using System;
using System.Collections.Generic;
using System.Text;
using WaveEngine.Framework;
using P2PTank.Entities.P2PMessages;
using P2PTank.Managers;

namespace P2PTank.Behaviors
{
    public class NetworkInputBehavior : Behavior
    {
        public string PlayerID { get; set; }

        public NetworkInputBehavior(P2PManager p2pManager = null)
        {
        }

        protected override void Update(TimeSpan gameTime)
        {
        }
    }
}