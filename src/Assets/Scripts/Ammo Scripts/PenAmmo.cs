using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PenAmmo : MonoBehaviour
{

    public GameObject player;

    public Text penAmmoText;
    public float penAmmo = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //detect shot
        if (Input.GetMouseButtonDown(0) && player.GetComponent<Shoot>().WeaponNumber == 2)
        {
            penAmmo -= 1;
        }
        
        if (penAmmo < 0)
            penAmmo = 0;
        //reload FOR TESTING PURPOSES
        if (Input.GetKeyDown(KeyCode.R))
        {
            RefillPenAmmo();
        }
        //display ammo
        penAmmoText.text = (penAmmo-1).ToString();
    }
    public void RefillPenAmmo()
    {
        penAmmo = 10;
    }
}