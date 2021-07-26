using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApi;
using WebApi.Controllers;

namespace NUnitTestProject1
{
    public class webapi
    {

        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void Get()
        {
            WeatherForecastController controller = new WeatherForecastController(null);
            IEnumerable<WeatherForecast> result = controller.Get();
            Assert.AreEqual(result.ToList().Count, 10);//注意这里不能对比JSON格式的数据
        }
    }
}
