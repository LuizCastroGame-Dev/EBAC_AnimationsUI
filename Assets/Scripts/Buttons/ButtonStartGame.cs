using UnityEngine;

public class ButtonStartGame : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void OnClick()
    {
        particleSystem.Play();
    }
}
