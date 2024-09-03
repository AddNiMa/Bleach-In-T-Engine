using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TEngine;
using System;
using static UnityEditor.FilePathAttribute;
using System.Threading;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UITest : UIWindow
    {
        public static int a = 1;
        #region �ű��������ɵĴ���
        private Image m_imgHead;
        private Button m_btnTestButton;
        protected override void ScriptGenerator()
        {
            m_imgHead = FindChildComponent<Image>("m_imgHead");
            m_btnTestButton = FindChildComponent<Button>("m_btnTestButton");
            m_btnTestButton.onClick.AddListener(UniTask.UnityAction(OnClickTestButtonBtn));
        }
        #endregion

        #region �¼�
        private async UniTaskVoid OnClickTestButtonBtn()
        {
            //չʾǰǰ���������UI
            // GameModule.UI.CloseUI<UITest>();
            // SaySomeThings();
            //�������ñ��ȡ;
<<<<<<< HEAD
            GameModule.NetWork.StartNetWork("127.0.0.1", 7718);
            GameModule.Procedure.RestartProcedure(new OnEnterLoginSceneProcedure());

            //int a = 1;
            //int c=GameModule.Timer.AddTimer((x) =>
            //{
            //    a++;
            //    if (a == 10)
            //    {
            //    }
            //    Log.Info($"�¼�{a}");
            //},4,false);
            //await UniTask.Yield();
=======
            GameModule.NetWork.StartNetWork("10.161.16.110", 7718);
            GameModule.Procedure.RestartProcedure(new OnEnterLoginSceneProcedure());

            int a = 1;
            int c=GameModule.Timer.AddTimer((x) =>
            {
                a++;
                if (a == 10)
                {
                }
                Log.Info($"�¼�{a}");
            },4,false);
            await UniTask.Yield();
>>>>>>> 48404c380af1e28512fcf9aac0dd3a7e38b16c8d
        }
        #endregion

        void LoadAsset()
        {
            ////ͬ�����ء�
            //GameModule.Resource.LoadAsset<SkillDisplayData>(location);

            ////�첽���ء�
            //GameModule.Resource.LoadAssetAsync<SkillDisplayData>(location, OnLoadSuccess);
            //private void OnLoadSuccess(AssetOperationHandle assetOperationHandle) { }

            ////ʹ��UniTask�첽���ء�
            //await GameModule.Resource.LoadAssetAsync<SkillDisplayData>(location, CancellationToken.None);
        }


        void TestEvent1()
        {
            Log.Info($"����һ��ͨ��String ��������Ϣ�ŵ��¼�");
        }

        void TestEvent2(int a)
        {
            Log.Info($"{a}����һ��ͨ��Int ��������Ϣ�ŵ��¼�");
        }

        private void SaySomeThings()
        {
            //�����¼���
            GameEvent.Send("TEngine�ܺ���");
            GameEvent.Send(a, 1444);
        }

        protected override void RegisterEvent()
        {
            base.RegisterEvent();

            //�ַ���ת��Ϊint ���͵ı���;
            a = RuntimeId.ToRuntimeId("��һ��");


            //����¼�����string
            GameEvent.AddEventListener("TEngine�ܺ���", TestEvent1);
            //����¼�����int �¼�ID
            GameEvent.AddEventListener<int>(a, TestEvent2);
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }
    }
}
