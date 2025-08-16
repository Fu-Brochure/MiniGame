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
        ///  前后端使用消息系统通信，在initial或者run进行监听注册，在run记得注销
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>

        public virtual void Run()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 注册回调后被前端游戏结束message触发
        /// </summary>
        public virtual void DealResult()
        {
            throw new NotImplementedException();
        }

        private MiniGameInputData _data = null;

        private MiniGameResult _result = null;

    }
}
