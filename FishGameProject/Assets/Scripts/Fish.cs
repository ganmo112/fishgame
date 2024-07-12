using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private Util util;
    private int xDirection = 1;

    void Start()
    {
        util = new Util(transform);
    }

    void Update()
    {
        var position = transform.position;
        if (util.IsReachedLeftEnd() || util.IsReachedRigntEnd())
        {
            util.RotateY180();
            xDirection = -1 * xDirection;
        }

        position.x += xDirection * 0.001f;
        position.y += (util.GetRandomBool(50) ? -1 : 1) * 0.001f;
        transform.position = position;
    }

    void OnMouseOver()
    {
        Destroy(gameObject);
    }
}
