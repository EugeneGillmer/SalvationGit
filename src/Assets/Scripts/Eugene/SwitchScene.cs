using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {

    public string LevelName;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag=="Player")
                Application.LoadLevel(LevelName);

    }
}
