using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
  
    private void OnCollisionEnter2D(Collision2D collision)//sendir mann í victory screen

    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
          
        }
    }
}

