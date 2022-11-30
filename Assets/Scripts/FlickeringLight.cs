using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour
{

    public new Light light;
    public float minIntensity = 0f;            //minimum light intensity 
    public float maxIntensity = 1f;           // maximum Light Intensity 

    [Range(1, 50)]
    public int smoothing = 30;                // soft glow rather than sparks 

    Queue<float> smoothQueue;               // continuous Claculation 
    float lastSum = 0;

    // Start is called before the first frame update
    void Start()
    {
        smoothQueue = new Queue<float>(smoothing);
        // External or internal light?
        if (light == null)
        {
            light = GetComponent<Light>();
        }

        // Update is called once per frame
        void Update()
        {
            if (light == null)
                return;


            float newVal = Random.Range(minIntensity, maxIntensity);
            smoothQueue.Enqueue(newVal);
            lastSum += newVal;


        }
    }
}
