using UnityEngine;
using System.Collections;

public class ProjectileStick : MonoBehaviour {

    void OnCollisionStay()
    {
        this.GetComponent<Rigidbody>().drag = 50;
        this.GetComponent<Rigidbody>().angularDrag = 50;
    }
    void OnCollisionExit()
    {
        this.GetComponent<Rigidbody>().drag = 0;
        this.GetComponent<Rigidbody>().angularDrag = 0;
    }
}
