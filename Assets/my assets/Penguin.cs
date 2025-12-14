using UnityEngine;

public class Penguin : MonoBehaviour
{
    public AudioClip munchSFX;
    AudioSource aud;

    void Start()
    {
        aud = GetComponent<AudioSource>();
    }

    void Update()
    {
    }
    
    public void Munch()
    {
        GetComponent<AudioSource>().PlayOneShot(munchSFX);
        Game.score++;
        Destroy(gameObject);
    }
}
