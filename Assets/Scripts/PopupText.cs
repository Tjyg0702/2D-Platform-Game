using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupText : MonoBehaviour
{
    private Renderer render;
    private Rigidbody2D playerRb;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject conversation;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        playerRb = player.GetComponent<Rigidbody2D>();
        render.enabled = false;
        conversation.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        conversationControll();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            render.enabled = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            render.enabled = false;
        }

    }

    private void conversationControll()
    {
        if (render.enabled)
        {
            if (Input.GetKeyDown(KeyCode.E) && !conversation.activeSelf)
            {
                conversation.SetActive(true);
                playerRb.bodyType = RigidbodyType2D.Static;

            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Escape) && conversation.activeSelf)
            {
                conversation.SetActive(false);
                playerRb.bodyType = RigidbodyType2D.Dynamic;

            }
        }
    }
}
