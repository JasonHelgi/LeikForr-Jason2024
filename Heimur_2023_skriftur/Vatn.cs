using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vatn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")//drepur player ef hann snertir vatn
        {
            Debug.Log("Drukknaði");
            playerpoints.points = 0;
            sceneloadManager.gameOver();

        }
    }
}
