﻿using CardLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace Durak
{
    public class Player
    {
        public Player(): this("Noname") { }

        public Player(string name) : this(name, new CardSet()) { }
        public Player(string name, CardSet hand)
        {
            Name = name;
            Hand = hand;
        }
        
        public string Name { get; set; }
        public CardSet Hand { get; set; }
        public bool InGame { get; set; } = true;
    }
}