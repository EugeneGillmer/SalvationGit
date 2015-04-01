using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour
{
    public GameObject player;
    void OnCollisionEnter(Collision col)
    {
        //ruler hits enemy
        if (col.transform.name == "Ruler" && this.transform.tag == "Enemy")
        {
			GetComponent<Stats>().HP -= player.GetComponent<Stats>().ATK;
        }        
        //projectile hits enemy
        if (col.transform.tag == "Projectile" && this.transform.tag == "Enemy")
        {
            GetComponent<Stats>().HP -= (int)(col.gameObject.GetComponent<Rigidbody>().mass*0.1f);//remove *0.1f later when actual stats are in place
        }
        //enemy hits player
        if (this.transform.tag == "Enemy" && col.transform.tag == "Player")
        {
            player.GetComponent<Stats>().HP -= GetComponent<Stats>().ATK;
        }        
		//0 means 0!
		if (player.GetComponent<Stats> ().HP < 0)
			player.GetComponent<Stats> ().HP = 0;
		if (this.GetComponent<Stats> ().HP < 0)
			this.GetComponent<Stats> ().HP = 0;
    }
}