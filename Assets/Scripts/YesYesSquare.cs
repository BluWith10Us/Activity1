using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class YesYesSquare : MonoBehaviour
{
    [SerializeField] GameObject fuckingUI;

    Transform playerCharacter;
    SpriteRenderer spriteRenderer;
    [SerializeField] float winDist;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerCharacter = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.color = Color.white;
        if (DistFromPlayer() < winDist)
        {
            fuckingUI.SetActive(true);
        } else
        {
            fuckingUI.SetActive(false);
        }

        Debug.Log("Dist from Win: " + DistFromPlayer());
    }


    float DistFromPlayer()
    {
        var dist = Mathf.Sqrt(Mathf.Pow(playerCharacter.transform.position.x - this.transform.position.x, 2)
            + Mathf.Pow(playerCharacter.position.y - this.transform.position.y, 2));
        return dist;
    }
}
