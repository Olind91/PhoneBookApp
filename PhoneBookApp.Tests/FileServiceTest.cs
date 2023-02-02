using PhoneBookApp.Services;
using Newtonsoft.Json;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Tests
{
    public class FileServiceTest
    {
        FileService fileService;
        string content; public FileServiceTest()
        {
            
            fileService = new FileService();
            fileService.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\contentTest.json";
            content = JsonConvert.SerializeObject(new{ FirstName = "Axel", LastName = "Skägglund", Email = "Axel@internet.com", PhoneNumber = "09738979", City = "Örebro" });
        }
        [Fact]
        public void Should_Create_a_File_With_Json_Content()
        {
            
            fileService.Save(fileService.FilePath, content);
            string result = fileService.Read(fileService.FilePath);             
            
            
            Assert.True(File.Exists(fileService.FilePath));
            Assert.Equal(result.Trim(), content);
        }
    }
}