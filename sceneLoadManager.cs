using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloadManager : MonoBehaviour
{
    public TextMeshProUGUI texti;
    public static int activeScene;
    // Start is called before the first frame update
    void Start()
    {//resetar health og unlockar cursor
        playerpoints.health = 10;
        Cursor.lockState = CursorLockMode.None;
        if (activeScene == 2)
        {
            if (playerpoints.points > 30)
            {
                texti.text = " vel gert heimaver�ldinn er stolt. �u f�kkst" + playerpoints.points + " stig";
            }
            else { 
            texti.text = "�� f�kkst " + playerpoints.points + " stig";}
        }
    }

    // Update is called once per frame
    void Update()//�tla�i a� gera eithva� meria me� etta
        //enda�i bara sem eithva� til a� gera lif mitt a�eins lettara
        //eg nenti ekki a� muna nr hva� hvert scene var
    {
        
    }
    public static void lvl1()
    {   
        SceneManager.LoadScene(1);
        activeScene = 1;
    }
    public static void mainMenu()
    { SceneManager.LoadScene(0);
        activeScene = 0;}
    public static void gameOver() 
    { SceneManager.LoadScene(2);
        activeScene = 2;
    }
}
