using UnityEngine;
using System.Collections;

public class FlickerLights2 : MonoBehaviour {

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
        
        LightComponent.intensity = AnimationUtilities.MappedPingPong(FadeSpeed,1f,3f);
        LightComponent.range = AnimationUtilities.MappedPingPong(FadeSpeed,1f,3f);
	
	}
}
