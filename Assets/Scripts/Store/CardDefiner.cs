﻿using System;

public static class CardDefiner
{
    public static string GetACard(Rarity rarity)
    {
        switch (rarity)
        {
            case Rarity.N:
                return getAnN();
            case Rarity.R:
                return getAnR();
            case Rarity.SR:
                return getAnSR();
            case Rarity.SSR:
                return getAnSSR();
            default:
                return null;
        }
    }
    public static String getAnSSR()
    {
        return "EnemyType1";
    }

    public static String getAnSR()
    {
        return "TowerType1";
    }
    public static String getAnR()
    {
        return "TowerType2";
    }
    public static String getAnN()
    {
        return "TowerType3";
    }
}
