using System.Collections.Generic;
using System.Linq;
using TrelloClone.Models;

namespace TrelloClone.Services
{
    public class TestService
    {
          public List<Card> Cards = new List<Card>();

          public bool AddCard(Card card)
          {
               if (card != null)
               {
                    Cards.Add(card);
               }
               return card != null;
          }
          public bool DeleteCart(int id)
          {
               var deletableItem = Cards.Where(c => c.Id == id).First();
               if (deletableItem != null)
               {
                    Cards.Remove(deletableItem);
               }
               return deletableItem != null;
          }
          public Card GetCartById(int id)
          {
               var result = Cards.Find(x => x.Id == id);
               if (result != null)
               {
                    return result;
               }
               return null;
          }
    }
}
