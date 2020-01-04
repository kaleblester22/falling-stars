using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployStars : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject starPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(starWave());

    }
    private void spawnStar()
    {
        GameObject a = Instantiate(starPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y );



    }
    
    IEnumerator starWave(){
        while (true){
            yield return new WaitForSeconds(respawnTime);
            spawnStar();


        }
        

    }
}
