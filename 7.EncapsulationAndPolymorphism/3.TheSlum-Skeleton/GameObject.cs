﻿using System;
using TheSlum.GameEngine;
namespace TheSlum
{
    public abstract class GameObject
    {
        protected GameObject(string id)
        {
            this.Id = id;
        }

        public string Id { get; private set; }
    }
}