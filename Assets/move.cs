using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    // 変化量
    public float dy;

    void Update()
    {
        // dxは任意の値
        this.transform.position += new Vector3(dy * Time.deltaTime, 0, 0);
    }

}