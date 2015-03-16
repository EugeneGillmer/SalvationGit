
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Reloader : MonoBehaviour {

    public GameObject peaShooterAmmo;
    public GameObject mainCamera;
    public Text peaAmmoText;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                string name = hit.collider.name;                
                if (name == "TrashCan") 
                {
                    peaShooterAmmo.GetComponent<PeaShooterAmmo>().RefillPeaAmmo();
                    peaAmmoText.text = (peaShooterAmmo.GetComponent<PeaShooterAmmo>().peaAmmo - 1).ToString();
                }
            }            
        }
	}
}
