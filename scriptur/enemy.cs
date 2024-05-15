using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class enemy : MonoBehaviour
{
    public PointManager pointManager;//hefði org á að gera etta private en er bara með eitt lvl svo ette er ekki altof mikill vinna
    public RubyController rubyController;//sama hér ef eg breitti þessu í private gerðist eithvað fuckshit, en if its not broke dont fix it
    public int damage;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //tékkar hvað enemy klessti á og hvað á að gerast miðað við það
        if (collision.gameObject.CompareTag("Player"))
        {
            rubyController.ChangeHealth(-damage);
            pointManager.SubtractPoints(-1);

            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Kula"))
        {
            
            Destroy(gameObject);
        }
    }
}
