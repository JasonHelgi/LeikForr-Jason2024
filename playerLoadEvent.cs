using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerLoadEvent : MonoBehaviour
{

    
        

//�tti orgl a� b�ta �vi sem er � vatn.cs hinga� in en er oge�slega latur
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "instantGameOver")//seigir hva� � a� geras vi� player ef hann klessir � s�rstaka hluti
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

