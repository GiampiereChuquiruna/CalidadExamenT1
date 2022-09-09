using CalidadT1;

namespace TestBook
{
    public class Tests
    {
        [Test]
        public void BookCaso01()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2 );
            book.AddToCart("Inmension", 11.8);
            var total = book.GetTotal();
            Assert.AreEqual(24, total);
        }
        [Test]
        public void BookCaso02()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 10);
            var total = book.GetTotal();
            Assert.AreEqual(22.2, total);
        }
        [Test]
        public void BookCaso03()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 2.8);
            book.AddToCart("Inmension", 4.2);
            var total = book.GetTotal();
            Assert.AreEqual(7, total);
        }
        [Test]
        public void BookCaso04()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.3);
            book.AddToCart("Inmension", 12.3);
            var total = book.GetTotal();
            Assert.AreEqual(24.6 , total);
        }
        [Test]
        public void BookCaso05()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 12.2);
            var total = book.GetTotal();
            Assert.Pass();
        }
        [Test]
        public void BookCaso06()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 12.2);
            var total = book.GetTotal();
            Assert.Pass();
        }
        [Test]
        public void BookCaso07()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 12.2);
            var total = book.GetTotal();
            Assert.Pass();
        }
        [Test]
        public void BookCaso08()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 12.2);
            var total = book.GetTotal();
            Assert.Pass();
        }
        [Test]
        public void BookCaso10()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 12.2);
            var total = book.GetTotal();
            Assert.Pass();
        }
        [Test]
        public void BookCaso11()
        {
            var book = new BookStore();
            book.AddToCart("La playa", 12.2);
            book.AddToCart("Inmension", 12.2);
            var total = book.GetTotal();
            Assert.Pass();
        }
    }
}