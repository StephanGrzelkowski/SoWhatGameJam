using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FrequencyAnalyzer : MonoBehaviour
{
    public AudioSource cur_sample;
    public float[] sample = new float[512];
    // Start is called before the first frame update
    void Start()
    {
        cur_sample = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    public void GetSpectrumAudioSource()
    {
        cur_sample.GetSpectrumData(sample, 0, FFTWindow.Hamming);
    }
}
