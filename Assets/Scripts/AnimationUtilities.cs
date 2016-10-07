using UnityEngine;
using System.Collections;

public class AnimationUtilities {

	public static float MappedPingPong(float duration, float min, float max){
        float pongedTime = Mathf.PingPong(Time.time, duration); // 0 to duration
        float lerpAmount = pongedTime/duration; // 0 to 1
        float mappedValue = Mathf.Lerp(min,max,lerpAmount); // min to max
        return mappedValue;
        
    }
    public static Color MappedPingPong(float duration, Color color1, Color color2){
        float pongedTime = Mathf.PingPong(Time.time, duration); // 0 to duration
        float lerpAmount = pongedTime/duration; // 0 to 1
        Color color = Color.Lerp(color1,color2,lerpAmount); // min to max
        return color;
    }
}
