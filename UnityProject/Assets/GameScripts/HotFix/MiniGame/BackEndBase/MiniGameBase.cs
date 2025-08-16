using GameBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TEngine;
using UnityEngine;

namespace GameLogic
{
    /// <summary>
    /// 
    /// </summary>
    public class MiniGameBase : BehaviourSingleton<MiniGameBase>
    {
        public virtual void Initialize(MiniGameInputData data, MiniGameResult result)
        {
            _data = data;
            _result = result;
        }

        public virtual void Clear()
        {
            _data = null;
            _result = null;
        }


        /// <summary>
        ///  GameModule.UI.ShowUI() 
        ///  ǰ���ʹ����Ϣϵͳͨ�ţ���initial����run���м���ע�ᣬ��run�ǵ�ע��
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>

        public virtual void Run()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ע��ص���ǰ����Ϸ����message����
        /// </summary>
        public virtual void DealResult()
        {
            throw new NotImplementedException();
        }

        private MiniGameInputData _data = null;

        private MiniGameResult _result = null;

    }
}
