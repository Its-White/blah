using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager{

    public int playerCount;

    void Start()
    {
        if (playerCount < 2)
        {
            SceneManager.LoadScene(3);
        }
    }
}
