using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UIMainWindow : UIWindow
    {
        #region 脚本工具生成的代码
        private Text m_textHelloWord;
        protected override void ScriptGenerator()
        {
            m_textHelloWord = FindChildComponent<Text>("m_textHelloWord");
        }
        #endregion

        #region 事件
        #endregion

    }
}
