using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Util
{
    /// <summary>
    /// �w�肵���m����True��Ԃ��܂��B
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
