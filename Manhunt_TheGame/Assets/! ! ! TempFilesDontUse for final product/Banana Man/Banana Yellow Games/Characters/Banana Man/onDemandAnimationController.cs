using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class onDemandAnimationController : MonoBehaviour
{
        [SerializeField] private GameObject _theActor;
        [SerializeField] private InputActionAsset _playerInputAction;

    private void _playAnim1(InputValue value)
    {
        Debug.Log("Anim1 has been played");
        _theActor.GetComponent<Animator> ().Play ("Anim1");
    }

}
