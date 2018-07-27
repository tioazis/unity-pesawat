using UnityEngine;
using System.Collections;

public class Pelurumusuh : MonoBehaviour
{
    public GameObject explosion;
    private GameController gameController;
    public GameController psawat;
   
    // Use this for initialization
    void Start()
    {
        GameObject Hpdecrement = GameObject.Find("GameObject");
        psawat = Hpdecrement.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector2(0, 10) * Time.deltaTime);
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            psawat.UpdateHp(1);
            //print(psawat.getHp());
            Destroy(this.gameObject);
            Destroy(expl, 0.1f);
            if (psawat.Hp == 0)
            {
                Destroy(col.gameObject);            
                Application.LoadLevel(0);
            }
 
        }
    }
}
