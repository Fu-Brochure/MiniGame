using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TEngine;
using TMPro;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class HellowWorld : UIWindow
    {
        #region �ű��������ɵĴ���
        private TextMeshProUGUI m_tmpText1;
        protected override void ScriptGenerator()
        {
            m_tmpText1 = FindChildComponent<TextMeshProUGUI>("m_tmpText1");
        }
        #endregion

        #region �¼�
        #endregion

    }
}
