using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class coinBob : MonoBehaviour
{
    public float bobSpeed;
    public AnimationCurve myCurve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//lætur coin skoppa up og niður
    {
        transform.Rotate(new Vector3(80,0,0) * Time.deltaTime);
        transform.position = new Vector3(transform.position.x,1+ myCurve.Evaluate((Time.time % myCurve.length*bobSpeed)), transform.position.z);
    }
}
