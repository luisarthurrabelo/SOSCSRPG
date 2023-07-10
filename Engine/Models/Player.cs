﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string? _name;
        private string? _characterClass;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;
        public string Name
        {
            get { 
                return _name; 
            }
            set {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CharacterClass
        {
            get { 
                return _characterClass; 
            }
            set {
                _characterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }
        public int HitPoints
        {
            get { 
                return _hitPoints; 
            }
            set {
                _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }
        public int ExperiencePoints
        {
            get { 
                return _experiencePoints; 
            }
            set {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }
        public int Level
        {
            get { 
                return _level; 
            }
            set {
                _level = value;
                OnPropertyChanged("Level");
            }
        }
        public int Gold
        {
            get { 
                return _gold; 
            }
            set {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        public List<GameItem> Weapons => Inventory.Where(i => i is Weapon).ToList();

        public ObservableCollection<GameItem> Inventory { get; set; }
        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }

        public void RemoveItemFromInventory(GameItem item)
        {
            Inventory.Remove(item);
            OnPropertyChanged(nameof(Weapons));
        }

        public void AddItemToInventory(GameItem item)
        {
            Inventory.Add(item);
            OnPropertyChanged(nameof(Weapons));
        }

        public bool HasAllTheseItems(List<ItemQuantity> items)
        {
            foreach (ItemQuantity item in items)
            {
                if (Inventory.Count(i => i.ItemTypeID == item.ItemID) < item.Quantity)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
