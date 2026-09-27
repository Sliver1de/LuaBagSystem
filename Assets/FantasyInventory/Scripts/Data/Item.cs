using System;
using Assets.FantasyInventory.Scripts.Enums;
using Assets.FantasyInventory.Scripts.GameData;

namespace Assets.FantasyInventory.Scripts.Data
{
    /// <summary>
    /// Represents item object for storing with game profile (please note, that item params are stored separately in params database).
    /// 表示用于随游戏档案（game profile）一起存储的物品对象（请注意，物品的参数是单独存储在参数数据库中的）。
    /// </summary>
    [Serializable]
    public class Item
    {
        public ItemId Id;
        public int Count;

        public ItemParams Params => Items.Params[Id];

        public Item()
        {
        }

        public Item(ItemId id, int count)
        {
            Id = id;
            Count = count;
        }
    }
}