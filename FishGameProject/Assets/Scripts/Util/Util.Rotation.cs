using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Util
{
    /// <summary>
    /// オブジェクトを左右回転させます。
    /// </summary>
    public void RotateY180() => transform.Rotate(0f, 180f, 0f);
}
