using NUnit.Framework;
using Mid;
[TestFixture]
public class Program
{
    [Test]
    public void PPICalculate_inputWidth34andHeight68andDiagnal9_OutputValuePPI()
    {

        int width, height, diagnal;
        // Arrange
        width = 34;
        height = 68;
        diagnal = 9;

        // Act
        
       
        Dictionary<string, double> result = PixelCalc.PixelCalcFunction(height, width, diagnal);

        // Assert
        Assert.AreEqual(8.447367914999205, result["PPI"]);

    }
}