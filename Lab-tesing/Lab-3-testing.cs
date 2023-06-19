using lab03_evaluating_C__competancy;
namespace Lab_tesing

{
    public class UnitTest1
    {
        [Theory]
        [InlineData("5 5 5", 125)]
        [InlineData("5 5 5 0", 125)]
        [InlineData("2 3", 0)]
        [InlineData("-2 3 -2", 12)]
        public void TestThreeNumProduct(string input, int expected)
        {
            //Arrange
            var inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            //act
            int result = Program.ThreeNumProduct();

            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("3\n1\n2\n3", 2)]
        [InlineData("10\n1\n2\n3\n4\n6\n5\n7\n8\n9\n10", 5)]
        [InlineData("2\n1\n2", 1)]
        [InlineData("3\n0\n0\n0", 0)]
        public void CalculateAvgTest(string input, int expected)
        {
            //Arrange
            var inputReader = new StringReader(input);
            Console.SetIn(inputReader);

            //Act
            int result = Program.CalculateAvg();

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 5, 1, 67, 2, 7, 4, 4, 5, 2, 5, 8, 9, 5 }, 5)]
        [InlineData(new int[] { 1, 5, 7, 95, 4, 3, 2, 1 }, 1)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1)]
        public void MostFrequentTest(int[] input, int expected)
        {
            //arrange dont in input
            //act
            int result = Program.MostFrequentNumber(input);
            //assert
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(new int[] { -5, -235, -4, -1, -4567, -6 }, -1)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1 }, 1)]
        public void MaxValueTest(int[] input, int expected)
        {
            //arrange dont is input
            //act
            int result = Program.MaxValue(input);
            //assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("its a me mario", new string[] { "[\"its: 3\",", "\"a: 1\",", "\"me: 2\",", "\"mario: 5\",]" })]
        [InlineData("YOU SHALL NOT PASS", new string[] { "[\"YOU: 3\",", "\"SHALL: 5\",", "\"NOT: 3\",", "\"PASS: 4\",]" })]
        [InlineData("spooky scary skeletons", new string[] { "[\"spooky: 6\",", "\"scary: 5\",", "\"skeletons: 9\",]" })]

        public void WordLengthArrayTest(string input, string[] expected)
        {
            // Arrange
            Console.SetIn(new StringReader(input));

            // Act
            string[] result = Program.WordLengthArray();

            // Assert
            Assert.Equal(expected, result);
        }


    }

}