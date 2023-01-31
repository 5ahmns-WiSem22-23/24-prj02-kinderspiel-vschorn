using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;


public class Dice : MonoBehaviour
{
    public Sprite[] diceSides;
    public Sprite pink;
    public Sprite blue;
    public Sprite yellow;
    public Sprite orange;
    public Sprite red;
    public Sprite green;


    public GameObject pinkFish;
    public GameObject blueFish;
    public GameObject yellowFish;
    public GameObject orangeFish;


    public GameObject ship;

    public Transform finishLine;







    private SpriteRenderer rend;



    private bool coroutineAllowed = true;


    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        diceSides = Resources.LoadAll<Sprite>("DiceSides/");



    }

    private void OnMouseDown()
    {

        StartCoroutine("RollTheDice");
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        int finalSide = 0;


        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0,
                6);

            rend.sprite = diceSides[randomDiceSide];

            yield return new WaitForSeconds(0.05f);

        }

        finalSide = randomDiceSide + 1;

        Debug.Log(finalSide);



        if (finalSide == 5)
        {
            ship.transform.position += new Vector3(-1, 0, 0);
        }

        if (finalSide == 2)
        {
            ship.transform.position += new Vector3(-1, 0, 0);
        }

        if (finalSide == 1)
        {
            blueFish.transform.position += new Vector3(-1, 0, 0);
        }

        if (finalSide == 3)
        {
            orangeFish.transform.position += new Vector3(-1, 0, 0);
        }

        if (finalSide == 4)
        {
            pinkFish.transform.position += new Vector3(-1, 0, 0);
        }

        if (finalSide == 6)
        {
            yellowFish.transform.position += new Vector3(-1, 0, 0);
        }



    }


    



    }






   






