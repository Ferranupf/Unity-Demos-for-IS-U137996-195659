using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance; 

    public Text obstaclesAvoidedText; 
    public Text hitsbyObstacleText; 
    public GameObject gameOverWindow; 

    void Awake()
    {
        Instance = this;
    }

    
    public void UpdatehitsbyObstacles() 
    {
        hitsbyObstacleText.text = GameStateManager.Instance.hitsbyObstacles.ToString();
    }

    public void UpdateobstaclesAvoided() // 2
    {
        obstaclesAvoidedText.text = GameStateManager.Instance.obstaclesAvoided.ToString();
    }
    public void ShowGameOverWindow()
    {
        gameOverWindow.SetActive(true);
    }
}
