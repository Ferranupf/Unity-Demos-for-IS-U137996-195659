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
    [HideInInspector]
    public int hitbyCoin;


    public int obstaclesHitBeforeGameOver;
    public ObstacleSpawner obstacleSpawner1;
    public ObstacleSpawner obstacleSpawner2;
    public ObstacleSpawner obstacleSpawner3;
    public ObstacleSpawner obstacleSpawner4;



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
        obstacleSpawner1.canSpawn = false;
        obstacleSpawner2.canSpawn = false;
        obstacleSpawner3.canSpawn = false;
        obstacleSpawner4.canSpawn = false;
        obstacleSpawner1.DestroyAllObstacles();
        obstacleSpawner2.DestroyAllObstacles();
        obstacleSpawner3.DestroyAllObstacles();
        obstacleSpawner4.DestroyAllObstacles();
    }
    
    public void ObstacleAvoided()
    {
        obstaclesAvoided++; 
        UIManager.Instance.UpdateobstaclesAvoided();
    }

    public void Coined()
    {
        hitbyCoin++;
        UIManager.Instance.UpdatehitbyCoin();
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
