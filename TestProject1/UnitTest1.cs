using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using WebApiGIT.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        ValuesController controller;
        public UnitTest1()
        {
            controller = new ValuesController();
        }
        [Fact]
        [Category("ValueCtrl")]
        public void TestToday()
        {
            IActionResult result =controller.Get();
            var dt = result as OkObjectResult;
            Assert.IsType<DateTime>(dt.Value);
        }

        [Fact]
        [Category("ValueCtrl")]
        public void ColorsTest()
        {
            string[] ary;
            IActionResult result = controller.Colors();
            var dt = result as OkObjectResult;
            Assert.IsType<string[]>(dt.Value);
            ary = (string[])dt.Value;

            Assert.Equal(ary.Length, 3);
        }
        [Fact]
        [Category("ValueCtrl")]
        public void Seasons()
        {
            IActionResult result = controller.Seasons();
            var dt = result as OkObjectResult;
            Assert.NotNull(dt.Value);
        }
    }
}