using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Kassi : MonoBehaviour
{
 
    
    public GameObject sprenging;
    
    void Start()
    {
        //sprenging= GetComponent<Explosion>
 
    }
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "kula")
        {
            Destroy(gameObject);
            gameObject.SetActive(false);
            Debug.Log("varð fyrir kúlu");
            playerpoints.points = playerpoints.points + 1;
            Sprengin();
        }
    }
    void Sprengin()
    {
        Instantiate(sprenging, transform.position, transform.rotation);
    }
}
