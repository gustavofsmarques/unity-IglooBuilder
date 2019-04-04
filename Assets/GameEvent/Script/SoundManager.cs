using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour {

    

    public static SoundManager instance = null;     //Allows other scripts to call functions from SoundManager.             
    public float lowPitchRange = .95f;              //The lowest a sound effect will be randomly pitched.
    public float highPitchRange = 1.05f;            //The highest a sound effect will be randomly pitched.

    public string actualScene;
    public string gameScene;
    public string storyScene;


    public AudioSource efxSource;                   //Drag a reference to the audio source which will play the sound effects.
    public AudioSource musicSource;                 //Drag a reference to the audio source which will play the music.
    public AudioSource gameMusic;
    public AudioSource storyMusic;

    public bool story;
    public bool menu;
    public bool game
        ;

    void Awake()
    {
        //Check if there is already an instance of SoundManager
        if (instance == null)
            //if not, set it to this.
            instance = this;
        //If instance already exists:
        else if (instance != this)
            //Destroy this, this enforces our singleton pattern so there can only be one instance of SoundManager.
            Destroy(gameObject);

        //Set SoundManager to DontDestroyOnLoad so that it won't be destroyed when reloading our scene.
        DontDestroyOnLoad(gameObject);
    }


    private void Update()
    {
        actualScene = SceneManager.GetActiveScene().name;
        if (actualScene == gameScene)
        {
            if (!game)
            {
                gameMusic.Play();
                storyMusic.Stop();
                musicSource.Stop();
                game = true;
                menu = false;
                story = false;
            }

        }
        else if (actualScene == storyScene)
        {
            if (!story)
            {
                storyMusic.Play();
                gameMusic.Stop();
                musicSource.Stop();
                game = false;
                menu = false;
                story = true;
            }
        }
        else 
        {
            if (!menu)
            {
                storyMusic.Stop();
                gameMusic.Stop();
                musicSource.Play();
                game = false;
                menu = true;
                story = false;
            }
        }
    }


    //Used to play single sound clips.
    public void PlaySingle(AudioClip clip)
    {
        //Set the clip of our efxSource audio source to the clip passed in as a parameter.
        efxSource.clip = clip;

        //Play the clip.
        efxSource.Play();
    }


    //RandomizeSfx chooses randomly between various audio clips and slightly changes their pitch.
    public void RandomizeSfx(params AudioClip[] clips)
    {
        //Generate a random number between 0 and the length of our array of clips passed in.
        int randomIndex = Random.Range(0, clips.Length);

        //Choose a random pitch to play back our clip at between our high and low pitch ranges.
        float randomPitch = Random.Range(lowPitchRange, highPitchRange);

        //Set the pitch of the audio source to the randomly chosen pitch.
        efxSource.pitch = randomPitch;

        //Set the clip to the clip at our randomly chosen index.
        efxSource.clip = clips[randomIndex];

        //Play the clip.
        efxSource.Play();
    }
}

