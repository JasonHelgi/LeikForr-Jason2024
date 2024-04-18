using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class playerpoints : MonoBehaviour
{   
    //h�rna s� eg um flestuu semtengis playerinum td stig health og allt ui
    public static int points;
    public static int health = 10;
    public TextMeshProUGUI countText;
    private TextMeshProUGUI texti;
    private TextMeshProUGUI timer;
    private float timeLeft;

    // Start is called before the first frame update
    void Start()
    {   
        //er a� virkja ui
        texti = GameObject.Find("Text2").GetComponent<TextMeshProUGUI>();
        timer = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();
        points = 0;
        timeLeft = 120;
        timer.text = timeLeft.ToString("0.0") + " time left";
        countText.text = "stig " + points.ToString();
        texti.text = "L�f " + health.ToString();
    }

    // Update is called once per frame
    void Update()
    {   
        timeLeft -= Time.deltaTime;// er a� telja ni�ur
        timer.text = timeLeft.ToString("0.0") + " time left";//updatear ui
        if (timeLeft < 0) // hva� gerist ef timin rennur �t
        {
            points = 0;
            sceneloadManager.gameOver(); }
        countText.text = "stig " + points.ToString();
        texti.text = "L�f " + health.ToString();
        if (health <= 0) {//hva� geris ef health rennur �t
            points = 0;
            sceneloadManager.gameOver();}
    }
}
