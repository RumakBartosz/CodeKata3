using System;
using Kata3.Kata4Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata4Tests
{
    [TestClass]
    public class DataLoaderTests
    {
        [TestMethod]
        public void TestLoadDataToStringWhenLoaded()
        {
            //Arrange
            DataLoader MockDataLoader = new DataLoader(@"C:\Users\mion\Source\Repos\Kata3\weather.dat");
            String[] TemporaryFileHolder;

            //Act
            TemporaryFileHolder = MockDataLoader.LoadFileToStringAndTokenize();

            //Assert
            Assert.AreNotEqual("", TemporaryFileHolder);
        }

        [TestMethod]
        public void TestLoadDataToString()
        {
            //Arrange
            DataLoader MockClass = new DataLoader(@"C:\Users\mion\Source\Repos\Kata3\weather.dat");
            String[] TemporaryFileHolder;

            //Act
            TemporaryFileHolder = MockClass.LoadFileToStringAndTokenize();

            //Assert
            Assert.AreEqual('D', TemporaryFileHolder[0][2]);
        }
    }

    [TestClass]
    public class LowestChangeTests
    {
        [TestMethod]
        public void TestLowestChangeMainMethod()
        {
            //Arrange
            DataLoader MockDataLoader = new DataLoader(@"C:\Users\mion\Source\Repos\Kata3\weather.dat");
            LowestChange MockLowestChange = new LowestChange();
            String[] TemporaryFileHolder;
            int GetLowestIndexValue;

            //Act
            TemporaryFileHolder = MockDataLoader.LoadFileToStringAndTokenize();
            GetLowestIndexValue = MockLowestChange.GetLowestChange(TemporaryFileHolder);


            //Assert
            Assert.AreEqual(2, GetLowestIndexValue);
        }
    }

    [TestClass]
    public class FootbalTeamsTests
    {

        [TestMethod]
        public void TestLoadDataToString()
        {
            //Arrange
            DataLoader MockClass = new DataLoader(@"C:\Users\mion\Source\Repos\Kata3\football.dat");
            String[] TemporaryFileHolder;

            //Act
            TemporaryFileHolder = MockClass.LoadFileToStringAndTokenize();

            //Assert
            Assert.AreEqual("       Team            P     W    L   D    F      A     Pts", TemporaryFileHolder[0]);
        }

        [TestMethod]
        public void TestFootbalTeams()
        {
            //Arrange
            DataLoader MockDataLoader = new DataLoader(@"C:\Users\mion\Source\Repos\Kata3\football.dat");
            FootbalTeams MockFootbalTeams = new FootbalTeams();
            String[] TemporaryFileHolder;
            int GetLowestIndexValue;

            //Act
            TemporaryFileHolder = MockDataLoader.LoadFileToStringAndTokenize();
            GetLowestIndexValue = MockFootbalTeams.GetLowestChange(TemporaryFileHolder);


            //Assert
            Assert.AreEqual(1, GetLowestIndexValue);
        }
    }

    [TestClass]
    public class DRYFusionTests
    {
        [TestMethod]
        public void TestDRYFusion()
        {
            //Arrange
            DataLoader MockDataLoader = new DataLoader(@"C:\Users\mion\Source\Repos\Kata3\football.dat");
            DRYFusion MockDRYFusion = new DRYFusion();
            String[] TemporaryFileHolder;
            int GetLowestIndexValue;

            //Act
            TemporaryFileHolder = MockDataLoader.LoadFileToStringAndTokenize();
            GetLowestIndexValue = MockDRYFusion.GetLowestChange(TemporaryFileHolder, "football");


            //Assert
            Assert.AreEqual(1, GetLowestIndexValue);
        }
    }
}
