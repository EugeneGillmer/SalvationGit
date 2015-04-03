using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Shoot : MonoBehaviour
{
    public Camera eyes;
    public GameObject body;
    public GameObject peaShooter;    

    public Rigidbody peaAmmo;
    public Rigidbody eraser;
    public Rigidbody pen;
    public Rigidbody projectile3;
    public Rigidbody projectile4;
    Rigidbody selectedWeapon;

    public Button btnPea;
    public Button btnEraser;
    public Button btnPen;
    public Button btnP4;
    public Button btnP5;

    public float zoomDistance = 100f;
    public float zoomSmooth = 50f;
    public float shotSpeed = 10f;
    public float upSpeed = 10f;
    public bool MG = false;
    
    public int WeaponNumber = 0;

    Vector3 hiddenPeaPosition;


    // Use this for initialization
    void Start()
    {
        hiddenPeaPosition = new Vector3(eyes.transform.position.x, eyes.transform.position.y-5, eyes.transform.position.z);        
    }

    // Update is called once per frame
    void Update()
    {

        //scrolling for weapons
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            WeaponNumber += 1;
            if (WeaponNumber > 4)
                WeaponNumber = 0;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            WeaponNumber -= 1;
            if (WeaponNumber < 0)
                WeaponNumber = 4;
        }

        //change weapon
        if (WeaponNumber == 0)
        {
            selectedWeapon = peaAmmo;
            peaShooter.transform.position = new Vector3(transform.position.x,transform.position.y-0.5f,transform.position.z);
            //btnPea.Select();
        }
        else if (WeaponNumber > 0)
        {
            peaShooter.transform.position = hiddenPeaPosition;
            if (WeaponNumber == 1)
            {
                selectedWeapon = eraser;
                //btnEraser.Select();
            }
            else if (WeaponNumber == 2)
            {
                selectedWeapon = pen;
                //btnPen.Select();
            }
            else if (WeaponNumber == 3)
            {
                selectedWeapon = projectile3;
                //btnP4.Select();
            }
            else if (WeaponNumber == 4)
            {
                selectedWeapon = projectile4;
                //btnP5.Select();
            }
        }
     
        //zoom if pencil is selected
        if (selectedWeapon==pen)
        {
            if (Input.GetMouseButtonDown(1))
            {
                eyes.fieldOfView = 20;
            }
            if (Input.GetMouseButtonUp(1))
            {
                eyes.fieldOfView = 60;
            }
        }
        
        //the actual shooting function:
        if (MG == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (WeaponNumber == 0 && selectedWeapon.GetComponent<PeaShooterAmmo>().peaAmmo > 0)
                {
                    Fire(selectedWeapon);
                }
                if (WeaponNumber == 1 && selectedWeapon.GetComponent<EraserAmmo>().eraserAmmo > 0)
                {
                    Fire(selectedWeapon);
                }
                if (WeaponNumber == 2 && selectedWeapon.GetComponent<PenAmmo>().penAmmo > 0)
                {
                    Fire(selectedWeapon);
                }
                //if (WeaponNumber == 3 && selectedWeapon.GetComponent<PeaShooterAmmo>().peaAmmo > 0)
                //{
                //    Fire(selectedWeapon);
                //}
                //if (WeaponNumber == 4 && selectedWeapon.GetComponent<PeaShooterAmmo>().peaAmmo > 0)
                //{
                //    Fire(selectedWeapon);
                //}
            }
        }
        else
        //machinegun testing fun
        {
            if (Input.GetMouseButton(0))
            {
                Fire(selectedWeapon);

            }
        }
        //activate/deactivate MG ingame
        if (Input.GetKeyDown(KeyCode.M))
        {
            MG = !MG;
        }
    }
    void Fire(Rigidbody selWep)
    {
        Rigidbody clone;
        clone = Instantiate(selWep, new Vector3(transform.position.x, transform.position.y - 1, transform.position.z), transform.rotation) as Rigidbody;
        clone.velocity = transform.TransformDirection(0, upSpeed, shotSpeed);
    }
}
