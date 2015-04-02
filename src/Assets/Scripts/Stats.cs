using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    //stats
    public float HP = 2000;
    public float stamina = 100;

    public float HPRegen = 10;
    public float MaxHP = 2000;
    public float staminaRegen = 10;
    public float ATK = 500;
    public float atkSpd = 10;

    //abilities
    public float jumpHeight = 10;
    public float dashDmg = 100;
    public float dashRegen = 25;

    //experience
    public int MC = 0;
    public int KP = 0;
    int playerKPLevel;
    int playerMCLevel;

    //collectibles/bools put these in inventory script later
    public float coins = 50;
    public bool hasDeonsStaffCard = false;
    public bool defeatedKitty = false;
    public bool defeatedKayode = false;    

    //script vars
    int nextKPLevel;
    int nextMCLevel;

    void Start()
    {

    }

    void Update()
    {
        //get experience values
        KP = Mathf.RoundToInt(this.GetComponent<Stats>().KP);
        MC = Mathf.RoundToInt(this.GetComponent<Stats>().MC);

        //check if level up

        //nextKPLevel
        if (KP > nextKPLevel)
        {
            HPRegen = HPRegen + 0.1f * HPRegen;
            MaxHP = MaxHP + 0.1f * MaxHP;
            staminaRegen = staminaRegen + 0.2f * staminaRegen;
            ATK = ATK + 0.1f * ATK;
            atkSpd = atkSpd + 0.1f * atkSpd;

            nextKPLevel = nextKPLevel * 2;
        }
        //nextMCLevel
        if (MC > nextMCLevel)
        {
            jumpHeight = jumpHeight + 0.1f * jumpHeight;
            dashDmg = dashDmg + 0.1f * dashDmg;
            dashRegen = dashRegen = 0.1f * dashRegen;

            nextMCLevel = nextMCLevel * 2;
        }

    }
    
}
