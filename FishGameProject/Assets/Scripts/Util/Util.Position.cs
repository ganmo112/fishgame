using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Util
{
    /// <summary>
    /// 画面左下のワールド座標を取得します。
    /// </summary>
    public Vector2 GetWorldLeftBottomPosition()
        => Camera.main.ScreenToWorldPoint(Vector3.zero);

    /// <summary>
    /// 画面右上のワールド座標を取得します。
    /// </summary>
    public Vector2 GetWorldRightTopPosition()
        => Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

    /// <summary>
    /// 画面左端に到達したかどうか
    /// </summary>
    public bool IsReachedLeftEnd() => transform.position.x < GetWorldLeftBottomPosition().x;

    /// <summary>
    /// 画面右端に到達したかどうか
    /// </summary>
    public bool IsReachedRigntEnd() => transform.position.x > GetWorldRightTopPosition().x;
}
