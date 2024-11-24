using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class onDemandAnimationController : MonoBehaviour
{
        [SerializeField] private GameObject _theActor;
        [SerializeField] private InputActionAsset _playerInputAction;
        [SerializeField] private Animator _animator;

    private void Awake()
    {
        _animator = _theActor.GetComponent<Animator>();
        
        //_theActor.GetComponent<Animator> ().Play ("Anim1");
    }

    private void Update() 
    {
        
    }

    public void OnTwerk()
    {
        Debug.Log("Anim1 has been played");
        _animator.SetTrigger ("Twerk");
    }
}
