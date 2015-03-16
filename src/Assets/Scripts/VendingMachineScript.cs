using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VendingMachineScript : MonoBehaviour {

    public GameObject player;

    public void PayForCola()
    {
        player.GetComponent<Stats>().coins -= 5;
    }
}
