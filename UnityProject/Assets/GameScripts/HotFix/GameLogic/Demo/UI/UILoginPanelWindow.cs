using UnityEngine;
using UnityEngine.UI;
using TEngine;
using System;
using UnityEditor.VersionControl;
using Newtonsoft.Json;
using System.IO;
using UnityEditor;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine.SceneManagement;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class UILoginPanelWindow : UIWindow
    {
        #region �ű��������ɵĴ���
        private InputField m_inputUser;
        private InputField m_inputPassWord;
        private Button m_btnLogin;
        private Button m_btnRegister;
        private Button m_btnforget;
        private Toggle m_toggleRemember;
        private Dropdown m_droUser_Group;
        protected override void ScriptGenerator()
        {
            m_inputUser = FindChildComponent<InputField>("UILoginPanelWindow/m_inputUser");
            m_inputPassWord = FindChildComponent<InputField>("UILoginPanelWindow/m_inputPassWord");
            m_btnLogin = FindChildComponent<Button>("UILoginPanelWindow/m_btnLogin");
            m_btnRegister = FindChildComponent<Button>("UILoginPanelWindow/m_btnRegister");
            m_btnforget = FindChildComponent<Button>("UILoginPanelWindow/m_btnforget");
            m_toggleRemember = FindChildComponent<Toggle>("UILoginPanelWindow/m_toggRemember");
            m_droUser_Group = FindChildComponent<Dropdown>("UILoginPanelWindow/m_droUser_Group");

            m_btnLogin.onClick.AddListener(OnClickLoginBtn);
            m_btnforget.onClick.AddListener(OnClickforgetBtn);
            m_inputUser.onEndEdit.AddListener(OnGettingUser);
            m_inputPassWord.onEndEdit.AddListener(OnGettingPassWord);
            m_droUser_Group.onValueChanged.AddListener(OnUserNameAndPaw);


        }
        //����������¼�
        private void OnUserNameAndPaw(int index)
        {
            m_inputUser.text = arr[index].Name;
            m_inputPassWord.text = arr[index].Password;
            _userTest.Name = arr[index].Name;
            _userTest.Password = arr[index].Password;
        }

        List<ReqLoginMessage> arr = new List<ReqLoginMessage>();
        List<string> userNames = new List<string>();
        //��¼��Ϣ
        ReqLoginMessage _userTest = new ReqLoginMessage();
        protected override void OnCreate()
        {
            base.OnCreate();
            //ע����Ϣ
            var message = GameModule.NetWork.SetMessage<ResLoginResultMessage>(ResLoginResult);
            _userTest.GameVersion = 1092;//��Ϸ�汾��
            _userTest.ServerId = 10012;//������id
            //===============================================================
            if (!File.Exists(Application.dataPath + "/Resources/UserJson.json")) return;
            string json = Resources.Load<TextAsset>("UserJson").text;
            arr = JsonConvert.DeserializeObject<List<ReqLoginMessage>>(json);
            foreach (var item in arr)
            {
                userNames.Add(item.Name);
            }
            m_droUser_Group.ClearOptions();
            m_droUser_Group.AddOptions(userNames);
            m_droUser_Group.value = arr.Count - 1;
            //if (arr.Count > 0)
            //{
            //    m_inputUser.text = arr[arr.Count - 1].Name;
            //    m_inputPassWord.text = arr[arr.Count - 1].Password;
            //}
        }
        private void OnGettingPassWord(string pwd)
        {
            _userTest.Password = pwd;
        }

        private void OnGettingUser(string name)
        {
            _userTest.Name = name;
        }
        #endregion

        #region �¼�


        private void OnClickLoginBtn()
        {
            if (_userTest.Password == null || _userTest.Name == null || m_inputUser.text == null || _userTest.Password == string.Empty)
            {
                Log.Error("�������û��������룡");
            }
            else
            {
                //���͵�¼����
                GameModule.NetWork.SendMessage(_userTest);
                Log.Info("���������������");
            }

        }
        /// <summary>
        /// ��������������
        /// </summary>
        /// <param name="message">�������Ϣ</param>
        private void ResLoginResult(Message message)
        {
            var loginResult = message as ResLoginResultMessage;
            //0-�ɹ�  1-������δ���� 2-�û�������� �� 3-��ip��������  4-����Һ������� 5-�汾��ƥ��
            switch (loginResult.IsSuccess)
            {
                case 0:
                    Log.Info("�ɹ�");
                    if (m_toggleRemember.isOn)
                    {
                        if (IsJsonHave(_userTest))
                        {
                            string json = JsonConvert.SerializeObject(arr);
                            File.WriteAllText(Application.dataPath + "/Resources/UserJson.json", json);
                            AssetDatabase.Refresh();
                        }
                    }
                    GameModule.Procedure.RestartProcedure(new OnEnterPlaySceneProcedure());
                    ; break;
                case 1: Log.Error("������δ����"); ; break;
                case 2:
                    Log.Error("�û����������");
                    _userTest.Password = null;
                    m_inputPassWord.text = "";
                    ; break;
                case 3: Log.Error("��ip��������"); ; break;
                case 4: Log.Error("����Һ�������"); ; break;
                case 5: Log.Error("�汾��ƥ��"); ; break;
            }
        }
        //���˺������Ƿ񱻼�ס
        private bool IsJsonHave(ReqLoginMessage userTest)
        {
            foreach (var item in arr)
            {
                if (item.Name == userTest.Name)
                {
                    return false;
                }
            }
            arr.Add(userTest);
            return true;
        }

        private void OnClickforgetBtn()
        {
            Log.Error("�������˰ɡ�����զ����QAQ~~~~");

        }
        #endregion

    }

}
