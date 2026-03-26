/// -------------------------------------------------------------------------------
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
    /// 数据同步的目标对象类型启用标记的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public sealed class UReplicateObjectAttribute : GameEngine.CReplicateObjectAttribute
    {
        public UReplicateObjectAttribute() : base() { }

        public UReplicateObjectAttribute(string tag) : base(tag) { }
    }

    /// <summary>
    /// 数据同步的目标实体对象唯一标识的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class UReplicateIdAttribute : GameEngine.CReplicateIdAttribute
    {
        public UReplicateIdAttribute() : base() { }

        public UReplicateIdAttribute(string tag) : base(tag) { }
    }

    /// <summary>
    /// 数据同步的目标对象字段启用标记的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public sealed class UReplicateFieldAttribute : GameEngine.CReplicateFieldAttribute
    {
        public UReplicateFieldAttribute() : base() { }

        public UReplicateFieldAttribute(string tag) : base(tag) { }
    }

    /// <summary>
    /// 数据同步的目标对象属性启用标记的属性类型定义
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public sealed class UReplicatePropertyAttribute : GameEngine.CReplicatePropertyAttribute
    {
        public UReplicatePropertyAttribute() : base() { }

        public UReplicatePropertyAttribute(string tag) : base(tag) { }
    }
}
