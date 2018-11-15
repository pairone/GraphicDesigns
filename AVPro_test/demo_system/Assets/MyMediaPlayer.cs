using UnityEngine;
using System.Collections;
using RenderHeads.Media.AVProVideo;

// Media Player(Script)に、このクラスをAdd Componentしてください。
//
//
//
public class MyMediaPlayer : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyUp("a"))
        {
            //シーク移動
            MediaPlayer m_MediaPlayer = this.gameObject.GetComponent<MediaPlayer>();//自分のコンポーネントから
            IMediaControl control = m_MediaPlayer.Control;
            control.Pause();//単位は、ミリセカンド(1000分の１秒)

            Debug.Log("A Key UP");

        }

      
    }
}

