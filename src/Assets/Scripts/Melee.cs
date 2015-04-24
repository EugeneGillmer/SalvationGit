//Eugene Gillmer Botha
//2015/04/23

//Melee Script
//Should detect when a player wants to attack and play an animation 

using UnityEngine;
using System.Collections;

public class Melee : MonoBehaviour {

    string attackAnim;
    int attackNumber;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //generate a new random number to pick which animation will play
            attackNumber = Random.Range(0, 3);

            //assign animation
            switch (attackNumber)
            {
                case 0:
                    attackAnim = "Attack_1";
                    break;
                case 1:
                    attackAnim = "Attack_2";
                    break;
                case 2:
                    attackAnim = "Attack_3";
                    break;
            }
            //play animation
            GetComponent<Animation>().Play(attackAnim);
        }
	}
}
