using System;
using TMPro;
using UnityEngine.UI;

namespace UIFramework.Examples
{

    [Serializable]
    public class TestParam:WindowProperties
    {
        public string s;

        public TestParam(string s)
        {
            this.s = s;
        }
    }
    public class TestWindowController: WindowController<TestParam>
    {
        public Button Button;

        public Button CloseBtn;

        protected override void AddListeners()
        {
            base.AddListeners();
            CloseBtn.onClick.AddListener(() =>
            {
                UI_Close();
            });
        }

        protected override void OnPropertiesSet()
        {
            base.OnPropertiesSet();

            Button.GetComponentInChildren<TextMeshProUGUI>().text=(Properties.s);
        }
    }
}