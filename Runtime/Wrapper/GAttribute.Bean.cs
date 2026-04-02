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
    public class OnObjectConfigureAttribute : GameEngine.CObjectTemplateConfigurationAttribute
    {
        public OnObjectConfigureAttribute() : base() { }

        public OnObjectConfigureAttribute(string viewName) : base(viewName) { }

        public OnObjectConfigureAttribute(int priority) : base(priority) { }

        public OnObjectConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 场景实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnSceneConfigureAttribute : GameEngine.CSceneTemplateConfigurationAttribute
    {
        public OnSceneConfigureAttribute() : base() { }

        public OnSceneConfigureAttribute(string viewName) : base(viewName) { }

        public OnSceneConfigureAttribute(int priority) : base(priority) { }

        public OnSceneConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 角色实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnActorConfigureAttribute : GameEngine.CActorTemplateConfigurationAttribute
    {
        public OnActorConfigureAttribute() : base() { }

        public OnActorConfigureAttribute(string viewName) : base(viewName) { }

        public OnActorConfigureAttribute(int priority) : base(priority) { }

        public OnActorConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 视图实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnViewConfigureAttribute : GameEngine.CViewTemplateConfigurationAttribute
    {
        public OnViewConfigureAttribute() : base() { }

        public OnViewConfigureAttribute(string viewName) : base(viewName) { }

        public OnViewConfigureAttribute(int priority) : base(priority) { }

        public OnViewConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
    }

    /// <summary>
    /// 组件实现类声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class OnComponentConfigureAttribute : GameEngine.CComponentTemplateConfigurationAttribute
    {
        public OnComponentConfigureAttribute() : base() { }

        public OnComponentConfigureAttribute(string viewName) : base(viewName) { }

        public OnComponentConfigureAttribute(int priority) : base(priority) { }

        public OnComponentConfigureAttribute(string viewName, int priority) : base(viewName, priority) { }
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
    public class GAutomaticallyActivatedComponentAttribute : GameEngine.CAutomaticallyActivatedComponentAttribute
    {
        public GAutomaticallyActivatedComponentAttribute(Type referenceType) : base(referenceType) { }

        public GAutomaticallyActivatedComponentAttribute(Type referenceType, int priority) : base(referenceType, priority) { }

        public GAutomaticallyActivatedComponentAttribute(Type referenceType, int priority, GameEngine.AspectBehaviourType activationBehaviourType) : base(referenceType, priority, activationBehaviourType) { }
    }
}
