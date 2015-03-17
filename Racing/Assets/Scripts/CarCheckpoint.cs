using UnityEngine;
using System.Collections;

public class CarCheckpoint : MonoBehaviour {

    public static int current = 0;
    public static int lap = 0;
    public Transform[] checkPoints;

	void Start () 
    {
        var chPnts = GameObject.FindGameObjectsWithTag("Checkpoint");
        checkPoints = new Transform[chPnts.Length];
        for (int i = 0; i < chPnts.Length; i++)
        {
            checkPoints[i] = chPnts[i].transform;            
        }
	}
	
	void Update () 
    {
	
	}
}
