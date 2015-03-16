using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EraserAmmo : MonoBehaviour
{

    public GameObject player;
    public Text eraserAmmoText;
    public float eraserAmmo = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && player.GetComponent<Shoot>().WeaponNumber == 1)
        {
            eraserAmmo -= 1;
            Debug.Log(eraserAmmo);
        }
        if (eraserAmmo < 0)
            eraserAmmo = 0;

        if(Input.GetKeyDown(KeyCode.R))
        {
            RefillEraserAmmo();
        }

        eraserAmmoText.text = (eraserAmmo-1f).ToString();

    }
    public void RefillEraserAmmo()
    {
        eraserAmmo = 25;
    }
}