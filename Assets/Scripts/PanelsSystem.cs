using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class PanelsSystem : MonoBehaviour
{
    public int framesCount = 0;
    public Sprite toFind;
    public Text toFindText;

    public bool isCanClick = true;

    public GameObject restartPanel;
    public GameObject loadingBarOBJ;
    public Image loadingBarIMG;

    [SerializeField] public int firstGap;
    [SerializeField] public int secondGap;
    [SerializeField] public int thirdGap;

    public CanvasGroup TaskText;

    [Header("ObjectsInFrames")]
    public Sprite[] numbers;
    public Sprite[] words;

    [Header("Frames")]
    public List<Image> framesOBJ = new List<Image>();
    public List<GameObject> gaps = new List<GameObject>();

    public GameObject gapPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadingBar());
        loadingBarOBJ.GetComponent<CanvasGroup>().DOFade(1, 2f);

        framesCount = 3;
    }

    IEnumerator loadingBar()
    {
        if(loadingBarIMG.fillAmount != 1f)
        {
            loadingBarIMG.fillAmount += 0.1f;
            yield return new WaitForSeconds(0.1f);
            StartCoroutine(loadingBar());
        }
        else if(loadingBarIMG.fillAmount == 1f)
        {
            loadingBarOBJ.GetComponent<CanvasGroup>().DOFade(0, 2f);
            yield return new WaitForSeconds(2f);
            loadingBarOBJ.SetActive(false);
            TaskText.DOFade(1, 3f);
            SpawnGaps();
        }
    }

    public void ClearArray()
    {
        for (int i = gaps.ToArray().Length - 1; i > -1; i--)
        {
            if(framesCount != 9)
            {
                Destroy(gaps[i]);
            }
        }

        for (int i = gaps.ToArray().Length - 1; i > -1; i--)
        {
            if(framesCount != 9)
            {
                framesOBJ.Clear();
                gaps.Clear();
            }
        }
    }

    public void SpawnGaps()
    {
        if(framesCount == 3)
        {
            for (int i = 1; i < 4; i++)
            {
                var gap = Instantiate(gapPrefab, Vector3.zero, Quaternion.identity);
                gap.GetComponent<GapSystem>().number = i;
                gap.GetComponent<GapSystem>().level = 1;
                gaps.Add(gap);
                framesOBJ.Add(gap.GetComponent<GapSystem>().frame);
            }
            RandomChooseType();
        }
        else if(framesCount == 6)
        {
            for (int i = 1; i < 7; i++)
            {
                var gap = Instantiate(gapPrefab, Vector3.zero, Quaternion.identity);
                gap.GetComponent<GapSystem>().number = i;
                gap.GetComponent<GapSystem>().level = 2;
                gaps.Add(gap);
                framesOBJ.Add(gap.GetComponent<GapSystem>().frame);
            }
            RandomChooseType();
        }
        else if (framesCount == 9)
        {
            for (int i = 1; i < 10; i++)
            {
                var gap = Instantiate(gapPrefab, Vector3.zero, Quaternion.identity);
                gap.GetComponent<GapSystem>().number = i;
                gap.GetComponent<GapSystem>().level = 3;
                gaps.Add(gap);
                framesOBJ.Add(gap.GetComponent<GapSystem>().frame);
            }
            RandomChooseType();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartScene()
    {
        StartCoroutine(restartScene());
    }

    public IEnumerator restartScene()
    {
        restartPanel.GetComponent<CanvasGroup>().DOFade(0, 1f);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(0);
    }

    public void RandomChooseType()
    {
        var rnd = Random.Range(1, 3);
        switch (rnd)
        {
            case 1:
                for (int i = 0; i < framesCount; i++)
                {
                    var rnd2 = Random.Range(0, numbers.Length);
                    if (framesCount == 3)
                    {
                        firstGap = rnd2;
                    }
                    else if (framesCount == 6)
                    {
                        secondGap = rnd2;
                        if(secondGap == firstGap)
                        {
                            i--;
                        }
                    }
                    else if(framesCount == 9)
                    {
                        thirdGap = rnd2;
                        if(thirdGap == firstGap || thirdGap == secondGap)
                        {
                            i--;
                        }
                    }
                    framesOBJ[i].sprite = numbers[rnd2];
                }
                int needToFind = Random.Range(0, framesCount);

                if (framesCount == 3)
                {
                    framesOBJ[needToFind].sprite = numbers[firstGap];
                    toFind = framesOBJ[needToFind].sprite;
                }
                else if(framesCount == 6)
                {
                    if (secondGap != firstGap)
                    {
                        framesOBJ[needToFind].sprite = numbers[secondGap];
                        toFind = framesOBJ[needToFind].sprite;
                    }
                }
                else if(framesCount == 9)
                {
                    if (thirdGap != firstGap && thirdGap != secondGap)
                    {
                        framesOBJ[needToFind].sprite = numbers[thirdGap];
                        toFind = framesOBJ[needToFind].sprite;
                    }
                }
                break;
            case 2:
                for (int i = 0; i < framesCount; i++)
                {
                    var rnd2 = Random.Range(0, words.Length);

                    if (framesCount == 3)
                    {
                        firstGap = rnd2;
                    }
                    else if (framesCount == 6)
                    {
                        secondGap = rnd2;
                        if (secondGap == firstGap)
                        {
                            i--;
                        }
                    }
                    else if (framesCount == 9)
                    {
                        thirdGap = rnd2;
                        if (thirdGap == firstGap || thirdGap == secondGap)
                        {
                            i--;
                        }
                    }
                    framesOBJ[i].sprite = words[rnd2];
                }
                int needToFind2 = Random.Range(0, framesCount);
                if (framesCount == 3)
                {
                        framesOBJ[needToFind2].sprite = words[firstGap];
                        toFind = framesOBJ[needToFind2].sprite;
                }
                else if (framesCount == 6)
                {
                    if (secondGap != firstGap)
                    {
                        var rnd2 = Random.Range(0, words.Length);
                        framesOBJ[needToFind2].sprite = words[rnd2];
                        toFind = framesOBJ[needToFind2].sprite;
                    }
                }
                else if (framesCount == 9)
                {
                    if (thirdGap != firstGap && thirdGap != secondGap)
                    {
                        var rnd2 = Random.Range(0, words.Length);
                        framesOBJ[needToFind2].sprite = words[rnd2];
                        toFind = framesOBJ[needToFind2].sprite;
                    }
                }
                break;
        }
    }
}
