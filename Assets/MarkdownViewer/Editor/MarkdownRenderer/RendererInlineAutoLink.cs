﻿////////////////////////////////////////////////////////////////////////////////

using Markdig.Renderers;
using Markdig.Syntax.Inlines;

namespace MG.MDV
{
    ////////////////////////////////////////////////////////////////////////////////
    // <a href="...">...</a>
    /// <see cref="Markdig.Renderers.Html.Inlines.AutolinkInlineRenderer"/>

    public class RendererInlineAutoLink : MarkdownObjectRenderer<RendererMarkdown, AutolinkInline>
    {
        protected override void Write( RendererMarkdown renderer, AutolinkInline node )
        {
            throw new System.NotImplementedException();
        }
    }
}