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
    //basic co�i sem eg ger�i handa moving barrier sem kemur � lvl 2
    void Update()//f�rir barrier fram
    { transform.Translate(Vector3.back*Time.deltaTime*speed);}


    private void OnTriggerEnter(Collider other)//instant game over �egar ma�ur snertir �ennan barrier
    {other.gameObject.SetActive(false);
        SceneManager.LoadScene(4);}
}
