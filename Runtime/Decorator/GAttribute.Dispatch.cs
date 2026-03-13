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
    /// 全局输入绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnGlobalInputAttribute : GameEngine.OnInputDispatchCallAttribute
    {
        public OnGlobalInputAttribute(int inputCode) : base(inputCode) { }

        public OnGlobalInputAttribute(int inputCode, GameEngine.InputOperationType inputOperationType) : base(inputCode, inputOperationType) { }

        public OnGlobalInputAttribute(Type inputDataType) : base(inputDataType) { }

        public OnGlobalInputAttribute(Type classType, int inputCode) : base(classType, inputCode) { }

        public OnGlobalInputAttribute(Type classType, int inputCode, GameEngine.InputOperationType inputOperationType) : base(classType, inputCode, inputOperationType) { }

        public OnGlobalInputAttribute(Type classType, Type inputDataType) : base(classType, inputDataType) { }
    }

    /// <summary>
    /// 对象输入绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnBeanInputAttribute : GameEngine.InputResponseBindingOfTargetAttribute
    {
        public OnBeanInputAttribute(int inputCode) : base(inputCode, GameEngine.AspectBehaviourType.Startup) { }

        public OnBeanInputAttribute(int inputCode, GameEngine.InputOperationType inputOperationType) : base(inputCode, inputOperationType, GameEngine.AspectBehaviourType.Startup) { }

        public OnBeanInputAttribute(Type inputDataType) : base(inputDataType, GameEngine.AspectBehaviourType.Startup) { }
    }

    /// <summary>
    /// 全局事件绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnGlobalEventAttribute : GameEngine.OnEventDispatchCallAttribute
    {
        public OnGlobalEventAttribute(int eventID) : base(eventID) { }

        public OnGlobalEventAttribute(Type eventDataType) : base(eventDataType) { }

        public OnGlobalEventAttribute(Type classType, int eventID) : base(classType, eventID) { }

        public OnGlobalEventAttribute(Type classType, Type eventDataType) : base(classType, eventDataType) { }
    }

    /// <summary>
    /// 对象事件绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnBeanEventAttribute : GameEngine.EventSubscribeBindingOfTargetAttribute
    {
        public OnBeanEventAttribute(int eventID) : base(eventID, GameEngine.AspectBehaviourType.Startup) { }

        public OnBeanEventAttribute(Type eventDataType) : base(eventDataType, GameEngine.AspectBehaviourType.Startup) { }
    }

    /// <summary>
    /// 全局消息绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnGlobalMessageAttribute : GameEngine.OnMessageDispatchCallAttribute
    {
        public OnGlobalMessageAttribute(int opcode) : base(opcode) { }

        public OnGlobalMessageAttribute(Type messageType) : base(messageType) { }

        public OnGlobalMessageAttribute(Type classType, int opcode) : base(classType, opcode) { }

        public OnGlobalMessageAttribute(Type classType, Type messageType) : base(classType, messageType) { }
    }

    /// <summary>
    /// 对象消息绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnBeanMessageAttribute : GameEngine.MessageListenerBindingOfTargetAttribute
    {
        public OnBeanMessageAttribute(int opcode) : base(opcode, GameEngine.AspectBehaviourType.Startup) { }

        public OnBeanMessageAttribute(Type messageType) : base(messageType, GameEngine.AspectBehaviourType.Startup) { }
    }

    /// <summary>
    /// 全局同步绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnGlobalReplicateAttribute : GameEngine.OnReplicateDispatchCallAttribute
    {
        public OnGlobalReplicateAttribute(string tags) : base(tags) { }

        public OnGlobalReplicateAttribute(string tags, GameEngine.ReplicateAnnounceType announceType) : base(tags, announceType) { }

        public OnGlobalReplicateAttribute(Type classType, string tags) : base(classType, tags) { }

        public OnGlobalReplicateAttribute(Type classType, string tags, GameEngine.ReplicateAnnounceType announceType) : base(classType, tags, announceType) { }
    }

    /// <summary>
    /// 对象同步绑定函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public class OnBeanReplicateAttribute : GameEngine.ReplicateCommunicateBindingOfTargetAttribute
    {
        public OnBeanReplicateAttribute(string tags) : base(tags, GameEngine.AspectBehaviourType.Startup) { }

        public OnBeanReplicateAttribute(string tags, GameEngine.ReplicateAnnounceType announceType) : base(tags, announceType, GameEngine.AspectBehaviourType.Startup) { }
    }
}
