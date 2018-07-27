using UnityEngine;
using System.Collections;

public class Peluru : MonoBehaviour {
    public int scoreValue = 78;
    public GameObject explosion;
    private GameController gameController;
    private Enemy musuh;
	// Use this for initialization
	void Start () {
        musuh = FindObjectOfType<Enemy>();

        GameObject gameControllerObject = GameObject.Find("GameObject");
        gameController = gameControllerObject.GetComponent<GameController>();

        GameObject HpMusuhKurang = GameObject.FindWithTag("Musuh");
        musuh = HpMusuhKurang.GetComponent<Enemy>();
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector2(0, 10) * Time.deltaTime);
        if (this.transform.position.y>20)
        {
            Destroy(this.gameObject);
        }
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        

        if (col.gameObject.tag == "Musuh" )
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity)as GameObject;

            gameController.AddScore(1);
            Destroy(col.gameObject);
            Destroy(expl, 0.1f);
            musuh.UpdateHpMusuh();
            

            /*if (musuh.HpMusuh==0)
            {
                
                Destroy(col.gameObject);
                Destroy(this.gameObject);

            }*/

        }
    }
}
