using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLoadEvent : MonoBehaviour
{

    
        

//ætti orgl að bæta þvi sem er í vatn.cs hingað in en er ogeðslega latur
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "instantGameOver")//seigir hvað á að geras við player ef hann klessir á sérstaka hluti
        {
            playerpoints.points = 0;
            sceneloadManager.gameOver();
        }
        if (collision.collider.tag == "Home")
        {
            sceneloadManager.gameOver();
        }
    }
}

