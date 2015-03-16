using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {


    public GameObject[] characters;
    public GameObject selectedCharacter;
    public int selectedIndex;
    public Text selectedCharacterText;
    public GameObject startButton;
    
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

        if (selectedCharacter == null)
        {
            //Disbales text and button if no character is selected
            selectedCharacterText.enabled = false;
            startButton.SetActive(false);
        }
        else
        {
            //Enables button
            startButton.SetActive(true);
            //Enables text, sets it on a relative position to the selected character and displays that characters name
            selectedCharacterText.enabled = true;
            selectedCharacterText.text = "" + selectedCharacter.name;
            selectedCharacterText.rectTransform.anchoredPosition = new Vector2(selectedCharacter.transform.position.x * characters.Length * 13, 30);
        }
	}
}
