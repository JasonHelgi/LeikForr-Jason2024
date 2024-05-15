using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovmt : MonoBehaviour

{
    public Transform startPosition; 
    public Transform endPosition;  
    public float speed = 2f;        

    private Vector3 direction;       
    private Vector3 targetPosition;  
    private SpriteRenderer spriteRenderer; 

    private void Start()
    {
        
        targetPosition = endPosition.position;

      
        //reiknar í hvaða átt á að fara
        direction = (targetPosition - transform.position).normalized;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //færir objectið
        transform.Translate(direction * speed * Time.deltaTime);

        //tékkar ef object er komið á staðinn
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // If the target position is the end position, set it to the start position; otherwise, set it to the end position
            //switchar hvaða staða er loka eðabirjuna staðann, svoe ef hann er komin á staðinn þá verður endastaðan breitt í birjunarstoðuna og birjunarstaðann í enda
            targetPosition = targetPosition == endPosition.position ? startPosition.position : endPosition.position;

            //hvaða átt ´spritiðá að horfa
            direction = (targetPosition - transform.position).normalized;
        }

        //flippar spritinu
        if (direction.x < 0)
        {
            spriteRenderer.flipX = false;
        }
        //þetta líka
        else if (direction.x > 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
