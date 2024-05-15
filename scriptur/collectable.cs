using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class collectable : MonoBehaviour
{
    public  PointManager PointManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collided GameObject has a specific tag, you can customize this based on your needs
        if (collision.gameObject.CompareTag("Player"))
        {
            PointManager.AddPoints(3);//gefur player stig
            Destroy(gameObject);
        }
    }
}
