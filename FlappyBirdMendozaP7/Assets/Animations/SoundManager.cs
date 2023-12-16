using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour
{
    private AudioSource[] mysounds;

    private AudioSource flap;
    private AudioSource die;
    // Start is called before the first frame update
    void Start()
    {
        mysounds = GetComponents<AudioSource>();

        flap = mysounds[0];
        die = mysounds[1];
    }
    
    public void playFlap()
    {
        flap.Play();
    }
    
    public void playDie()
    {
        die.Play();
    }
}
