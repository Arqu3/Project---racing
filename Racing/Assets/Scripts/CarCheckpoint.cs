using UnityEngine;
using System.Collections;

public class CarCheckpoint : MonoBehaviour {

    public static int current = 0;
    public static int lap = 0;
    public Transform[] checkPoints;
    Transform temp;

    void Start()
    {
        //Finds all checkpoints
        var chPnts = GameObject.FindGameObjectsWithTag("Checkpoint");
        checkPoints = new Transform[chPnts.Length];
        for (int i = 0; i < chPnts.Length; i++)
        {
            checkPoints[i] = chPnts[i].transform;
        }

        //Sorts checkpoints depending on ID
        for (int write = 0; write < chPnts.Length; write++)
        {
            for (int sort = 0; sort < chPnts.Length - 1; sort++)
            {
                if (checkPoints[sort].GetComponent<Checkpoint>().ID > checkPoints[sort + 1].GetComponent<Checkpoint>().ID)
                {
                    temp = checkPoints[sort + 1];
                    checkPoints[sort + 1] = checkPoints[sort];
                    checkPoints[sort] = temp;
                }
            }
        }
 
    }
	
	void Update () 
    {
	
	}
}
