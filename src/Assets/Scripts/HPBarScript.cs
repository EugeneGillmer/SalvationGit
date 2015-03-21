using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPBarScript : MonoBehaviour {


    public Image HPBarRect;
    public Image HPBarCircle;
    public GameObject character;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (character != null)
        {
            if (character.tag == "Player")
            {
                if (character.GetComponent<Stats>().HP > 0.5f * character.GetComponent<Stats>().MaxHP)
                {
                    //hp - half maxHP / halfmaxHP * 100 = percentageWidth
                    HPBarRect.rectTransform.sizeDelta = new Vector2(((float)character.GetComponent<Stats>().HP - 0.5f * character.GetComponent<Stats>().MaxHP) / 0.5f * character.GetComponent<Stats>().MaxHP *100, HPBarRect.GetComponent<RectTransform>().sizeDelta.y);
                }
                else
                {
                    //gets amount of HP divided by max HP *100 * 2
                    HPBarCircle.fillAmount = ((float)character.GetComponent<Stats>().HP / character.GetComponent<Stats>().MaxHP * 100)*2;
                }
            }
            else
            {
                HPBarRect.rectTransform.sizeDelta = new Vector2((float)character.GetComponent<Stats>().HP, HPBarRect.GetComponent<RectTransform>().sizeDelta.y);
            }
            //destroy enemies if hp <= 0
            if (character.GetComponent<Stats>().HP <= 0 && character.tag != "Player")
            {
                Destroy(character.gameObject);
            }
        }
    }
}
