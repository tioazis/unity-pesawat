using UnityEngine;
using System.Collections;

public class Pulau : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector2.down * Time.deltaTime);
        if(this.transform.position.y < -20)
        {
            Destroy(this.gameObject);
        }
	}
}
