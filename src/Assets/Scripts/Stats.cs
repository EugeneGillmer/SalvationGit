using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    //stats
    public float playerKPLevel = 0;
    public float playerMCLevel = 0;

    public float HP = 100;
    public float HPRegen = 10;
    public float MaxHP = 2000;
    public float stamina = 100;
    public float staminaRegen = 10;
    public float ATK = 500;
    public float atkSpd = 10;

    //experience
    public float MC = 0;
    public float KP = 0;

    //collectibles/bools
    public float coins = 50;
    public bool hasDeonsStaffCard = false;
    public bool defeatedKitty = false;
    public bool defeatedKayode = false;

    //abilities
    public float jumpHeight = 10;
    public float dashDmg = 100;
    public float dashRegen = 25;

    //level increases
    float lvl1Increase = 0.1f;
    float lvl2Increase = 0.2f;
    float lvl3Increase = 0.3f;
    float lvl4Increase = 0.4f;
    float lvl5Increase = 0.5f;

    public void KPCheck()
    {
        if (KP >= 100 && KP < 200 && playerKPLevel < 1)
        {
            //change player Level
            playerKPLevel = 1;
            Debug.Log("KP Level up! Player Level is now: " + playerKPLevel.ToString());

            //adjust stats
            HP += HP * lvl1Increase;
            HPRegen += HPRegen * lvl1Increase;
            MaxHP += MaxHP * lvl1Increase;
            stamina += stamina * lvl1Increase;
            staminaRegen += staminaRegen * lvl1Increase;
            ATK += ATK * lvl1Increase;
            atkSpd += atkSpd * lvl1Increase;
        }
        else if (KP >= 200 && KP < 300 && playerKPLevel < 2)
        {
            //checks if lvl 1 boss is defeated
            if (defeatedKayode == false)
            {
                KP = 199;
            }
            else
            {
                //change player Level
                playerKPLevel = 2;
                Debug.Log("KP Level up! Player Level is now: " + playerKPLevel.ToString());

                //adjust stats
                HP += HP * lvl2Increase;
                HPRegen += HPRegen * lvl2Increase;
                MaxHP += MaxHP * lvl2Increase;
                stamina += stamina * lvl2Increase;
                staminaRegen += staminaRegen * lvl2Increase;
                ATK += ATK * lvl2Increase;
                atkSpd += atkSpd * lvl2Increase;
            }
        }
        else if (KP >= 300 && KP < 400 && playerKPLevel < 3)
        {
            //checks if lvl 2 boss is defeated
            if (defeatedKitty == false)
            {
                KP = 299;
            }
            else
            {
                //change player Level
                playerKPLevel = 3;
                Debug.Log("KP Level up! Player Level is now: " + playerKPLevel.ToString());

                //adjust stats
                HP += HP * lvl3Increase;
                HPRegen += HPRegen * lvl3Increase;
                MaxHP += MaxHP * lvl3Increase;
                stamina += stamina * lvl3Increase;
                staminaRegen += staminaRegen * lvl3Increase;
                ATK += ATK * lvl3Increase;
                atkSpd += atkSpd * lvl3Increase;
            }
        }
        else if (KP >= 400 && KP < 500 && playerKPLevel < 4)
        {
            //change player Level
            playerKPLevel = 4;
            Debug.Log("KP Level up! Player Level is now: " + playerKPLevel.ToString());

            //adjust stats
            HP += HP * lvl4Increase;
            HPRegen += HPRegen * lvl4Increase;
            MaxHP += MaxHP * lvl4Increase;
            stamina += stamina * lvl4Increase;
            staminaRegen += staminaRegen * lvl4Increase;
            ATK += ATK * lvl4Increase;
            atkSpd += atkSpd * lvl4Increase;
        }
        else if (KP > 500 && playerKPLevel < 5)
        {
            //change player Level
            playerKPLevel = 5;
            Debug.Log("KP Level up! Player Level is now: " + playerKPLevel.ToString());

            //adjust stats
            HP += HP * lvl5Increase;
            HPRegen += HPRegen * lvl5Increase;
            MaxHP += MaxHP * lvl5Increase;
            stamina += stamina * lvl5Increase;
            staminaRegen += staminaRegen * lvl5Increase;
            ATK += ATK * lvl5Increase;
            atkSpd += atkSpd * lvl5Increase;
        }
    }

    public void MCCheck()
    {
        if (MC >= 100 && MC < 200 && playerMCLevel < 1)
        {
            //change player Level
            playerMCLevel = 1;
            Debug.Log("MC Level up! Player Level is now: " + playerMCLevel.ToString());

            //adjust abilities
            jumpHeight += jumpHeight * lvl1Increase;
            dashDmg += dashDmg * lvl1Increase;
            dashRegen += dashRegen * lvl1Increase;
        }
        else if (MC >= 200 && MC < 300 && playerMCLevel < 2)
        {
            //change player Level
            playerMCLevel = 2;
            Debug.Log("MC Level up! Player Level is now: " + playerMCLevel.ToString());

            //adjust abilities
            jumpHeight += jumpHeight * lvl2Increase;
            dashDmg += dashDmg * lvl2Increase;
            dashRegen += dashRegen * lvl2Increase;
        }

        else if (MC >= 300 && MC < 400 && playerMCLevel < 3)
        {
            //change player Level
            playerMCLevel = 3;
            Debug.Log("MC Level up! Player Level is now: " + playerMCLevel.ToString());

            //adjust abilities
            jumpHeight += jumpHeight * lvl3Increase;
            dashDmg += dashDmg * lvl3Increase;
            dashRegen += dashRegen * lvl3Increase;
        }

        else if (MC >= 400 && MC < 500 && playerMCLevel < 4)
        {
            //change player Level
            playerMCLevel = 4;
            Debug.Log("MC Level up! Player Level is now: " + playerMCLevel.ToString());

            //adjust abilities
            jumpHeight += jumpHeight * lvl4Increase;
            dashDmg += dashDmg * lvl4Increase;
            dashRegen += dashRegen * lvl4Increase;
        }
        else if (MC > 500 && playerMCLevel < 5)
        {
            //change player Level
            playerMCLevel = 5;
            Debug.Log("MC Level up! Player Level is now: " + playerMCLevel.ToString());

            //adjust abilities
            jumpHeight += jumpHeight * lvl5Increase;
            dashDmg += dashDmg * lvl5Increase;
            dashRegen += dashRegen * lvl5Increase;
        }
    }
    void Update()
    {
        KPCheck();
        MCCheck();
    }
}
