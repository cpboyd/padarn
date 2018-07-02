# OpenNETCF.Web #

## Method UI.PageParserFilter.PreprocessDirective(System.String,System.Collections.IDictionary)

 Allows the page parser filter to preprocess page directives. 


| Name | Description |
|-----|------|
|directiveName: ||
|attributes: ||


> The page parser calls the PreprocessDirective method for each directive encountered during parsing.



---
## Property UI.PageParserFilter.VirtualPath

 Gets the virtual path to the page currently being parsed. 



---
## Property UI.PageParserFilter.AllowCode

 Gets a value indicating whether a Padarn parser filter permits code on the page. 



>  For Padarn, this is always **false**. 



---
## Type HttpWorkerRequest

 This abstract class defines the base worker methods and enumerations used by PS managed code to process requests. 



---
## Method HttpWorkerRequest.EndOfRequest

 Used by the runtime to notify the HttpWorkerRequest that request processing for the current request is complete. 



---
## Method HttpWorkerRequest.FlushResponse(System.Boolean)

 Sends all pending response data to the client. 


| Name | Description |
|-----|------|
|finalFlush: |true if this is the last time response data will be flushed; otherwise, false.|


---
## Method HttpWorkerRequest.ReadRequestHeaders

 Read the headers from the request 



---
## Method HttpWorkerRequest.ProcessRequest

 Process the HTTP request 



---
## Method HttpWorkerRequest.GetUriPath

 Returns the virtual path to the requested URI 

**Returns**: The path to the requested URI.



---
## Method HttpWorkerRequest.GetLocalAddress

 Provides access to the specified member of the request header. 

**Returns**: The server IP address returned in the request header.



---
## Method HttpWorkerRequest.GetLocalPort

 Provides access to the specified member of the request header. 

**Returns**: The server port number returned in the request header.



---
## Method HttpWorkerRequest.GetHttpVersion

 Provides access to the HTTP version of the request (for example, &quot;HTTP/1.1&quot;). 

**Returns**: The HTTP version returned in the request header.



---
## Method HttpWorkerRequest.GetHttpVerbName

 Returns the specified member of the request header. 

**Returns**: The HTTP verb returned in the request header.



---
## Method HttpWorkerRequest.GetQueryString

 Returns the query string specified in the request URL. 

**Returns**: The request query string.



---
## Method HttpWorkerRequest.GetRemoteAddress

 Provides access to the specified member of the request header. 

**Returns**: The client&#39;s IP address.



---
## Method HttpWorkerRequest.SendResponseFromMemory(System.Byte[],System.Int32)

 Adds the specified number of bytes from a byte array to the response. 


| Name | Description |
|-----|------|
|data: |The byte array to send.|
|length: |The number of bytes to send, starting at the first byte.|


---
## Method HttpWorkerRequest.SendKnownResponseHeader(System.String,System.String)

 Adds a standard HTTP header to the response. 


| Name | Description |
|-----|------|
|name: |The header name. For example, Accept-Range|
|value: |The value of the header.|


---
## Method HttpWorkerRequest.IsClientConnected

 Returns a value indicating whether the client connection is still active. 

**Returns**: true if the client connection is still active; otherwise, false.



---
## Method HttpWorkerRequest.GetRemoteName

 When overridden in a derived class, returns the name of the client computer. 

**Returns**: The name of the client computer.



---
## Method HttpWorkerRequest.GetAppPathTranslated

 Returns the physical path to the currently executing server application. 

**Returns**: The physical path of the current application.



---
## Method HttpWorkerRequest.GetServerVariable(System.String)

 Returns a single server variable from a dictionary of server variables associated with the request. 


| Name | Description |
|-----|------|
|name: |The name of the requested server variable.|
**Returns**: The requested server variable.



---
## Method HttpWorkerRequest.GetRequestHeaders





---
## Method HttpWorkerRequest.GetKnownRequestHeader(System.Int32)




| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Method HttpWorkerRequest.GetServerName

 When overridden in a derived class, returns the name of the local server. 

**Returns**: The name of the local server.



---
## Method HttpWorkerRequest.MapPath(System.String)

 Maps a virtual path to a physical path on the server. 


| Name | Description |
|-----|------|
|virtualPath: ||
**Returns**: 



---
## Method HttpWorkerRequest.IsSecure

 Returns a value indicating whether the connection uses SSL. 

**Returns**: true if the connection is an SSL connection; otherwise, false. The default is false.



---
## Method HttpWorkerRequest.CloseConnection

 Terminates the connection with the client. 



---
## Method HttpWorkerRequest.SendCalculatedContentLength(System.Int32)

 Adds a Content-Length HTTP header to the response. 


| Name | Description |
|-----|------|
|contentLength: |The length of the response, in bytes.|


---
## Method HttpWorkerRequest.HeadersSent

 Returns a value indicating whether HTTP response headers have been sent to the client for the current request. 

**Returns**: 



---
## Type OpenNETCF.Security.Principal.GenericIdentity

 Represents a generic user. 



---
## Type OpenNETCF.Security.Principal.IIdentity

 Defines the basic functionality of an identity object. 



---
## Property OpenNETCF.Security.Principal.IIdentity.AuthenticationType

 Gets the type of authentication used. 



---
## Property OpenNETCF.Security.Principal.IIdentity.IsAuthenticated

 Gets a value that indicates whether the user has been authenticated. 



---
## Property OpenNETCF.Security.Principal.IIdentity.Name

 Gets the name of the current user. 



---
## Method OpenNETCF.Security.Principal.GenericIdentity.#ctor(System.String)

 Initializes a new instance of the GenericIdentity class representing the user with the specified name. 


| Name | Description |
|-----|------|
|userName: ||


---
## Method OpenNETCF.Security.Principal.GenericIdentity.#ctor(System.String,System.String)

 Initializes a new instance of the GenericIdentity class representing the user with the specified name and authentication type. 


| Name | Description |
|-----|------|
|userName: ||
|authType: ||


---
## Property OpenNETCF.Security.Principal.GenericIdentity.AuthenticationType

 Gets the type of authentication used to identify the user. 



---
## Property OpenNETCF.Security.Principal.GenericIdentity.IsAuthenticated

 Gets a value indicating whether the user has been authenticated. 



---
## Property OpenNETCF.Security.Principal.GenericIdentity.Name

 Gets the user&#39;s name. 



---
## Type Configuration.ServerConfigurationHandler

 Represents the WebServer section in the app.config file 



---
## Type OpenNETCF.Configuration.IConfigurationSectionHandler

 Defines the contract that all configuration section handlers must implement in order to participate in the resolution of configuration settings. Reads key-value pair configuration information for a configuration section. 



---
## Method OpenNETCF.Configuration.IConfigurationSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)

 Implemented by all configuration section handlers to parse the XML of the configuration section. The returned object is added to the configuration collection and is accessed by System.Configuration.ConfigurationSettings.GetConfig(System.String). 


| Name | Description |
|-----|------|
|parent: |The configuration settings in a corresponding parent configuration section.|
|configContext: |An System.Web.Configuration.HttpConfigurationContext when System.Configuration.IConfigurationSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode) is called from the ASP.NET configuration system. Otherwise, this parameter is reserved and is null.|
|section: |The System.Xml.XmlNode that contains the configuration information from the configuration file. Provides direct access to the XML contents of the configuration section.|
**Returns**: A configuration object.



---
## Method Configuration.ServerConfigurationHandler.Create(System.Object,System.Object,System.Xml.XmlNode)

 Creates an instance of ServerConfig from the information in the app.config file 


| Name | Description |
|-----|------|
|parent: ||
|configContext: ||
|section: ||
**Returns**: 



---
## Type UI.ControlBuilder

 Supports the page parser in building a control and the child controls it contains. 



---
## Method UI.ControlBuilder.#ctor

 Initializes a new instance of the ControlBuilder class. 



---
## Method UI.ControlBuilder.GetChildControlType(System.String,System.Collections.IDictionary)

 Obtains the Type of the control type corresponding to a child tag. This method is called by the Padarn page framework. 


| Name | Description |
|-----|------|
|tagName: ||
|attribs: ||
**Returns**: 



---
## Property UI.ControlBuilder.Parser

 Gets the TemplateParser responsible for parsing the control. 



---
## Property UI.ControlBuilder.ControlType

 The Type for the control to be created. 



---
## Property UI.ControlBuilder.TagName

 Gets the tag name for the control to be built. 



---
## Type OpenNETCF.Configuration.AppSettingsReader

 Provides a method for reading values of a particular type from the .config file. 



---
## Method OpenNETCF.Configuration.AppSettingsReader.#ctor





---
## Method OpenNETCF.Configuration.AppSettingsReader.GetValue(System.String,System.Type)




| Name | Description |
|-----|------|
|key: ||
|type: ||
**Returns**: 



---
## Type HttpPostedFile

 Provides access to individual files that have been uploaded by a client. 



---
## Method HttpPostedFile.SaveAs(System.String)

 Saves the contents of an uploaded file. 


| Name | Description |
|-----|------|
|filename: |The name of the saved file. |


---
## Property HttpPostedFile.ContentLength

 Gets the size of an uploaded file, in bytes 



---
## Property HttpPostedFile.ContentType

 Gets the MIME content type of a file sent by a client. 



---
## Property HttpPostedFile.FileName

 Gets the fully qualified name of the file on the client. 



---
## Property HttpPostedFile.InputStream

 Gets a Stream object that points to an uploaded file to prepare for reading the contents of the file. 



---
## Type Hosting.HostingEnvironment

 Provides application-management functions and application services to a managed application within its application domain. This class cannot be inherited. 



---
## Method Hosting.HostingEnvironment.RegisterVirtualPathProvider(OpenNETCF.Web.Hosting.VirtualPathProvider)

 Registers a new VirtualPathProvider instance with the Padarn system. 


| Name | Description |
|-----|------|
|virtualPathProvider: ||


---
## Method Hosting.HostingEnvironment.MapPath(System.String)

 Maps a virtual path to a physical path on the server. 


| Name | Description |
|-----|------|
|virtualPath: |The virtual path (absolute or relative). |
**Returns**: The physical path on the server specified by virtualPath.



---
## Property Hosting.HostingEnvironment.ApplicationPhysicalPath

 Gets the physical path on disk to the application&#39;s directory. 



---
## Property Hosting.HostingEnvironment.ApplicationVersion

 Gets the version of the Padarn server assembly 



---
## Type HttpRequestValidationException

 The exception that is thrown when a potentially malicious input string is received from the client as part of the request data. This class cannot be inherited. 



---
## Type HttpException

 Describes an exception that occurred during the processing of HTTP requests. 



