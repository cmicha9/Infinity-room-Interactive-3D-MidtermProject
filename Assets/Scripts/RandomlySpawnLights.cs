using UnityEngine;
using System.Collections;

public class RandomlySpawnLights : MonoBehaviour {

    public GameObject[] Prefabs;
    public int NumberToSpawn = 100;
    
	// Use this for initialization
	void Start () {
        for (int i=0; i<NumberToSpawn; i += 1){
           int randomIndex = Random.Range(0, Prefabs.Length); 
            GameObject randomPrefab = Prefabs[randomIndex];
            
            Vector3 randomPos = new Vector3(Random.Range(-20f,20f),Random.Range(-20f,20f),Random.Range(-20f,20f));
            Quaternion randomRot = Quaternion.Euler(0f,0f,0f);
        
            Instantiate(randomPrefab,randomPos,randomRot);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
