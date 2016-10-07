using UnityEngine;
using System.Collections;

public class FlickerLights : MonoBehaviour {

    public float FadeSpeed = 1f; // Intensity units per second
    
    private Light LightComponent;
	private bool FadingIn = true;
    
	// Use this for initialization
	void Start () {
        
        LightComponent = GetComponent<Light>();
        LightComponent.intensity = 1f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
        LightComponent.intensity = AnimationUtilities.MappedPingPong(0.5f,1f,5f);
        LightComponent.range = AnimationUtilities.MappedPingPong(0.5f,1f,5f);
        
        }
	}

