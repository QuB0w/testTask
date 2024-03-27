using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToFindSystem : MonoBehaviour
{
    private PanelsSystem cnv;


    // Start is called before the first frame update
    void Start()
    {
        cnv = GameObject.Find("Canvas").GetComponent<PanelsSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cnv.numbers.Length; i++)
        {
            if (cnv.toFind == cnv.numbers[i])
            {
                if(cnv.framesCount == 3)
                {
                    cnv.toFindText.text = "Find " + (cnv.firstGap + 1).ToString();
                }
                else if(cnv.framesCount == 6)
                {
                    cnv.toFindText.text = "Find " + (cnv.secondGap + 1).ToString();
                }
                else if (cnv.framesCount == 9)
                {
                    cnv.toFindText.text = "Find " + (cnv.thirdGap + 1).ToString();
                }
            }
        }

        for (int i = 0; i < cnv.words.Length; i++)
        {
            if (cnv.toFind == cnv.words[i])
            {
                if (i == 0)
                {
                    cnv.toFindText.text = "Find A";
                }
                else if (i == 1)
                {
                    cnv.toFindText.text = "Find B";
                }
                else if (i == 2)
                {
                    cnv.toFindText.text = "Find C";
                }
                else if (i == 3)
                {
                    cnv.toFindText.text = "Find D";
                }
                else if (i == 4)
                {
                    cnv.toFindText.text = "Find E";
                }
                else if (i == 5)
                {
                    cnv.toFindText.text = "Find F";
                }
                else if (i == 6)
                {
                    cnv.toFindText.text = "Find G";
                }
                else if (i == 7)
                {
                    cnv.toFindText.text = "Find H";
                }
                else if (i == 8)
                {
                    cnv.toFindText.text = "Find I";
                }
                else if (i == 9)
                {
                    cnv.toFindText.text = "Find J";
                }
                else if (i == 10)
                {
                    cnv.toFindText.text = "Find K";
                }
                else if (i == 11)
                {
                    cnv.toFindText.text = "Find L";
                }
                else if (i == 12)
                {
                    cnv.toFindText.text = "Find M";
                }
                else if (i == 13)
                {
                    cnv.toFindText.text = "Find N";
                }
                else if (i == 14)
                {
                    cnv.toFindText.text = "Find O";
                }
                else if (i == 15)
                {
                    cnv.toFindText.text = "Find P";
                }
                else if (i == 16)
                {
                    cnv.toFindText.text = "Find Q";
                }
                else if (i == 17)
                {
                    cnv.toFindText.text = "Find R";
                }
                else if (i == 18)
                {
                    cnv.toFindText.text = "Find S";
                }
                else if (i == 19)
                {
                    cnv.toFindText.text = "Find T";
                }
                else if (i == 20)
                {
                    cnv.toFindText.text = "Find U";
                }
                else if (i == 21)
                {
                    cnv.toFindText.text = "Find V";
                }
                else if (i == 22)
                {
                    cnv.toFindText.text = "Find W";
                }
                else if (i == 23)
                {
                    cnv.toFindText.text = "Find X";
                }
                else if (i == 24)
                {
                    cnv.toFindText.text = "Find Y";
                }
                else if (i == 25)
                {
                    cnv.toFindText.text = "Find Z";
                }
            }
        }
    }
}
