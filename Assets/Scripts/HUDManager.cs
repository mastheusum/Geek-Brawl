using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    public PlayerBehaviour player;
    public Text score;
    public Image  healthBar;
    
    public void UpdateScore(int val)
    {
        score.text = val.ToString();
    }
    public void UpdateHealt(float val)
    {
        healthBar.fillAmount = val;
    }
}
