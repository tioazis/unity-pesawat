using UnityEngine;
using System.Collections;

public class GantiScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void mainscene()
    {
        Application.LoadLevel("Main Scene");
    }

    public void keluar()
    {
        Application.Quit();
    }
}
