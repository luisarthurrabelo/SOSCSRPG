using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>
            {
                new Weapon(1001, "wood staff", 1, 1, 2),
                new Weapon(1002, "Rusty Sword", 5, 1, 3)
            };
        }

        public static GameItem? CreateGameItem(int itemTypeID)
        {
            GameItem? standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (standardItem != null)
            {
                return standardItem.Clone(); //Não entendi por que o clone está sendo no GameItem, não deveria clonar a Weapon também?
            }
            return default;
        }
    }
}
