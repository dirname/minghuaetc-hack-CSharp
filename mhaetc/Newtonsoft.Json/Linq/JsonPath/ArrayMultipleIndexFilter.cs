/************************************************************************************
*源码来自(C#源码世界)  www.HelloCsharp.com
*如果对该源码有问题可以直接点击下方的提问按钮进行提问哦
*站长将亲自帮你解决问题
*C#源码世界-找到你需要的C#源码，交流和学习
************************************************************************************/
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq.JsonPath
{
    internal class ArrayMultipleIndexFilter : PathFilter
    {
        public List<int> Indexes { get; set; }

        public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
        {
            foreach (JToken t in current)
            {
                foreach (int i in Indexes)
                {
                    JToken v = GetTokenIndex(t, errorWhenNoMatch, i);

                    if (v != null)
                        yield return v;
                }
            }
        }
    }
}