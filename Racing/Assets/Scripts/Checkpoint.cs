using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

    public int ID = 0;
    static Transform playerTransform;

	void Start () 
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update () 
    {
	}

    void OnTriggerEnter(Collider other)
    {
        //Only the player can reach checkpoints
        if (other.gameObject.tag == "Player")
        {
            //Is this checkpoint the current one
            if (transform == playerTransform.GetComponent<CarCheckpoint>().checkPoints[CarCheckpoint.current].transform)
            {
                //Is the current checkpoint + 1 lesser than the length of the array
                if (CarCheckpoint.current + 1 < playerTransform.GetComponent<CarCheckpoint>().checkPoints.Length)
                {
                    //If this is the first checkpoint, increase lap
                    if (CarCheckpoint.current == 0)
                        CarCheckpoint.lap++;
                    //Sets next checkpoint
                    CarCheckpoint.current++;
                }
                //If there are no more checkpoints, go to 0
                else
                    CarCheckpoint.current = 0;
            }
        }
        Debug.Log("Next checkpoint: " + CarCheckpoint.current);
        Debug.Log("Lap: " + CarCheckpoint.lap);
    }
}
