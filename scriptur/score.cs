using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using TMPro;

public class PointManager : MonoBehaviour
{
    
    private int totalPoints = 0;

    //tengir við ui
    private TextMeshProUGUI scoreboardText;

    // Start is called before the first frame update
    void Start()
    {
        //finnur og tengir  við ui 
        GameObject scoreboardObject = GameObject.FindGameObjectWithTag("Scoreboard");
        if (scoreboardObject != null)
        {
            scoreboardText = scoreboardObject.GetComponent<TextMeshProUGUI>();
            //updatear ui
            UpdateScoreboard();
        }
        else
        {
            Debug.LogWarning("No TextMeshPro object tagged as 'Scoreboard' found in the scene.");
        }
    }

    //bæta við points
    public void AddPoints(int pointsToAdd)
    {
        totalPoints += pointsToAdd;
        UpdateScoreboard();
        Debug.Log("Points added: " + pointsToAdd);
        Debug.Log("Total Points: " + totalPoints);
    }

    // taka points
    public void SubtractPoints(int pointsToSubtract)
    {
        totalPoints -= pointsToSubtract;
        UpdateScoreboard();
        Debug.Log("Points subtracted: " + pointsToSubtract);
        Debug.Log("Total Points: " + totalPoints);
    }

    //til að updatea scoreboardið
    private void UpdateScoreboard()
    {
        if (scoreboardText != null)
        {
            scoreboardText.text = "Score: " + totalPoints.ToString();
        }
    }

    //bætti þessu þegar eg fékk hugmindina að láta allt(respawna/skóta) kosta
    //funtion sem returnar magn pointa í int
    public int GetTotalPoints()
    {
        return totalPoints;
    }
}
