/// -------------------------------------------------------------------------------
/// GameFramework By UnityEngine
///
/// Copyright (C) 2026, Hainan Yuanyou Information Technology Co., Ltd. Guangzhou Branch
/// Copyright (C) 2026, Hurley, Independent Studio.
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
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace GameFramework
{
    /// 游戏层提供的调试对象类
    public static partial class Debugger
    {
        /// <summary>
        /// 检测指定条件是否为TRUE的断言函数
        /// </summary>
        /// <param name="condition">断言条件</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTrue(bool condition)
        {
            GameEngine.Debugger.IsTrue(condition);
        }

        /// <summary>
        /// 检测指定条件是否为TRUE的断言函数
        /// </summary>
        /// <param name="condition">断言条件</param>
        /// <param name="message">消息内容</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTrue(bool condition, string message)
        {
            GameEngine.Debugger.IsTrue(condition, message);
        }

        /// <summary>
        /// 检测指定条件是否为TRUE的断言函数
        /// </summary>
        /// <param name="condition">断言条件</param>
        /// <param name="format">消息格式</param>
        /// <param name="args">消息参数列表</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTrue(bool condition, string format, params object[] args)
        {
            GameEngine.Debugger.IsTrue(condition, format, args);
        }

        /// <summary>
        /// 检测指定条件是否为FALSE的断言函数
        /// </summary>
        /// <param name="condition">断言条件</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsFalse(bool condition)
        {
            GameEngine.Debugger.IsFalse(condition);
        }

        /// <summary>
        /// 检测指定条件是否为FALSE的断言函数
        /// </summary>
        /// <param name="condition">断言条件</param>
        /// <param name="message">消息内容</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsFalse(bool condition, string message)
        {
            GameEngine.Debugger.IsFalse(condition, message);
        }

        /// <summary>
        /// 检测指定条件是否为FALSE的断言函数
        /// </summary>
        /// <param name="condition">断言条件</param>
        /// <param name="format">消息格式</param>
        /// <param name="args">消息参数列表</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsFalse(bool condition, string format, params object[] args)
        {
            GameEngine.Debugger.IsFalse(condition, format, args);
        }

        /// <summary>
        /// 检测指定类对象是否为NULL的断言函数
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">对象实例</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNull<T>(T value) where T : class
        {
            GameEngine.Debugger.IsNull(value);
        }

        /// <summary>
        /// 检测指定类对象是否为NULL的断言函数
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">对象实例</param>
        /// <param name="message">消息内容</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNull<T>(T value, string message) where T : class
        {
            GameEngine.Debugger.IsNull(value, message);
        }

        /// <summary>
        /// 检测指定类对象是否为NULL的断言函数
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">对象实例</param>
        /// <param name="format">消息格式</param>
        /// <param name="args">消息参数列表</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNull<T>(T value, string format, params object[] args) where T : class
        {
            GameEngine.Debugger.IsNull(value, format, args);
        }

        /// <summary>
        /// 检测指定类对象是否为非NULL的断言函数
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">对象实例</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotNull<T>(T value) where T : class
        {
            GameEngine.Debugger.IsNotNull(value);
        }

        /// <summary>
        /// 检测指定类对象是否为非NULL的断言函数
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">对象实例</param>
        /// <param name="message">消息内容</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotNull<T>(T value, string message) where T : class
        {
            GameEngine.Debugger.IsNotNull(value, message);
        }

        /// <summary>
        /// 检测指定类对象是否为非NULL的断言函数
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="value">对象实例</param>
        /// <param name="format">消息格式</param>
        /// <param name="args">消息参数列表</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotNull<T>(T value, string format, params object[] args) where T : class
        {
            GameEngine.Debugger.IsNotNull(value, format, args);
        }

        /// <summary>
        /// 检测指定对象是否继承自目标类型的断言函数
        /// </summary>
        /// <typeparam name="T">父对象类型</typeparam>
        /// <param name="obj">对象实例</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTypeOf<T>(object obj) where T : class
        {
            GameEngine.Debugger.IsTypeOf<T>(obj);
        }

        /// <summary>
        /// 检测指定对象是否继承自目标类型的断言函数
        /// </summary>
        /// <typeparam name="T">父对象类型</typeparam>
        /// <param name="obj">对象实例</param>
        /// <param name="message">消息内容</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTypeOf<T>(object obj, string message) where T : class
        {
            GameEngine.Debugger.IsTypeOf<T>(obj, message);
        }

        /// <summary>
        /// 检测指定对象是否继承自目标类型的断言函数
        /// </summary>
        /// <typeparam name="T">父对象类型</typeparam>
        /// <param name="obj">对象实例</param>
        /// <param name="format">消息格式</param>
        /// <param name="args">消息参数列表</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTypeOf<T>(object obj, string format, params object[] args) where T : class
        {
            GameEngine.Debugger.IsTypeOf<T>(obj, format, args);
        }

        /// <summary>
        /// 检测指定对象类型是否继承自目标类型的断言函数
        /// </summary>
        /// <typeparam name="T">父对象类型</typeparam>
        /// <param name="type">对象类型</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTypeOf<T>(Type type) where T : class
        {
            GameEngine.Debugger.IsTypeOf<T>(type);
        }

        /// <summary>
        /// 检测指定对象类型是否继承自目标类型的断言函数
        /// </summary>
        /// <typeparam name="T">父对象类型</typeparam>
        /// <param name="type">对象类型</param>
        /// <param name="message">消息内容</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTypeOf<T>(Type type, string message) where T : class
        {
            GameEngine.Debugger.IsTypeOf<T>(type, message);
        }

        /// <summary>
        /// 检测指定对象类型是否继承自目标类型的断言函数
        /// </summary>
        /// <typeparam name="T">父对象类型</typeparam>
        /// <param name="type">对象类型</param>
        /// <param name="format">消息格式</param>
        /// <param name="args">消息参数列表</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsTypeOf<T>(Type type, string format, params object[] args) where T : class
        {
            GameEngine.Debugger.IsTypeOf<T>(type, format, args);
        }
    }
}
