using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int currentFlowers;
    public Text flowerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddFlower(int flowerToAdd)
    {
        currentFlowers += flowerToAdd;
        flowerText.text = "Flower:" + currentFlowers;
    }
}
