using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    //etta eru allir buttons sem eg þarf
    public void mainMenu() {SceneManager.LoadScene(0);}
    public void Game() { SceneManager.LoadScene(1); }
    public void Explain() { SceneManager.LoadScene(2);}
    public void beatGame() {  SceneManager.LoadScene(3);}
}
