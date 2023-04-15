using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIMovement : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Animator anim;
    [SerializeField] private Transform player;
    [SerializeField] private RectTransform popupText;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (player.transform.position.x > sprite.transform.position.x)
        {
            sprite.flipX = false;
        } else {sprite.flipX = true;}
    }

}
