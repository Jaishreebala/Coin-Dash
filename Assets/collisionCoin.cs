using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class collisionCoin : MonoBehaviour
{
    public int score;
    public Text txt;

    public GameObject[] stage;
    public string scoreString;
    public Material WinningStage;

    void Start()
    {
        score = GameObject.FindGameObjectsWithTag("Coin").Length;
        stage = GameObject.FindGameObjectsWithTag("Stage");
        Debug.Log(score);
        scoreString = "Coins Remaining: " + score.ToString();
        txt.GetComponent<UnityEngine.UI.Text>().text = scoreString;

    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Coin")
        {
            Debug.Log("meh jeezri sad");
            Debug.Log(collisionInfo.collider);
            collisionInfo.gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(collisionInfo.collider);
            score--;
            Debug.Log(score);

            if (score > 0)
            {
                scoreString = "Coins Remaining: " + score.ToString();

            }
            else
            {
                scoreString = "All Coins Collected";
                foreach (GameObject i in stage)
                {
                    i.GetComponent<MeshRenderer>().material = WinningStage;
                }

            }
            txt.GetComponent<UnityEngine.UI.Text>().text = scoreString;

            // change score
        }
        if (collisionInfo.collider.tag == "Stage")
        {
            if (score > 0)
            {
                Debug.Log("YA DEAD");
            }
            else
            {
                if (collisionInfo.collider.name == "podium")
                {
                    Debug.Log("You win :pppppp");
                    // collisionInfo.gameObject.GetComponent<MeshRenderer>().material = WinningStage;

                }
            }
        }
    }
}
