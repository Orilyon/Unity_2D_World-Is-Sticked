using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter_takip : MonoBehaviour {
    public Transform target;
    void FixedUpdate()
    {
        Vector3 new_position = target.position;
        new_position.z = -10;
        transform.position = new_position;

    }
}
