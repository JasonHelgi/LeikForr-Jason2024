using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveFwd : MonoBehaviour
{
    
    void Start()
    {
        
    }
    public float speed;
    //basic coði sem eg gerði handa moving barrier sem kemur í lvl 2
    void Update()//færir barrier fram
    { transform.Translate(Vector3.back*Time.deltaTime*speed);}


    private void OnTriggerEnter(Collider other)//instant game over þegar maður snertir þennan barrier
    {other.gameObject.SetActive(false);
        SceneManager.LoadScene(4);}
}
