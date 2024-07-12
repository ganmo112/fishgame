using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Util
{
    /// <summary>
    /// 指定した確率でTrueを返します。
    /// </summary>
    public bool GetRandomBool(int rate)
    {
        int num = Random.Range(0, 100);
        if (num < rate)
        {
            return true;
        }
        return false;
    }

}
