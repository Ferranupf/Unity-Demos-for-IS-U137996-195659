using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance; 

    [HideInInspector]
    public int hitsbyObstacles; //initially with 1 the game ends

    [HideInInspector]
    public int obstaclesAvoided; 

    public int obstaclesHitBeforeGameOver; 
    public ObstacleSpawner obstacleSpawner; 
    
    public void HitByObstacle()
    {
        hitsbyObstacles++;
        if (hitsbyObstacles == obstaclesHitBeforeGameOver)
        {
          GameOver();
          UIManager.Instance.ShowGameOverWindow();
        }
        UIManager.Instance.UpdatehitsbyObstacles();
    }
    private void GameOver()
    {
        obstacleSpawner.canSpawn = false; 
        obstacleSpawner.DestroyAllObstacles(); 
    }
    public void ObstacleAvoided()
    {
        obstaclesAvoided++; 
        UIManager.Instance.UpdateobstaclesAvoided();
    }
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update(){

        if (Input.GetKeyDown(KeyCode.Escape)){
            SceneManager.LoadScene("Title");
        }
    }
}
