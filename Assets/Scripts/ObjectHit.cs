using Mono.Cecil.Cil;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    [SerializeField] float colorTransitionTime = 1f;
    Color currentColor;
    bool isHit = false;

    void Start()
    {
        currentColor = GetComponent<MeshRenderer>().material.color;
    }

    void Update()
    {
        FlashColor();
    }
    void OnCollisionEnter(Collision collision)
    {
        isHit = true;
        Debug.Log("You hit an object!");
    }

    void FlashColor()
    {
        if (isHit)
        {
            // TO FIX gradient of colour flash to red and back to original colour
            // GetComponent<MeshRenderer>().material.color = Color.Lerp(currentColor, Color.red, Mathf.PingPong(Time.time, colorTransitionTime)); 
            GetComponent<MeshRenderer>().material.color = Color.Lerp(currentColor, Color.red, colorTransitionTime); 
            GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.red, currentColor, colorTransitionTime); 
            isHit = false;
        }
    }

}
