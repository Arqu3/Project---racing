using UnityEngine;
using System.Collections;

public class CharacterSelect : MonoBehaviour {


    public GameObject[] characters;
    public GameObject selectedCharacter;
    public int selectedIndex;
    
    RaycastHit hit;

	void Start () 
    {
        selectedIndex = -1;
	}
	
	void Update () 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    //Checks what gameobject the ray is colliding with
                    if (hit.collider.gameObject == characters[i])
                    {
                        //Sets selected character
                        selectedCharacter = characters[i];
                        selectedIndex = i;
                        PlayerPrefs.SetInt("selectedPlayer", selectedIndex);
                    }
                }
            }
            else
                return;
            Debug.Log("Currently selected: " + selectedCharacter + "\nAt index: " + selectedIndex);
        }

	}
}
