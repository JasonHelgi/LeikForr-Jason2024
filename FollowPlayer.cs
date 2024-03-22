using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public GameObject player;
    public Vector3 offset = new Vector3 (0, 4, -9);
    // Update is called once per frame
    void LateUpdate()
    {//færir camið svo það eltir bilinn 
        transform.position = player.transform.position + offset;
    }
}
