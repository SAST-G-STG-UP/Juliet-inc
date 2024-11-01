﻿/*
 *
 * (c) Copyright Ascensio System Limited 2010-2023
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
*/


using System;
using System.Text.RegularExpressions;
using System.Web;

using ASC.Common.Notify.Patterns;
using ASC.Notify.Messages;
using ASC.Notify.Patterns;

namespace ASC.Notify.Textile
{
    public class MarkDownStyler : IPatternStyler
    {
        static readonly Regex VelocityArguments = new Regex(NVelocityPatternFormatter.NoStylePreffix + "(?<arg>.*?)" + NVelocityPatternFormatter.NoStyleSuffix, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
        static readonly Regex LinkReplacer = new Regex(@"""(?<text>[\w\W]+?)"":""(?<link>[^""]+)""", RegexOptions.Singleline | RegexOptions.Compiled);
        static readonly Regex DivPTagReplacer = new Regex(@"(<(p|div).*?>)|(<\/(p|div)>)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled | RegexOptions.Singleline);
        static readonly Regex TagReplacer = new Regex(@"<(.|\n)*?>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled | RegexOptions.Singleline);
        static readonly Regex MultiLineBreaksReplacer = new Regex(@"(?:\r\n|\r(?!\n)|(?!<\r)\n){3,}", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex SymbolReplacer = new Regex(@"\[(.*?)]\(([^()]*)\)|[]\\[(){}*_|#+=.!~>`-]", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex LinkSymbolReplacer = new Regex(@"[]\\[(){}*_|#+=.!~>`-]", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex BoldReplacer = new Regex(@"<(strong|\/strong)\\>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex StrikeThroughReplacer = new Regex(@"<(s|\/s)\\>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex UnderLineReplacer = new Regex(@"<(u|\/u)\\>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex ItalicReplacer = new Regex(@"<(em|\/em)\\>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        static readonly Regex HTMLLinkReplacer = new Regex(@"<a.*?href=""(.*?)"".*?>(.*?)<\/a>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);

        public void ApplyFormating(NoticeMessage message)
        {
            var body = string.Empty;
            if (!string.IsNullOrEmpty(message.Subject))
            {
                body += VelocityArguments.Replace(message.Subject, ArgMatchReplace) + Environment.NewLine;
                message.Subject = string.Empty;
            }
            if (string.IsNullOrEmpty(message.Body)) return;
            var lines = message.Body.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.None);
            for (var i = 0; i < lines.Length - 1; i++)
            {
                if (string.IsNullOrEmpty(lines[i])) { body += Environment.NewLine; continue; }
                lines[i] = VelocityArguments.Replace(lines[i], ArgMatchReplace);
                body += LinkReplacer.Replace(lines[i], EvalLink) + Environment.NewLine;
            }
            lines[lines.Length - 1] = VelocityArguments.Replace(lines[lines.Length - 1], ArgMatchReplace);
            body += LinkReplacer.Replace(lines[lines.Length - 1], EvalLink);
            body = DivPTagReplacer.Replace(body, "");
            body = HTMLLinkReplacer.Replace(body, @"[$2]($1)");
            body = HttpUtility.HtmlDecode(body);
            body = SymbolReplacer.Replace(body, m => m.Groups[1].Success ? $@"[{LinkSymbolReplacer.Replace(m.Groups[1].Value, @"\$&")}]({m.Groups[2].Value})" : $@"\{m.Value}");
            body = BoldReplacer.Replace(body, "*");
            body = StrikeThroughReplacer.Replace(body, "~");
            body = UnderLineReplacer.Replace(body, "__");
            body = ItalicReplacer.Replace(body, "_");
            body = TagReplacer.Replace(body, "");
            body = MultiLineBreaksReplacer.Replace(body, Environment.NewLine);
            message.Body = body;
        }

        private static string EvalLink(Match match)
        {
            if (match.Success)
            {
                if (match.Groups["text"].Success && match.Groups["link"].Success)
                {
                    if (match.Groups["text"].Value.Equals(match.Groups["link"].Value, StringComparison.OrdinalIgnoreCase))
                    {
                        return " " + match.Groups["text"].Value + " ";
                    }
                    return match.Groups["text"].Value + string.Format(" ( {0} )", match.Groups["link"].Value);
                }
            }
            return match.Value;
        }

        private static string ArgMatchReplace(Match match)
        {
            return match.Result("${arg}");
        }
    }
}
