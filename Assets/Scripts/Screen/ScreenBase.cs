using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
using UnityEngine.UI;

namespace Screens
{
    public enum ScreenType
    {
        Panel,
        Info_Panel,
        Shop
    }

    public class ScreenBase : MonoBehaviour
    {
        public ScreenType screenType;

        public List<Transform> listOfObjects;
        public List<Typper> listOfPhrases;

        public bool startHided = false;

        [Header("Animation")]
        public float animationDuration = .3f;
        public float delayBetweenObjects = .05f;

        public Image uiBackground;


        private void Start()
        {
            if(startHided)
            {
                HideObjets();
            }
        }

        [Button]
        public virtual void Show()
        {
            ShowObjects();
            Debug.Log("Show");
        }

        [Button]
        public virtual void Hide()
        {
            HideObjets();
            Debug.Log("Hide");
        }

        private void ForceShowObjects()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(true));
            uiBackground.enabled = false;
        }

        private void ShowObjects()
        {
            for(int i = 0; i < listOfObjects.Count; i++)
            {
                var obj = listOfObjects[i];

                obj.gameObject.SetActive(true);
                obj.DOScale(0, animationDuration).From().SetDelay(i * delayBetweenObjects);
            }

            Invoke(nameof(StartType), delayBetweenObjects * listOfObjects.Count);
            uiBackground.enabled = true;
        }

        private void HideObjets()
        {
            listOfObjects.ForEach(i => i.gameObject.SetActive(false));
            uiBackground.enabled = false;
        }

        private void StartType()
        {
            for (int i = 0; i < listOfPhrases.Count; i++)
            {
                listOfPhrases[i].StartType();
            }
        }

    }

}
