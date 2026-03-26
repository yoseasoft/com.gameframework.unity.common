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
    /// 初始化阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnInitializeAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnInitializeAttribute() : base(GameEngine.AspectBehaviourType.Initialize) { }
    }

    /// <summary>
    /// 开启阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnStartupAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnStartupAttribute() : base(GameEngine.AspectBehaviourType.Startup) { }
    }

    /// <summary>
    /// 唤醒阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnAwakeAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnAwakeAttribute() : base(GameEngine.AspectBehaviourType.Awake) { }
    }

    /// <summary>
    /// 开始阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnStartAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnStartAttribute() : base(GameEngine.AspectBehaviourType.Start) { }
    }

    /// <summary>
    /// 执行阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnExecuteAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnExecuteAttribute() : base(GameEngine.AspectBehaviourType.Execute) { }
    }

    /// <summary>
    /// 延迟执行阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnLateExecuteAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnLateExecuteAttribute() : base(GameEngine.AspectBehaviourType.LateExecute) { }
    }

    /// <summary>
    /// 刷新阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnUpdateAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnUpdateAttribute() : base(GameEngine.AspectBehaviourType.Update) { }
    }

    /// <summary>
    /// 延迟刷新阶段前置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnLateUpdateAttribute : GameEngine.OnAspectBeforeCallAttribute
    {
        public OnLateUpdateAttribute() : base(GameEngine.AspectBehaviourType.LateUpdate) { }
    }

    /// <summary>
    /// 销毁阶段后置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnDestroyAttribute : GameEngine.OnAspectAfterCallAttribute
    {
        public OnDestroyAttribute() : base(GameEngine.AspectBehaviourType.Destroy) { }
    }

    /// <summary>
    /// 关闭阶段后置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnShutdownAttribute : GameEngine.OnAspectAfterCallAttribute
    {
        public OnShutdownAttribute() : base(GameEngine.AspectBehaviourType.Shutdown) { }
    }

    /// <summary>
    /// 清理阶段后置通知函数的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class OnCleanupAttribute : GameEngine.OnAspectAfterCallAttribute
    {
        public OnCleanupAttribute() : base(GameEngine.AspectBehaviourType.Cleanup) { }
    }
}
