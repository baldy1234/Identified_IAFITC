using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easyRotater : MonoBehaviour
{
    [SerializeField]
    float speed;
    private void Update()
    {
        transform.Rotate(0, speed, 0);
    }
}
