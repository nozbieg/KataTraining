using System;
using System.Linq;
using KataTraining.GetReadableTimeKata;

namespace KataTrainingTest.GetReadableTime
{
    public class GetReadableTimeKataTest
    {
        [Fact]
        public void HumanReadableTest()
        {
            "00:00:00".Should().Be(TimeFormat.GetReadableTime(0));
            "00:00:05".Should().Be(TimeFormat.GetReadableTime(5));
            "00:01:00".Should().Be(TimeFormat.GetReadableTime(60));
            "23:59:59".Should().Be(TimeFormat.GetReadableTime(86399));
            "99:59:59".Should().Be(TimeFormat.GetReadableTime(359999));
        }
    }
}
