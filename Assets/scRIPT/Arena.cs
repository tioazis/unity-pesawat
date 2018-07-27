using UnityEngine;
using System.Collections;

public class Arena : MonoBehaviour {
    public GameObject water;
    public Pulau[] island;
    public Enemy[] musuh;

    private float generateIslandDelayCount;
    private float generateMusuhDelayCount;

    private Vector2 minPosition, maxPosition;

	// Use this for initialization
	void Start () {
        minPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        maxPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float waterPosX = minPosition.x, waterPosY = minPosition.y;

        SpriteRenderer instWater = (Instantiate(water, new Vector2(waterPosX, waterPosY), Quaternion.identity) as GameObject).GetComponent<SpriteRenderer>();
        instWater.transform.parent = this.transform;

        while (waterPosY - 2 * instWater.sprite.bounds.max.y < maxPosition.y)
        {
            waterPosX = minPosition.x;
            while (waterPosX - 2 * instWater.sprite.bounds.max.x < maxPosition.x)
            {
                instWater = (Instantiate(water, new Vector2(waterPosX, waterPosY), Quaternion.identity) as GameObject).GetComponent<SpriteRenderer>();
                instWater.transform.parent = this.transform;
                waterPosX += 2 * instWater.sprite.bounds.max.x;
            }
            waterPosY += 2 * instWater.sprite.bounds.max.y;
        }
    }
	
	// Update is called once per frame
	void Update () {
        generateIslandDelayCount -= Time.deltaTime;
        generateMusuhDelayCount -= Time.deltaTime;

        if (generateIslandDelayCount <= 0)
        {
            Instantiate(island[Random.Range(0, 4)], new Vector2(Random.Range(minPosition.x, maxPosition.x), 10), Quaternion.identity);
            generateIslandDelayCount = Random.Range(5, 15);
        }

        if (generateMusuhDelayCount <= 0)
        {
            Instantiate(musuh[Random.Range(0, musuh.Length - 1)], new Vector2(Random.Range(minPosition.x, maxPosition.x), 10), Quaternion.identity);
            generateMusuhDelayCount = Random.Range(3, 1);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.LoadLevel(0);
        }

    }
}
