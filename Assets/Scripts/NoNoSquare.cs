using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class NoNoSquare : MonoBehaviour
{
    Transform playerCharacter;
    SpriteRenderer spriteRenderer;
    float dangerDist;
    float restartDist;

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
        if (DistFromPlayer() < dangerDist)
        {
            ShakeItOff();
        } else if(DistFromPlayer() < restartDist)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    } 

    void ShakeItOff()
    {
        spriteRenderer.color = Color.red;
        float xShakeVal = Random.Range(0, 2);
        float yShakeVal = Random.Range(0, 2);
        Vector2 shake = new Vector2(xShakeVal, yShakeVal);
        transform.Translate(shake);
    }   

    float DistFromPlayer()
    {
        var dist = Mathf.Sqrt(Mathf.Pow(playerCharacter.transform.position.x - this.transform.position.x, 2)
            + Mathf.Pow(playerCharacter.position.y - this.transform.position.y, 2));
        return dist;
    }
}
