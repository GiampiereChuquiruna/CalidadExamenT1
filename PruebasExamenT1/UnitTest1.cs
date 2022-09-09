using CalidadT1;

namespace PruebasExamenT1
{
    public class Tests
    {

        [Test]
        public void GeneradorRomanoCaso01()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(100);
            Assert.AreEqual("C", result);
        }
        [Test]
        public void GeneradorRomanoCaso02()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(500);
            Assert.AreEqual("D", result);
        }
        [Test]
        public void GeneradorRomanoCaso03()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(1);
            Assert.AreEqual("I", result);
        }
        [Test]
        public void GeneradorRomanoCaso04()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(3);
            Assert.AreEqual("III", result);
        }
        [Test]
        public void GeneradorRomanoCaso05()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(5);
            Assert.AreEqual("V", result);
        }
        [Test]
        public void GeneradorRomanoCaso06()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(8);
            Assert.AreEqual("VIII", result);
        }
        [Test]
        public void GeneradorRomanoCaso07()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(15);
            Assert.AreEqual("XV", result);
        }
        [Test]
        public void GeneradorRomanoCaso08()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(26);
            Assert.AreEqual("XXVI", result);
        }
        [Test]
        public void GeneradorRomanoCaso09()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(30);
            Assert.AreEqual("XXX", result);
        }
        [Test]
        public void GeneradorRomanoCaso10()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(45);
            Assert.AreEqual("XXXXV", result);
        }
        [Test]
        public void GeneradorRomanoCaso11()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(50);
            Assert.AreEqual("L", result);
        }
        [Test]
        public void GeneradorRomanoCaso12()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(55);
            Assert.AreEqual("LV", result);
        }
        [Test]
        public void GeneradorRomanoCaso13()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(72);
            Assert.AreEqual("LXXII", result);
        }
        [Test]
        public void GeneradorRomanoCaso14()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(85);
            Assert.AreEqual("LXXXV", result);
        }
        [Test]
        public void GeneradorRomanoCaso15()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(90);
            Assert.AreEqual("LXXXX", result);
        }
        [Test]
        public void GeneradorRomanoCaso16()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(110);
            Assert.AreEqual("CX", result);
        }
        [Test]
        public void GeneradorRomanoCaso17()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(150);
            Assert.AreEqual("CL", result);
        }
        [Test]
        public void GeneradorRomanoCaso18()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(200);
            Assert.AreEqual("CC", result);
        }
        [Test]
        public void GeneradorRomanoCaso19()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(270);
            Assert.AreEqual("CCLXX", result);
        }
        [Test]
        public void GeneradorRomanoCaso20()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(300);
            Assert.AreEqual("CCC", result);
        }
        [Test]
        public void GeneradorRomanoCaso21()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(445);
            Assert.AreEqual("CCCCXXXXV", result);
        }
        [Test]
        public void GeneradorRomanoCaso22()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(550);
            Assert.AreEqual("DL", result);
        }
        [Test]
        public void GeneradorRomanoCaso23()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(602);
            Assert.AreEqual("DCII", result);
        }
        [Test]
        public void GeneradorRomanoCaso24()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(800);
            Assert.AreEqual("DCCC", result);
        }
        [Test]
        public void GeneradorRomanoCaso25()
        {
            var numero = new RomanoGenerator();
            var result = numero.GetRomano(990);
            Assert.AreEqual("DCCCCLXXXX", result);
        }

    }
}