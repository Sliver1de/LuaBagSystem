namespace Assets.FantasyInventory.Scripts.Enums
{
    /// <summary>
    /// Add new item types here.
    /// Use constant integer values for enums to avoid data distortion when adding/removing new values.
    /// 在此处添加新的物品类型。
    /// 枚举请使用固定的整型常量值，以避免在新增或删除枚举项时造成数据错乱。
    /// </summary>
    public enum ItemType
    {
        Undefined   = 0,
        Currency    = 1,
        Loot        = 2,
        Potion      = 3,
        Scroll      = 4,
        Helmet      = 5,
        Armor       = 6,
        Ring        = 7,
        Necklace    = 8,
        Shield      = 9,
        Weapon      = 10
    }
}