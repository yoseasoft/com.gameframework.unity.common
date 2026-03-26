/// -------------------------------------------------------------------------------
/// Copyright (C) 2024 - 2025, Hurley, Independent Studio.
/// Copyright (C) 2025 - 2026, Hainan Yuanyou Information Technology Co., Ltd. Guangzhou Branch
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in
/// all copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
/// THE SOFTWARE.
/// -------------------------------------------------------------------------------

using System;

namespace GameFramework
{
    /// <summary>
    /// 输入绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnInputAttribute : GameEngine.OnInputDispatchCallAttribute
    {
        public OnInputAttribute(GameEngine.VirtualKeyCode keyCode) : base(keyCode, GameEngine.AspectBehaviourType.Startup) { }

        public OnInputAttribute(GameEngine.VirtualKeyCode keyCode, GameEngine.InputOperationType inputOperationType) : base(keyCode, inputOperationType, GameEngine.AspectBehaviourType.Startup) { }

        public OnInputAttribute(Type inputDataType) : base(inputDataType, GameEngine.AspectBehaviourType.Startup) { }

        public OnInputAttribute(Type classType, GameEngine.VirtualKeyCode keyCode) : base(classType, keyCode) { }

        public OnInputAttribute(Type classType, GameEngine.VirtualKeyCode keyCode, GameEngine.InputOperationType inputOperationType) : base(classType, keyCode, inputOperationType) { }

        public OnInputAttribute(Type classType, Type inputDataType) : base(classType, inputDataType) { }
    }

    /// <summary>
    /// 事件绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnEventAttribute : GameEngine.OnEventDispatchCallAttribute
    {
        public OnEventAttribute(int eventID) : base(eventID, GameEngine.AspectBehaviourType.Startup) { }

        public OnEventAttribute(Type eventDataType) : base(eventDataType, GameEngine.AspectBehaviourType.Startup) { }

        public OnEventAttribute(Type classType, int eventID) : base(classType, eventID) { }

        public OnEventAttribute(Type classType, Type eventDataType) : base(classType, eventDataType) { }
    }

    /// <summary>
    /// 消息绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnMessageAttribute : GameEngine.OnMessageDispatchCallAttribute
    {
        public OnMessageAttribute(int opcode) : base(opcode, GameEngine.AspectBehaviourType.Startup) { }

        public OnMessageAttribute(Type messageType) : base(messageType, GameEngine.AspectBehaviourType.Startup) { }

        public OnMessageAttribute(Type classType, int opcode) : base(classType, opcode) { }

        public OnMessageAttribute(Type classType, Type messageType) : base(classType, messageType) { }
    }

    /// <summary>
    /// 同步绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnReplicateAttribute : GameEngine.OnReplicateDispatchCallAttribute
    {
        public OnReplicateAttribute(string tags) : base(tags, GameEngine.AspectBehaviourType.Startup) { }

        public OnReplicateAttribute(string tags, GameEngine.ReplicateAnnounceType announceType) : base(tags, announceType, GameEngine.AspectBehaviourType.Startup) { }

        public OnReplicateAttribute(Type classType, string tags) : base(classType, tags) { }

        public OnReplicateAttribute(Type classType, string tags, GameEngine.ReplicateAnnounceType announceType) : base(classType, tags, announceType) { }
    }
}
