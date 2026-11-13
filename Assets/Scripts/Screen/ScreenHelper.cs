using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
using UnityEngine.UI;

namespace Screens
{
    public class ScreenHelper : MonoBehaviour
    {
        public ScreenType ScreenType;

        public void OnClick()
        {
            ScreenManager.Instance.ShowByType(ScreenType);
        }
    }
}