
Thank you for using SelectPdf for .NET Standard 2.0 (.NET Core 2.0, .NET Framework 4.6.1 or .NET Framework 4.7.2). This also works for .NET 5, .NET 6.

Online demo C#: https://selectpdf.com/demo-mvc/
Online documentation: https://selectpdf.com/pdf-library/


Select.Pdf is very easy to use. For example, the following code will create a pdf document with a simple text in it:

            SelectPdf.PdfDocument doc = new SelectPdf.PdfDocument();
            SelectPdf.PdfPage page = doc.AddPage();

            SelectPdf.PdfFont font = doc.AddFont(SelectPdf.PdfStandardFont.Helvetica);
            font.Size = 20;

            SelectPdf.PdfTextElement text = new SelectPdf.PdfTextElement(50, 50, "Hello world!", font);
            page.Add(text);

            doc.Save("test.pdf");
            doc.Close();


With SelectPdf is also very easy to convert any web page to a pdf document. The code is as simple as this:

            SelectPdf.HtmlToPdf converter = new SelectPdf.HtmlToPdf();
            SelectPdf.PdfDocument doc = converter.ConvertUrl("https://selectpdf.com");
            doc.Save("test.pdf");
            doc.Close();


Installation troubleshooting
============================

When SelectPdf is installed into your project, a reference to Select.Pdf.dll is created. Besides this assembly, several additional files are needed by SelectPdf:
- Select.Html.dep (required when the Webkit rendering engine is used for html to pdf conversions)
- Select.Tools.dep
- Chromium-124.0.6367.201 folder (required when the Blink rendering engine is used for html to pdf conversions) - if this is needed, install the Select.Pdf.NetCore.Blink Nuget package.


If you are using a newer NuGet client (newer Visual Studio - 2017+) and a newer project type that uses PackageReference, these files are automatically copied to your project.
If you are using older Visual Studio versions or older project types, these files will not be copied automatically to your project.

IMPORTANT: If you do not see these files into your project, you need to manually copy them from the packages folder located next to your solution. 
You will find them in \packages\Select.Pdf.NetCore.25.2.0\contentFiles\any\any\ folder. Copy all the files into your project bin folder (\bin\Release, \bin\Debug), next to SelectPdf library main assembly - Select.Pdf.dll.

IMPORTANT: To have these files included when you publish or deploy your application, set in Visual Studio:
- Build Action: Content
- Copy to Output Directory: Copy if newer


For complete product information, take a look at https://selectpdf.com.
For support, contact us at support@selectpdf.com.
