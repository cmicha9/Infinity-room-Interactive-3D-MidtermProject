using UnityEngine;
using System.Collections;

public class InstantiateLights : MonoBehaviour {
    public Light LightComponent;
    public GameObject Prefab;

	// Use this for initialization
	void Start () {
        LightComponent = GetComponent<Light>();
        
        // Creating a copy of an object
        //specifying location of the prefab
        Vector3 spawnPoint = new Vector3(0f,2f,0f);
        //specifying no rotation
        Quaternion rotation = Quaternion.identity;
        Instantiate(Prefab,spawnPoint,rotation);
        
	// Spawning and casting
        
        //makes another instance in a new location at a new rotation in Quaternion units and changes the color to blue
        /*GameObject clone = (GameObject) Instantiate(Prefab,new Vector3(1f,3f,1f),rotation);
        clone.transform.localScale = new Vector3(1f,3f,1f);
        Material mat = clone.GetComponent<MeshRenderer>().material;
        mat.color = new Color(0f,1f,2f);*/
	
    // Grid - 2D loop
        for (int x=0; x<20; x+=1){
            for(int y=0; y<5; y+=1){
                for (int z=0; z<20;z+=1)
            {
                /*Vector3 spawnPoint2 = new Vector3(0f,2f,0f);
                Quaternion rotation2 = Quaternion.identity;*/
                GameObject clone2 =(GameObject)Instantiate(Prefab, new Vector3(x*3f,y*3f,z*3f),Quaternion.identity);
                 Material mat2 = clone2.GetComponent<MeshRenderer>().material;
                 //makes color vary with your distance to the controller  
                /*mat2.color = new Color(x/9f,x/9f,y/9f);*/
                
                //decrease the width of object by 0.1
                transform.localScale = new Vector3(Random.Range(0.01f,3f),Random.Range(0.01f,3f),Random.Range(0.1f,3f));
                
            }
        }
    }
        
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
