using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour
{
    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlayVid());
    }

    private IEnumerator PlayVid()
    {
        videoPlayer.Prepare();
        WaitForSeconds wait = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared)
        {
            yield return wait;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            SceneManager.LoadScene("ObjectManipulation");
        }
    }
}
