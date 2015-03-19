using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPBarScript : MonoBehaviour {


    public Image HPBar;
    public GameObject character;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        HPBar.rectTransform.sizeDelta = new Vector2((float)character.GetComponent<Stats>().HP, HPBar.GetComponent<RectTransform>().sizeDelta.y);
        if (character.GetComponent<Stats>().HP < 0)
        {
            Destroy(character.gameObject);
        }
	}
}
