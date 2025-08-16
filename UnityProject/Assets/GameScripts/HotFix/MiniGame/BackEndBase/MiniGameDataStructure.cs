using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameLogic
{
    /// <summary>
    /// 继承后自定义
    /// </summary>
    public class MiniGameResult
    {
        protected bool _spicealFlag= false;

        protected List<int> _intResult = new List<int>();

        protected List<bool> _boolReult = new List<bool>();

        protected List<string> _stringResult = new List<string>();

        protected List<float> _floatResult = new List<float>();



        public void AddIntResult(int result)
        {
            _intResult.Add(result);
        } 

        public void AddBoolResult(bool result)
        {
            _boolReult.Add(result);
        }

        public void AddStringResult(string result)
        {
            _stringResult.Add(result);
        }

        public void AddFloatResult(float result)
        {
            _floatResult.Add(result);
        }

        public IReadOnlyList<int> IntResult => _intResult;

        public IReadOnlyList<bool> BoolResult => _boolReult;

        public IReadOnlyList<string> StringResult => _stringResult;

        public IReadOnlyList<float> FloatResult => _floatResult;

        public virtual void Clear()
        {
            _intResult.Clear();
            _boolReult.Clear();
            _stringResult.Clear();
            _floatResult.Clear();
        }
    }

    /// <summary>
    /// 不同小游戏配置需要继承的基类,纯数据类
    /// </summary>
    public abstract class MiniGameConfig
    {
        public int _callback;

        // 添加每个游戏需要的数据
    }

    public class MiniGameCallBack
    {
        public MiniGameCallBack(List<int> messages)
        {
            _messages.Capacity = messages.Capacity;
            foreach (var item in messages)
            {
                _messages.Add(item);
            }
        }

        private List<int> _messages = new List<int>();

        public IReadOnlyList<int> Callbacks => _messages;

    }

    // send to minigame backend
    public class MiniGameInputData
    {
       
        public MiniGameInputData(MiniGameConfig config, MiniGameCallBack callBack)
        {
            _gameConfig = config;
            _gameCallBack = callBack;
        }

        private MiniGameConfig _gameConfig;

        private MiniGameCallBack _gameCallBack;

        public MiniGameConfig Config => _gameConfig;

        public MiniGameCallBack CallBack => _gameCallBack;

    }

}
