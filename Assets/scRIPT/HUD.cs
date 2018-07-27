using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
    public Pesawat pesawat;



	// Update is called once per frame
	void Update () {
	if (Input.GetKey(KeyCode.UpArrow))
        {
            pesawat.MoveUp();
        }
    if (Input.GetKey(KeyCode.DownArrow))
        {
            pesawat.MoveDown();
        }
    if (Input.GetKey(KeyCode.LeftArrow))
        {
            pesawat.MoveLeft();
        }
    if (Input.GetKey(KeyCode.RightArrow))
        {
            pesawat.MoveRight();
        }
    if(Input.GetKey(KeyCode.Space))
        {
            pesawat.Attack();
        }

    }
}
