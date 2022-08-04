using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int currentScore;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;


        }
        else
        {
            Destroy(this);
        }

    }

    // Start is called before the first frame update
    public void AddToScore()
    {
        currentScore++;
        Debug.Log("Current score is now" + currentScore);
    }

    void Start()
    {
        currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
