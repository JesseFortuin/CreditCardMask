namespace CreditCardMask.Test
{
    public class MaskingDetailsTest
    {
        [Theory]
        [InlineData("4556364607935616", "############5616")]
        [InlineData("64607935616", "#######5616")]
        [InlineData("1", "1")]
        [InlineData("", "")]
        [InlineData("Skippy", "##ippy")]
        [InlineData("Nananananananananananananananana Batman!", "####################################man!")]

        public void MaskifyTest(string input, string expected)
        {
            //arrange
            IMaskingDetails mask = new MaskingDetails();


            //act
            string actual = mask.Maskify(input);


            //assert
            Assert.Equal(expected, actual);
        }
    }
}