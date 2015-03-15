using UnityEngine;
using System.Collections;

public class DisableRenderer : MonoBehaviour {

    RaycastHit hit;
    GameObject[] walls;


	void Start () 
    {
	
	}
	
	void Update () 
    {
        walls = GameObject.FindGameObjectsWithTag("Wall");

        Debug.DrawRay(transform.position, transform.forward * 6);
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, 6))
        {
            if (hit.collider.tag == "Wall")
                hit.collider.GetComponentInChildren<Renderer>().enabled = false;
        }
        else
        {
            for (int i = 0; i < walls.Length; i++)
            {
                walls[i].GetComponent<Renderer>().enabled = true;
            }
        }
	}
}
