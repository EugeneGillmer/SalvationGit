using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
	//stats
	public float playerLevel=0;

    public float HP = 100;
	public float HPRegen = 10;
	public float MaxHP = 100;
	public float stamina= 100;
	public float staminaRegen= 10;
	public float ATK = 50;
	public float atkSpd = 10;

	//experience
	public float MC=0;
	public float KP=0;

	//collectibles/bools
	public float coins = 50;
	public bool hasDeonsStaffCard = false;

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

	public void Main()
	{
		if (KP > 100 && playerLevel<1) {
			//change player Level
			playerLevel=1;
			Debug.Log ("Level up! Player Level is now: " +playerLevel.ToString ());

			//adjust stats
			HP += HP * lvl1Increase;
			HPRegen += HPRegen * lvl1Increase;
			MaxHP += MaxHP * lvl1Increase;
			stamina += stamina * lvl1Increase;
			staminaRegen += staminaRegen * lvl1Increase;
			ATK += ATK * lvl1Increase;
			atkSpd += atkSpd * lvl1Increase;

			//adjust abilities
			jumpHeight += jumpHeight * lvl1Increase;
			dashDmg += dashDmg * lvl1Increase;
			dashRegen += dashRegen * lvl1Increase;
		} else if (KP > 200&&playerLevel>2) {
			//change player Level
			playerLevel=2;
			Debug.Log ("Level up! Player Level is now: " +playerLevel.ToString ());

			//adjust stats
			HP += HP * lvl2Increase;
			HPRegen += HPRegen * lvl2Increase;
			MaxHP += MaxHP * lvl2Increase;
			stamina += stamina * lvl2Increase;
			staminaRegen += staminaRegen * lvl2Increase;
			ATK += ATK * lvl2Increase;
			atkSpd += atkSpd * lvl2Increase;

			//adjust abilities
			jumpHeight += jumpHeight * lvl2Increase;
			dashDmg += dashDmg * lvl2Increase;
			dashRegen += dashRegen * lvl2Increase;
		} else if (KP > 300 && playerLevel<3) {
			//change player Level
			playerLevel=3;
			Debug.Log ("Level up! Player Level is now: " +playerLevel.ToString ());

			//adjust stats
			HP += HP * lvl3Increase;
			HPRegen += HPRegen * lvl3Increase;
			MaxHP += MaxHP * lvl3Increase;
			stamina += stamina * lvl3Increase;
			staminaRegen += staminaRegen * lvl3Increase;
			ATK += ATK * lvl3Increase;
			atkSpd += atkSpd * lvl3Increase;

			//adjust abilities
			jumpHeight += jumpHeight * lvl3Increase;
			dashDmg += dashDmg * lvl3Increase;
			dashRegen += dashRegen * lvl3Increase;
		} else if (KP > 400 && playerLevel<4) {
			//change player Level
			playerLevel=4;
			Debug.Log ("Level up! Player Level is now: " +playerLevel.ToString ());

			//adjust stats
			HP += HP * lvl4Increase;
			HPRegen += HPRegen * lvl4Increase;
			MaxHP += MaxHP * lvl4Increase;
			stamina += stamina * lvl4Increase;
			staminaRegen += staminaRegen * lvl4Increase;
			ATK += ATK * lvl4Increase;
			atkSpd += atkSpd * lvl4Increase;

			//adjust abilities
			jumpHeight += jumpHeight * lvl4Increase;
			dashDmg += dashDmg * lvl4Increase;
			dashRegen += dashRegen * lvl4Increase;
		} else if (KP > 500&& playerLevel<5) {
			//change player Level
			playerLevel=5;
			Debug.Log ("Level up! Player Level is now: " +playerLevel.ToString ());

			//adjust stats
			HP += HP * lvl5Increase;
			HPRegen += HPRegen * lvl5Increase;
			MaxHP += MaxHP * lvl5Increase;
			stamina += stamina * lvl5Increase;
			staminaRegen += staminaRegen * lvl5Increase;
			ATK += ATK * lvl5Increase;
			atkSpd += atkSpd * lvl5Increase;

			//adjust abilities
			jumpHeight += jumpHeight * lvl5Increase;
			dashDmg += dashDmg * lvl5Increase;
			dashRegen += dashRegen * lvl5Increase;
		}
	}
	void Update()
	{
		Main ();
	}
}
