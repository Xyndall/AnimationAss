using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDeeCharacter : MonoBehaviour
{
    Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _animator.SetTrigger("Slice");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _animator.SetTrigger("Thrust");
        }
    }
}
