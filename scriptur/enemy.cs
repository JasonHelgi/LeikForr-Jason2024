using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class enemy : MonoBehaviour
{
    public PointManager pointManager;//hef�i org � a� gera etta private en er bara me� eitt lvl svo ette er ekki altof mikill vinna
    public RubyController rubyController;//sama h�r ef eg breitti �essu � private ger�ist eithva� fuckshit, en if its not broke dont fix it
    public int damage;
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //t�kkar hva� enemy klessti � og hva� � a� gerast mi�a� vi� �a�
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
