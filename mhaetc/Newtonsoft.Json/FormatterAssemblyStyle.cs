/************************************************************************************
*源码来自(C#源码世界)  www.HelloCsharp.com
*如果对该源码有问题可以直接点击下方的提问按钮进行提问哦
*站长将亲自帮你解决问题
*C#源码世界-找到你需要的C#源码，交流和学习
************************************************************************************/

#if PocketPC || NETFX_CORE || PORTABLE40 || PORTABLE

namespace System.Runtime.Serialization.Formatters
{
    /// <summary>
    /// Indicates the method that will be used during deserialization for locating and loading assemblies.
    /// </summary>
    public enum FormatterAssemblyStyle
    {
        /// <summary>
        /// In simple mode, the assembly used during deserialization need not match exactly the assembly used during serialization. Specifically, the version numbers need not match as the LoadWithPartialName method is used to load the assembly.
        /// </summary>
        Simple,

        /// <summary>
        /// In full mode, the assembly used during deserialization must match exactly the assembly used during serialization. The Load method of the Assembly class is used to load the assembly.
        /// </summary>
        Full
    }
}

#endif