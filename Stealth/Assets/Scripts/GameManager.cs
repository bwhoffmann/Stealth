using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Sets two separate instance variables, one that can be changed only from gameManager and one that can only be called to return the changeable version.
    private static GameManager instance;
    public static GameManager Instance 
    { 
        get
        {
            return instance;
        }
    }
    public GameObject player;
    public GameObject playerPrefab;
    private void Awake()
    {
        //Sets the GameManager on starting the program
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //Destroys any additional GameManagers
            Debug.Log("Attempted to create a second GameManager");
            Destroy(this.gameObject);
        }
    }
    public void StartGame()
    {
       Debug.Log("Game has started.");
    }

    //Instantiates the player

    private void SpawnPlayer()
    {
        if (player != null)
            {
                player = Instantiate(playerPrefab, Vector3.zero, Quaternion.identity);
            }
    }
}
