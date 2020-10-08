using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.FileProviders;
using Scriban;
using TrxToHtml.Models;

namespace TrxToHtml
{
    public class HtmlBuilder
    {
        public Options Options { get; }

        public HtmlBuilder(Options options)
        {
            Options = options;
        }

        public string GetEmbeddedTemplate(string filename = "Template.html")
        {
            var embeddedProvider = new EmbeddedFileProvider(Assembly.GetExecutingAssembly());
            var embeddedFile = embeddedProvider.GetFileInfo(filename);
            using var stream = embeddedFile.CreateReadStream();
            using var reader = new StreamReader(stream, Encoding.UTF8);
            return reader.ReadToEnd();
        }

        public string GetExternalTemplate()
        {
            var filePath = Path.GetFullPath(Options.TemplateFile, Directory.GetCurrentDirectory());
            using var stream = File.OpenRead(filePath);
            using var reader = new StreamReader(stream, Encoding.UTF8);
            return reader.ReadToEnd();
        }

        public string GetHtml(List<TestRun> testRuns)
        {
            var textTemplate = Options.TemplateFile == null ? GetEmbeddedTemplate() : GetExternalTemplate();
            return ParseHtml(testRuns, textTemplate);
        }

        public string ParseHtml(List<TestRun> testRuns, string textTemplate)
        {
            var template = Template.Parse(textTemplate);
            return template.Render(new { TestRuns = testRuns }, member => member.Name);
        }
    }
}
