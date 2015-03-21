using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {

    int savedPlayer;
    public GameObject[] players;

    void Awake()
    {
        //Gets saved int from selectionmenu
        savedPlayer = PlayerPrefs.GetInt("selectedPlayer");
        //Spawn selected player
        Instantiate(players[savedPlayer], new Vector3(0, 1, 0), Quaternion.identity);
    }
}
