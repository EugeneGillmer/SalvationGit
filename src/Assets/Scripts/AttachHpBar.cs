using UnityEngine;
using System.Collections;

public class AttachHpBar : MonoBehaviour {


    public GameObject enemyHPBar;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        enemyHPBar.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 8, this.transform.position.z);
	}
}
