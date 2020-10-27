using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

public class spin : MonoBehaviour
{
    float spinSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        this.spinSpeed = 97;
        transform.Rotate(0, 0, this.spinSpeed);

        this.spinSpeed *= 0.96f;
    }
}
