using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public Vector3 rotationSpeed;

    void Start()
    {
        
    }

    
    void Update()
    {
        //time.deltatime frame ba��na demek gibi bir �ey
        //transform.Rotate(0, 50 * Time.deltaTime, 0);
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
