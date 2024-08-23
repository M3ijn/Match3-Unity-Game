using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class Utils
{
    public static NormalItem.eNormalType GetRandomNormalType()
    {
        Array values = Enum.GetValues(typeof(NormalItem.eNormalType));
        NormalItem.eNormalType result = (NormalItem.eNormalType)values.GetValue(URandom.Range(0, values.Length));

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeExcept(NormalItem.eNormalType[] types)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(types).ToList();

        int rnd = URandom.Range(0, list.Count);
        NormalItem.eNormalType result = list[rnd];

        return result;
    }

    public static NormalItem.eNormalType GetRandomNormalTypeWithSmallestAmountExcept(NormalItem.eNormalType[] exceptTypes, int[] typeCounts)
    {
        List<NormalItem.eNormalType> list = Enum.GetValues(typeof(NormalItem.eNormalType)).Cast<NormalItem.eNormalType>().Except(exceptTypes).ToList();
        List<int> count = typeCounts.ToList();
        NormalItem.eNormalType result = NormalItem.eNormalType.TYPE_ONE;
        int min = int.MaxValue;
        for (int i = 0; i < count.Count; i++)
        {
            if (list.Contains((NormalItem.eNormalType)i))
            {
                if (count[i] < min)
                {
                    min = count[i];
                    result = (NormalItem.eNormalType)i;
                }
            }
        }

        return result;
    }
}
