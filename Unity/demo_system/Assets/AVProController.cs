using RenderHeads.Media.AVProVideo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AVProController : MonoBehaviour {

    [SerializeField]
    private MediaPlayer m_MediaPlayer = null;

    // Use this for initialization
    void Start () {
        this.Load("/Users/yanomekeifutoshi/work/SR/sig_asia/demo_system/Assets/StreamingAssets/AVProVideoSamples/BigBuckBunny_720p30.mp4", false);

    }

    public void Load(string path, bool isLooping = false)
    {
        m_MediaPlayer.m_StereoPacking = StereoPacking.TopBottom;
        m_MediaPlayer.OpenVideoFromFile(MediaPlayer.FileLocation.AbsolutePathOrURL, path, false);
        m_MediaPlayer.Control.SetLooping(isLooping);
    }


    public void Pause()
    {
        m_MediaPlayer.Pause();
    }

    public void Play()
    {
        m_MediaPlayer.Play();
    }

    public void SeekTo(int position)
    {
        m_MediaPlayer.Control.SeekFast((float)position);
    }

    public void Stop()
    {
        m_MediaPlayer.Rewind(true);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("a"))
        {
            print("kaj");
            this.Play();
        }
    }
}
