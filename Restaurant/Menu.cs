﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; }
        public DateTime LastUpdated { get; private set; }

        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
            // Update LastUpdated anytime we add a new menuItem
            this.LastUpdated = DateTime.Now;
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
            // Update LastUpdated anytime we remove a menuItem
            this.LastUpdated = DateTime.Now;
        }
    }
}