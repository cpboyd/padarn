#region License
// Copyright ©2017 Tacke Consulting (dba OpenNETCF)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute, 
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or 
// substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR 
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR 
// ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
#endregion
using System;

using System.Collections.Generic;
using System.Text;

namespace OpenNETCF.Web.UI
{
    /// <summary>
    /// Specifies the HTML tags that can be passed to an HtmlTextWriter object output stream.
    /// </summary>
    public enum HtmlTextWriterTag
    {
        /// <summary>
        /// The string passed as an HTML tag is not recognized.  
        /// </summary>
        Unknown,
        /// <summary>
        /// The HTML a element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/a
        /// </summary>
        A,
        /// <summary>
        /// The HTML address element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/address
        /// </summary>
        Address,
        /// <summary>
        /// The HTML area element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/area
        /// </summary>
        Area,        
        /// <summary>
        /// The HTML blockquote element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/blockquote
        /// </summary>
        Blockquote,        
        /// <summary>
        /// The HTML body element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/body
        /// </summary>
        Body,
        /// <summary>
        /// The HTML br element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/br
        /// </summary>
        Br,       
        /// <summary>
        /// The HTML button element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/button
        /// </summary>
        Button,
        /// <summary>
        /// The HTML caption element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/caption
        /// </summary>
        Caption,
        /// <summary>
        /// The HTML code element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/code
        /// </summary>
        Code,        
        /// <summary>
        /// The HTML col element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
        /// </summary>
        Col,
        /// <summary>
        /// The HTML colgroup element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/colgroup
        /// </summary>  
        Colgroup,        
        /// <summary>
        /// The HTML div element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/div
        /// </summary>
        Div,
        /// <summary>
        /// The HTML fieldset element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/fieldset
        /// </summary>
        Fieldset,        
        /// <summary>
        /// The HTML form element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/form
        /// </summary>
        Form,        
        /// <summary>
        /// The HTML H1 element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/h1
        /// </summary>
        H1,
        /// <summary>
        /// The HTML H2 element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/h2
        /// </summary>
        H2,
        /// <summary>
        /// The HTML H3 element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/h3
        /// </summary>
        H3,
        /// <summary>
        /// The HTML H4 element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/h4
        /// </summary>
        H4,
        /// <summary>
        /// The HTML H5 element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/h5
        /// </summary>
        H5,
        /// <summary>
        /// The HTML H6 element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/h6
        /// </summary>
        H6,
        /// <summary>
        /// The HTML head element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/head
        /// </summary>
        Head,          
        /// <summary>
        /// The HTML html element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/html
        /// </summary>
        Html,
        /// <summary>
        /// The HTML hr element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/hr
        /// </summary>
        Hr,
        /// <summary>
        /// The HTML i element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/i
        /// </summary>
        I,
        /// <summary>
        /// The HTML iframe element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/iframe
        /// </summary>
        Iframe,
        /// <summary>
        /// The HTML img element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img
        /// </summary>
        Img,
        /// <summary>
        /// The HTML input element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input
        /// </summary>
        Input,
        /// <summary>
        /// The HTML label element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/label
        /// </summary>
        Label,
        /// <summary>
        /// The HTML legend element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/legend
        /// </summary>
        Legend,
        /// <summary>
        /// The HTML li element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/li
        /// </summary>
        Li,
        /// <summary>
        /// The HTML link element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/link
        /// </summary>
        Link,
        /// <summary>
        /// The HTML meta element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/meta
        /// </summary>
        Meta,
        /// <summary>
        /// The HTML object element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/object
        /// </summary>
        Object,
        /// <summary>
        /// The HTML ol element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ol
        /// </summary>
        Ol,
        /// <summary>
        /// The HTML option element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/option
        /// </summary>
        Option,        
        /// <summary>
        /// The HTML p element.   
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/p
        /// </summary>        
        P,
        /// <summary>
        /// The HTML param element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/param
        /// </summary>
        Param,
        /// <summary>
        /// The HTML pre element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/pre
        /// </summary>
        Pre,
        /// <summary>
        /// The HTML script element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/script
        /// </summary>
        Script,        
        /// <summary>
        /// The HTML select element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
        /// </summary>
        Select,
        /// <summary>
        /// The HTML span element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/span
        /// </summary>
        Span,
        /// <summary>
        /// The HTML strike element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/strike
        /// </summary>
        [Obsolete("This element is deprecated in HTML 4 and XHTML 1, and obsoleted in HTML5. If semantically appropriate, i.e., if it represents deleted content, use <del> instead. In all other cases use <s>.")]
        Strike,
        /// <summary>
        /// The HTML strong element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/strong
        /// </summary>
        Strong, 
        /// <summary>
        /// The HTML style element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/style
        /// </summary>
        Style,        
        /// <summary>
        /// The HTML table element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/table
        /// </summary>
        Table,
        /// <summary>
        /// The HTML tbody element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tbody
        /// </summary>
        Tbody,
        /// <summary>
        /// The HTML td element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/td
        /// </summary>
        Td,
        /// <summary>
        /// The HTML textarea element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/textarea
        /// </summary>
        Textarea,
        /// <summary>
        /// The HTML tfoot element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot
        /// </summary>
        Tfoot,    
        /// <summary>
        /// The HTML th element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/th
        /// </summary>
        Th,
        /// <summary>
        /// The HTML thead element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/thead
        /// </summary>
        Thead,
        /// <summary>
        /// The HTML title element.
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/title
        /// </summary>
        Title,        
        /// <summary>
        /// The HTML tr element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tr
        /// </summary>
        Tr,        
        /// <summary>
        /// The HTML ul element.  
        /// https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ul
        /// </summary>
        Ul,
        


        //Acronym The HTML acronym element.  
        //B The HTML b element.  
        //Base The HTML base element.  
        //Basefont The HTML basefont element.  
        //Bdo The HTML bdo element.  
        //Bgsound The HTML bgsound element.  
        //Big The HTML big element.  
        //Center The HTML center element.  
        //Cite The HTML cite element.  
        //Dd The HTML dd element.  
        //Del The HTML del element.  
        //Dfn The HTML dfn element.  
        //Dir The HTML dir element.  
        //Dl The HTML dl element.  
        //Dt The HTML dt element.  
        //Em The HTML em element.  
        //Embed The HTML embed element.  
        //Font The HTML font element.  
        //Frame The HTML frame element.  
        //Frameset The HTML frameset element.  
          
        //I The HTML i element.  
        //Ins The HTML ins element.  
        //Isindex The HTML isindex element.  
        //Kbd The HTML kbd element.  
        //Map The HTML map element.  
        //Marquee The HTML marquee element.  
        //Menu The HTML menu element.  
          
        //Nobr The HTML nobr element.  
        //Noframes The HTML noframes element.  
        //Noscript The HTML noscript element.  
        //Q The HTML q element.  
        //Rt The DHTML rt element, which specifies text for the ruby element.  
        //Ruby The DHTML ruby element.  
        //S The HTML s element.  
        //Samp The HTML samp element.  
        //Small The HTML small element.  
          
        //Sub The HTML sub element.  
        //Sup The HTML sup element.  
          
        //Tt The HTML tt element.  
        //U The HTML u element.  
        //Var The HTML var element.  
        //Wbr The HTML wbr element.  
        //Xml 
    }
}
