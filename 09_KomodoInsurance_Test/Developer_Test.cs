using _09_KomodoInsurance__Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _09_KomodoInsurance_Test
{
    [TestClass]
    public class Developer_Test

    {
        private DeveloperRepo _repo;
        private Developer _content;


        [TestInitialize]
        public void Arrange()
        {
            _repo = new DeveloperRepo();
            _content = new Developer("Mark AramStrong", 103, false);

            _repo.AddDeveloperToList(_content);


        }



        [TestMethod]
        public void SAddToList_ShouldGetNotNull()
        {
            Developer content = new Developer();
            content.Name = "Komodo";
            DeveloperRepo repository = new DeveloperRepo();



            //Act  Get/run the code we want to test
            repository.AddDeveloperToList(content);
            Developer contentFromDirectory = repository.GetDeveloperByName("Komodo");




            //Assert
            Assert.IsNotNull(contentFromDirectory);
        }



        //Update
        [TestMethod]
        public void UpodateExisitingDeveloper_ShouldReturnTrue()
        {
            //Arrange
            //TestInitialize
            Developer newContent = new Developer ("Mark Armstrong", 103, false);



            // Act
           // bool updateResult = _repo.UpdateExistingDeveloper("Mark Armstrong", newContent);

            // Assert

           // Assert.IsTrue(updateResult);



        }

        [DataTestMethod]
        [DataRow("Mark Armstrong", true)]
        [DataRow("Komodo", false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalTitle, bool shouldUpdate)
        {
            //Arrange
            //TestInitialize
            
            Developer newContent = new Developer("Mark Armstrong", 103, false);


            // Act


            // Act
            bool updateResult = _repo.UpdateExistingContent(originalTitle, newContent);

            // Assert

            Assert.AreEqual(shouldUpdate, updateResult);
        }


        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            //Arrange

            //Act
            bool deleteResult = _repo.RemoveDeveloperFromList(_content.Name);

            //Asser
            Assert.IsTrue(deleteResult);

        }

    }


    
}
