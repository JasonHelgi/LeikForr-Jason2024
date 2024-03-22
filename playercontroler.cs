using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //er me� allt public svo eg get leiki� mer me� values
    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardSpeed;
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardSpeed = Input.GetAxis("Vertical");
        //faera afram
        transform.Translate(Vector3.forward * Time.deltaTime * speed*forwardSpeed);
        //ser um rotation/movment
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput *  Time.deltaTime);
    }
}
