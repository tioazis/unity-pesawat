using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    private Pesawat pesawatMusuh;
    public float speed2 = 10;
    public Transform[] pelurunya;
    public Pelurumusuh pel_musuh;
    public GameObject explosion;
    public float Delay;
    public int HpMusuh=1;
    private GameController gameController;



    // Use this for initialization
    public int GetHpmusuh()
    {
        print("s");
        return HpMusuh;
    }

    public void UpdateHpMusuh()
    {
        print("s");
        HpMusuh -= 1;
    }
    void Start () {
        this.transform.Rotate(0, 0, 180);
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }
    
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector2.up * 5 * Time.deltaTime);
        if (this.transform.position.y < -20)
            Destroy(this.gameObject);
        Delay -= Time.deltaTime;

        if(Delay<=0)
            foreach(Transform VarmissileLauncher in pelurunya)
            {
                Instantiate(pel_musuh, VarmissileLauncher.position, VarmissileLauncher.rotation);
                Delay = 1;
            }
	}

    

    

    
}
    