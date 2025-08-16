using System.Collections;
using System.Collections.Generic;
using TEngine;
using UnityEngine;

namespace GameLogic
{
    /// <summary>
    /// 小游戏继承此类，UI部分多使用UIWigget
    /// </summary>
    public abstract class MiniGameUIBase : UIWindow
    {
        protected MiniGameConfig _config;

        protected MiniGameResult _result;

        protected override void OnCreate()
        {
            base.OnCreate();
            if (userDatas.Length == 0)
            {
                Log.Error("No input data");
            }
            _config = (MiniGameConfig)userDatas[0];
            _result = (MiniGameResult)userDatas[1];
        }

        protected virtual void Finish()
        {
            // notify the backend 
            GameEvent.Send(_config._callback);
        }

    }
}
