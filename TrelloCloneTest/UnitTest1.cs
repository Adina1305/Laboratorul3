using TrelloClone.Services;

namespace TrelloCloneTest
{
     [TestClass]
     public class UnitTest1
     {
          private readonly TestService _testService = new();

          [TestMethod]
          public void AddNotNullCard_ShouldReturnTrue()
          {
               var result = _testService.AddCard(new TrelloClone.Models.Card()
               {
                    Id = 5,
                    Column = new TrelloClone.Models.Column() { },
                    Contents = "123",
                    ColumnId = 4

               });
               Assert.IsTrue(result);
          }

          [TestMethod]
          public void GetById_ValidItem_ShouldBeNotNull()
          {
               _testService.AddCard(new TrelloClone.Models.Card()
               {
                    Id = 6,
                    Column = new TrelloClone.Models.Column() { },
                    Contents = "123",
                    ColumnId = 4

               });
               var result = _testService.GetCartById(6);
               Assert.IsNotNull(result);
          }

          [TestMethod]
          public void DeleteAnItem_ShouldReturn_True()
          {
               _testService.AddCard(new TrelloClone.Models.Card()
               {
                    Id = 7,
                    Column = new TrelloClone.Models.Column() { },
                    Contents = "123",
                    ColumnId = 4

               });
               var result = _testService.DeleteCart(7);
               Assert.IsTrue(result);
          }
     }
}