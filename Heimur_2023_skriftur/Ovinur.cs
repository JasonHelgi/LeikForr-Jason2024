using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;
using TMPro;

public class Ovinur : MonoBehaviour
{
    private Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 5f;
    // Start is called before the first frame update
    void Start()
    {
       
        rb = this.GetComponent<Rigidbody>();//veit ekki hvað þetta gerir. þori ekki að snerta það
    }

    // Update is called once per frame
    void Update()
    {   //lætur enemy fara í attina að player
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();
        movement = stefna;
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);
    }
    void Hreyfing(Vector3 stefna)
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag=="Player")
        {
            Debug.Log("Leikmaður fær í sig óvin");
            playerpoints.health = playerpoints.health - 10;//tek health af player(playerPoints.cs sér um að updatea ui)
   
            gameObject.SetActive(false);// deleta enemy
        }
        if (collision.collider.tag == "kula")//drepur enemy ef skotið
        {
            gameObject.SetActive(false);
        }
    }

    

}
