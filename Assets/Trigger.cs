using UnityEngine;

public class Trigger : MonoBehaviour
{
  
    

    public AudioSource Sound;
    public GameObject Lights;

    private void OnTriggerEnter(Collider other)
    {
        Sound.Play();
        Lights.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        Sound.Pause();
        Lights.SetActive(false);
    }




}