---
## Method HttpException.CreateFromLastError(System.String)

 Creates a new [Type HttpException](#type-httpexception) exception based on the error code that is returned from the Win32 API GetLastError() method. 


| Name | Description |
|-----|------|
|message: ||
**Returns**: 



---
## Method HttpException.#ctor(System.String)

 Initializes a new instance of the [Type HttpException](#type-httpexception) class using a supplied error message. 


| Name | Description |
|-----|------|
|message: |The error message displayed to the client when the exception is thrown.|


---
## Method HttpException.#ctor(System.Int32,System.String)

 Creates an instance of the [Type HttpException](#type-httpexception) type 


| Name | Description |
|-----|------|
|httpCode: ||
|message: ||


---
## Method HttpException.#ctor(OpenNETCF.Web.HttpErrorCode,System.String)

 Creates an instance of the [Type HttpException](#type-httpexception) type 


| Name | Description |
|-----|------|
|httpCode: ||
|message: ||


---
## Method HttpException.#ctor(System.String,System.Exception)

 Initializes a new instance of the [Type HttpException](#type-httpexception) class using an error message and the InnerException property. 


| Name | Description |
|-----|------|
|message: |The error message displayed to the client when the exception is thrown.|
|innerException: |The [Property System.Exception.InnerException](https://msdn.microsoft.com/en-us/library/System.Exception.InnerException), if any, that threw the current exception.|


---
## Method HttpException.#ctor(OpenNETCF.Web.HttpErrorCode,System.String,System.Exception)

 Creates an instance of the [Type HttpException](#type-httpexception) type 


| Name | Description |
|-----|------|
|httpCode: ||
|message: ||
|innerException: ||


---
## Method HttpException.#ctor(System.String,System.Int32)

 Creates an instance of the [Type HttpException](#type-httpexception) type 


| Name | Description |
|-----|------|
|message: ||
|hr: ||


---
## Method HttpException.#ctor(OpenNETCF.Web.HttpErrorCode,System.String,System.Int32)

 Creates an instance of the [Type HttpException](#type-httpexception) type 


| Name | Description |
|-----|------|
|httpCode: ||
|message: ||
|hr: ||


---
## Method HttpException.GetHttpCode



**Returns**: 



---
## Method HttpRequestValidationException.#ctor(System.String)

 Creates a new HttpRequestValidationException exception with the specified error message. 


| Name | Description |
|-----|------|
|message: |A string that describes the error.|


---
## Method HttpRequestValidationException.#ctor(System.String,System.Exception)

 Initializes a new instance of the HttpRequestValidationException class with a specified error message and a reference to the inner exception that is the cause of the exception. 


| Name | Description |
|-----|------|
|message: |An error message that explains the reason for the exception.|
|innerException: |The exception that is the cause of the current exception. If this parameter is not null, the current exception is raised in a catch block that handles the inner exception.|


---
## Property Configuration.CachingProfile.Duration

 Specifies the time that the page or user control is cached . The default is 00:00:30. 



---
## Property Configuration.CachingProfile.Extension

 Specifies the file name extension for the files you want to cache. 



---
## Property Configuration.CachingProfile.Location

 Specifies the valid values for controlling the location of the output-cached HTTP response for a resource. 



> This will default to **Client**



---
## Type Configuration.CachingConfig

 Caching configuration for the server 



---
## Property Configuration.CachingConfig.Profiles

 The currently set caching profiles for the server 



---
## Type UI.WebControls.WebControl

 Serves as the base class that defines the methods, properties and events common to all controls in the OpenNETCF.Web.UI.WebControls namespace. 



---
## Type UI.Control

 Defines the properties, methods, and events that are shared by all Padarn server controls. 



---
## Method UI.Control.#ctor

 Initializes a new instance of the [Type UI.Control](#type-uicontrol) class. 



---
## Method UI.Control.OnInit(System.EventArgs)

 Raises the Init event. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Control.OnLoad(System.EventArgs)

 Raises the Load event. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Control.Render(OpenNETCF.Web.UI.HtmlTextWriter)

 Sends server control content to a provided HtmlTextWriter object, which writes the content to be rendered on the client. 


| Name | Description |
|-----|------|
|writer: ||


---
## Event UI.Control.Load

 Occurs when the server control is loaded into the [Property UI.Control.Page](#property-uicontrolpage) object. 



---
## Event UI.Control.Init

 Occurs when the server control is initialized, which is the first step in its lifecycle. 



---
## Property UI.Control.ID

 Gets or sets the programmatic identifier assigned to the server control. 



---
## Property UI.Control.Visible

 Gets or sets a value that indicates whether a server control is rendered as UI on the page. 



---
## Property UI.Control.Page

 Gets a reference to the Page instance that contains the server control. 



---
## Property UI.Control.Controls

 Gets a ControlCollection object that represents the child controls for a specified server control in the UI hierarchy. 



---
## Method UI.WebControls.WebControl.#ctor

 Initializes a new instance of the WebControl class that represents a Span HTML tag. 



---
## Method UI.WebControls.WebControl.#ctor(System.String)

 Initializes a new instance of the WebControl class using the specified HTML tag. 


| Name | Description |
|-----|------|
|tag: ||


---
## Method UI.WebControls.WebControl.#ctor(OpenNETCF.Web.UI.HtmlTextWriterTag)

 Initializes a new instance of the WebControl class using the specified HTML tag. 


| Name | Description |
|-----|------|
|tag: ||


---
## Property UI.WebControls.WebControl.TagName

 Gets the name of the control tag. This property is used primarily by control developers. 



---
## Type UI.WebControls.TextBox

 Displays a text box control for user input. 



---
## Method UI.WebControls.TextBox.OnTextChanged(System.EventArgs)

 Raises the TextChanged event. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.WebControls.TextBox.Render(System.Xml.XmlWriter)

 Sends server control content to a provided HtmlTextWriter object, which writes the content to be rendered on the client. 


| Name | Description |
|-----|------|
|writer: ||


---
## Event UI.WebControls.TextBox.TextChanged

 Occurs when the content of the text box changes between posts to the server. 



---
## Property UI.WebControls.TextBox.Text

 Gets or sets the text caption displayed in the TextBox control. 



---
## Property UI.WebControls.TextBox.TextMode

 Gets or sets the behavior mode (single-line, multiline, or password) of the TextBox control. 



---
## Type Resources

 A strongly-typed resource class, for looking up localized strings, etc. 



---
## Property Resources.ResourceManager

 Returns the cached ResourceManager instance used by this class. 



---
## Property Resources.Culture

 Overrides the current thread&#39;s CurrentUICulture property for all resource lookups using this strongly typed resource class. 



---
## Property Resources.BinFolderName

 Looks up a localized string similar to bin. 



---
## Property Resources.CannotRedirectToNewLine

 Looks up a localized string similar to Cannot redirect to new line. 



---
## Property Resources.CodeBehindNotFoundDesc

 Looks up a localized string similar to Although the page seems to be valid, the server was unable to find its associated code-behind assembly. &lt;ul style=&quot;list-style: square;&quot;&gt; &lt;li style=&quot;padding-bottom: 5px;&quot;&gt;Check that the file mentioned in the exception exists on the device.&lt;/li&gt; &lt;li style=&quot;padding-bottom: 5px; line-height: 1.4;&quot;&gt;Is the name of the assembly the same as the name specified in the ASP.NET page? They must be the same.&lt;/li&gt; &lt;/ul&gt;. 



---
## Property Resources.CodeBehindNotFoundTitle

 Looks up a localized string similar to Code-behind assembly, or one of its references, could not be found.. 



---
## Property Resources.ContextualErrorTemplate

 Looks up a localized string similar to &lt;html style=&quot;background-color: #f0f0f0; font-family: Helvetica; color: #000; font-size: 10.5pt; line-height: 1.4;&quot;&gt; &lt;head&gt; &lt;title&gt;Server Error: {0}&lt;/title&gt; &lt;/head&gt; &lt;body&gt; &lt;center&gt; &lt;div style=&quot;text-align: left; margin-top: 50px; margin-bottom: 0px; border: 1px solid #e3e3e3; width: 600px; background: #fff; margin-left: auto; margin-right: auto; padding-left: 10px; padding-right: 40px; padding-top: 30px; padding-bottom: 20px;&quot;&gt; &lt;div style=&quot;float: left; margin-left: 40px; width: 540px [rest of string was truncated]&quot;;. 



---
## Property Resources.Dangerous_input_detected

 Looks up a localized string similar to A potentially dangerous {0} value was detected from the client ({1}).. 



---
## Property Resources.DiskError

 Looks up a localized string similar to Disk Error. 



---
## Property Resources.DiskErrorDesc

 Looks up a localized string similar to A Disk/Drive Error has been occurred. Check to ensure the Padarn Server is not out of disk space for temporary and log files.. 



---
## Property Resources.DiskErrorTitle

 Looks up a localized string similar to A Disk/Drive Error has occurred. 



---
## Property Resources.ErrorPage

 Looks up a localized string similar to &lt;html style=&quot;background-color: #f0f0f0; font-family: Helvetica; color: #000; font-size: 11pt;&quot;&gt; &lt;head&gt; &lt;title&gt;Server Error: Unhandled exception in &#39;{0}&#39;&lt;/title&gt; &lt;/head&gt; &lt;body&gt; &lt;center&gt; &lt;div style=&quot;text-align: left; margin-top: 50px; margin-bottom: 0px; border: 1px solid #e3e3e3; width: 600px; background: #fff; margin-left: auto; margin-right: auto; padding-left: 10px; padding-right: 40px; padding-top: 40px; padding-bottom: 20px;&quot;&gt; &lt;div style=&quot;float: left; margin-left: 40px; width: [rest of string was truncated]&quot;;. 



---
## Property Resources.FileNotFoundDesc

 Looks up a localized string similar to The page or file is missing and cannot be served. &lt;ul style=&quot;list-style: square;&quot;&gt; &lt;li style=&quot;padding-bottom: 5px;&quot;&gt;Check that the file mentioned in the exception exists on the device.&lt;/li&gt; &lt;li style=&quot;padding-bottom: 5px;&quot;&gt;Check that the URL for the file is correct.&lt;/li&gt; &lt;/ul&gt;. 



---
## Property Resources.FileNotFoundErrorPage

 Looks up a localized string similar to &lt;html style=&quot;background-color: #f0f0f0; font-family: Helvetica; color: #000; font-size: 10.5pt; line-height: 1.4;&quot;&gt; &lt;head&gt; &lt;title&gt;Server Error: Code-behind assembly not found.&lt;/title&gt; &lt;/head&gt; &lt;body&gt; &lt;center&gt; &lt;div style=&quot;text-align: left; margin-top: 50px; margin-bottom: 0px; border: 1px solid #e3e3e3; width: 600px; background: #fff; margin-left: auto; margin-right: auto; padding-left: 10px; padding-right: 40px; padding-top: 30px; padding-bottom: 20px;&quot;&gt; &lt;div style=&quot;float: left; mar [rest of string was truncated]&quot;;. 



---
## Property Resources.FileNotFoundTitle

 Looks up a localized string similar to The page or file cannot be found.. 



---
## Property Resources.HeaderAcceptRanges

 Looks up a localized string similar to Accept-Ranges. 



---
## Property Resources.HeaderAcceptRangesBytes

 Looks up a localized string similar to bytes. 



---
## Property Resources.HeaderContentLength

 Looks up a localized string similar to Content-Length. 



---
## Property Resources.HeaderContentType

 Looks up a localized string similar to Content-Type. 



---
## Property Resources.HeaderFormat

 Looks up a localized string similar to {0}: {1}\r\n. 



---
## Property Resources.HeaderLocation

 Looks up a localized string similar to Location. 



---
## Property Resources.HttpAccessDenied

 Looks up a localized string similar to Access is denied.. 



---
## Property Resources.HttpAccessForbidden

 Looks up a localized string similar to Access is forbidden.. 



---
## Property Resources.HttpContinue

 Looks up a localized string similar to HTTP/1.1 100 Continue\r\n. 



---
## Property Resources.HttpEnumeratorDenied

 Looks up a localized string similar to The file enumerator has been denied access.. 



---
## Property Resources.HttpEnumeratorError

 Looks up a localized string similar to An error occurred attempting to enumerate the files.. 



---
## Property Resources.HttpErrorParsingHeader

 Looks up a localized string similar to Error parsing request headers. 



---
## Property Resources.HttpFileHidden

 Looks up a localized string similar to The file you are trying to access is hidden.. 



---
## Property Resources.HttpFileNotFound

 Looks up a localized string similar to The file you are trying to access cannot be found.. 



---
## Property Resources.HttpOK

 Looks up a localized string similar to HTTP/1.1 200 OK\r\n. 



---
## Property Resources.HttpStatusBadRequest

 Looks up a localized string similar to HTTP/1.1 400 Bad Request\r\n. 



---
## Property Resources.HttpStatusConflict

 Looks up a localized string similar to HTTP/1.1 409 Conflict\r\n. 



---
## Property Resources.HttpStatusExpectationFailed

 Looks up a localized string similar to HTTP/1.1 417 ExpectationFailed\r\n. 



---
## Property Resources.HttpStatusFileNotFound

 Looks up a localized string similar to HTTP/1.1 404 Not Found\r\n. 



---
## Property Resources.HttpStatusForbidden

 Looks up a localized string similar to HTTP/1.1 403 Forbidden\r\n. 



---
## Property Resources.HttpStatusGeneric

 Looks up a localized string similar to HTTP/1.1 {0} Http Status\r\n. 



---
## Property Resources.HttpStatusGone

 Looks up a localized string similar to HTTP/1.1 410 Gone\r\n. 



---
## Property Resources.HttpStatusInternalServerError

 Looks up a localized string similar to HTTP/1.1 500 Internal Server Error\r\n. 



---
## Property Resources.HttpStatusLengthRequired

 Looks up a localized string similar to HTTP/1.1 411 Length Required\r\n. 



---
## Property Resources.HttpStatusNotAcceptable

 Looks up a localized string similar to HTTP/1.1 406 Not Acceptable\r\n. 



---
## Property Resources.HttpStatusNotAllowed

 Looks up a localized string similar to HTTP/1.1 405 Method Not Allowed\r\n. 



---
## Property Resources.HttpStatusPaymentRequired

 Looks up a localized string similar to HTTP/1.1 402 Payment Required\r\n. 



---
## Property Resources.HttpStatusPreconditionFailed

 Looks up a localized string similar to HTTP/1.1 412 Precondition Failed\r\n. 



---
## Property Resources.HttpStatusProxyAuthRequired

 Looks up a localized string similar to HTTP/1.1 407 Proxy Authentication Required\r\n. 



---
## Property Resources.HttpStatusRequestedRangeNotSatisfiable

 Looks up a localized string similar to HTTP/1.1 416 Requested Range Not Satisfiable\r\n. 



---
## Property Resources.HttpStatusRequestEntityTooLarge

 Looks up a localized string similar to HTTP/1.1 413 Request Entity Too Large\r\n. 



---
## Property Resources.HttpStatusRequestTimeout

 Looks up a localized string similar to HTTP/1.1 408 RequestTimeout\r\n. 



---
## Property Resources.HttpStatusRequestURITooLong

 Looks up a localized string similar to HTTP/1.1 414 Request URI Too Long\r\n. 



---
## Property Resources.HttpStatusUnauthorized

 Looks up a localized string similar to HTTP/1.1 401 Unauthorized\r\n. 



---
## Property Resources.HttpStatusUnsupportedMediaType

 Looks up a localized string similar to HTTP/1.1 415 Unsupported Media Type\r\n. 



---
## Property Resources.Invalid_string_from_browser_caps

 Looks up a localized string similar to The HttpBrowserCapabilities string &#39;{1}&#39; evaluated to &#39;{2}&#39;. {0} Check the browserCaps section of machine.config or web.config to correct the error.. 



---
## Property Resources.Invalid_urlencoded_form_data

 Looks up a localized string similar to The URL-encoded form data is not valid.. 



---
## Property Resources.InvalidHeaderEncoding

 Looks up a localized string similar to Invalid header encoding {0}.. 



---
## Property Resources.machine_config

 Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt; &lt;configuration&gt; &lt;configSections&gt; &lt;section name=&quot;appSettings&quot; type=&quot;OpenNETCF.Configuration.NameValueFileSectionHandler, OpenNETCF.Configuration&quot; allowLocation=&quot;false&quot; /&gt; &lt;section name=&quot;opennetcf.diagnostics&quot; type=&quot;OpenNETCF.Diagnostics.DiagnosticsConfigurationHandler, OpenNETCF&quot;/&gt; &lt;/configSections&gt; &lt;/configuration&gt;. 



---
## Property Resources.Max_request_length_exceeded

 Looks up a localized string similar to Maximum request length exceeded. 



---
## Property Resources.MaxRequestLengthErrorDesc

 Looks up a localized string similar to The file being uploaded exceeds the maximum length allowed by the server configuration.. 



---
## Property Resources.MaxRequestLengthErrorTitle

 Looks up a localized string similar to Upload exceeds server setting. 



---
## Property Resources.NoHttpHandler

 Looks up a localized string similar to No HTTP handler for this file type. 



---
## Property Resources.OutOfDiskSpaceError

 Looks up a localized string similar to Out of disk space. 



---
## Property Resources.OutOfMemoryErrorDesc

 Looks up a localized string similar to The HTTP request has resulted in an out of memory exception. Please ensure the requestLengthDiskThreshold configuration setting does not exceed the amount of available memory.. 



---
## Property Resources.OutOfMemoryErrorTitle

 Looks up a localized string similar to The server has no available memory. 



---
## Property Resources.OutOfMemoryException

 Looks up a localized string similar to Out of memory. 



---
## Property Resources.PageLoadEventName

 Looks up a localized string similar to Page_Load. 



---
## Property Resources.TypeLoadDesc

 Looks up a localized string similar to The code-behind class for this page is either missing from the assembly or is invalid. &lt;ul style=&quot;list-style: square;&quot;&gt; &lt;li style=&quot;padding-bottom: 5px;&quot;&gt;Check that the code-behind class derives from &lt;b&gt;OpenNETCF.Web.UI.Page&lt;/b&gt;.&lt;/li&gt; &lt;li style=&quot;padding-bottom: 5px;&quot;&gt;Is the name of the code-behind class the same as the name specified in the ASP.NET page? They must be the same.&lt;/li&gt; &lt;li style=&quot;padding-bottom: 5px;&quot;&gt;Check the scope of the code-behind class and make sure it is [rest of string was truncated]&quot;;. 



---
## Property Resources.TypeLoadTitle

 Looks up a localized string similar to Missing or invalid page class. 



---
## Property Resources.UnauthorizedDesc

 Looks up a localized string similar to You do not have permission to view this directory or page using the credentials you supplied.. 



---
## Property Resources.UnauthorizedTitle

 Looks up a localized string similar to Logon failed due to server configuration. 



---
## Property Resources.UnhandledExceptionDesc

 Looks up a localized string similar to There was an unhandled exception in &#39;{0}&#39;. Please review the exception and stack trace below. . 



---
## Property Resources.UnsupportedMethod

 Looks up a localized string similar to Unsupported method in query: {0}. 



---
## Property Resources.UnuthorizedMessage

 Looks up a localized string similar to You are not authorized to view this page. 



---
## Property Resources.VirtualDir_AttributeNotFound

 Looks up a localized string similar to {0} attribute not found in the VirtualDirectory node in {1}.. 



---
## Type OpenNETCF.Reflection.Assembly2

 Contains helper functions for the [Type System.Reflection.Assembly](https://msdn.microsoft.com/en-us/library/System.Reflection.Assembly) class. 

##### See also: [Type System.Reflection.Assembly](https://msdn.microsoft.com/en-us/library/System.Reflection.Assembly)


---
## Method OpenNETCF.Reflection.Assembly2.GetEntryAssembly

 Gets the process executable. 

**Returns**: The [Type System.Reflection.Assembly](https://msdn.microsoft.com/en-us/library/System.Reflection.Assembly) that is the process executable.



---
## Type IHttpModule





---
## Method IHttpModule.Dispose





---
## Method IHttpModule.Init(OpenNETCF.Web.HttpContext)





---
## Type HttpCachePolicy

 Contains methods for setting cache-specific HTTP headers and for controlling the ASP.NET page output cache. 



---
## Method HttpCachePolicy.SetNoStore

 Sets the **Cache-Control: no-store** directive. 



---
## Method HttpCachePolicy.SetCacheability(OpenNETCF.Web.HttpCacheability)

 Sets the Cache-Control HTTP header. The Cache-Control HTTP header controls how documents are to be cached on the network. 


| Name | Description |
|-----|------|
|cacheability: |The HttpCacheability enumeration value to set the header to.|


---
## Method HttpCachePolicy.SetCacheability(OpenNETCF.Web.HttpCacheability,System.String)

 Sets the Cache-Control HTTP header. The Cache-Control HTTP header controls how documents are to be cached on the network. 


| Name | Description |
|-----|------|
|cacheability: |The HttpCacheability enumeration value to set the header to.|
|field: |The cache control extension to add to the header.|


---
## Method HttpCachePolicy.SetNoTransforms

 Sets the **Cache-Control: no-transform** HTTP header. 



>  The Cache-Control: no-transform HTTP header instructs network caching applications not to modify the document. The Cache-Control: no-transform HTTP header prevents downstream proxy servers from changing any header values specified by the Content-Encoding, Content-Range, or Content-Type headers (this includes the entity body). For example, it prevents proxies from converting GIF images to PNG. As with other restrictions on caching, once SetNoTransforms is called, the Cache-Control: no-transform HTTP header cannot be disabled through the HttpCachePolicy interface. 



---
## Method HttpCachePolicy.SetMaxAge(System.TimeSpan)

 Sets the **Cache-Control: max-age HTTP header** based on the specified time span. 


| Name | Description |
|-----|------|
|delta: |The time span used to set the **Cache-Control: max-age** header.|


---
## Type Hosting.VirtualFile

 Represents a file object in a virtual file or resource space. 



---
## Type Hosting.VirtualFileBase

 Provides the core implementation for the VirtualFile and VirtualDirectory objects. An abstract class, it cannot be instantiated. 



---
## Method Hosting.VirtualFileBase.#ctor

 Initializes the class for use by an inherited class instance. This constructor can be called only by an inherited class. 



---
## Property Hosting.VirtualFileBase.IsDirectory

 When overridden in a derived class, gets a value indicating whether the VirtualFileBase instance represents a virtual file or a virtual directory. 



---
## Property Hosting.VirtualFileBase.Name

 Gets the display name of the virtual resource. 



---
## Property Hosting.VirtualFileBase.VirtualPath

 Gets the virtual file path. 



---
## Method Hosting.VirtualFile.#ctor(System.String)

 Initializes a new instance of the VirtualFile class. 



---
## Method Hosting.VirtualFile.Open

 When overridden in a derived class, returns a read-only stream to the virtual resource. 

**Returns**: A read-only stream to the virtual file.



> The Open method returns a stream containing the data treated as a file by the VirtualPathProvider class. The stream is read-only, and can be seekable.



---
## Property Hosting.VirtualFile.IsDirectory

 Gets a value that indicates that this is a virtual resource that should be treated as a file. 

**Value**: Always **false**.



---
## Type UI.HtmlTextWriterTag

 Specifies the HTML tags that can be passed to an HtmlTextWriter object output stream. 



---
## Field UI.HtmlTextWriterTag.Unknown

 The string passed as an HTML tag is not recognized. 



---
## Field UI.HtmlTextWriterTag.A

 The HTML a element. 



---
## Field UI.HtmlTextWriterTag.Address

 The HTML address element. 



---
## Field UI.HtmlTextWriterTag.Area

 The HTML area element. 



---
## Field UI.HtmlTextWriterTag.Blockquote

 The HTML blockquote element. 



---
## Field UI.HtmlTextWriterTag.Body

 The HTML body element. 



---
## Field UI.HtmlTextWriterTag.Br

 The HTML br element. 



---
## Field UI.HtmlTextWriterTag.Button

 The HTML button element. 



---
## Field UI.HtmlTextWriterTag.Caption

 The HTML caption element. 



---
## Field UI.HtmlTextWriterTag.Code

 The HTML code element. 



---
## Field UI.HtmlTextWriterTag.Col

 The HTML col element. 



---
## Field UI.HtmlTextWriterTag.Colgroup

 The HTML colgroup element. 



---
## Field UI.HtmlTextWriterTag.Div

 The HTML div element. 



---
## Field UI.HtmlTextWriterTag.Fieldset

 The HTML fieldset element. 



---
## Field UI.HtmlTextWriterTag.Form

 The HTML form element. 



---
## Field UI.HtmlTextWriterTag.H1

 The HTML H1 element. 



---
## Field UI.HtmlTextWriterTag.H2

 The HTML H2 element. 



---
## Field UI.HtmlTextWriterTag.H3

 The HTML H3 element. 



---
## Field UI.HtmlTextWriterTag.H4

 The HTML H4 element. 



---
## Field UI.HtmlTextWriterTag.H5

 The HTML H5 element. 



---
## Field UI.HtmlTextWriterTag.H6

 The HTML H6 element. 



---
## Field UI.HtmlTextWriterTag.Head

 The HTML head element. 



---
## Field UI.HtmlTextWriterTag.Html

 The HTML html element. 



---
## Field UI.HtmlTextWriterTag.Hr

 The HTML hr element. 



---
## Field UI.HtmlTextWriterTag.I

 The HTML i element. 



---
## Field UI.HtmlTextWriterTag.Iframe

 The HTML iframe element. 



---
## Field UI.HtmlTextWriterTag.Img

 The HTML img element. 



---
## Field UI.HtmlTextWriterTag.Input

 The HTML input element. 



---
## Field UI.HtmlTextWriterTag.Label

 The HTML label element. 



---
## Field UI.HtmlTextWriterTag.Legend

 The HTML legend element. 



---
## Field UI.HtmlTextWriterTag.Li

 The HTML li element. 



---
## Field UI.HtmlTextWriterTag.Link

 The HTML link element. 



---
## Field UI.HtmlTextWriterTag.Meta

 The HTML meta element. 



---
## Field UI.HtmlTextWriterTag.Object

 The HTML object element. 



---
## Field UI.HtmlTextWriterTag.Ol

 The HTML ol element. 



---
## Field UI.HtmlTextWriterTag.Option

 The HTML option element. 



---
## Field UI.HtmlTextWriterTag.P

 The HTML p element. 



---
## Field UI.HtmlTextWriterTag.Param

 The HTML param element. 



---
## Field UI.HtmlTextWriterTag.Pre

 The HTML pre element. 



---
## Field UI.HtmlTextWriterTag.Script

 The HTML script element. 



---
## Field UI.HtmlTextWriterTag.Select

 The HTML select element. 



---
## Field UI.HtmlTextWriterTag.Span

 The HTML span element. 



---
## Field UI.HtmlTextWriterTag.Strike

 The HTML strike element. 



---
## Field UI.HtmlTextWriterTag.Strong

 The HTML strong element. 



---
## Field UI.HtmlTextWriterTag.Style

 The HTML style element. 



---
## Field UI.HtmlTextWriterTag.Table

 The HTML table element. 



---
## Field UI.HtmlTextWriterTag.Tbody

 The HTML tbody element. 



---
## Field UI.HtmlTextWriterTag.Td

 The HTML td element. 



---
## Field UI.HtmlTextWriterTag.Textarea

 The HTML textarea element. 



---
## Field UI.HtmlTextWriterTag.Th

 The HTML th element. 



---
## Field UI.HtmlTextWriterTag.Thead

 The HTML thead element. 



---
## Field UI.HtmlTextWriterTag.Title

 The HTML title element. 



---
## Field UI.HtmlTextWriterTag.Tr

 The HTML tr element. 



---
## Field UI.HtmlTextWriterTag.Ul

 The HTML ul element. 



---
## Type HttpCookie

 Provides a type-safe way to create and manipulate individual HTTP cookies. 



---
## Method HttpCookie.#ctor(System.String)

 Creates and names a new cookie. 


| Name | Description |
|-----|------|
|name: ||


---
## Method HttpCookie.#ctor(System.String,System.String)

 Creates, names, and assigns a value to a new cookie. 


| Name | Description |
|-----|------|
|name: ||
|value: ||


---
## Property HttpCookie.Domain

 Gets or sets the domain to associate the cookie with. 



---
## Property HttpCookie.Expires

 Gets or sets the expiration date and time for the cookie. 



---
## Property HttpCookie.HasKeys

 Gets a value indicating whether a cookie has subkeys. 



---
## Property HttpCookie.HttpOnly

 Gets or sets a value that specifies whether a cookie is accessible by client-side script. 



---
## Property HttpCookie.Name

 Gets or sets the name of a cookie. 



---
## Property HttpCookie.Path

 Gets or sets the virtual path to transmit with the current cookie. 



---
## Property HttpCookie.Secure

 Gets or sets a value indicating whether to transmit the cookie using Secure Sockets Layer (SSL)--that is, over HTTPS only. 



---
## Property HttpCookie.Value

 Gets or sets an individual cookie value. 



---
## Property HttpCookie.Values

 Gets a collection of key/value pairs that are contained within a single cookie object. 



---
## Type Hosting.VirtualDirectory

 Represents a directory object in a virtual file or resource space. 



---
## Method Hosting.VirtualDirectory.#ctor(System.String)

 Initializes a new instance of the VirtualDirectory class. 



---
## Property Hosting.VirtualDirectory.IsDirectory

 Gets a value that indicates that this is a virtual resource that should be treated as a directory. 

**Value**: Always **true**.



---
## Property Hosting.VirtualDirectory.Files

 Gets a list of all files contained in this directory. 

**Value**: An object implementing the IEnumerable interface containing VirtualFile objects.



> The Files property contains VirtualFile objects that represent the files contained in this virtual directory. To return the VirtualDirectory objects, use the Directories property. To return both VirtualFile and VirtualDirectory objects, use the Children property.



---
## Property Hosting.VirtualDirectory.Directories

 Gets a list of all the subdirectories contained in this directory. 



---
## Property Hosting.VirtualDirectory.Children

 Gets a list of the files and subdirectories contained in this virtual directory. 



---
## Type UI.TemplateParser

 Serves as the abstract base class for Padarn file parsers. 



---
## Type Security.FormsAuthentication

 Manages forms-authentication services for Web applications. This class cannot be inherited. 



---
## Method Security.FormsAuthentication.GetRedirectUrl(System.String,System.Boolean)

 Returns the redirect URL for the original request that caused the redirect to the login page. 


| Name | Description |
|-----|------|
|userName: |The name of the authenticated user.|
|createPersistentCookie: |This parameter is ignored.|
**Returns**: A string that contains the redirect URL.



---
## Method Security.FormsAuthentication.RedirectFromLoginPage(System.String,System.Boolean)

 Redirects an authenticated user back to the originally requested URL or the default URL. 


| Name | Description |
|-----|------|
|userName: |The authenticated user name.|
|createPersistentCookie: |**true** to create a durable cookie (one that is saved across browser sessions); otherwise, **false**.|


---
## Method Security.FormsAuthentication.RedirectToLoginPage

 Redirects the browser to the login URL. 



---
## Method Security.FormsAuthentication.SignOut

 Removes the forms-authentication ticket from the browser. 



---
## Property Security.FormsAuthentication.Timeout

 Gets the amount of time before an authentication ticket expires. 



---
## Property Security.FormsAuthentication.SlidingExpiration

 Gets a value indicating whether sliding expiration is enabled. 



---
## Property Security.FormsAuthentication.RequireSSL

 Gets a value indicating whether the forms-authentication cookie requires SSL in order to be returned to the server. 



---
## Property Security.FormsAuthentication.FormsCookiePath

 Gets the path for the forms-authentication cookie. 

**Value**: The path of the cookie where the forms-authentication ticket information is stored. The default is &quot;/&quot;.



---
## Property Security.FormsAuthentication.DefaultUrl

 Gets the URL that the FormsAuthentication class will redirect to if no redirect URL is specified. 



---
## Property Security.FormsAuthentication.CookieDomain

 Gets the value of the domain of the forms-authentication cookie. 



---
## Property Security.FormsAuthentication.CookieMode

 Gets a value that indicates whether the application is configured for cookieless forms authentication. 



---
## Property Security.FormsAuthentication.EnableCrossAppRedirects

 Gets a value indicating whether authenticated users can be redirected to URLs in other Web applications. 



---
## Property Security.FormsAuthentication.CookiesSupported

 Gets a value that indicates whether the application is configured to support cookieless forms authentication. 



---
## Property Security.FormsAuthentication.IsEnabled

 Gets the Padarn server&#39;s enabled state for Forms Authentication. 



>  To Enable Forms Authentication, set the authentication type in the app.config file 



---
## Property Security.FormsAuthentication.LoginUrl

 Gets the URL for the login page that the FormsAuthentication class will redirect to. 



---
## Property Security.FormsAuthentication.FormsCookieName

 Gets the name of the cookie used to store the forms-authentication ticket. 

**Value**: The name of the cookie used to store the forms-authentication ticket. The default is &quot;.ASPXAUTH&quot;.



---
## Method Security.Authentication.#ctor(System.String)




| Name | Description |
|-----|------|
|authenticationMethod: ||


---
## Property Security.Authentication.AuthenticationMethod





---
## Type OpenNETCF.Configuration.ConfigXmlDocument





---
## Method OpenNETCF.Configuration.ConfigXmlDocument.Load(System.String)




| Name | Description |
|-----|------|
|filename: ||


---
## Method OpenNETCF.Configuration.ConfigXmlDocument.ReadConfigNode(System.String,System.Xml.XmlTextReader)




| Name | Description |
|-----|------|
|filename: ||
|sourceReader: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.LoadSingleElement(System.String,System.Xml.XmlTextReader)




| Name | Description |
|-----|------|
|filename: ||
|sourceReader: ||


---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateAttribute(System.String,System.String,System.String)




| Name | Description |
|-----|------|
|prefix: ||
|localName: ||
|namespaceUri: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateElement(System.String,System.String,System.String)




| Name | Description |
|-----|------|
|prefix: ||
|localName: ||
|namespaceUri: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateTextNode(System.String)




| Name | Description |
|-----|------|
|text: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateCDataSection(System.String)




| Name | Description |
|-----|------|
|data: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateComment(System.String)




| Name | Description |
|-----|------|
|data: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateSignificantWhitespace(System.String)




| Name | Description |
|-----|------|
|data: ||
**Returns**: 



---
## Method OpenNETCF.Configuration.ConfigXmlDocument.CreateWhitespace(System.String)




| Name | Description |
|-----|------|
|data: ||
**Returns**: 



---
## Property OpenNETCF.Configuration.ConfigXmlDocument.Filename





---
## Property OpenNETCF.Configuration.ConfigXmlDocument.LineNumber





---
## Type HttpRequestBase

 Serves as the base class for classes that enable ASP.NET to read the HTTP values sent by a client during a Web request. 



>  The HttpRequestBase class is an abstract class that contains the same members as the HttpRequest class. The HttpRequestBase class enables you to create derived classes that are like the HttpRequest class, but that you can customize and that work outside the ASP.NET pipeline. When you perform unit testing, you typically use a derived class to implement members that have customized behavior that fulfills the scenario that you are testing. The HttpRequestWrapper class derives from the HttpRequestBase class. The HttpRequestWrapper class serves as a wrapper for the HttpRequest class. At run time, you typically use an instance of the HttpRequestWrapper class to invoke members of the HttpRequest object. 



---
## Property HttpRequestBase.Headers

 When overridden in a derived class, gets the collection of HTTP headers that were sent by the client. 



---
## Property HttpRequestBase.QueryString

 When overridden in a derived class, gets the collection of HTTP query-string variables. 



---
## Property HttpRequestBase.HttpMethod

 When overridden in a derived class, gets the HTTP data-transfer method (such as GET, POST, or HEAD) that was used by the client. 



---
## Property HttpRequestBase.Form

 When overridden in a derived class, gets the collection of form variables that were sent by the client. 



---
## Property HttpRequestBase.Path

 When overridden in a derived class, gets the virtual path of the current request. 



---
## Property HttpRequestBase.ApplicationPath

 When overridden in a derived class, gets the virtual root path of the Padarn application on the server 



---
## Property HttpRequestBase.ServerVariables

 When overridden in a derived class, gets a collection of Web server variables. 



---
## Property HttpRequestBase.RawUrl

 When overridden in a derived class, gets the complete URL of the current request. 



---
## Type HttpContext

 Encapsulates all HTTP-specific information about an individual HTTP request. 



---
## Property HttpContext.Current

 Gets the [Type HttpContext](#type-httpcontext) object for the current HTTP request. 

**Returns**: The [Type HttpContext](#type-httpcontext) for the current request.



---
## Property HttpContext.Request

 Gets the [Type HttpRequest](#type-httprequest) object for the current HTTP request. 



---
## Property HttpContext.Response

 Gets the [Type HttpResponse](#type-httpresponse) object for the current HTTP response. 



---
## Property HttpContext.Session

 Gets the HttpSessionState object for the current HTTP request. 



---
## Property HttpContext.User

 Gets or sets security information for the current HTTP request. 



---
## Type UI.WebControls.Button

 Displays a push button control on the Web page. 



---
## Type UI.IPostBackEventHandler

 Defines the method Padarn server controls must implement to handle postback events. 



---
## Method UI.IPostBackEventHandler.RaisePostBackEvent(System.String)

 When implemented by a class, enables a server control to process an event raised when a form is posted to the server. 


| Name | Description |
|-----|------|
|eventArgument: |A String that represents an optional event argument to be passed to the event handler.|


---
## Method UI.WebControls.Button.OnClick(System.EventArgs)

 Raises the Click event of the Button control. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.WebControls.Button.RaisePostBackEvent(System.String)

 Raises events for the Button control when it posts back to the server. 


| Name | Description |
|-----|------|
|eventArgument: ||


---
## Event UI.WebControls.Button.Click

 Occurs when the Button control is clicked. 



---
## Property UI.WebControls.Button.Text

 Gets or sets the text caption displayed in the Button control. 



---
## Type UI.TemplateControl

 Provides the [Type UI.Page](#type-uipage) class and the [Type UI.UserControl](#type-uiusercontrol) class with a base set of functionality. 



---
## Type Server.WebServer

 The Web Server. 



---
## Method Server.WebServer.#ctor(OpenNETCF.Web.Configuration.ServerConfig)

 Creates an instance of the WebServer type. 


| Name | Description |
|-----|------|
|config: |The configuration to use in place of that provided in the app.config file|


---
## Method Server.WebServer.#ctor

 Creates an instance of the WebServer type. 



---
## Method Server.WebServer.Start

 Listens for incoming requests on a separate thread. 



---
## Method Server.WebServer.Stop

 Stops listening for incoming requests. 



---
## Property Server.WebServer.PhysicalPath

 Returns the physical path of the Web Application folder. 



> Obsolete as of version 1.1.70. Throws an error as of version 1.1.90



---
## Property Server.WebServer.Configuration

 Gets the current server configuration information 



---
## Property Server.WebServer.Running

 Returns **true** if the server is currently running, otherwise **false**. 



---
## Property Server.WebServer.IsLicensed

 Returns **true** if this binary is licensed, otherwise returns **false**. 



---
## Method Server.HttpRequestListener.#ctor(System.Net.IPAddress,System.Int32,System.Int32,OpenNETCF.Web.Logging.ILogProvider)

 Create an instance of the listener on the specified port. 


| Name | Description |
|-----|------|
|port: |The port to listen on for incoming requests.|
|maxConnections: |The maximum number of clients that can concurrently connect to listener.|
|localIP: ||


---
## Method Server.HttpRequestListener.StartListening

 Listen for incoming HTTP requests 



---
## Type Routing.RouteValueDictionary

 Represents a case-insensitive collection of key/value pairs that you use in various places in the routing framework, such as when you define the default values for a route or when you generate a URL that is based on a route. 



---
## Method Routing.RouteValueDictionary.#ctor

 Initializes a new instance of the RouteValueDictionary class that is empty. 



---
## Method Routing.RouteValueDictionary.#ctor(System.Object)

 Initializes a new instance of the RouteValueDictionary class and adds values that are based on properties from the specified object. 


| Name | Description |
|-----|------|
|values: ||


---
## Type Routing.RouteData

 Encapsulates information about a route. 



---
## Method Routing.RouteData.#ctor

 Initializes a new instance of the RouteData class. 



---
## Method Routing.RouteData.GetRequiredString(System.String)

 Retrieves the value with the specified identifier. 


| Name | Description |
|-----|------|
|valueName: ||
**Returns**: 



---
## Property Routing.RouteData.Values

 Gets a collection of URL parameter values and default values for the route. 



---
## Property Routing.RouteData.DataTokens

 Gets a collection of custom values that are passed to the route handler but are not used when ASP.NET routing determines whether the route matches a request. 



---
## Property Routing.RouteData.Route

 Gets or sets the object that represents a route. 



---
## Type OpenNETCF.Configuration.IgnoreSectionHandler

 Provides a section handler definition for configuration sections read and handled by systems other than OpenNETCF.Configuration. 



---
## Method OpenNETCF.Configuration.IgnoreSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)




| Name | Description |
|-----|------|
|parent: ||
|configContext: ||
|section: ||
**Returns**: 



---
## Type HttpBrowserCapabilities

 Enables the server to gather information on the capabilities of the browser that is running on the client. 



---
## Type HttpCapabilitiesBase

 Provides access to detailed information about the capabilities of the client&#39;s browser. 



---
## Method HttpCapabilitiesBase.#ctor(System.Collections.Specialized.NameValueCollection)

 Creates a new instance of the HttpCapabilitiesBase class. 


| Name | Description |
|-----|------|
|headers: ||


---
## Method HttpCapabilitiesBase.AddBrowser(System.String)

 Used internally to add an entry to the internal collection of browsers for which capabilities are recognized. 


| Name | Description |
|-----|------|
|browserName: |The name of the browser to add.|


---
## Method HttpCapabilitiesBase.GetClrVersions

 Gets the version of the .NET Framework that is installed on the client. 

**Returns**: The common language runtime Version.



---
## Method HttpCapabilitiesBase.IsBrowser(System.String)

 Gets a value indicating whether the client browser is the same as the specified browser. 


| Name | Description |
|-----|------|
|browserName: |The specified browser.|
**Returns**: true if the client browser is the same as the specified browser; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Item(System.String)

 Gets the value of the specified browser capability. In C#, this property is the indexer for the class. 


| Name | Description |
|-----|------|
|key: |The name of the browser capability to retrieve.|
**Returns**: The browser capability with the specified key name.



---
## Property HttpCapabilitiesBase.Capabilities

 Used internally to get the defined capabilities of the browser. 

**Returns**: The defined capabilities of the browser



---
## Property HttpCapabilitiesBase.ActiveXControls

Gets a value indicating whether the browser supports ActiveX controls.

**Returns**: true if the browser supports ActiveX controls; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.AOL

Gets a value indicating whether the client is an America Online (AOL) browser.

**Returns**: true if the browser is an AOL browser; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.BackgroundSounds

Gets a value indicating whether the browser supports playing background sounds using the &lt;bgsounds&gt; HTML element.

**Returns**: true if the browser supports playing background sounds; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Beta

Gets a value indicating whether the browser is a beta version.

**Returns**: true if the browser is a beta version; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Browser

Gets the browser string (if any) that was sent by the browser in the User-Agent request header.

**Returns**: The contents of the User-Agent request header sent by the browser.



---
## Property HttpCapabilitiesBase.Browsers

Gets an [Type System.Collections.ArrayList](https://msdn.microsoft.com/en-us/library/System.Collections.ArrayList) of the browsers in the [Property System.Web.Configuration.HttpCapabilitiesBase.Capabilities](https://msdn.microsoft.com/en-us/library/System.Web.Configuration.HttpCapabilitiesBase.Capabilities) dictionary.

**Returns**: An [Type System.Collections.ArrayList](https://msdn.microsoft.com/en-us/library/System.Collections.ArrayList) of the browsers in the [Property System.Web.Configuration.HttpCapabilitiesBase.Capabilities](https://msdn.microsoft.com/en-us/library/System.Web.Configuration.HttpCapabilitiesBase.Capabilities) dictionary.



---
## Property HttpCapabilitiesBase.CanCombineFormsInDeck

Gets a value indicating whether the browser supports decks that contain multiple forms, such as separate cards.

**Returns**: true if the browser supports decks that contain multiple forms; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanInitiateVoiceCall

Gets a value indicating whether the browser device is capable of initiating a voice call.

**Returns**: true if the browser device is capable of initiating a voice call; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.CanRenderAfterInputOrSelectElement

Gets a value indicating whether the browser supports page content following WML &lt;select&gt; or &lt;input&gt; elements.

**Returns**: true if the browser supports page content following HTML &lt;select&gt; or &lt;input&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanRenderEmptySelects

Gets a value indicating whether the browser supports empty HTML &lt;select&gt; elements.

**Returns**: true if the browser supports empty HTML &lt;select&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanRenderInputAndSelectElementsTogether

Gets a value indicating whether the browser supports WML INPUT and SELECT elements together on the same card.

**Returns**: true if the browser supports WML &lt;input&gt; and &lt;select&gt; elements together; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.CanRenderMixedSelects

Gets a value indicating whether the browser supports WML &lt;option&gt; elements that specify both onpick and value attributes.

**Returns**: true if the browser supports WML &lt;option&gt; elements that specify both onpick and value attributes; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanRenderOneventAndPrevElementsTogether

Gets a value indicating whether the browser supports WML &lt;onevent&gt; and &lt;prev&gt; elements that coexist within the same WML card.

**Returns**: true if the browser supports WML &lt;onevent&gt; and &lt;prev&gt; elements that coexist within the same WML card; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanRenderPostBackCards

Gets a value indicating whether the browser supports WML cards for postback.

**Returns**: true if the browser supports WML cards for postback; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanRenderSetvarZeroWithMultiSelectionList

Gets a value indicating whether the browser supports WML &lt;setvar&gt; elements with a value attribute of 0.

**Returns**: true if the browser supports WML &lt;setvar&gt; elements with a value attribute of 0; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CanSendMail

Gets a value indicating whether the browser supports sending e-mail by using the HTML &lt;mailto&gt; element for displaying electronic addresses.

**Returns**: true if the browser supports sending e-mail by using the HTML &lt;mailto&gt; element for displaying electronic addresses; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.CDF

Gets a value indicating whether the browser supports Channel Definition Format (CDF) for webcasting.

**Returns**: true if the browser supports CDF; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.ClrVersion

Gets the version of the .NET Framework that is installed on the client.

**Returns**: The common language runtime [Type System.Version](https://msdn.microsoft.com/en-us/library/System.Version).



---
## Property HttpCapabilitiesBase.Cookies

Gets a value indicating whether the browser supports cookies.

**Returns**: true if the browser supports cookies; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Crawler

Gets a value indicating whether the browser is a search engine Web crawler.

**Returns**: true if the browser is a search engine; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.DefaultSubmitButtonLimit

Returns the maximum number of Submit buttons that are allowed for a form.

**Returns**: The maximum number of Submit buttons that are allowed for a form.



---
## Property HttpCapabilitiesBase.EcmaScriptVersion

Gets the version number of ECMAScript that the browser supports.

**Returns**: The version number of ECMAScript that the browser supports.



---
## Property HttpCapabilitiesBase.Frames

Gets a value indicating whether the browser supports HTML frames.

**Returns**: true if the browser supports frames; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.GatewayMajorVersion

Gets the major version number of the wireless gateway used to access the server, if known. 

**Returns**: The major version number of the wireless gateway used to access the server, if known. The default is 0.

[[T:System.Web.HttpUnhandledException|T:System.Web.HttpUnhandledException]]: The major version number of the wireless gateway cannot be parsed.



---
## Property HttpCapabilitiesBase.GatewayMinorVersion

Gets the minor version number of the wireless gateway used to access the server, if known. 

**Returns**: The minor version number of the wireless gateway used to access the server, if known. The default is 0.

[[T:System.Web.HttpUnhandledException|T:System.Web.HttpUnhandledException]]: The minor version number of the wireless gateway cannot be parsed.



---
## Property HttpCapabilitiesBase.GatewayVersion

Gets the version of the wireless gateway used to access the server, if known.

**Returns**: The version number of the wireless gateway used to access the server, if known. The default is None.



---
## Property HttpCapabilitiesBase.HasBackButton

Gets a value indicating whether the browser has a dedicated Back button.

**Returns**: true if the browser has a dedicated Back button; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.HidesRightAlignedMultiselectScrollbars

Gets a value indicating whether the scrollbar of an HTML &lt;select multiple&gt; element with an align attribute value of right is obscured upon rendering.

**Returns**: true if the scrollbar of an HTML &lt;select multiple&gt; element with an align attribute value of right is obscured upon rendering; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.HtmlTextWriter

Gets or sets the fully qualified class name of the [Type System.Web.UI.HtmlTextWriter](https://msdn.microsoft.com/en-us/library/System.Web.UI.HtmlTextWriter) to use.

**Returns**: The fully qualified class name of the [Type System.Web.UI.HtmlTextWriter](https://msdn.microsoft.com/en-us/library/System.Web.UI.HtmlTextWriter) to use.



---
## Property HttpCapabilitiesBase.Id

Gets the internal identifier of the browser as specified in the browser definition file.

**Returns**: Internal identifier of the browser as specified in the browser definition file.



---
## Property HttpCapabilitiesBase.InputType

Returns the type of input supported by browser.

**Returns**: The type of input supported by browser. The default is telephoneKeypad.



---
## Property HttpCapabilitiesBase.IsColor

Gets a value indicating whether the browser has a color display.

**Returns**: true if the browser has a color display; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.IsMobileDevice

Gets a value indicating whether the browser is a recognized mobile device.

**Returns**: true if the browser is a recognized mobile device; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.JavaApplets

Gets a value indicating whether the browser supports Java.

**Returns**: true if the browser supports Java; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.JavaScript

Gets a value indicating whether the browser supports JavaScript.

**Returns**: true if the browser supports JavaScript; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.JScriptVersion

Gets the Jscript version that the browser supports.

**Returns**: The [Type System.Version](https://msdn.microsoft.com/en-us/library/System.Version) of Jscript that the browser supports.



---
## Property HttpCapabilitiesBase.MajorVersion

Gets the major (integer) version number of the browser.

**Returns**: The major version number of the browser.

[[T:System.Web.HttpUnhandledException|T:System.Web.HttpUnhandledException]]: The header value is not valid.



---
## Property HttpCapabilitiesBase.MaximumHrefLength

Gets the maximum length in characters for the href attribute of an HTML &lt;a&gt; (anchor) element.

**Returns**: The maximum length in characters for the href attribute of an HTML &lt;a&gt; (anchor) element.



---
## Property HttpCapabilitiesBase.MaximumRenderedPageSize

Gets the maximum length of the page, in bytes, which the browser can display. 

**Returns**: The maximum length of the page, in bytes, which the browser can display. The default is 2000.



---
## Property HttpCapabilitiesBase.MaximumSoftkeyLabelLength

Returns the maximum length of the text that a soft-key label can display.

**Returns**: The maximum length of the text that a soft-key label can display. The default is 5.



---
## Property HttpCapabilitiesBase.MinorVersion

Gets the minor (that is, decimal) version number of the browser.

**Returns**: The minor version number of the browser.

[[T:System.Web.HttpUnhandledException|T:System.Web.HttpUnhandledException]]: The header value is not valid.



---
## Property HttpCapabilitiesBase.MinorVersionString

Gets the minor (decimal) version number of the browser as a string.

**Returns**: The minor version number of the browser.



---
## Property HttpCapabilitiesBase.MobileDeviceManufacturer

Returns the name of the manufacturer of a mobile device, if known.

**Returns**: The name of the manufacturer of a mobile device, if known. The default is Unknown.



---
## Property HttpCapabilitiesBase.MobileDeviceModel

Gets the model name of a mobile device, if known.

**Returns**: The model name of a mobile device, if known. The default is Unknown.



---
## Property HttpCapabilitiesBase.MSDomVersion

Gets the version of Microsoft HTML (MSHTML) Document Object Model (DOM) that the browser supports.

**Returns**: The number of the MSHTML DOM version that the browser supports.



---
## Property HttpCapabilitiesBase.NumberOfSoftkeys

Returns the number of soft keys on a mobile device.

**Returns**: The number of soft keys supported on a mobile device. The default is 0.



---
## Property HttpCapabilitiesBase.Platform

Gets the name of the platform that the client uses, if it is known.

**Returns**: The operating system that the client uses, if it is known, otherwise the value is set to Unknown.



---
## Property HttpCapabilitiesBase.PreferredImageMime

Returns the MIME type of the type of image content typically preferred by the browser.

**Returns**: The MIME type of the type of image content typically preferred by the browser. The default is image/gif.



---
## Property HttpCapabilitiesBase.PreferredRenderingMime

Returns the MIME type of the type of content typically preferred by the browser.

**Returns**: The MIME type of the type of content typically preferred by the browser. The default is text/html.



---
## Property HttpCapabilitiesBase.PreferredRenderingType

Gets the general name for the type of content that the browser prefers.

**Returns**: html32 or chtml10. The default is html32.



---
## Property HttpCapabilitiesBase.PreferredRequestEncoding

Gets the request encoding preferred by the browser.

**Returns**: The request encoding preferred by the browser.



---
## Property HttpCapabilitiesBase.PreferredResponseEncoding

Gets the response encoding preferred by the browser.

**Returns**: The response encoding preferred by the browser.



---
## Property HttpCapabilitiesBase.RendersBreakBeforeWmlSelectAndInput

Gets a value indicating whether the browser renders a line break before &lt;select&gt; or &lt;input&gt; elements.

**Returns**: true if the browser renders a line break before &lt;select&gt; or &lt;input&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RendersBreaksAfterHtmlLists

Gets a value indicating whether the browser renders a line break after list-item elements.

**Returns**: true if the browser renders a line break after list-item elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.RendersBreaksAfterWmlAnchor

Gets a value indicating whether the browser renders a line break after a stand-alone HTML &lt;a&gt; (anchor) element.

**Returns**: true if the browser renders a line break after a stand-alone HTML &lt;a&gt; (anchor) element; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RendersBreaksAfterWmlInput

Gets a value indicating whether the browser renders a line break after an HTML &lt;input&gt; element.

**Returns**: true if the browser renders a line break after an HTML &lt;input&gt; element; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RendersWmlDoAcceptsInline

Gets a value indicating whether the mobile-device browser renders a WML do-based form accept construct as an inline button rather than as a soft key.

**Returns**: true if the mobile-device browser renders a WML do-based form-accept construct as an inline button; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.RendersWmlSelectsAsMenuCards

Gets a value indicating whether the browser renders WML &lt;select&gt; elements as menu cards, rather than as a combo box.

**Returns**: true if the browser renders WML &lt;select&gt; elements as menu cards; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiredMetaTagNameValue

Used internally to produce a meta-tag required by some browsers.

**Returns**: A meta-tag required by some browsers.



---
## Property HttpCapabilitiesBase.RequiresAttributeColonSubstitution

Gets a value indicating whether the browser requires colons in element attribute values to be substituted with a different character.

**Returns**: true if the browser requires colons in element attribute values to be substituted with a different character; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresContentTypeMetaTag

Gets a value indicating whether the browser requires an HTML &lt;meta&gt; element for which the content-type attribute is specified.

**Returns**: true if the browser requires an HTML &lt;meta&gt; element for which the content-type attribute is specified; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresControlStateInSession

Gets a value indicating whether the browser requires control state to be maintained in sessions.

**Returns**: true if the browser requires control state to be maintained in sessions; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresDBCSCharacter

Gets a value indicating whether the browser requires a double-byte character set.

**Returns**: true if the browser requires a double-byte character set; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresHtmlAdaptiveErrorReporting

Gets a value indicating whether the browser requires nonstandard error messages.

**Returns**: true if the browser requires nonstandard error messages; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresLeadingPageBreak

Gets a value indicating whether the browser requires the first element in the body of a Web page to be an HTML &lt;br&gt; element.

**Returns**: true if the browser requires the first element in the body of a Web page to be an HTML BR element; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresNoBreakInFormatting

Gets a value indicating whether the browser does not support HTML &lt;br&gt; elements to format line breaks.

**Returns**: true if the browser does not support HTML &lt;br&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresOutputOptimization

Gets a value indicating whether the browser requires pages to contain a size-optimized form of markup language tags.

**Returns**: true if the browser requires pages to contain a size-optimized form of markup language tags; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresPhoneNumbersAsPlainText

Gets a value indicating whether the browser supports phone dialing based on plain text, or whether it requires special markup.

**Returns**: true if the browser supports phone dialing based on plain text only; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresSpecialViewStateEncoding

Gets a value indicating whether the browser requires VIEWSTATE values to be specially encoded.

**Returns**: true if the browser requires VIEWSTATE values to be specially encoded; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresUniqueFilePathSuffix

Gets a value indicating whether the browser requires unique form-action URLs.

**Returns**: true if the browser requires unique form-action URLs; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresUniqueHtmlCheckboxNames

Gets a value indicating whether the browser requires unique name attribute values of multiple HTML &lt;input type=&quot;checkbox&quot;&gt; elements.

**Returns**: true if the browser requires unique name attribute values of multiple HTML &lt;input type=&quot;checkbox&quot;&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresUniqueHtmlInputNames

Gets a value indicating whether the browser requires unique name attribute values of multiple HTML &lt;input&gt; elements.

**Returns**: true if the browser requires unique name attribute values of multiple HTML &lt;input&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.RequiresUrlEncodedPostfieldValues

Gets a value indicating whether postback data sent by the browser will be UrlEncoded.

**Returns**: true if postback data sent by the browser will be UrlEncoded; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.ScreenBitDepth

Returns the depth of the display, in bits per pixel.

**Returns**: The depth of the display, in bits per pixel. The default is 1.



---
## Property HttpCapabilitiesBase.ScreenCharactersHeight

Returns the approximate height of the display, in character lines.

**Returns**: The approximate height of the display, in character lines. The default is 6.



---
## Property HttpCapabilitiesBase.ScreenCharactersWidth

Returns the approximate width of the display, in characters.

**Returns**: The approximate width of the display, in characters. The default is 12.



---
## Property HttpCapabilitiesBase.ScreenPixelsHeight

Returns the approximate height of the display, in pixels.

**Returns**: The approximate height of the display, in pixels. The default is 72.



---
## Property HttpCapabilitiesBase.ScreenPixelsWidth

Returns the approximate width of the display, in pixels.

**Returns**: The approximate width of the display, in pixels. The default is 96.



---
## Property HttpCapabilitiesBase.SupportsAccesskeyAttribute

Gets a value indicating whether the browser supports the ACCESSKEY attribute of HTML &lt;a&gt; (anchor) and &lt;input&gt; elements.

**Returns**: true if the browser supports the accesskey attribute of HTML &lt;a&gt; (anchor) and &lt;input&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsBodyColor

Gets a value indicating whether the browser supports the bgcolor attribute of the HTML &lt;body&gt; element.

**Returns**: true if the browser supports the bgcolor attribute of the HTML &lt;body&gt; element; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsBold

Gets a value indicating whether the browser supports HTML &lt;b&gt; elements to format bold text.

**Returns**: true if the browser supports HTML &lt;b&gt; elements to format bold text; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsCacheControlMetaTag

Gets a value indicating whether the browser supports the cache-control value for the http-equiv attribute of HTML &lt;meta&gt; elements.

**Returns**: true if the browser supports the cache-control value for the http-equiv attribute of HTML &lt;meta&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsCallback

Gets a value indicating whether the browser supports callback scripts.

**Returns**: true if the browser supports callback scripts; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsCss

Gets a value indicating whether the browser supports Cascading Style Sheets (CSS).

**Returns**: true if the browser supports CSS; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsDivAlign

Gets a value indicating whether the browser supports the align attribute of HTML &lt;div&gt; elements.

**Returns**: true if the browser supports the align attribute of HTML &lt;div&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsDivNoWrap

Gets a value indicating whether the browser supports the nowrap attribute of HTML &lt;div&gt; elements.

**Returns**: true if the browser supports the nowrap attribute of HTML &lt;div&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsEmptyStringInCookieValue

Gets a value indicating whether the browser supports empty (null) strings in cookie values.

**Returns**: true if the browser supports empty (null) strings in cookie values; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsFontColor

Gets a value indicating whether the browser supports the color attribute of HTML &lt;font&gt; elements.

**Returns**: true if the browser supports the color attribute of HTML &lt;font&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsFontName

Gets a value indicating whether the browser supports the name attribute of HTML &lt;font&gt; elements.

**Returns**: true if the browser supports the name attribute of HTML &lt;font&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsFontSize

Gets a value indicating whether the browser supports the size attribute of HTML &lt;font&gt; elements.

**Returns**: true if the browser supports the size attribute of HTML &lt;font&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsImageSubmit

Gets a value indicating whether the browser supports using a custom image in place of a standard form Submit button.

**Returns**: true if the browser supports using a custom image in place of a standard form Submit button; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsIModeSymbols

Gets a value indicating whether the browser supports i-mode symbols.

**Returns**: true if the browser supports i-mode symbols; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsInputIStyle

Gets a value indicating whether the browser supports the istyle attribute of HTML &lt;input&gt; elements.

**Returns**: true if the browser supports the istyle attribute of HTML &lt;input&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsInputMode

Gets a value indicating whether the browser supports the mode attribute of HTML &lt;input&gt; elements.

**Returns**: true if the browser supports the mode attribute of HTML &lt;input&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsItalic

Gets a value indicating whether the browser supports HTML &lt;i&gt; elements to format italic text.

**Returns**: true if the browser supports HTML &lt;i&gt; elements to format italic text; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsJPhoneMultiMediaAttributes

Gets a value indicating whether the browser supports J-Phone multimedia attributes.

**Returns**: true if the browser supports J-Phone multimedia attributes; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsJPhoneSymbols

Gets a value indicating whether the browser supports J-Phone–specific picture symbols.

**Returns**: true if the browser supports J-Phone–specific picture symbols; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.SupportsQueryStringInFormAction

Gets a value indicating whether the browser supports a query string in the action attribute value of HTML &lt;form&gt; elements.

**Returns**: true if the browser supports a query string in the action attribute value of HTML &lt;form&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsRedirectWithCookie

Gets a value indicating whether the browser supports cookies on redirection.

**Returns**: true if the browser supports cookies on redirection; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsSelectMultiple

Gets a value indicating whether the browser supports the multiple attribute of HTML &lt;select&gt; elements.

**Returns**: true if the browser supports the multiple attribute of HTML &lt;select&gt; elements; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsUncheck

Gets a value indicating whether the clearing of a checked HTML &lt;input type=checkbox&gt; element is reflected in postback data.

**Returns**: true if the clearing of a checked HTML &lt;input type=checkbox&gt; element is reflected in postback data; otherwise, false. The default is true.



---
## Property HttpCapabilitiesBase.SupportsXmlHttp

Gets a value indicating whether the browser supports receiving XML over HTTP.

**Returns**: true if the browser supports receiving XML over HTTP; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Tables

Gets a value indicating whether the browser supports HTML &lt;table&gt; elements.

**Returns**: true if the browser supports HTML &lt;table&gt; elements; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Type

Gets the name and major (integer) version number of the browser.

**Returns**: The name and major version number of the browser.



---
## Property HttpCapabilitiesBase.VBScript

Gets a value indicating whether the browser supports Visual Basic Scripting edition (VBScript).

**Returns**: true if the browser supports VBScript; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Version

Gets the full version number (integer and decimal) of the browser as a string.

**Returns**: The full version number of the browser as a string.



---
## Property HttpCapabilitiesBase.W3CDomVersion

Gets the version of the World Wide Web Consortium (W3C) XML Document Object Model (DOM) that the browser supports.

**Returns**: The number of the W3C XML DOM version number that the browser supports.



---
## Property HttpCapabilitiesBase.Win16

Gets a value indicating whether the client is a Win16-based computer.

**Returns**: true if the browser is running on a Win16-based computer; otherwise, false. The default is false.



---
## Property HttpCapabilitiesBase.Win32

Gets a value indicating whether the client is a Win32-based computer.

**Returns**: true if the client is a Win32-based computer; otherwise, false. The default is false.



---
## Type DefaultHttpHandler

 The default handler for HTTP requests 



---
## Type IHttpHandler

 Defines the contract that ASP.NET implements to synchronously process HTTP Web requests using custom HTTP handlers. 



---
## Method IHttpHandler.ProcessRequest(OpenNETCF.Web.HttpContext)

 Enables processing of HTTP Web requests by a custom HttpHandler that implements the [Type IHttpHandler](#type-ihttphandler) interface. 


| Name | Description |
|-----|------|
|context: |An [Type HttpContext](#type-httpcontext) object that provides references to the intrinsic server objects (for example, Request, Response, Session, and Server) used to service HTTP requests.|


---
## Property IHttpHandler.IsReusable

 Gets a value indicating whether another request can use the IHttpHandler instance. 



---
## Method DefaultHttpHandler.ProcessRequest(OpenNETCF.Web.HttpContext)

 Process the HTTP request 


| Name | Description |
|-----|------|
|context: |The current context of the request|


---
## Type UI.WebControls.TextBoxMode

 Specifies the behavior mode of the text box. 



---
## Field UI.WebControls.TextBoxMode.SingleLine

 Represents single-line entry mode. 



---
## Field UI.WebControls.TextBoxMode.MultiLine

 Represents multiline entry mode. 



---
## Field UI.WebControls.TextBoxMode.Password

 Represents password entry mode. 



---
## Type UI.WebControls.Label

 Represents a label control, which displays text on a Web page. 



---
## Type UI.ITextControl

 Defines the interface a control implements to get or set its text content. 



---
## Property UI.ITextControl.Text

 Gets or sets the text content of a control. 



---
## Property UI.WebControls.Label.Text

 Gets or sets the text caption displayed in the Label control. 



---
## Type StaticFileHandler

 Provides access to specific file types. 



---
## Method StaticFileHandler.#ctor(System.String,System.String)




| Name | Description |
|-----|------|
|filePath: ||
|mimeType: ||


---
## Method StaticFileHandler.ProcessRequest(OpenNETCF.Web.HttpContext)

 Processes the incoming HTTP request 


| Name | Description |
|-----|------|
|context: |The HttpContext for the request|


---
## Type PageHandler

 Padarn Page Handler 



---
## Method PageHandler.#ctor(System.String,System.String)

 Creates an instance of the Padarn page handler 


| Name | Description |
|-----|------|
|filePath: ||
|mimeType: ||


---
## Method PageHandler.ProcessRequest(OpenNETCF.Web.HttpContext)

 Parses the Padarn Page and creates the HTTP response 


| Name | Description |
|-----|------|
|context: ||


---
## Property PageHandler.IsReusable

 Gets a value indicating whether another request can use the HttpHandler instance. 



---
## Type UI.Page

 Represents an .aspx file, also known as a Web Forms page, requested from a server that hosts a Padarn Web application. 



---
## Method UI.Page.#ctor

 Initializes a new instance of the [Type UI.Page](#type-uipage) class. 



---
## Method UI.Page.RaisePostBackEvent(OpenNETCF.Web.UI.IPostBackEventHandler,System.String)

 Notifies the server control that caused the postback that it should handle an incoming post back event. 


| Name | Description |
|-----|------|
|sourceControl: ||
|eventArgument: ||


---
## Method UI.Page.OnPreLoad(System.EventArgs)

 Raises the PreLoad event after postback data is loaded into the page server controls but before the OnLoad event. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Page.OnLoadComplete(System.EventArgs)

 Raises the LoadComplete event at the end of the page load stage. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Page.OnPreInit(System.EventArgs)

 Raises the PreInit event at the beginning of page initialization. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Page.OnInitComplete(System.EventArgs)

 Raises the InitComplete event after page initialization. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Page.OnPreRender(System.EventArgs)

 Raises the PreRender event. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Page.OnPreRenderComplete(System.EventArgs)

 Raises the PreRenderComplete event after the OnPreRenderComplete event and before the page is rendered. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.Page.Render(OpenNETCF.Web.UI.HtmlTextWriter)

 Initializes the HtmlTextWriter object and calls on the child controls of the Page to render. 


| Name | Description |
|-----|------|
|writer: ||


---
## Event UI.Page.PreInit

 Occurs at the beginning of page initialization. 



---
## Event UI.Page.InitComplete

 Occurs when page initialization is complete. 



---
## Event UI.Page.PreLoad

 Occurs before the page Load event. 



---
## Event UI.Page.LoadComplete

 Occurs at the end of the load stage of the page&#39;s life cycle. 



---
## Event UI.Page.PreRender

 Occurs after the Control object is loaded but prior to rendering. 



---
## Event UI.Page.PreRenderComplete

 Occurs before the page content is rendered. 



---
## Property UI.Page.Request

 Gets the [Type HttpRequest](#type-httprequest) object for the requested page. 

**Returns**: The current [Type HttpRequest](#type-httprequest) associated with the page.

[[T:OpenNETCF.Web.HttpException|T:OpenNETCF.Web.HttpException]]: Occurs when the [Type HttpRequest](#type-httprequest) object is not available.



---
## Property UI.Page.Response

 Gets the [Type HttpResponse](#type-httpresponse) object associated with the [Type UI.Page](#type-uipage) object. This object allows you to send HTTP response data to a client and contains information about that response. 

**Returns**: The current [Type HttpResponse](#type-httpresponse) associated with the page

[[T:OpenNETCF.Web.HttpException|T:OpenNETCF.Web.HttpException]]: The [Type HttpResponse](#type-httpresponse) object is not available. 



---
## Property UI.Page.Session

 Gets the current Session object provided by Padarn. 



---
## Property UI.Page.IsPostBack

 Gets a value that indicates whether the page is being rendered for the first time or is being loaded in response to a postback. 



---
## Property UI.Page.IsReusable

 Gets or sets a value indicating whether this instance is reusable. 

**Value**:  `true`  if this instance is reusable; otherwise,  `false` .



---
## Type SessionState.ISessionIDManager

 Defines the contract that a custom session-state identifier manager must implement. 



---
## Method SessionState.ISessionIDManager.Initialize

 Initializes the SessionIDManager object with information from configuration files. 



---
## Method SessionState.ISessionIDManager.InitializeRequest(OpenNETCF.Web.HttpContext,System.Boolean,System.Boolean@)

 Performs per-request initialization of the SessionIDManager object. 


| Name | Description |
|-----|------|
|context: ||
|suppressAutoDetectRedirect: ||
|supportSessionIDReissue: ||
**Returns**: 



---
## Method SessionState.ISessionIDManager.GetSessionID(OpenNETCF.Web.HttpContext)

 Gets the session-identifier value from the current Web request. 


| Name | Description |
|-----|------|
|context: ||
**Returns**: 



---
## Method SessionState.ISessionIDManager.CreateSessionID(OpenNETCF.Web.HttpContext)

 Creates a unique session identifier for the session. 


| Name | Description |
|-----|------|
|context: ||
**Returns**: 



---
## Method SessionState.ISessionIDManager.RemoveSessionID(OpenNETCF.Web.HttpContext)

 Deletes the session-identifier cookie from the HTTP response. 


| Name | Description |
|-----|------|
|context: ||


---
## Method SessionState.ISessionIDManager.SaveSessionID(OpenNETCF.Web.HttpContext,System.String,System.Boolean@,System.Boolean@)

 Saves a newly created session identifier to the HTTP response. 


| Name | Description |
|-----|------|
|context: ||
|id: ||
|redirected: ||
|cookieAdded: ||


---
## Method SessionState.ISessionIDManager.Validate(System.String)

 Gets a value indicating whether a session identifier is valid. 


| Name | Description |
|-----|------|
|id: ||
**Returns**: 



---
## Type OpenNETCF.Security.Principal.GenericPrincipal

 Represents a generic principal. 



---
## Type OpenNETCF.Security.Principal.IPrincipal

 Defines the basic functionality of a principal object. 



---
## Method OpenNETCF.Security.Principal.IPrincipal.IsInRole(System.String)

 Determines whether the current principal belongs to the specified role. 


| Name | Description |
|-----|------|
|role: ||
**Returns**: 



---
## Property OpenNETCF.Security.Principal.IPrincipal.Identity

 Gets the identity of the current principal. 



---
## Method OpenNETCF.Security.Principal.GenericPrincipal.#ctor(OpenNETCF.Security.Principal.IIdentity,System.String[])

 Initializes a new instance of the GenericPrincipal class from a user identity and an array of role names to which the user represented by that identity belongs. 


| Name | Description |
|-----|------|
|identity: ||
|roles: ||


---
## Method OpenNETCF.Security.Principal.GenericPrincipal.#ctor(OpenNETCF.Security.Principal.IIdentity)

 Initializes a new instance of the GenericPrincipal class from a user identity and an array of role names to which the user represented by that identity belongs. 


| Name | Description |
|-----|------|
|identity: ||


---
## Method OpenNETCF.Security.Principal.GenericPrincipal.IsInRole(System.String)

 Determines whether the current GenericPrincipal belongs to the specified role. 


| Name | Description |
|-----|------|
|role: ||
**Returns**: 



---
## Property OpenNETCF.Security.Principal.GenericPrincipal.Identity

 Gets the GenericIdentity of the user represented by the current GenericPrincipal. 



---
## Type HttpMethod

 Http methods 



---
## Field HttpRawRequestContent.m_startofLine

 The offset in which to start reading the line data 



---
## Type HttpErrorCode





---
## Field HttpErrorCode.BadRequest

 The request could not be understood by the server due to malformed syntax. 



---
## Field HttpErrorCode.Unauthorized

 The request requires user authentication. 



---
## Field HttpErrorCode.PaymentRequired

 This code is reserved for future use. 



---
## Field HttpErrorCode.Forbidden

 The server understood the request, but is refusing to fulfill it. Authorization will not help and the request SHOULD NOT be repeated. 



---
## Field HttpErrorCode.NotFound

 The server has not found anything matching the Request-URI. No indication is given of whether the condition is temporary or permanent. 



---
## Field HttpErrorCode.MethodNotAllowed

 The method specified in the Request-Line is not allowed for the resource identified by the Request-URI. 



---
## Field HttpErrorCode.NotAcceptable

 The resource identified by the request is only capable of generating response entities which have content characteristics not acceptable according to the accept headers sent in the request. 



---
## Field HttpErrorCode.ProxyAuthenticationRequired

 This code is similar to 401 (Unauthorized), but indicates that the client must first authenticate itself with the proxy. 



---
## Field HttpErrorCode.RequestTimeout

 The client did not produce a request within the time that the server was prepared to wait. 



---
## Field HttpErrorCode.Conflict

 The request could not be completed due to a conflict with the current state of the resource. 



---
## Field HttpErrorCode.Gone

 The requested resource is no longer available at the server and no forwarding address is known. This condition is expected to be considered permanent. 



---
## Field HttpErrorCode.LengthRequired

 The server refuses to accept the request without a defined Content- Length. 



---
## Field HttpErrorCode.PreconditionFailed

 The precondition given in one or more of the request-header fields evaluated to false when it was tested on the server. 



---
## Field HttpErrorCode.RequestEntityTooLarge

 The server is refusing to process a request because the request entity is larger than the server is willing or able to process. 



---
## Field HttpErrorCode.RequestURITooLong

 The server is refusing to service the request because the Request-URI is longer than the server is willing to interpret. 



---
## Field HttpErrorCode.UnsupportedMediaType

 The server is refusing to service the request because the entity of the request is in a format not supported by the requested resource for the requested method. 



---
## Field HttpErrorCode.RequestedRangeNotSatisfiable

 server SHOULD return a response with this status code if a request included a Range request-header field (section 14.35), and none of the range-specifier values in this field overlap the current extent of the selected resource, and the request did not include an If-Range request-header field. (For byte-ranges, this means that the first- byte-pos of all of the byte-range-spec values were greater than the current length of the selected resource.) 



---
## Field HttpErrorCode.ExpectationFailed

 The expectation given in an Expect request-header field (see section 14.20) could not be met by this server, or, if the server is a proxy, the server has unambiguous evidence that the request could not be met by the next-hop server. 



---
## Field HttpErrorCode.WebDAVUnprocessableEntity





---
## Field HttpErrorCode.WebDAVLocked





---
## Field HttpErrorCode.WebDAVFailedDependency





---
## Field HttpErrorCode.WebDAVUnorderedCollection





---
## Field HttpErrorCode.WebDAVUpgradeRequired





---
## Field HttpErrorCode.WebDAVRetryWith





---
## Field HttpErrorCode.InternalServerError

 The server encountered an unexpected condition which prevented it from fulfilling the request. 



---
## Field HttpErrorCode.NotImplemented

 The server does not support the functionality required to fulfill the request. 



---
## Field HttpErrorCode.BadGateway

 The server, while acting as a gateway or proxy, received an invalid response from the upstream server it accessed in attempting to fulfill the request. 



---
## Field HttpErrorCode.ServiceUnavailable

 The server is currently unable to handle the request due to a temporary overloading or maintenance of the server. The implication is that this is a temporary condition which will be alleviated after some delay. 



---
## Field HttpErrorCode.GatewayTimeout

 The server, while acting as a gateway or proxy, did not receive a timely response from the upstream server specified by the URI (e.g. HTTP, FTP, LDAP) or some other auxiliary server (e.g. DNS) it needed to access in attempting to complete the request 



---
## Field HttpErrorCode.HTTPVersionNotSupported

 The server does not support, or refuses to support, the HTTP protocol version that was used in the request message. 



---
## Field HttpErrorCode.VariantAlsoNegotiates







---
## Field HttpErrorCode.InsufficientStorage





---
## Field HttpErrorCode.BandwidthLimitExceeded





---
## Type HttpCookieMode

 Specifies how cookies are used for a Web application. 



---
## Field HttpCookieMode.UseUri

 The calling feature uses the query string to store an identifier regardless of whether the browser or device supports cookies. 



---
## Field HttpCookieMode.UseCookies

 Cookies are used to persist user data regardless of whether the browser or device supports cookies. 



---
## Field HttpCookieMode.AutoDetect

 Padarn determines whether the requesting browser or device supports cookies. If the requesting browser or device supports cookies then AutoDetect uses cookies to persist user data; otherwise, an identifier is used in the query string. If the browser or device supports the use of cookies but cookies are currently disabled, cookies are still used by the requesting feature. 



---
## Field HttpCookieMode.UseDeviceProfile

 Padarn determines whether to use cookies based on System.Web.HttpBrowserCapabilities setting. If the setting indicates that the browser or device supports cookies, cookies are used; otherwise, an identifier is used in the query string. 



---
## Type HttpCookieCollection

 Provides a type-safe way to manipulate HTTP cookies. 



---
## Method HttpCookieCollection.#ctor

 Initializes a new instance of the HttpCookieCollection class. 



---
## Method HttpCookieCollection.Add(OpenNETCF.Web.HttpCookie)

 Adds the specified cookie to the cookie collection. 


| Name | Description |
|-----|------|
|cookie: ||


---
## Method HttpCookieCollection.Remove(System.String)

 Removes the cookie with the specified name from the collection. 


| Name | Description |
|-----|------|
|name: ||


---
## Method HttpCookieCollection.Clear

 Clears all cookies from the cookie collection. 



---
## Method HttpCookieCollection.CopyTo(System.Array,System.Int32)

 Copies members of the cookie collection to an Array beginning at the specified index of the array. 


| Name | Description |
|-----|------|
|dest: ||
|index: ||


---
## Method HttpCookieCollection.Get(System.Int32)

 Returns the cookie with the specified index from the cookie collection. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Method HttpCookieCollection.Get(System.String)

 Returns the cookie with the specified name from the cookie collection. 


| Name | Description |
|-----|------|
|name: ||
**Returns**: 



---
## Method HttpCookieCollection.GetKey(System.Int32)

 Returns the key (name) of the cookie at the specified numerical index. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Method HttpCookieCollection.Set(OpenNETCF.Web.HttpCookie)

 Updates the value of an existing cookie in a cookie collection. 


| Name | Description |
|-----|------|
|cookie: ||


---
## Property HttpCookieCollection.AllKeys

 Gets a string array containing all the keys (cookie names) in the cookie collection. 



---
## Property HttpCookieCollection.Item(System.String)

 Gets the cookie with the specified name from the cookie collection. 


| Name | Description |
|-----|------|
|name: ||
**Returns**: 



---
## Property HttpCookieCollection.Item(System.Int32)

 Gets the cookie with the specified index from the cookie collection. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Type HttpContextBase

 Serves as the base class for classes that contain HTTP-specific information about an individual HTTP request. 



---
## Method HttpContextBase.#ctor

 Initializes the class for use by an inherited class instance. This constructor can only be called by an inherited class. 



---
## Method HttpContextBase.GetService(System.Type)

 When overridden in a derived class, returns an object for the current service type. 


| Name | Description |
|-----|------|
|serviceType: ||
**Returns**:  The current service type, or null if no service is found. 



---
## Method HttpContextBase.AddError(System.Exception)

 When overridden in a derived class, adds an exception to the exception collection for the current HTTP request. 


| Name | Description |
|-----|------|
|errorInfo: ||


---
## Method HttpContextBase.ClearError

 When overridden in a derived class, clears all errors for the current HTTP request. 



---
## Property HttpContextBase.AllErrors

 When overridden in a derived class, gets an array of errors (if any) that accumulated when an HTTP request was being processed. 



---
## Property HttpContextBase.Error

 When overridden in a derived class, gets the first error (if any) that accumulated when an HTTP request was being processed. 

**Value**:  The first exception for the current HTTP request/response process, or null if no errors accumulated during the HTTP request processing. 



---
## Property HttpContextBase.Request

 When overridden in a derived class, gets the HttpRequest object for the current HTTP request. 



---
## Property HttpContextBase.Response

 When overridden in a derived class, gets the HttpResponse object for the current HTTP response. 



---
## Type HttpCacheability

 Provides enumerated values that are used to set the Cache-Control HTTP header. 



>  See http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html for more information 



---
## Field HttpCacheability.Private

 Default value. Sets **Cache-Control: private** to specify that the response is cacheable only on the client and not by shared (proxy server) caches. 



---
## Field HttpCacheability.NoCache

 Sets the **Cache-Control: no-cache** header. Without a field name, the directive applies to the entire request and a shared (proxy server) cache must force a successful revalidation with the origin Web server before satisfying the request. With a field name, the directive applies only to the named field; the rest of the response may be supplied from a shared cache. 



---
## Field HttpCacheability.Server

 Specifies that the response is cached only at the origin server. Similar to the NoCache option. Clients receive a **Cache-Control: no-cache** directive but the document is cached on the origin server. Equivalent to ServerAndNoCache. 



> **This is currently unsupported by Padarn**



---
## Field HttpCacheability.ServerAndNoCache

 Applies the settings of both Server and NoCache to indicate that the content is cached at the server but all others are explicitly denied the ability to cache the response. 



> **This is currently unsupported by Padarn**



---
## Field HttpCacheability.Public

 Sets **Cache-Control: public** to specify that the response is cacheable by clients and shared (proxy) caches. 



---
## Field HttpCacheability.ServerAndPrivate

 Indicates that the response is cached at the server and at the client but nowhere else. Proxy servers are not allowed to cache the response. 



> **This is currently unsupported by Padarn**



---
## Type Configuration.VirtualDirectoryMapping

 Mappings for Padarn virtual directories 



---
## Method Configuration.VirtualDirectoryMapping.#ctor(System.String,System.String)

 VirtualDirectoryMapping constructor 


| Name | Description |
|-----|------|
|virtualPath: ||
|phyiscalPath: ||


---
## Property Configuration.VirtualDirectoryMapping.PhysicalDirectory

 Physical directory path 



---
## Property Configuration.VirtualDirectoryMapping.VirtualDirectory

 Virtual directory name 



---
## Property Configuration.VirtualDirectoryMapping.RequiresAuthentication

 True if the virtual directory requires authentication, otherwise false 



---
## Type CodeBehindAssembly

 Helper class for loading a code-behind assembly into the Web Server 



---
## Method CodeBehindAssembly.LoadFrom(System.String)

 Loads a code-behind assembly from the specified path. 


| Name | Description |
|-----|------|
|assemblyPath: |The path to load the assembly from.|
**Returns**: An instance of CodeBehindAssembly



---
## Method CodeBehindAssembly.GetTypesFromBaseType(System.Type)

 Returns an array of Types with a particular base type. 


| Name | Description |
|-----|------|
|baseType: |The base type used to filter the array|
**Returns**: An array of types of type baseType



---
## Method SessionState.ISessionStateItemCollection.Clear

 Removes all values and keys from the session-state collection. 



---
## Method SessionState.ISessionStateItemCollection.Remove(System.String)

 Deletes an item from the collection. 


| Name | Description |
|-----|------|
|name: ||


---
## Method SessionState.ISessionStateItemCollection.RemoveAt(System.Int32)

 Deletes an item at a specified index from the collection. 


| Name | Description |
|-----|------|
|index: ||


---
## Property SessionState.ISessionStateItemCollection.Dirty

 Gets or sets a value indicating whether the collection has been marked as changed. 



---
## Property SessionState.ISessionStateItemCollection.Item(System.String)

 Gets or sets a value in the collection by name. 


| Name | Description |
|-----|------|
|name: ||
**Returns**: 



---
## Property SessionState.ISessionStateItemCollection.Item(System.Int32)

 Gets or sets a value in the collection by numerical index. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Property SessionState.ISessionStateItemCollection.Keys

 Gets a collection of the variable names for all values stored in the collection. 



---
## Type SecureBlackbox.SSLSocket.Server.ElServerSSLSocket

 Summary description for SSLSocketServer. 



---
## Type SecureBlackbox.SSLSocket.ElSSLSocket

 Summary description for SSLSocket. 



---
## Type HttpRuntime

 Provides a set of Padarn run-time services for the current application. 



---
## Method HttpRuntime.ProcessRequest(OpenNETCF.Web.HttpWorkerRequest)

 Drives all Padarn Web processing execution. 


| Name | Description |
|-----|------|
|wr: ||


---
## Type Routing.RouteTable

 Stores the URL routes for an application 



---
## Method Routing.RouteTable.#ctor

 Initializes a new instance of the RouteTable class. 



---
## Property Routing.RouteTable.Routes

 Gets a collection of objects that derive from the RouteBase class. 



---
## Type OpenNETCF.Configuration.NameValueFileSectionHandler





---
## Method OpenNETCF.Configuration.NameValueFileSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)




| Name | Description |
|-----|------|
|parent: ||
|configContext: ||
|section: ||
**Returns**: 



---
## Type OpenNETCF.Configuration.IConfigurationSystem





---
## Method OpenNETCF.Configuration.IConfigurationSystem.GetConfig(System.String,System.Object)

 Returns the config object for the specified key. 


| Name | Description |
|-----|------|
|configKey: |Section name of config object to retrieve. |
|context: |Application provided context object that gets passed into the Create method of the IConfigurationSectionHandler|
**Returns**: 



---
## Method OpenNETCF.Configuration.IConfigurationSystem.Init

 Initializes the configuration system. 



---
## Type OpenNETCF.Configuration.DefaultConfigurationSystem

 Summary description for DefaultConfigurationSystem. 



---
## Type OpenNETCF.Net.NetworkInformation.PhysicalAddress

 Provides the Media Access Control (MAC) address for a network interface (adapter). 



---
## Field OpenNETCF.Net.NetworkInformation.PhysicalAddress.None

 Returns a new System.Net.NetworkInformation.PhysicalAddress instance with a zero length address. This field is read-only. 



---
## Method OpenNETCF.Net.NetworkInformation.PhysicalAddress.#ctor(System.Byte[])

 Initializes a new instance of the System.Net.NetworkInformation.PhysicalAddress class. 


| Name | Description |
|-----|------|
|address: | A System.Byte array containing the address. |


---
## Method OpenNETCF.Net.NetworkInformation.PhysicalAddress.Equals(System.Object)

 Compares two System.Net.NetworkInformation.PhysicalAddress instances. 


| Name | Description |
|-----|------|
|comparand: | The System.Net.NetworkInformation.PhysicalAddress to compare to the current instance. |
**Returns**:  true if this instance and the specified instance contain the same address; otherwise false. 



---
## Method OpenNETCF.Net.NetworkInformation.PhysicalAddress.GetAddressBytes

 Returns the address of the current instance. 

**Returns**: A System.Byte array containing the address.



---
## Method OpenNETCF.Net.NetworkInformation.PhysicalAddress.GetHashCode

 Returns the hash value of a physical address. 

**Returns**: An integer hash value.



---
## Method OpenNETCF.Net.NetworkInformation.PhysicalAddress.ToString

 Returns the System.String representation of the address of this instance. 

**Returns**:  A System.String containing the address contained in this instance. 



---
## Type Logging.DefaultLogProvider

 The default log provider for Padarn. This provider is used for logging if a specialized logging provider is not specified 



---
## Type Logging.ILogProvider

 Interface for Padarn Log Providers 



---
## Method Logging.ILogProvider.LogPageAccess(OpenNETCF.Web.Logging.LogDataItem)

 Called on page access 


| Name | Description |
|-----|------|
|dataItem: ||


---
## Method Logging.ILogProvider.LogPadarnError(System.String,OpenNETCF.Web.Logging.LogDataItem)

 Called on error conditions 


| Name | Description |
|-----|------|
|errorInfo: ||
|dataItem: |Log data for the current error, if it exists|


---
## Method Logging.ILogProvider.LogRuntimeInfo(OpenNETCF.Web.Logging.ZoneFlags,System.String)

 Called during certain runtime operations. Primarily used for debugging Padarn&#39;s internal systems. 


| Name | Description |
|-----|------|
|info: ||


---
## Property Logging.ILogProvider.ServerConfiguration

 The Padarn configuration state at the time the Provider was created 



>  Padarn injects the configuration when the provider is created at startup 



---
## Method Logging.DefaultLogProvider.LogPageAccess(OpenNETCF.Web.Logging.LogDataItem)

 Called whenever padarn get a request to access a page 


| Name | Description |
|-----|------|
|dataItem: |Data related to the access call|


---
## Method Logging.DefaultLogProvider.LogPadarnError(System.String,OpenNETCF.Web.Logging.LogDataItem)

 Called whenever Padarn encounters an internal error 


| Name | Description |
|-----|------|
|errorInfo: |Information about the specific error|


---
## Method Logging.DefaultLogProvider.LogRuntimeInfo(OpenNETCF.Web.Logging.ZoneFlags,System.String)

 Called during certain runtime operations. Primarily used for debugging Padarn&#39;s internal systems. 


| Name | Description |
|-----|------|
|info: ||
|zoneMask: |The zone associated with the incoming information|


---
## Property Logging.DefaultLogProvider.ServerConfiguration

 The Padarn configuration state at the time the Provider was created 



>  Padarn injects the configuration when the provider is created at startup 



---
## Type HttpValidationStatus

 Provides enumerated values that indicate cache validation status. 



---
## Field HttpValidationStatus.IgnoreThisRequest

 Indicates that the request is treated as a cache miss and the page is executed. The cache is not invalidated. 



---
## Field HttpValidationStatus.Invalid

 Indicates that the cache is invalid. The item is evicted from the cache and the request is handled as a cache miss. 



---
## Field HttpValidationStatus.Valid

 Indicates that the cache is valid. 



---
## Type HttpResponseBase

 Serves as the base class for classes that provides HTTP-response information from an ASP.NET operation. 



>  The HttpResponseBase class is an abstract class that contains the same members as the HttpResponse class. The HttpResponseBase class enables you to create derived classes that are like the HttpResponse class, but that you can customize and that work outside the ASP.NET pipeline. When you perform unit testing, you typically use a derived class to implement members that have customized behavior that fulfills the scenario you are testing. The HttpResponseWrapper class derives from the HttpResponseBase class. The HttpResponseWrapper class serves as a wrapper for the HttpResponse class. At run time, you typically use an instance of the HttpResponseWrapper class to call members of the HttpResponse object. 



---
## Method HttpResponseBase.ApplyAppPathModifier(System.String)

 When overridden in a derived class, adds a session ID to the virtual path if the session is using Cookieless session state, and returns the combined path. 


| Name | Description |
|-----|------|
|virtualPath: ||
**Returns**: 



---
## Property HttpResponseBase.Cache

 When overridden in a derived class, gets the caching policy (such as expiration time, privacy settings, and vary clauses) of the current Web page. 

**Value**: The caching policy of the current response.



---
## Method HttpResponseWrapper.Redirect(System.String,System.Boolean)

 Redirects a request to the specified URL and specifies whether execution of the current process should terminate. 


| Name | Description |
|-----|------|
|url: ||
|endResponse: ||


---
## Type Configuration.HttpRuntimeConfig

 Holds configuration information for the HTTP run-time settings that determine how to process a request for an ASP.NET application. 



---
## Method Configuration.HttpRuntimeConfig.GetConfig

 Reads the HttpRuntime configuration settings. 

**Returns**: An instance of HttpRuntimeConfig



---
## Method Configuration.HttpRuntimeConfig.Reload

 Reloads the httpRuntime configuration section from the App.Config 



---
## Property Configuration.HttpRuntimeConfig.MaxRequestLength

 Specifies the limit for the input stream buffering threshold, in KB. This limit can be used to prevent denial of service attacks that are caused, for example, by users posting large files to the server. 



---
## Property Configuration.HttpRuntimeConfig.RequestLengthDiskThreshold

 Specifies the limit for the input stream buffering threshold, in bytes. This value should not exceed the maxRequestLength attribute. 



---
## Type Configuration.HttpRuntimeConfigurationHandler

 Represents the WebServer section in the app.config file 



---
## Method Configuration.HttpRuntimeConfigurationHandler.Create(System.Object,System.Object,System.Xml.XmlNode)

 Creates an instance of ServerConfig from the information in the app.config file 


| Name | Description |
|-----|------|
|parent: ||
|configContext: ||
|section: ||
**Returns**: 



---
## Type Configuration.ServerConfig

 Holds configuration information for the Web Server 



---
## Method Configuration.ServerConfig.GetConfig

 Reads the Server configuration from the application configuration file. 

**Returns**: An instance of ServerConfig



---
## Method Configuration.ServerConfig.Reload

 Forces the server to reload the configuration settings from the Padarn configuration settings XML file 



---
## Property Configuration.ServerConfig.LogProvider

 Optional path to a custom log provider assembly 



---
## Property Configuration.ServerConfig.Port

 The default port to listen on for incoming requests. 



---
## Property Configuration.ServerConfig.DefaultDocuments

 Contains a list of default documents to display when a document is not specified in a request. 



---
## Property Configuration.ServerConfig.LocalIP

 Gets or sets the value of the local IP address to which Padarn will bind. 



>  The Address 0.0.0.0 will be returned if no specific IP address has been configured. In this case the Padarn server will attach to the first valid IP address it finds. This is equivalent to the IIS setting of &quot;Unassigned&quot; 



---
## Property Configuration.ServerConfig.AuthenticationEnabled

 Gets a value indicating if authentication is enabled for the server 



---
## Property Configuration.ServerConfig.Authentication

 Gets the authentication configuration for the server 



---
## Property Configuration.ServerConfig.Session

 Gets the session configuration for the server 



---
## Property Configuration.ServerConfig.SSLLicenseKey

 The SSL LicenseKey for the server when running in secure mode (from SecureBlackBox) 



---
## Property Configuration.ServerConfig.VirtualDirectories





---
## Property Configuration.ServerConfig.Cookies





---
## Property Configuration.ServerConfig.Caching





---
## Property Configuration.ServerConfig.VirtualPathProviders





---
## Property Configuration.ServerConfig.DocumentRoot

 The location of the Web Server pages. 



---
## Property Configuration.ServerConfig.TempRoot

 The location where Padarn will create its internally-generated temp files (such as for file uploads) 



---
## Property Configuration.ServerConfig.MaxConnections

 The maximum number of concurrent connections the Web Server will allow. 



---
## Property Configuration.ServerConfig.LoggingEnabled

 Determines whether server logging is turned on or not 



---
## Property Configuration.ServerConfig.LogFileFolder

 The location in the server&#39;s file system where log files are stored when LoggingEnabled is true. This folder will be created if it doesn&#39;t exist 



---
## Property Configuration.ServerConfig.LogExtensions

 The list of file extensions that access to will be logged 



---
## Property Configuration.ServerConfig.BrowserDefinitions

 Gets the Browser definition file directory. 



---
## Property Configuration.ServerConfig.CertificateName

 Fully qualified path to the SSL certificate file 



---
## Property Configuration.ServerConfig.ServerVersion

 Provides the version of the currently running Padarn server 



---
## Property Configuration.ServerConfig.CertificatePassword

 Password for the SSL certificate file 



---
## Property Configuration.ServerConfig.UseSsl

 Determines if the server instance uses secure sockets for client connections 



---
## Property Configuration.ServerConfig.CustomErrorFolder

 Gets the path for custom HTML error pages 



---
## Type Routing.IRouteHandler

 Defines the contract that a class must implement in order to process a request for a matching route pattern. 



---
## Method Routing.IRouteHandler.GetHttpHandler(OpenNETCF.Web.Routing.RequestContext)

 Provides the object that processes the request. 


| Name | Description |
|-----|------|
|requestContext: |An object that encapsulates information about the request.|
**Returns**: An object that processes the request.



---
## Type HttpRequest

 Enables Padarn to read the HTTP values sent by a client during a Web request. 



---
## Method HttpRequest.Abort

 Forcibly terminates the underlying TCP connection, causing any outstanding I/O to fail. 



---
## Method HttpRequest.#ctor(OpenNETCF.Web.HttpWorkerRequest,OpenNETCF.Web.HttpContext)




| Name | Description |
|-----|------|
|wr: ||
|context: ||


---
## Method HttpRequest.ValidateNameValueCollection(System.Collections.Specialized.NameValueCollection,System.String)

 Validates the name value collection created for POST data 


| Name | Description |
|-----|------|
|nvc: ||
|collectionName: ||


---
## Method HttpRequest.ValidateString(System.String,System.String,System.String)

 Validates a string for any cross site scripting 


| Name | Description |
|-----|------|
|s: ||
|valueName: ||
|collectionName: ||


---
## Property HttpRequest.Browser

 Gets or sets information about the requesting client&#39;s browser capabilities. 



---
## Property HttpRequest.Headers

 Returns the Headers associated with the HttpRequest 



---
## Property HttpRequest.RawQueryString

 Returns the raw web request query string 



---
## Property HttpRequest.LogonUserIdentity

 Gets the WindowsIdentity type for the current user. 



---
## Property HttpRequest.Url

 Gets information about the URL of the current request. 

**Value**:  A Uri object containing information regarding the URL of the current request. 



---
## Property HttpRequest.QueryString

 Gets the collection of HTTP query string variables. 



> A NameValueCollection containing the collection of query string variables sent by the client. For example, If the request URL is http://www.opennetcf.com/default.aspx?id=44 then the value of QueryString is &quot;id=44&quot;.



---
## Property HttpRequest.IsAuthenticated

 Gets a value indicating whether the request has been authenticated. 



---
## Property HttpRequest.IsSecureConnection

 Gets a value indicting whether the HTTP connection uses secure sockets (that is, HTTPS). 



---
## Property HttpRequest.IsLocal

 Gets a value indicating whether the request is from the local computer. 



---
## Property HttpRequest.UserHostAddress

 Gets the IP host address of the remote client. 



---
## Property HttpRequest.ContentEncoding

 Gets or sets the character set of the entity-body. 



---
## Property HttpRequest.ContentType

 Gets or sets the MIME content type of the incoming request. 



> A string representing the MIME content type of the incoming request, for example, &quot;text/html&quot;.



---
## Property HttpRequest.ContentLength

 Specifies the length, in bytes, of content sent by the client. 



---
## Property HttpRequest.AcceptTypes

 Gets a string array of client-supported MIME accept types. 



---
## Property HttpRequest.HttpMethod

 Gets the HTTP data transfer method (such as GET, POST, or HEAD) used by the client. 



---
## Property HttpRequest.RequestType

 Gets the HTTP data transfer method (GET or POST) used by the client. 



---
## Property HttpRequest.Path

 Gets the virtual path of the current request. 



---
## Property HttpRequest.Form





---
## Property HttpRequest.Files

 Gets the collection of files uploaded by the client, in multipart MIME format. 



---
## Property HttpRequest.RawPostContent

 The raw http content uploaded by the browser 



---
## Type UI.UserControl

 Represents an .ascx file, also known as a user control, requested from a server that hosts an ASP.NET Web application. The file must be called from a Web Forms page or a parser error will occur. 



---
## Type SessionState.SessionStateItemCollection

 A collection of objects stored in session state. This class cannot be inherited. 



---
## Method SessionState.SessionStateItemCollection.#ctor

 Creates a new, empty SessionStateItemCollection object. 



---
## Method SessionState.SessionStateItemCollection.Clear

 Removes all values and keys from the session-state collection. 



---
## Method SessionState.SessionStateItemCollection.Remove(System.String)

 Deletes an item from the collection. 


| Name | Description |
|-----|------|
|name: ||


---
## Method SessionState.SessionStateItemCollection.RemoveAt(System.Int32)

 Deletes an item at a specified index from the collection. 


| Name | Description |
|-----|------|
|index: ||


---
## Property SessionState.SessionStateItemCollection.Dirty

 Gets or sets a value indicating whether the collection has been marked as changed. 



---
## Property SessionState.SessionStateItemCollection.Item(System.String)

 Gets or sets a value in the collection by name. 


| Name | Description |
|-----|------|
|name: ||
**Returns**: 



---
## Property SessionState.SessionStateItemCollection.Item(System.Int32)

 Gets or sets a value in the collection by numerical index. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Type OpenNETCF.Configuration.ConfigurationSettings

 Provides access to configuration settings in a specified configuration section. This class cannot be inherited. 



---
## Method OpenNETCF.Configuration.ConfigurationSettings.Reload

 Forces the settings provider to re-load the settings from the configuration file. 



---
## Method OpenNETCF.Configuration.ConfigurationSettings.GetConfig(System.String)

 Returns configuration settings for a user-defined configuration section. 


| Name | Description |
|-----|------|
|sectionName: |The configuration section to read.|
**Returns**: The configuration settings for sectionName.



---
## Method OpenNETCF.Configuration.ConfigurationSettings.GetConfig(System.String,System.Object)

 Returns configuration settings for a user-defined configuration section. 


| Name | Description |
|-----|------|
|sectionName: |The configuration section to read.|
|context: ||
**Returns**: 



---
## Property OpenNETCF.Configuration.ConfigurationSettings.AppSettings

 Gets configuration settings in the configuration section. 



---
## Type HttpApplicationFactory





---
## Method HttpApplicationFactory.GetApplicationInstance(OpenNETCF.Web.HttpWorkerRequest)




| Name | Description |
|-----|------|
|wr: ||
**Returns**: 



---
## Type Configuration.AuthenticationConfiguration

 Descriptions the web server&#39;s authentication configuration 



---
## Method Configuration.AuthenticationConfiguration.#ctor

 Creates an instance of the AuthneticationConfiguration class. 



---
## Property Configuration.AuthenticationConfiguration.Mode

 Gets the authentication mode. Either Basic, Digest or Forms. 



---
## Property Configuration.AuthenticationConfiguration.Realm

 Gets the authentication realm for HTTP Authentication. 



---
## Property Configuration.AuthenticationConfiguration.Enabled

 Gets a boolean value indicating whether authentication is enabled or not. 



---
## Property Configuration.AuthenticationConfiguration.Users

 Describes the users configuration for authentication. 



---
## Type VirtualPathUtility

 Provides utility methods for common virtual path operations. 



---
## Method VirtualPathUtility.GetDirectory(System.String)

 Returns the directory portion of a virtual path 


| Name | Description |
|-----|------|
|virtualPath: |The virtual path.|
**Returns**: The directory referenced in the virtual path.



---
## Method VirtualPathUtility.GetExtension(System.String)

 Retrieves the extension of the file that is referenced in the virtual path. 


| Name | Description |
|-----|------|
|virtualPath: |The virtual path.|
**Returns**: The file name extension string literal, including the period (.), nullNothingnullptra null reference (Nothing in Visual Basic), or an empty string (&quot;&quot;).



---
## Method VirtualPathUtility.GetFileName(System.String)

 Retrieves the file name of the file that is referenced in the virtual path. 


| Name | Description |
|-----|------|
|virtualPath: |The virtual path.|
**Returns**: The file name literal after the last directory character in virtualPath; otherwise, an empty string (&quot;&quot;), if the last character of virtualPath is a directory or volume separator character.



---
## Method VirtualPathUtility.Combine(System.String,System.String)

 Combines a base path and a relative path. 


| Name | Description |
|-----|------|
|basePath: ||
|relativePath: ||
**Returns**: 



---
## Method VirtualPathUtility.ToAbsolute(System.String,System.String)

 Converts a virtual path to an application absolute path using the specified application path. 


| Name | Description |
|-----|------|
|virtualPath: ||
|applicationPath: ||
**Returns**: 



---
## Method VirtualPathUtility.MakeRelative(System.String,System.String)

 Returns the relative virtual path from one virtual path containing the root operator (the tilde [~]) to another. 


| Name | Description |
|-----|------|
|fromPath: ||
|toPath: ||
**Returns**: 



---
## Type HttpUtility

 Provides methods for encoding and decoding URLs when processing Web requests. This class cannot be inherited. 



---
## Method HttpUtility.UrlEncode(System.String)

 Encodes a URL string. 


| Name | Description |
|-----|------|
|str: |The text to encode.|
**Returns**: An encoded string.



---
## Method HttpUtility.UrlEncode(System.Byte[])

 Converts a byte array into an encoded URL string. 


| Name | Description |
|-----|------|
|bytes: |The array of bytes to encode.|
**Returns**: An encoded string.



---
## Method HttpUtility.UrlEncode(System.String,System.Text.Encoding)

 Encodes a URL string using the specified encoding object. 


| Name | Description |
|-----|------|
|str: |The text to encode. |
|e: |The Encoding object that specifies the encoding scheme. |
**Returns**: An encoded string.



---
## Method HttpUtility.UrlEncode(System.Byte[],System.Int32,System.Int32)

 Converts a byte array into a URL-encoded string, starting at the specified position in the array and continuing for the specified number of bytes. 


| Name | Description |
|-----|------|
|bytes: |The array of bytes to encode. |
|offset: |The position in the byte array at which to begin encoding.|
|count: |The number of bytes to encode. |
**Returns**: An encoded string.



---
## Method HttpUtility.UrlEncodeUnicode(System.String)

 Encodes a URL string 


| Name | Description |
|-----|------|
|str: |The text to encode. |
**Returns**: An encoded string.



---
## Method HttpUtility.UrlEncodeToBytes(System.Byte[])

 Converts an array of bytes into a URL-encoded array of bytes. 


| Name | Description |
|-----|------|
|bytes: |The array of bytes to encode. |
**Returns**: An encoded array of bytes.



---
## Method HttpUtility.UrlEncodeToBytes(System.String,System.Text.Encoding)

 Converts a string into a URL-encoded array of bytes using the specified encoding object. 


| Name | Description |
|-----|------|
|str: |The string to encode |
|e: |The Encoding that specifies the encoding scheme. |
**Returns**: An encoded array of bytes.



---
## Method HttpUtility.UrlEncodeToBytes(System.Byte[],System.Int32,System.Int32)

 Converts an array of bytes into a URL-encoded array of bytes, starting at the specified position in the array and continuing for the specified number of bytes. 


| Name | Description |
|-----|------|
|bytes: |The array of bytes to encode. |
|offset: |The position in the byte array at which to begin encoding.|
|count: |The number of bytes to encode. |
**Returns**: An encoded string.



---
## Method HttpUtility.UrlDecode(System.String)

 Converts a string that has been encoded for transmission in a URL into a decoded string. 


| Name | Description |
|-----|------|
|str: |The string to decode.|
**Returns**: A decoded string.



---
## Method HttpUtility.UrlDecode(System.Byte[],System.Text.Encoding)

 Converts a URL-encoded byte array into a decoded string, using the specified encoding object. 


| Name | Description |
|-----|------|
|bytes: |The array of bytes to decode.|
|e: |The Encoding that specifies the decoding scheme.|
**Returns**: 



---
## Method HttpUtility.UrlDecode(System.String,System.Text.Encoding)

 Converts a URL-encoded string into a decoded string, using the specified encoding object. 


| Name | Description |
|-----|------|
|str: |The string to decode.|
|e: |The Encoding that specifies the decoding scheme.|
**Returns**: 



---
## Method HttpUtility.UrlDecode(System.Byte[],System.Int32,System.Int32,System.Text.Encoding)

 Converts a URL-encoded byte array into a decoded string using the specified encoding object, starting at the specified position in the array, and continuing for the specified number of bytes. 


| Name | Description |
|-----|------|
|bytes: |The array of bytes to encode. |
|offset: |The position in the byte array at which to begin encoding.|
|count: |The number of bytes to encode. |
|e: |The Encoding object that specifies the decoding scheme. |
**Returns**: A decoded string.



---
## Method HttpUtility.HtmlEncode(System.String)

 Encodes a string to be displayed in a browser. 


| Name | Description |
|-----|------|
|text: ||
**Returns**: 



---
## Type HttpCachePolicyBase

 Serves as the base class for classes that contain methods for setting cache-specific HTTP headers and for controlling the ASP.NET page output cache. 



---
## Method HttpCachePolicyBase.SetProxyMaxAge(System.TimeSpan)

 When overridden in a derived class, sets the Cache-Control: s-maxage HTTP header to the specified time span. 


| Name | Description |
|-----|------|
|delta: ||


---
## Method HttpCachePolicyBase.AddValidationCallback(OpenNETCF.Web.HttpCacheValidateHandler,System.Object)

 When overridden in a derived class, registers a validation callback for the current response. 


| Name | Description |
|-----|------|
|handler: ||
|data: ||


---
## Type Configuration.User

 Defines a User. 



---
## Method Configuration.User.#ctor

 Creates an instance of the User class. 



---
## Property Configuration.User.Name

 The user&#39;s username. 



---
## Property Configuration.User.Password

 The user&#39;s password. 



---
## Type Hosting.DefaultWorkerRequest

 Default handler for ASP.NET page requests for the Web Server 



---
## Method Hosting.DefaultWorkerRequest.IsSecure

 Returns a value indicating whether the connection uses SSL. 

**Returns**: true if the connection is an SSL connection; otherwise, false.



---
## Method Hosting.DefaultWorkerRequest.#ctor(OpenNETCF.Web.Server.SocketWrapperBase,OpenNETCF.Web.Logging.ILogProvider)

 Initializes an instance of [Type Hosting.DefaultWorkerRequest](#type-hostingdefaultworkerrequest)


| Name | Description |
|-----|------|
|client: ||
|logProvider: ||


---
## Method Hosting.DefaultWorkerRequest.GetUriPath

 Returns the virtual path to the requested URI 

**Returns**: The path to the requested URI.



---
## Method Hosting.DefaultWorkerRequest.ProcessRequest

 Process the incoming HTTP request 



---
## Method Hosting.DefaultWorkerRequest.EndOfRequest





---
## Method Hosting.DefaultWorkerRequest.GetLocalAddress

 Returns the local address of the web server 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.GetLocalPort

 Returns the local port of the web server 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.GetHttpVersion

 Return the HTTP version of the request 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.GetHttpVerbName

 Returns the HTTP verb specified in the request 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.GetRemoteAddress

 Returns the remote address of the request 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.FlushResponse(System.Boolean)

 Flush the response stream to the client 


| Name | Description |
|-----|------|
|finalFlush: ||


---
## Method Hosting.DefaultWorkerRequest.HeadersSent

 Returns a value indicating whether HTTP response headers have been sent to the client for the current request. 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.CloseConnection

 Close the connection to the client. 



---
## Method Hosting.DefaultWorkerRequest.GetRequestHeaders

 Reads the HTTP headers from the request 



---
## Method Hosting.DefaultWorkerRequest.ReadRequestHeaders

 Reads the HTTP headers from the request 



---
## Method Hosting.DefaultWorkerRequest.SendResponseFromMemory(System.Byte[],System.Int32)

 Writes the specifide byte array to the response stream 


| Name | Description |
|-----|------|
|data: ||
|length: ||


---
## Method Hosting.DefaultWorkerRequest.SendCalculatedContentLength(System.Int32)

 Calculates the length of the response and then writes to the response 


| Name | Description |
|-----|------|
|contentLength: ||


---
## Method Hosting.DefaultWorkerRequest.SendKnownResponseHeader(System.String,System.String)

 Sends a well-known HTTP header to the response 


| Name | Description |
|-----|------|
|name: ||
|value: ||


---
## Method Hosting.DefaultWorkerRequest.GetQueryString

 Returns the query string from the request 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.IsClientConnected

 Returns a value indicating whether the client connection is still active. 

**Returns**: true if the client connection is still active; otherwise, false.



---
## Method Hosting.DefaultWorkerRequest.InitializeResponse

 initializes the resposen. Called from ctor and before closing the connection to see if keep alive is available 



---
## Method Hosting.DefaultWorkerRequest.SetDefaultServerHeaderAndStatus

 Sets the default headers. Called from ctor and before closing the connection to see if keep alive is available 



---
## Method Hosting.DefaultWorkerRequest.GetAppPathTranslated



**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.GetEntireRawContent

 Gets the remaing request content. Primarly used for posted data 

**Returns**: 



---
## Method Hosting.DefaultWorkerRequest.GetPartialRawRequestContent(OpenNETCF.Web.Server.SocketWrapperBase)

 Retreives the entire Http request and stores it in a HttpRawRequestContent 


| Name | Description |
|-----|------|
|client: ||
**Returns**: 



---
## Property Hosting.DefaultWorkerRequest.KeepConnectionAlive

 Determins if the connection should be kept alive 



---
## Type UI.HtmlTextWriter

 Writes markup characters and text to a Padarn server control output stream. This class provides formatting capabilities that Padarn pages use when rendering markup to clients. 



---
## Method UI.HtmlTextWriter.#ctor(System.IO.TextWriter)

 Initializes a new instance of the HtmlTextWriter class that uses a default tab string. 


| Name | Description |
|-----|------|
|writer: ||


---
## Method UI.HtmlTextWriter.RenderBeginTag(OpenNETCF.Web.UI.HtmlTextWriterTag)

 Writes the opening tag of the markup element associated with the specified HtmlTextWriterTag enumeration value to the output stream. 


| Name | Description |
|-----|------|
|tagKey: ||


---
## Method UI.HtmlTextWriter.RenderBeginTag(System.String)

 Writes the opening tag of the specified markup element to the output stream. 


| Name | Description |
|-----|------|
|tagName: ||


---
## Method UI.HtmlTextWriter.RenderEndTag

 Writes the end tag of a markup element to the output stream. 



---
## Method UI.HtmlTextWriter.AddAttribute(OpenNETCF.Web.UI.HtmlTextWriterAttribute,System.String)

 Adds the specified markup attribute and value to the opening tag of the element that the HtmlTextWriter object creates with a subsequent call to the RenderBeginTag method. 


| Name | Description |
|-----|------|
|key: ||
|value: ||


---
## Method UI.HtmlTextWriter.AddAttribute(System.String,System.String)

 Adds the specified markup attribute and value to the opening tag of the element that the HtmlTextWriter object creates with a subsequent call to the RenderBeginTag method. 


| Name | Description |
|-----|------|
|name: ||
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.String)

 Writes the specified string to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Boolean)

 Writes the text representation of a Boolean value to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Char[])

 Writes the text representation of an array of Unicode characters to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|buffer: ||


---
## Method UI.HtmlTextWriter.Write(System.Decimal)

 Writes the text representation of a decimal value to the text string or stream. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Double)

 Writes the text representation of a double-precision floating-point number to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Single)

 Writes the text representation of a single-precision floating-point number to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Int32)

 Writes the text representation of a 32-byte signed integer to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Int64)

 Writes the text representation of a 64-byte signed integer to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Object)

 Writes the text representation of an object to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.Write(System.Char)

 Writes the text representation of a Unicode character to the output stream, along with any pending tab spacing. 


| Name | Description |
|-----|------|
|value: ||


---
## Method UI.HtmlTextWriter.WriteBreak

 Writes a 
   markup element to the output stream. 



---
## Method UI.HtmlTextWriter.WriteEndTag(System.String)

 Writes any tab spacing and the closing tag of the specified markup element. 



---
## Property UI.HtmlTextWriter.Encoding

 Gets the encoding that the HtmlTextWriter object uses to write content to the page. 



---
## Type Security.DigestAuthentication





---
## Method Security.DigestAuthentication.#ctor





---
## Method Security.DigestAuthentication.AcceptCredentials(OpenNETCF.Web.HttpContext,System.String)




| Name | Description |
|-----|------|
|context: ||
|authentication: ||
**Returns**: 



---
## Method Security.DigestAuthentication.OnEndRequest(System.Object,System.EventArgs)




| Name | Description |
|-----|------|
|sender: ||
|e: ||


---
## Type Routing.RouteCollection

 Provides a collection of routes for Padarn routing. 



---
## Method Routing.RouteCollection.#ctor

 Initializes a new instance of the RouteCollection class. 



---
## Method Routing.RouteCollection.GetVirtualPath(OpenNETCF.Web.Routing.RequestContext,System.String,OpenNETCF.Web.Routing.RouteValueDictionary)

 Returns information about the URL path that is associated with the named route, given the specified context, route name, and parameter values. 


| Name | Description |
|-----|------|
|requestContext: ||
|name: ||
|values: ||
**Returns**: 



---
## Method Routing.RouteCollection.GetVirtualPath(OpenNETCF.Web.Routing.RequestContext,OpenNETCF.Web.Routing.RouteValueDictionary)

 Returns information about the URL path that is associated with the route, given the specified context and parameter values. 


| Name | Description |
|-----|------|
|requestContext: |An object that encapsulates information about the requested route.|
|values: |An object that contains the parameters for a route.|
**Returns**: An object that contains information about the URL path that is associated with the route.



---
## Method Routing.RouteCollection.GetReadLock

 Provides an object for managing thread safety when you retrieve an object from the collection. 

**Returns**: An object that manages thread safety



---
## Type Parsers.JSON

 This class encodes and decodes JSON strings. Spec. details, see http://www.json.org/ JSON uses Arrays and Objects. These correspond here to the datatypes ArrayList and Hashtable. All numbers are parsed to doubles. 



---
## Field Parsers.JSON.lastErrorIndex

 On decoding, this value holds the position at which the parse failed (-1 = no error). 



---
## Method Parsers.JSON.JsonDecode(System.String)

 Parses the string json into a value 


| Name | Description |
|-----|------|
|json: |A JSON string.|
**Returns**: An ArrayList, a Hashtable, a double, a string, null, true, or false



---
## Method Parsers.JSON.JsonEncode(System.Object)

 Converts a Hashtable / ArrayList object into a JSON string 


| Name | Description |
|-----|------|
|json: |A Hashtable / ArrayList|
**Returns**: A JSON encoded string, or null if object &#39;json&#39; is not serializable



---
## Method Parsers.JSON.LastDecodeSuccessful

 On decoding, this function returns the position at which the parse failed (-1 = no error). 

**Returns**: 



---
## Method Parsers.JSON.GetLastErrorIndex

 On decoding, this function returns the position at which the parse failed (-1 = no error). 

**Returns**: 



---
## Method Parsers.JSON.GetLastErrorSnippet

 If a decoding error occurred, this function returns a piece of the JSON string at which the error took place. To ease debugging. 

**Returns**: 



---
## Method Parsers.JSON.IsNumeric(System.Object)

 Determines if a given object is numeric in any way (can be integer, double, etc). C# has no pretty way to do this. 



---
## Type OpenNETCF.Configuration.SingleTagSectionHandler





---
## Method OpenNETCF.Configuration.SingleTagSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)

 Returns a collection of configuration section values. 


| Name | Description |
|-----|------|
|parent: |The configuration settings in a corresponding parent configuration section.|
|context: |This parameter is reserved and is null.|
|section: |An [Type System.Xml.XmlNode](https://msdn.microsoft.com/en-us/library/System.Xml.XmlNode) that contains configuration information from the configuration file. Provides direct access to the XML contents of the configuration section.|
**Returns**: A [Type System.Collections.Hashtable](https://msdn.microsoft.com/en-us/library/System.Collections.Hashtable) containing configuration section directives.



---
## Type OpenNETCF.Configuration.DictionarySectionHandler

 Reads key-value pair configuration information for a configuration section. 

##### Example: 

######  code

```
    <add key="name" value="text"> - sets key=text
    <remove key="name"> - removes the definition of key
    <clear/> - removes all definitions
```





---
## Method OpenNETCF.Configuration.DictionarySectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)




| Name | Description |
|-----|------|
|parent: ||
|context: ||
|section: ||
**Returns**: 



---
## Property OpenNETCF.Configuration.DictionarySectionHandler.KeyAttributeName

 Make the name of the key attribute configurable by derived classes. 



---
## Property OpenNETCF.Configuration.DictionarySectionHandler.ValueAttributeName

 Make the name of the value attribute configurable by derived classes. 



---
## Type Configuration.CookiesConfiguration

 Configures properties for cookies used by a Web application. 



---
## Property Configuration.CookiesConfiguration.RequireSSL

 Gets or sets a value indicating whether Secure Sockets Layer (SSL) communication is required. 



---
## Property Configuration.CookiesConfiguration.Domain

 Gets or sets the cookie domain name. 



---
## Property Configuration.CookiesConfiguration.HttpOnlyCookies

 Gets or sets a value indicating whether the support for the browser&#39;s HttpOnly cookie is enabled. 



---
## Type SessionState.SessionStateMode

 Specifies the session-state mode. 



---
## Field SessionState.SessionStateMode.Off

 Session state is disabled. 



---
## Field SessionState.SessionStateMode.InProc

 Session state is in process with the Padarn host process. 



---
## Field SessionState.SessionStateMode.StateServer

 Session state is in process with an Padarn worker process. 



---
## Field SessionState.SessionStateMode.SQLServer

 Session state is using an out-of-process SQL Server database to store state information. 



---
## Field SessionState.SessionStateMode.Custom

 Session state is using a custom data store to store session-state information. 



---
## Type Routing.Route

 Provides properties and methods for defining a route and for obtaining information about the route. 



---
## Type Routing.RouteBase

 Serves as the base class for all classes that represent a Padarn route. 



---
## Method Routing.RouteBase.#ctor

 Initializes the class for use by an inherited class instance. This constructor can only be called by an inherited class. 



---
## Method Routing.RouteBase.GetRouteData(OpenNETCF.Web.HttpContextBase)

 When overridden in a derived class, returns route information about the request. 


| Name | Description |
|-----|------|
|httpContext: ||
**Returns**: 



---
## Method Routing.RouteBase.GetVirtualPath(OpenNETCF.Web.Routing.RequestContext,OpenNETCF.Web.Routing.RouteValueDictionary)

 When overridden in a derived class, checks whether the route matches the specified values, and if so, generates a URL and retrieves information about the route. 


| Name | Description |
|-----|------|
|requestContext: ||
|values: ||
**Returns**: 



---
## Method Routing.Route.#ctor(System.String,OpenNETCF.Web.Routing.IRouteHandler)

 Initializes a new instance of the Route class, by using the specified URL pattern and handler class. 


| Name | Description |
|-----|------|
|url: ||
|routeHandler: ||


---
## Method Routing.Route.GetRouteData(OpenNETCF.Web.HttpContextBase)

 Returns information about the requested route. (Overrides RouteBase.GetRouteData(HttpContextBase).) 


| Name | Description |
|-----|------|
|httpContext: ||
**Returns**: 



---
## Method Routing.Route.GetVirtualPath(OpenNETCF.Web.Routing.RequestContext,OpenNETCF.Web.Routing.RouteValueDictionary)

 Returns information about the URL that is associated with the route. (Overrides RouteBase.GetVirtualPath(RequestContext, RouteValueDictionary).) 


| Name | Description |
|-----|------|
|requestContext: ||
|values: ||
**Returns**: 



---
## Property Routing.Route.DataTokens

 Gets or sets custom values that are passed to the route handler, but which are not used to determine whether the route matches a URL pattern. 



---
## Type OpenNETCF.Configuration.ConfigurationException

 The exception that is thrown when an error occurs in a configuration setting. 



---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor

 Initializes a new instance of the System.Configuration.ConfigurationException class. 



---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor(System.String)

 Initializes a new instance of the System.Configuration.ConfigurationException class with the specified error message. 


| Name | Description |
|-----|------|
|message: |The message to display to the client when the exception is thrown.|


---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor(System.String,System.Exception)

 Initializes a new instance of the System.Configuration.ConfigurationException class with the specified error message and System.Exception.InnerException property. 


| Name | Description |
|-----|------|
|message: |The message to display to the client when the exception is thrown.|
|inner: |The System.Exception.InnerException , if any, that threw the current exception.|


---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor(System.String,System.Exception,System.Xml.XmlNode)

 Initializes a new instance of the System.Configuration.ConfigurationException class with the specified error message and System.Exception.InnerException and the name of the configuration section node that contains the error. 


| Name | Description |
|-----|------|
|message: |The message to display to the client when the exception is thrown.|
|inner: |The System.Exception.InnerException , if any, that threw the current exception.|
|node: |The System.Xml.XmlNode that contains the error.|


---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor(System.String,System.String,System.Int32)

 Initializes a new instance of the System.Configuration.ConfigurationException class with the specified error message, the name of the configuration file that contains the error, and the line number in the file. 


| Name | Description |
|-----|------|
|message: |The message to display to the client when the exception is thrown.|
|filename: |The name of the configuration file that contains the error.|
|line: |The number of the line that contains the error.|


---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor(System.String,System.Exception,System.String,System.Int32)

 Initializes a new instance of the System.Configuration.ConfigurationException with the specified error message and System.Exception.InnerException, the name of the file containing the error, and the line number of the error in the file. 


| Name | Description |
|-----|------|
|message: |The message to display to the client when the exception is thrown.|
|inner: |The System.Exception.InnerException , if any, that threw the current exception.|
|filename: |The name of the configuration file that contains the error.|
|line: |The number of the line that contains the error.|


---
## Method OpenNETCF.Configuration.ConfigurationException.#ctor(System.String,System.Xml.XmlNode)

 Initializes a new instance of the System.Configuration.ConfigurationException with the specified error message and the name of the configuration section containing the error. 


| Name | Description |
|-----|------|
|message: |The message to display to the client when the exception is thrown.|
|node: |The System.Xml.XmlNode that contains the error.|


---
## Method OpenNETCF.Configuration.ConfigurationException.GetXmlNodeLineNumber(System.Xml.XmlNode)

 Returns the line number of the configuration section node that contains the error. 


| Name | Description |
|-----|------|
|node: |The name of the configuration section node that contains the error.|
**Returns**: The line number that contains the error.



---
## Method OpenNETCF.Configuration.ConfigurationException.GetXmlNodeFilename(System.Xml.XmlNode)

 Returns the name of the file that contains the configuration section node that contains the error. 


| Name | Description |
|-----|------|
|node: |The name of the configuration section node that contains the error.|
**Returns**: The name of the configuration file.



---
## Type HttpRequestWrapper

 Encapsulates the HTTP intrinsic object that enables Padarn to read the HTTP values that are sent by a client during a Web request. 



>  The HttpRequestWrapper class derives from the HttpRequestBase class and serves as a wrapper for the HttpRequest class. This class exposes the functionality of the HttpRequest class and exposes the HttpRequestBase type. The HttpRequestBase class enables you to replace the original implementation of the HttpRequest class in your application with a custom implementation, such as when you perform unit testing outside the ASP.NET pipeline. 



---
## Method HttpRequestWrapper.#ctor(OpenNETCF.Web.HttpRequest)

 Initializes a new instance of the HttpRequestWrapper class by using the specified request object. 


| Name | Description |
|-----|------|
|httpRequest: ||


---
## Type Hosting.AsyncWorkerRequest

 Default handler for ASP.NET page requests for the Web Server 



---
## Method Hosting.AsyncWorkerRequest.IsSecure

 Returns a value indicating whether the connection uses SSL. 

**Returns**: true if the connection is an SSL connection; otherwise, false.



---
## Method Hosting.AsyncWorkerRequest.#ctor(OpenNETCF.Web.Server.SocketWrapperBase,OpenNETCF.Web.Logging.ILogProvider)

 Initializes an instance of [Type Hosting.DefaultWorkerRequest](#type-hostingdefaultworkerrequest)


| Name | Description |
|-----|------|
|client: ||


---
## Method Hosting.AsyncWorkerRequest.GetUriPath

 Returns the virtual path to the requested URI 

**Returns**: The path to the requested URI.



---
## Method Hosting.AsyncWorkerRequest.ProcessRequest

 Process the incoming HTTP request 



---
## Method Hosting.AsyncWorkerRequest.EndOfRequest





---
## Method Hosting.AsyncWorkerRequest.GetLocalAddress

 Returns the local address of the web server 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.GetLocalPort

 Returns the local port of the web server 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.GetHttpVersion

 Return the HTTP version of the request 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.GetHttpVerbName

 Returns the HTTP verb specified in the request 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.GetRemoteAddress

 Returns the remote address of the request 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.FlushResponse(System.Boolean)

 Flush the response stream to the client 


| Name | Description |
|-----|------|
|finalFlush: ||


---
## Method Hosting.AsyncWorkerRequest.CloseConnection

 Close the connection to the client. 



---
## Method Hosting.AsyncWorkerRequest.GetRequestHeaders

 Reads the HTTP headers from the request 



---
## Method Hosting.AsyncWorkerRequest.ReadRequestHeaders

 Reads the HTTP headers from the request 



---
## Method Hosting.AsyncWorkerRequest.SendResponseFromMemory(System.Byte[],System.Int32)

 Writes the specifide byte array to the response stream 


| Name | Description |
|-----|------|
|data: ||
|length: ||


---
## Method Hosting.AsyncWorkerRequest.SendCalculatedContentLength(System.Int32)

 Calculates the length of the response and then writes to the response 


| Name | Description |
|-----|------|
|contentLength: ||


---
## Method Hosting.AsyncWorkerRequest.SendKnownResponseHeader(System.String,System.String)

 Sends a well-known HTTP header to the response 


| Name | Description |
|-----|------|
|name: ||
|value: ||


---
## Method Hosting.AsyncWorkerRequest.GetQueryString

 Returns the query string from the request 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.IsClientConnected

 Returns a value indicating whether the client connection is still active. 

**Returns**: true if the client connection is still active; otherwise, false.



---
## Method Hosting.AsyncWorkerRequest.InitializeResponse

 initializes the resposen. Called from ctor and before closing the connection to see if keep alive is available 



---
## Method Hosting.AsyncWorkerRequest.SetDefaultServerHeaderAndStatus

 Sets the default headers. Called from ctor and before closing the connection to see if keep alive is available 



---
## Method Hosting.AsyncWorkerRequest.GetAppPathTranslated



**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.GetEntireRawContent

 Gets the remaing request content. Primarly used for posted data 

**Returns**: 



---
## Method Hosting.AsyncWorkerRequest.GetPartialRawRequestContent(OpenNETCF.Web.Server.SocketWrapperBase)

 Retreives the entire Http request and stores it in a HttpRawRequestContent 


| Name | Description |
|-----|------|
|client: ||
**Returns**: 



---
## Property Hosting.AsyncWorkerRequest.KeepConnectionAlive

 Determins if the connection should be kept alive 



---
## Type HttpCacheValidateHandler

 Represents a method that is called to validate a cached item before the item is served from the cache. 


| Name | Description |
|-----|------|
|context: ||
|data: ||
|validationStatus: ||


---
## Type UI.HtmlTextWriterAttribute

 Specifies the HTML attributes that an HtmlTextWriter or Html32TextWriter object writes to the opening tag of an HTML element when a Web request is processed. 



---
## Field UI.HtmlTextWriterAttribute.Align

 Specifies that the HTML align attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Alt

 Specifies that the HTML alt attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Border

 Specifies that the HTML border attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Checked

 Specifies that the HTML checked attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Class

 Specifies that the HTML class attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Cols

 Specifies that the HTML cols attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Colspan

 Specifies that the HTML colspan attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Content

 Specifies that the HTML content attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Disabled

 Specifies that the HTML disabled attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Height

 Specifies that the HTML height attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Href

 Specifies that the HTML href attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Id

 Specifies that the HTML id attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Maxlength

 Specifies that the HTML maxlength attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Multiple

 Specifies that the HTML multiple attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Name

 Specifies that the HTML name attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Nowrap

 Specifies that the HTML nowrap attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Onchange

 Specifies that the HTML onchange attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Onclick

 Specifies that the HTML onclick attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.ReadOnly

 Specifies that the HTML readonly attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Rel

 Specifies that the HTML rel attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Rows

 Specifies that the HTML rows attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Rowspan

 Specifies that the HTML rowspan attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Rules

 Specifies that the HTML rules attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Scope

 Specifies that the HTML scope attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Selected

 Specifies that the HTML selected attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Size

 Specifies that the HTML size attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Src

 Specifies that the HTML src attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Style

 Specifies that the HTML style attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Tabindex

 Specifies that the HTML tabindex attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Target

 Specifies that the HTML target attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Title

 Specifies that the HTML title attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Type

 Specifies that the HTML type attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Value

 Specifies that the HTML value attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Width

 Specifies that the HTML width attribute be written to the tag. 



---
## Field UI.HtmlTextWriterAttribute.Wrap

 Specifies that the HTML wrap attribute be written to the tag. 



---
## Type HttpResponse

 Represents the response to a particular HTTP request. 



---
## Method HttpResponse.SetCookie(OpenNETCF.Web.HttpCookie)

 Updates an existing cookie in the cookie collection. 


| Name | Description |
|-----|------|
|cookie: ||


---
## Method HttpResponse.AppendCookie(OpenNETCF.Web.HttpCookie)

 Adds an HTTP cookie to the intrinsic cookie collection. 


| Name | Description |
|-----|------|
|cookie: ||


---
## Method HttpResponse.AppendHeader(System.String,System.String)

 Append a header to the HttpResponse 


| Name | Description |
|-----|------|
|name: ||
|value: ||


---
## Method HttpResponse.ClearHeaders

 Clears all headers from the buffer stream. 



---
## Method HttpResponse.BinaryWrite(System.Byte[])

 Writes a string of binary characters to the HTTP output stream. 


| Name | Description |
|-----|------|
|buffer: |The bytes to write to the output stream.|


---
## Method HttpResponse.BinaryWrite(System.Byte[],System.Int32,System.Int32)

 Writes a string of binary characters to the HTTP output stream. 


| Name | Description |
|-----|------|
|buffer: |The bytes to write to the output stream.|


---
## Method HttpResponse.Write(System.String)

 Write to the HttpResponse stream 


| Name | Description |
|-----|------|
|s: ||


---
## Method HttpResponse.WriteLine(System.String)

 Write a line to the HttpResponse stream 


| Name | Description |
|-----|------|
|s: ||


---
## Method HttpResponse.Redirect(System.String)

 Redirect the request to a different URL 


| Name | Description |
|-----|------|
|url: ||


---
## Method HttpResponse.Flush

 Flush the HttpResponse stream to the client. 



---
## Property HttpResponse.ContentLength

 Specifies the length of the entity body in the HTTP response 



---
## Property HttpResponse.HeaderEncoding

 Specifies the character encoding for the HTTP response 



---
## Property HttpResponse.ContentType

 Specifies the content type for the HTTP response 



---
## Property HttpResponse.Cache

 Gets the caching policy (expiration time, privacy, vary clauses) of a Web page. 



---
## Property HttpResponse.Cookies

 Gets the response cookie collection. 



---
## Property HttpResponse.StatusCode

 Gets or sets the HTTP status code of the output returned to the client. 



---
## Property HttpResponse.StatusDescription

 Gets or sets the HTTP status string of the output returned to the client. 



---
## Property HttpResponse.IsRequestBeingRedirected

 Gets a Boolean value indicating whether the client is being transferred to a new location. 



---
## Property HttpResponse.IsClientConnected

 Gets a value indicating whether the client is still connected to the server. 

**Value**: true if the client is currently connected; otherwise, false.



---
## Type HttpFileCollection

 Provides access to and organizes files uploaded by a client. 



---
## Method HttpFileCollection.CopyTo(System.Array,System.Int32)

 Copies members of the file collection to an Array beginning at the specified index of the array. 


| Name | Description |
|-----|------|
|dest: |The destination Array. |
|index: |The index of the destination array where copying starts. |


---
## Method HttpFileCollection.Get(System.Int32)

 Returns the HttpPostedFile object with the specified numerical index from the file collection. 


| Name | Description |
|-----|------|
|index: |The index of the object to be returned from the file collection.|
**Returns**: An HttpPostedFile object.



---
## Method HttpFileCollection.Get(System.String)

 Returns the HttpPostedFile object with the specified name from the file collection. 


| Name | Description |
|-----|------|
|name: |The name of the object to be returned from a file collection. |
**Returns**: An HttpPostedFile object.



---
## Method HttpFileCollection.GetKey(System.Int32)

 Returns the name of the HttpFileCollection member with the specified numerical index. 


| Name | Description |
|-----|------|
|index: |The index of the object name to be returned. |
**Returns**: The name of the HttpFileCollection member specified by index.



---
## Property HttpFileCollection.AllKeys

 Gets a string array containing the keys (names) of all members in the file collection. 



---
## Property HttpFileCollection.Item(System.String)

 Gets the object with the specified name from the file collection. 


| Name | Description |
|-----|------|
|name: |Name of item to be returned.|
**Returns**: The HttpPostedFile specified by name.



---
## Property HttpFileCollection.Item(System.Int32)

 Gets the object with the specified numerical index from the HttpFileCollection. 


| Name | Description |
|-----|------|
|index: |The index of the item to get from the file collection. |
**Returns**: The HttpPostedFile specified by index.



---
## Method Security.Cryptography.DigestAuthInfo.GetHashCode(System.String)

 Gets a unique MD5 hash code for the provides password based on RFC 2617 


| Name | Description |
|-----|------|
|password: ||
**Returns**: 



---
## Method Security.Cryptography.DigestAuthInfo.MatchCredentials(System.String)

 Checks to see if the HashCode generated with the supplied password matches the hash stored in the Digest 


| Name | Description |
|-----|------|
|password: ||
**Returns**: 



---
## Type OpenNETCF.Net.NetworkInformation.NetworkInterface

 Provides configuration and statistical information for a network interface. 

 Provides configuration and statistical information for a network interface. 



---
## Method OpenNETCF.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces

 Returns objects that describe the network interfaces on the local computer. 

**Returns**:  A System.Net.NetworkInformation.NetworkInterface array that contains objects that describe the available network interfaces, or an empty array if no interfaces are detected. 



---
## Method OpenNETCF.Net.NetworkInformation.NetworkInterface.#ctor(System.Int32,System.String)

 Creates a NetworkInterface instance 


| Name | Description |
|-----|------|
|index: ||
|interfaceName: ||


---
## Method OpenNETCF.Net.NetworkInformation.NetworkInterface.GetPhysicalAddress

 Returns the Media Access Control (MAC) address for this adapter. 

**Returns**:  A System.Net.NetworkInformation.PhysicalAddress object that contains the physical address. 



---
## Property OpenNETCF.Net.NetworkInformation.NetworkInterface.Name

 Gets the name of the network adapter. 



---
## Property OpenNETCF.Net.NetworkInformation.NetworkInterface.Description

 Gets a System.String that describes this interface. 



---
## Property OpenNETCF.Net.NetworkInformation.NetworkInterface.Id

 Gets the identifier of the network adapter. 



---
## Property OpenNETCF.Net.NetworkInformation.NetworkInterface.CurrentIpAddress

 The currently active IP address of the adapter. 



> After Setting this property, you must Rebind the adapter for it to take effect



---
## Type Logging.LogDataItem

 Contains data about a padarn page access 



---
## Property Logging.LogDataItem.Headers

 HTTP Headers passed into the page request 



---
## Property Logging.LogDataItem.PageName

 Page being called 



---
## Property Logging.LogDataItem.RemoteClientIP

 IP address of the client making the page request 



---
## Property Logging.LogDataItem.ServerConfiguration

 Current Padarn configuration settings 



---
## Type OpenNETCF.Configuration.ConfigurationErrorsException

 The current value is not one of the EnableSessionState values. 



---
## Method OpenNETCF.Configuration.ConfigurationErrorsException.#ctor(System.String,System.Exception)

 Initializes a new instance of a ConfigurationErrorsException class 


| Name | Description |
|-----|------|
|message: |A message that describes why this ConfigurationErrorsException exception was thrown.|
|inner: |The inner exception that caused this ConfigurationErrorsException exception to be thrown.|


---
## Method OpenNETCF.Configuration.ConfigurationErrorsException.#ctor(System.String,System.Exception,System.String,System.Int32)

 Initializes a new instance of a ConfigurationErrorsException class 


| Name | Description |
|-----|------|
|message: |A message that describes why this ConfigurationErrorsException exception was thrown.|
|inner: |The inner exception that caused this ConfigurationErrorsException exception to be thrown.|
|filename: |The line number within the configuration file at which this ConfigurationErrorsException exception was thrown.|
|line: |The path to the configuration file that caused this ConfigurationErrorsException exception to be thrown.|


---
## Type Configuration.UserCollection

 A collection of Users. 



---
## Method Configuration.UserCollection.Find(System.String)

 Find a user with a specific username. 


| Name | Description |
|-----|------|
|username: ||
**Returns**: 



---
## Type SessionState.HttpSessionState

 Provides access to session-state values as well as session-level settings and lifetime management methods. 



---
## Method SessionState.HttpSessionState.Abandon

 Cancels the current session. 



---
## Method SessionState.HttpSessionState.Add(System.String,System.Object)

 Adds a new item to the session-state collection. 


| Name | Description |
|-----|------|
|name: ||
|value: ||


---
## Method SessionState.HttpSessionState.Remove(System.String)

 Deletes an item from the session-state collection. 


| Name | Description |
|-----|------|
|name: ||


---
## Method SessionState.HttpSessionState.GetEnumerator

 Returns an enumerator that can be used to read all the session-state variable names in the current session. 

**Returns**: 



---
## Method SessionState.HttpSessionState.CopyTo(System.Array,System.Int32)

 Copies the collection of session-state values to a one-dimensional array, starting at the specified index in the array. 


| Name | Description |
|-----|------|
|array: ||
|index: ||


---
## Method SessionState.HttpSessionState.Clear

 Removes all keys and values from the session-state collection. 



---
## Property SessionState.HttpSessionState.SessionID

 Gets the unique identifier for the session. 



---
## Property SessionState.HttpSessionState.Timeout

 Gets and sets the amount of time, in minutes, allowed between requests before the session-state provider terminates the session. 



---
## Property SessionState.HttpSessionState.CookieMode

 Gets a value that indicates whether the application is configured for cookieless sessions. 



>  Padarn only supports cookie sessions 



---
## Property SessionState.HttpSessionState.Mode

 Gets the current session-state mode. 



---
## Property SessionState.HttpSessionState.Item(System.Int32)

 Gets or sets a session value by numerical index. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Property SessionState.HttpSessionState.Item(System.String)

 Gets or sets a session value by name. 


| Name | Description |
|-----|------|
|name: ||
**Returns**: 



---
## Property SessionState.HttpSessionState.Count

 Gets the number of items in the session-state collection. 



---
## Property SessionState.HttpSessionState.IsSynchronized

 Gets a value indicating whether access to the collection of session-state values is synchronized (thread safe). 



---
## Property SessionState.HttpSessionState.SyncRoot

 Gets an object that can be used to synchronize access to the collection of session-state values. 



---
## Method HttpContextWrapper.#ctor(OpenNETCF.Web.HttpContext)

 Initializes a new instance of the HttpContextWrapper class by using the specified context object. 


| Name | Description |
|-----|------|
|httpContext: ||


---
## Property Configuration.SessionConfiguration.Timeout

 Timeout in minutes 



---
## Property Configuration.SessionConfiguration.MaxSessions

 Specifies the maximum number of concurrent sessions. 



---
## Property Configuration.SessionConfiguration.AllowSessionState

 Specifies whether session state persistence for the Padarn server is enabled. 



---
## Type UI.WebControls.LinkButton

 Displays a hyperlink-style button control on a Web page. 



---
## Method UI.WebControls.LinkButton.OnClick(System.EventArgs)

 Raises the Click event of the LinkButton control. 


| Name | Description |
|-----|------|
|e: ||


---
## Method UI.WebControls.LinkButton.RaisePostBackEvent(System.String)

 Raises events for the LinkButton control when it posts back to the server. 


| Name | Description |
|-----|------|
|eventArgument: ||


---
## Event UI.WebControls.LinkButton.Click

 Occurs when the LinkButton control is clicked. 



---
## Property UI.WebControls.LinkButton.Text

 Gets or sets the text caption displayed in the Button control. 



---
## Type UI.ControlCollection

 Provides a collection container that enables Padarn server controls to maintain a list of their child controls. 



---
## Method UI.ControlCollection.Add(OpenNETCF.Web.UI.Control)

 Adds the specified Control object to the collection. 


| Name | Description |
|-----|------|
|child: ||


---
## Method UI.ControlCollection.Clear

 Removes all controls from the current server control&#39;s ControlCollection object. 



---
## Property UI.ControlCollection.Item(System.Int32)

 Gets a reference to the server control at the specified index location in the ControlCollection object. 


| Name | Description |
|-----|------|
|index: ||
**Returns**: 



---
## Property UI.ControlCollection.Count

 Gets the number of server controls in the ControlCollection object for the specified ASP.NET server control. 



---
## Type SessionState.SessionIDManager

 Manages unique identifiers for Padarn session state. 



---
## Method SessionState.SessionIDManager.#ctor

 Creates an instance of the SessionIDManager class. 



---
## Method SessionState.SessionIDManager.Initialize

 Initializes the SessionIDManager object with information from configuration files. 



---
## Method SessionState.SessionIDManager.InitializeRequest(OpenNETCF.Web.HttpContext,System.Boolean,System.Boolean@)

 Performs per-request initialization of the SessionIDManager object. 


| Name | Description |
|-----|------|
|context: ||
|suppressAutoDetectRedirect: ||
|supportSessionIDReissue: ||
**Returns**: 



---
## Method SessionState.SessionIDManager.GetSessionID(OpenNETCF.Web.HttpContext)

 Gets the session-identifier value from the current Web request. 


| Name | Description |
|-----|------|
|context: ||
**Returns**: 



---
## Method SessionState.SessionIDManager.CreateSessionID(OpenNETCF.Web.HttpContext)

 Creates a unique session identifier for the session. 


| Name | Description |
|-----|------|
|context: ||
**Returns**: 



---
## Method SessionState.SessionIDManager.RemoveSessionID(OpenNETCF.Web.HttpContext)

 Deletes the session-identifier cookie from the HTTP response. 


| Name | Description |
|-----|------|
|context: ||


---
## Method SessionState.SessionIDManager.SaveSessionID(OpenNETCF.Web.HttpContext,System.String,System.Boolean@,System.Boolean@)

 Saves a newly created session identifier to the HTTP response. 


| Name | Description |
|-----|------|
|context: ||
|id: ||
|redirected: ||
|cookieAdded: ||


---
## Method SessionState.SessionIDManager.Validate(System.String)

 Gets a value indicating whether a session identifier is valid. 


| Name | Description |
|-----|------|
|id: ||
**Returns**: 



---
## Property SessionState.SessionIDManager.SessionIDMaxLength

 ets the maximum length of a valid session identifier. 



>  While session identifiers created by the CreateSessionID method are 24 characters long, the maximum length of a session identifier allowed by the SessionIDManager class is 80 characters. 



---
## Type Routing.VirtualPathData

 Represents information about the route and virtual path that are the result of generating a URL with the Padarn routing framework. 



---
## Method Routing.VirtualPathData.#ctor(OpenNETCF.Web.Routing.RouteBase,System.String)

 Initializes a new instance of the VirtualPathData class. 


| Name | Description |
|-----|------|
|route: ||
|virtualPath: ||


---
## Property Routing.VirtualPathData.Route

 Gets or sets the route that is used to create the URL. 



---
## Property Routing.VirtualPathData.VirtualPath

 Gets or sets the URL that was created from the route definition 



---
## Property Routing.VirtualPathData.DataTokens

 Gets the collection of custom values for the route definition. 



---
## Type Routing.RequestContext

 Encapsulates information about an HTTP request that matches a defined route. 



---
## Method Routing.RequestContext.#ctor(OpenNETCF.Web.HttpContextBase,OpenNETCF.Web.Routing.RouteData)

 Initializes a new instance of the RequestContext class. 


| Name | Description |
|-----|------|
|httpContext: ||
|routeData: ||


---
## Property Routing.RequestContext.HttpContext

 Gets information about the HTTP request. 



---
## Property Routing.RequestContext.RouteData

 Gets information about the requested route. 



---
## Type OpenNETCF.Configuration.NameValueSectionHandler

 Provides name-value pair configuration information from a configuration section. 



---
## Method OpenNETCF.Configuration.NameValueSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)




| Name | Description |
|-----|------|
|parent: ||
|context: ||
|section: ||
**Returns**: 



---
## Property OpenNETCF.Configuration.NameValueSectionHandler.KeyAttributeName





---
## Property OpenNETCF.Configuration.NameValueSectionHandler.ValueAttributeName





---
## Type HttpUnhandledException

 The exception that is thrown when a generic exception occurs. 



---
## Method HttpUnhandledException.#ctor(System.String)

 Initializes a new instance of the HttpUnhandledException class with the specified error messages. 


| Name | Description |
|-----|------|
|message: |The message displayed to the client when the exception is thrown.|


---
## Method HttpUnhandledException.#ctor(System.String,System.Exception)

 Initializes a new instance of the HttpUnhandledException class with the specified error message and inner exception. 


| Name | Description |
|-----|------|
|message: |The message displayed to the client when the exception is thrown.|
|innerException: |The InnerException, if any, that threw the current exception.|


---
## Type Hosting.VirtualPathProvider

 Provides a set of methods that enable a Web application to retrieve resources from a virtual file system. 



---
## Method Hosting.VirtualPathProvider.Initialize

 Initializes the VirtualPathProvider instance. 



---
## Method Hosting.VirtualPathProvider.DirectoryExists(System.String)

 Gets a value that indicates whether a directory exists in the virtual file system. 


| Name | Description |
|-----|------|
|virtualDir: |The path to the virtual directory.|
**Returns**: **true** if the directory exists in the virtual file system; otherwise, **false**.



---
## Method Hosting.VirtualPathProvider.FileExists(System.String)

 Gets a value that indicates whether a file exists in the virtual file system. 


| Name | Description |
|-----|------|
|virtualPath: |The path to the virtual file.|
**Returns**: **true** if the file exists in the virtual file system; otherwise, **false**.



---
## Method Hosting.VirtualPathProvider.GetDirectory(System.String)

 Gets a virtual directory from the virtual file system. 


| Name | Description |
|-----|------|
|virtualDir: |The path to the virtual directory.|
**Returns**: A descendent of the VirtualDirectory class that represents a directory in the virtual file system.



---
## Method Hosting.VirtualPathProvider.GetFile(System.String)

 Gets a virtual file from the virtual file system. 


| Name | Description |
|-----|------|
|virtualPath: |The path to the virtual file.|
**Returns**: A descendent of the VirtualFile class that represents a file in the virtual file system.



---
## Method Hosting.VirtualPathProvider.GetFileHash(System.String,System.Collections.IEnumerable)

 Gets a hash for the specified virtual file. 


| Name | Description |
|-----|------|
|virtualPath: |Path to the virtual file|
|virtualPathDependencies: ||
**Returns**: 



---
## Type Configuration.CacheLocation

 Specifies the valid values for controlling the location of the output-cached HTTP response for a resource. 



---
## Field Configuration.CacheLocation.Any

 The output cache can be located on the browser client (where the request originated), on a proxy server (or any other server) participating in the request, or on the server where the request was processed. 



> **Not currently supported by Padarn.**



---
## Field Configuration.CacheLocation.Client

 The output cache is located on the browser client where the request originated. 



---
## Field Configuration.CacheLocation.Downstream

 The output cache can be stored in any HTTP 1.1 cache-capable devices other than the origin server. This includes proxy servers and the client that made the request. 



---
## Field Configuration.CacheLocation.Server

 The output cache is located on the Web server where the request was processed. 

**Not currently supported by Padarn.**

---
## Field Configuration.CacheLocation.None

 The output cache is disabled for the requested page. 



---
## Field Configuration.CacheLocation.ServerAndClient

 The output cache can be stored only at the origin server or at the requesting client. Proxy servers are not allowed to cache the response. 

**Not currently supported by Padarn.**

---


