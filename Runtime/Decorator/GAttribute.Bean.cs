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
    /// 对象实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GObjectClassAttribute : GameEngine.CObjectClassAttribute
    {
        public GObjectClassAttribute(string viewName) : base(viewName) { }

        public GObjectClassAttribute(int priority) : base(priority) { }

        public GObjectClassAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 场景实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GSceneClassAttribute : GameEngine.CSceneClassAttribute
    {
        public GSceneClassAttribute(string viewName) : base(viewName) { }

        public GSceneClassAttribute(int priority) : base(priority) { }

        public GSceneClassAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 角色实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GActorClassAttribute : GameEngine.CActorClassAttribute
    {
        public GActorClassAttribute(string viewName) : base(viewName) { }

        public GActorClassAttribute(int priority) : base(priority) { }

        public GActorClassAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 视图实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GViewClassAttribute : GameEngine.CViewClassAttribute
    {
        public GViewClassAttribute(string viewName) : base(viewName) { }

        public GViewClassAttribute(int priority) : base(priority) { }

        public GViewClassAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 组件实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GComponentClassAttribute : GameEngine.CComponentClassAttribute
    {
        public GComponentClassAttribute(string viewName) : base(viewName) { }

        public GComponentClassAttribute(int priority) : base(priority) { }

        public GComponentClassAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////

    /// <summary>
    /// 视图分组策略声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class GViewGroupAttribute : GameEngine.CViewGroupAttribute
    {
        public GViewGroupAttribute(string groupName) : base(groupName) { }
    }

    /// <summary>
    /// 实体自动挂载的目标组件的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class GComponentAutomaticActivationOfEntityAttribute : GameEngine.CComponentAutomaticActivationOfEntityAttribute
    {
        public GComponentAutomaticActivationOfEntityAttribute(Type referenceType) : base(referenceType) { }

        public GComponentAutomaticActivationOfEntityAttribute(Type referenceType, int priority) : base(referenceType, priority) { }

        public GComponentAutomaticActivationOfEntityAttribute(Type referenceType, int priority, GameEngine.AspectBehaviourType activationBehaviourType) : base(referenceType, priority, activationBehaviourType) { }
    }
}
