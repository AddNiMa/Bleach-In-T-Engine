using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UIMainWindow : UIWindow
    {
        #region �ű��������ɵĴ���
        private Text m_textHelloWord;
        protected override void ScriptGenerator()
        {
            m_textHelloWord = FindChildComponent<Text>("m_textHelloWord");
        }
        #endregion

        #region �¼�
        #endregion

    }
}
