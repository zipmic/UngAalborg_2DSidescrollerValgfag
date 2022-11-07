using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shoot : MonoBehaviour
{

    public GameObject TheBulletToShoot;
    public KeyCode PressThisToShoot = KeyCode.RightShift;
    public float IntervalBetweenShots = 0.2f;
    public int AmmoPerMagazine = 6;
    public float ReloadTime = 0.5f;
    public float BulletSpeed = 2;

    public UnityEvent OnReload, OnShoot;


    private bool _needsToBeReloaded;
    private float _reloadTimeCounter, _intervalCounter;
    private int _shotsFired = 0;
    private AudioSource _audioSource;

	private void Start()
	{
        _reloadTimeCounter = ReloadTime;
        _intervalCounter = 0;
        _audioSource = GetComponent<AudioSource>();

    }


	void Update()
    {

        if (_needsToBeReloaded != true)
        {
            //Spawn if pressed
            if (Input.GetKey(PressThisToShoot) && _intervalCounter <= 0 && _shotsFired < AmmoPerMagazine)
            {
                GameObject tmp = Instantiate(TheBulletToShoot) as GameObject;
                tmp.transform.position = transform.position;
                if (transform.parent.localScale.x > 0)
                {
                    tmp.GetComponent<Rigidbody2D>().velocity = transform.right * BulletSpeed;
                }
                else
                {
                    tmp.GetComponent<Rigidbody2D>().velocity = transform.right * -BulletSpeed;
                }
                Destroy(tmp, 8);
                _shotsFired++;
                _audioSource.pitch = Random.Range(0.9f, 1f);
                OnShoot.Invoke();
           

                _intervalCounter = IntervalBetweenShots;

                if (_shotsFired >= AmmoPerMagazine)
                {
                    _needsToBeReloaded = true;
                    _reloadTimeCounter = ReloadTime;
                    _audioSource.pitch = 1;
                    OnReload.Invoke();

                }
            }


            
        }
        else
        {
            if (_reloadTimeCounter > 0)
            {
                _reloadTimeCounter -= Time.deltaTime;
                if (_reloadTimeCounter <= 0)
                {
                    _needsToBeReloaded = false;
                    _shotsFired = 0;
                }
            }
        
        }

        if (_intervalCounter > 0)
        {
            _intervalCounter -= Time.deltaTime;
        }




    }


}
