using UnityEngine;
using System.Collections;

public class MenuSelect : MonoBehaviour {

    Animator myAnimator;
    bool rotateDirection = false;

	void Start () 
    {
        myAnimator = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
	}
	
	void Update () 
    {
        
	}

    public void LoadLevel()
    {
        Application.LoadLevel(1);
    }

    public void RotateCamera()
    {
        //Rotates camera depending on bool
        rotateDirection = !rotateDirection;
        if (rotateDirection)
            myAnimator.Play("RotateCamera");
        else
            myAnimator.Play("RotateCameraBack");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
