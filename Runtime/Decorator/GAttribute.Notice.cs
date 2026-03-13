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
    /// 视图窗口恢复通知声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GViewResumeAttribute : GameEngine.CViewNoticeCallAttribute
    {
        public GViewResumeAttribute() : base(GameEngine.ViewNoticeType.Resume) { }
    }

    /// <summary>
    /// 视图窗口暂停通知声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GViewPauseAttribute : GameEngine.CViewNoticeCallAttribute
    {
        public GViewPauseAttribute() : base(GameEngine.ViewNoticeType.Pause) { }
    }

    /// <summary>
    /// 视图窗口置顶通知声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GViewRevealAttribute : GameEngine.CViewNoticeCallAttribute
    {
        public GViewRevealAttribute() : base(GameEngine.ViewNoticeType.Reveal) { }
    }

    /// <summary>
    /// 视图窗口遮挡通知声明属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GViewCoverAttribute : GameEngine.CViewNoticeCallAttribute
    {
        public GViewCoverAttribute() : base(GameEngine.ViewNoticeType.Cover) { }
    }
}
