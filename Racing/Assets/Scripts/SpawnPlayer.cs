using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {

    int savedPlayer;
    public GameObject[] players;

    void Awake()
    {
        //Gets saved int from selectionmenu
        savedPlayer = PlayerPrefs.GetInt("selectedPlayer");

        //Disables all players that don't match saved index
        //for (int i = 0; i < players.Length; i++)
        //{
        //    if (i != savedPlayer)
        //    {
        //        players[i].SetActive(false);
        //    }
        //    else
        //        players[i].SetActive(true);
        //}
        Instantiate(players[savedPlayer], new Vector3(0, 1, 0), Quaternion.identity);
    }
}
