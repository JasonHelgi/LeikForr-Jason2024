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

      
        //reiknar � hva�a �tt � a� fara
        direction = (targetPosition - transform.position).normalized;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        //f�rir objecti�
        transform.Translate(direction * speed * Time.deltaTime);

        //t�kkar ef object er komi� � sta�inn
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            // If the target position is the end position, set it to the start position; otherwise, set it to the end position
            //switchar hva�a sta�a er loka e�abirjuna sta�ann, svoe ef hann er komin � sta�inn �� ver�ur endasta�an breitt � birjunarsto�una og birjunarsta�ann � enda
            targetPosition = targetPosition == endPosition.position ? startPosition.position : endPosition.position;

            //hva�a �tt �spriti�� a� horfa
            direction = (targetPosition - transform.position).normalized;
        }

        //flippar spritinu
        if (direction.x < 0)
        {
            spriteRenderer.flipX = false;
        }
        //�etta l�ka
        else if (direction.x > 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
