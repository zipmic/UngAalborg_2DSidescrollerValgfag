using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger_PlaySFX : MonoBehaviour
{

    private AudioSource _sfxPlayer;
    public string TriggerTag = "Player";
    public AudioClip SFXToPlay;
    public bool PlayOnce;
    private bool _once;

    // Start is called before the first frame update
    void Start()
    {
        _sfxPlayer = GameObject.Find("SFXPlayer").GetComponent<AudioSource>();
        if (_sfxPlayer == null)
        {
            Debug.LogError("Couln't find reference in start on " + name);
        }
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.tag == TriggerTag)
        {
            if (SFXToPlay != null && !_once)
            {
                
                _sfxPlayer.PlayOneShot(SFXToPlay);
                if (PlayOnce)
                {
                    _once = true;
                }

            }
            else if(!_once)
            {
                Debug.LogWarning("You need to add the reference on " + name);
            }
        }
	}
}
