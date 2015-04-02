using UnityEngine;
using System.Collections;

public class ReplenishHP : MonoBehaviour {

    public float replenishAmount = 10;

    void OnTriggerStay(Collider thing)
    {
        if (thing.gameObject.GetComponent<Stats>() != null)
        {
            thing.gameObject.GetComponent<Stats>().HP += replenishAmount * Time.deltaTime;

            if (thing.gameObject.GetComponent<Stats>().HP >= thing.gameObject.GetComponent<Stats>().MaxHP)
                thing.gameObject.GetComponent<Stats>().HP = thing.gameObject.GetComponent<Stats>().MaxHP;
        }
    }
}
