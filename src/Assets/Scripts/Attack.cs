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
            GetComponent<Stats>().HP -= (int)col.gameObject.GetComponent<Rigidbody>().mass;//LATER put player's attack value in here
        }        
        //projectile hits enemy
        if (col.transform.tag == "Projectile" && this.transform.tag == "Enemy")
        {
            GetComponent<Stats>().HP -= (int)(col.gameObject.GetComponent<Rigidbody>().mass*0.1f);//remove *0.1f later when actual stats are in place
            Debug.Log("projectile hits enemy");
        }
        //enemy hits player
        if (this.transform.tag == "Enemy" && col.transform.tag == "Player")
        {
            Debug.Log("OUCH!");
            player.GetComponent<Stats>().HP -= GetComponent<Stats>().ATK;
        }        
    }
}