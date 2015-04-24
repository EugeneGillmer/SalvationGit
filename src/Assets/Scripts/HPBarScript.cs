using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPBarScript : MonoBehaviour
{


    public Image HPBarRect;
    public Image HPBarCircle;
    public GameObject character;
    public float HP;
    public float MaxHP;
    public Text HPPercentageIndicator;


    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //get character HP
        HP = character.GetComponent<Stats>().HP;
        MaxHP = character.GetComponent<Stats>().MaxHP;

        if (character != null)
        {
            //player HP Bar
            if (character.tag == "Player")
            {
                HPPercentageIndicator.text = HP.ToString() + " / " + MaxHP.ToString();
                if (HP > (0.5f * MaxHP))
                {
                    HPBarRect.enabled = true;
                    //hp - half maxHP / halfmaxHP * 100 = percentageWidth
                    HPBarRect.rectTransform.sizeDelta = new Vector2((HP - (0.5f * MaxHP)) / (0.5f * MaxHP) * 100, HPBarRect.GetComponent<RectTransform>().sizeDelta.y);
                    HPBarCircle.fillAmount = 1;
                }
                else
                {
                    HPBarRect.enabled = false;
                    //(HP / (0.5f*MaxHP))
                    HPBarCircle.fillAmount = (HP / (0.5f * MaxHP));
                }
            }
            //Enemy HP Bar
            else
            {
                HPBarRect.rectTransform.sizeDelta = new Vector2((float)character.GetComponent<Stats>().HP, HPBarRect.GetComponent<RectTransform>().sizeDelta.y);
            }
            //destroy enemies if hp <= 0
            if (character.GetComponent<Stats>().HP <= 0 && character.tag != "Player")
            {
                Destroy(character.gameObject);
                Destroy(HPBarRect.gameObject);
                Destroy(HPBarCircle.gameObject);
            }
        }
    }
}
