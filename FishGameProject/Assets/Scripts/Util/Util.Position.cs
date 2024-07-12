using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Util
{
    /// <summary>
    /// ��ʍ����̃��[���h���W���擾���܂��B
    /// </summary>
    public Vector2 GetWorldLeftBottomPosition()
        => Camera.main.ScreenToWorldPoint(Vector3.zero);

    /// <summary>
    /// ��ʉE��̃��[���h���W���擾���܂��B
    /// </summary>
    public Vector2 GetWorldRightTopPosition()
        => Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

    /// <summary>
    /// ��ʍ��[�ɓ��B�������ǂ���
    /// </summary>
    public bool IsReachedLeftEnd() => transform.position.x < GetWorldLeftBottomPosition().x;

    /// <summary>
    /// ��ʉE�[�ɓ��B�������ǂ���
    /// </summary>
    public bool IsReachedRigntEnd() => transform.position.x > GetWorldRightTopPosition().x;
}
