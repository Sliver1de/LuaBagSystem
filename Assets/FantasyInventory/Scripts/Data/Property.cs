using System;
using Assets.FantasyInventory.Scripts.Enums;

namespace Assets.FantasyInventory.Scripts.Data
{
    /// <summary>
    /// Represents key-value pair for storing item params.表示用于存储物品参数的键值对。
    /// </summary>
    [Serializable]
    public class Property
    {
        public PropertyId Id;
        public int Value;

        public Property()
        {
        }

        public Property(PropertyId id, int value)
        {
            Id = id;
            Value = value;
        }
    }
}