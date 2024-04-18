using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKlessaA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        // ef player keyrir á object sem heitir hlutur
  
        if (collision.collider.tag == "peningur")
        {
            collision.collider.gameObject.SetActive(false);
            playerpoints.points = playerpoints.points + 5;
        }
        if (collision.collider.tag == "hindrun")
        {
            collision.collider.gameObject.SetActive(false);
            playerpoints.points = playerpoints.points - 1;

        }
    }
}
