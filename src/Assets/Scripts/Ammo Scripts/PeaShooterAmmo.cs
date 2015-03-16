using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PeaShooterAmmo : MonoBehaviour 
{

    public GameObject player;

    public Text peaAmmoText;
    public float peaAmmo = 25;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && player.GetComponent<Shoot>().WeaponNumber == 0)
        {
            peaAmmo -= 1;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RefillPeaAmmo();
        }
        
        if (peaAmmo < 0)
            peaAmmo = 0;

        peaAmmoText.text = (peaAmmo-1f).ToString();
	}
    public void RefillPeaAmmo()
    {
        peaAmmo = 100;
    }
}
