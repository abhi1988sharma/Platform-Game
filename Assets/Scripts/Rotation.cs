using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float SpeedX;
    public float SpeedY;
    public float SpeedZ;

    void Start()
    {
        
    }

    void Update()
    {// rotate objects at 360 degree at a given speed which can be assigned in inspector
        transform.Rotate(360 * SpeedX * Time.deltaTime, 360 * SpeedY * Time.deltaTime, 360 * SpeedZ * Time.deltaTime);
        
    }
}
