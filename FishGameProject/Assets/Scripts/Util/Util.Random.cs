using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Util
{
    /// <summary>
    /// w’è‚µ‚½Šm—¦‚ÅTrue‚ğ•Ô‚µ‚Ü‚·B
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
