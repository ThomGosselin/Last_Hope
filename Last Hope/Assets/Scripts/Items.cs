using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        KeyLvl11,
        KeyLvl12,
        KeyLvl13,
        PaperLvl1,
        PaperLvl2,
        NotePadLvl1,
        PenLvl1,
        BuisnessCardLvl1,
        PhoneLvl1,
        CanLvl1,
        RadioLvl1
    }

    public ItemType itemType;
    public int amount;
}
