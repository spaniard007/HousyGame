using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RandomGenerator : MonoBehaviour
{
    public int Rand;
    private int lastNumber = 0;

    public List<int> numbers = new List<int>();

    public List<Text> gridNumbTxt = new List<Text>();

    public Text nextNumberTxt;
    public Text lastNumberTxt;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            numbers.Add(i + 1);
            gridNumbTxt[i].text = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void NextRandomNumber()
    {
        lastNumberTxt.text = lastNumber.ToString();

        Rand = Random.Range(0,numbers.Count);
        nextNumberTxt.text = numbers[Rand].ToString();
        lastNumber = numbers[Rand];
        // gridMapping
        gridNumbTxt[numbers[Rand]-1].text = numbers[Rand].ToString();
        numbers.RemoveAt(Rand);

    }

    public void ResetBTN()
    {
        SceneManager.LoadScene(0);
    }
}
