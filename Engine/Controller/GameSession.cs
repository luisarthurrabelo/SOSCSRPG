﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Controller
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "Lucent",
                CharacterClass = "Knight",
                HitPoints = 10,
                Gold = 1000,
                ExperiencePoints = 0,
                Level = 1
            };
        }

    }
}
