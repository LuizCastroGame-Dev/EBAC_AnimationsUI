using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;
using DG.Tweening;
using UnityEngine.UI;

namespace Screens 
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        protected override void Awake()//Artificio para utilizar o Singleton
        {
            base.Awake(); //Artificio para utilizar o Singleton
        }

        private void Start()
        {
            HideAll();
            ShowByType(startScreen);
        }

        public List<ScreenBase> screenBases;

        public ScreenType startScreen = ScreenType.Panel;

        private ScreenBase _currentScreen;

        public void ShowByType(ScreenType type)
        {
            if (_currentScreen != null) _currentScreen.Hide();

            var nextScreen = screenBases.Find(i => i.screenType == type);

            _currentScreen = nextScreen;
            nextScreen.Show();
        }
        
        public void HideAll()
        {
            screenBases.ForEach(i => i.Hide());
        }
    }
}

