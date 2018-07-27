using UnityEngine;
using System.Collections;


public class Pesawat : MonoBehaviour
{
    public float speed = 100;
    public Transform[] missileLaunchers;
    public Peluru missile;
    public float attackDelay = 0.05f;
    public bool limitMove = true;
    private int HealthPoint=3;
    private Vector2 minPosition, maxPosition;
    private float attackDelayCounter;
    public bool pausedong;

    // Use this for initialization
    public int getHp()
    {
        return HealthPoint;
    }

    public void UpdateHp()
    {
        HealthPoint -= 1;

    }
    void Start()
    {
        minPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        maxPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
        {
            attackDelayCounter -= Time.deltaTime;
        }
    public void MoveUp(){
        if (limitMove) {
            Vector2 newPosition = (Vector2)this.transform.position + Vector2.up * speed * Time.deltaTime;
            if (newPosition.x < maxPosition.x) {
                this.transform.position = newPosition; 
        }
        else{
            this.transform.Translate(new Vector2(0,10)*speed*Time.deltaTime);

        }
        }
            
        }
    public void MoveDown()
        {
        if (limitMove)
        {
            Vector2 newPosition = (Vector2)this.transform.position - Vector2.up * speed * Time.deltaTime;
            if (newPosition.y > minPosition.y)
            {
                this.transform.position = newPosition;
            }
        }
            this.transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    public void MoveLeft()
    {
        Vector2 newPosition = (Vector2)this.transform.position-Vector2.right * speed * Time.deltaTime;
        if (newPosition.x < maxPosition.x)
        {
            this.transform.position = newPosition;
        }
    }
    public void MoveRight()
    {
        if (limitMove)
        {
            Vector2 newPosition = (Vector2)this.transform.position + Vector2.right * speed * Time.deltaTime;
            if (newPosition.x < maxPosition.x)
            {
                this.transform.position = newPosition;
            }
        }

    }
   
    public void Attack()
    {
        if (attackDelayCounter <= 0)
        {
            foreach(Transform missileLauncher in missileLaunchers)
            {
                Instantiate(missile, missileLauncher.position, missileLauncher.rotation);
            }
            attackDelayCounter = attackDelay;
            {

            }
        }
    }

    public void GamePausedong()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            ApplicationPause (true);
        }
        else
        {
            Time.timeScale = 1;
            ApplicationPause (false);
        }
    }

    void OnGui()
    {
        GUI.Box(new Rect(Screen.width / 2 - 140, Screen.height / 2 - 70, 250, 40), "GAME PAUSED");
    }
    void ApplicationPause(bool status)
    {
        pausedong = status;
    }
    
}
