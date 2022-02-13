using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public HUDManager hud;

    int score = 0;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else 
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        AddScore(0);
    }

    public void AddScore(int value)
    {
        score += value;
        hud.SendMessage("UpdateScore", score);
    }

    public int GetScore()
    {
        return score;
    }

}
