/************************************************************************************
*源码来自(C#源码世界)  www.HelloCsharp.com
*如果对该源码有问题可以直接点击下方的提问按钮进行提问哦
*站长将亲自帮你解决问题
*C#源码世界-找到你需要的C#源码，交流和学习
************************************************************************************/
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
    internal class FieldFilter : PathFilter
    {
        public string Name { get; set; }

        public override IEnumerable<JToken> ExecuteFilter(IEnumerable<JToken> current, bool errorWhenNoMatch)
        {
            foreach (JToken t in current)
            {
                JObject o = t as JObject;
                if (o != null)
                {
                    if (Name != null)
                    {
                        JToken v = o[Name];

                        if (v != null)
                            yield return v;

                        if (errorWhenNoMatch)
                            throw new JsonException("Property '{0}' does not exist on JObject.".FormatWith(CultureInfo.InvariantCulture, Name));
                    }
                    else
                    {
                        foreach (KeyValuePair<string, JToken> p in o)
                        {
                            yield return p.Value;
                        }
                    }
                }
                else
                {
                    if (errorWhenNoMatch)
                        throw new JsonException("Property '{0}' not valid on {1}.".FormatWith(CultureInfo.InvariantCulture, Name ?? "*", t.GetType().Name));
                }
            }
        }
    }
}