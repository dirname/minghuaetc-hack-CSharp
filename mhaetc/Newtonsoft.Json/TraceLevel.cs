/************************************************************************************
*源码来自(C#源码世界)  www.HelloCsharp.com
*如果对该源码有问题可以直接点击下方的提问按钮进行提问哦
*站长将亲自帮你解决问题
*C#源码世界-找到你需要的C#源码，交流和学习
************************************************************************************/

#if (NETFX_CORE || PORTABLE40 || PORTABLE)
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
    /// <summary>
    /// Specifies what messages to output for the <see cref="ITraceWriter"/> class.
    /// </summary>
    public enum TraceLevel
    {
        /// <summary>
        /// Output no tracing and debugging messages.
        /// </summary>
        Off,

        /// <summary>
        /// Output error-handling messages.
        /// </summary>
        Error,

        /// <summary>
        /// Output warnings and error-handling messages.
        /// </summary>
        Warning,

        /// <summary>
        /// Output informational messages, warnings, and error-handling messages.
        /// </summary>
        Info,

        /// <summary>
        /// Output all debugging and tracing messages.
        /// </summary>
        Verbose
    }
}

#endif