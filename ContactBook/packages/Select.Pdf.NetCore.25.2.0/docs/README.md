# SelectPdf PDF Library for .NET Core / .NET 8 with Html To Pdf Converter

[![SelectPdf](https://avatars.githubusercontent.com/u/11090785?v=4)](https://selectpdf.com)

SelectPdf for .NET is a professional **PDF library** that can be used for creating, writing, editing, handling and reading PDF files 
without any external dependencies within .NET applications. Using this .NET PDF library, you can implement rich capabilities to create PDF files from scratch 
or process existing PDF documents entirely through C#/VB.NET without installing Adobe Acrobat.

Many rich features can be supported by the .NET PDF API, such as security setting (including digital signatures), PDF merge/split, text, 
html and image drawing into pdf and many more. Besides, SelectPdf for .NET component can be used to easily convert **HTML to PDF** with C#/VB.NET in high quality. 
SelectPdf can also extract text from existing PDF documents or search for text in PDF documents and can convert PDF pages to raster images (PNG, BMP, JPEG, TIFF).

This is a package for **.NET 8**, .NET 7, .NET 6, .NET 5, **.NET Core**, .NET 4.7.2, .NET 4.6.1.
SelectPdf only works on Windows. SelectPdf works on Azure cloud, including Azure Web Apps (Basic plan or above) with some limitations.


## Main Features

### General Features

* Support for .NET Framework and .NET Core on Windows systems
* Generate PDF documents from scratch
* Load and modify existing PDF documents
* Set PDF document properties
* Set PDF document viewer preferences
* Set pdf page settings (size, orientation, margins)
* Set PDF document security settings (user password, permissions)
* Support for a large variety of pdf elements: text, image, html, shapes, links, bookmarks, etc
* Pdf templates to repeat elements in all pages of the generated PDF document
* Custom headers and footers for the generated pdf document
* Watermarks and stamps
* Support for page numbering
* Merge pdf documents
* Split pdf documents
* Extract pages from existing pdf documents
* Digital signatures
* Compressed pdf documents
* Support for pdf open actions (open to a specific page, execute javascript)
* Modify color space
* Support for PDF/A, PDF/X standards
* Advanced security settings (RC4 or AES encryption algorithms, up to 256 bits encryption keys)
* Form filling
* PDF portfolios management
* Resize/scale existing PDF content
 
### Html to Pdf Converter Features

* Convert any web page to pdf
* Convert any raw html string to pdf
* Set pdf page settings (page size, page orientation, page margins)
* Resize content during conversion to fit the pdf page
* Set pdf document properties
* Set pdf viewer preferences
* Set pdf security (passwords, permissions)
* Convert multiple web pages into the same pdf document
* Set conversion delay and web page navigation timeout
* Custom headers and footers
* Support for html in headers and footers
* Possibility to have different headers and footers for specific pages
* Automatic and manual page breaks
* Repeat html table headers on each page
* Support for @media types screen and print
* Support for internal and external links
* Generate bookmarks automatically based on html elements
* Support for HTTP headers
* Support for HTTP cookies
* Support for HTTP POST parameters
* Possibility to manually start the html to pdf conversion from Javascript
* Support for web pages that require authentication
* Support for proxy servers
* Possibility to convert only a section of a web page to pdf
* Possibility to exclude certain html elements from conversion
* Enable/disable javascript
* Modify color space
* Support for PDF/A, PDF/X standards
* Multithreading support
* HTML5/CSS3 support
* Web fonts support

### Html to Image Converter Features

* Convert any web page to image
* Convert any raw html string to image

### Pdf To Text Converter Features

* Extract Text from PDF
* Extract text at specific coordinates
* Search for Text in PDF

### Pdf To Image Converter Features

* Convert PDF Pages to Images

## Documentation and Samples

Online demo MVC C#: [https://selectpdf.com/demo-mvc/](https://selectpdf.com/demo-mvc/)\
Online demo MVC Vb.Net: [https://selectpdf.com/demo-mvc-vb/](https://selectpdf.com/demo-mvc-vb/)\
Online documentation: [https://selectpdf.com/pdf-library/](https://selectpdf.com/pdf-library/)


SelectPdf is very easy to use. For example, the following code will create a pdf document with a simple text in it:

```csharp
    SelectPdf.PdfDocument doc = new SelectPdf.PdfDocument();
    SelectPdf.PdfPage page = doc.AddPage();

    SelectPdf.PdfFont font = doc.AddFont(SelectPdf.PdfStandardFont.Helvetica);
    font.Size = 20;

    SelectPdf.PdfTextElement text = new SelectPdf.PdfTextElement(50, 50, "Hello world!", font);
    page.Add(text);

    doc.Save("test.pdf");
    doc.Close();
```


With SelectPdf is also very easy to convert any web page to a pdf document. The code is as simple as this:

```csharp
    SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
    SelectPdf.PdfDocument doc = converter.ConvertUrl("https://selectpdf.com");
    doc.Save("test.pdf");
    doc.Close();
```

## Installation troubleshooting

When SelectPdf is installed into your project, a reference to Select.Pdf.dll is created. 
Besides this assembly, several additional files are needed by SelectPdf:
* Select.Html.dep (required when the Webkit rendering engine is used for html to pdf conversions)
* Select.Tools.dep (required for pdf to text and pdf to image conversions)
* Chromium-124.0.6367.201 folder (required when the Blink rendering engine is used for html to pdf conversions) - if this is needed, 
install the [Select.Pdf.NetCore.Blink Nuget package](https://www.nuget.org/packages/Select.Pdf.NetCore.Blink).


If you are using a newer NuGet client (newer Visual Studio - 2017+) and a newer project type that uses PackageReference, 
these files are automatically copied to your project.
If you are using older Visual Studio versions or older project types, these files will not be copied automatically to your project.
\
IMPORTANT: If you do not see these files into your project, you need to manually copy them from the packages folder located next to your solution. 
You will find them in \packages\Select.Pdf.NetCore.25.2.0\contentFiles\any\any\ folder. 
Copy all the files into your project bin folder (\bin\Release, \bin\Debug), next to SelectPdf library main assembly - Select.Pdf.dll.

IMPORTANT: To have these files included when you publish or deploy your application, set in Visual Studio:
* Build Action: Content
* Copy to Output Directory: Copy if newer


For complete product information, take a look at [SelectPdf](https://selectpdf.com) website.
