
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase encargada de imprimir recipes por consola, implementa la interfaz IPrinter. Asi como esta, podriamos tener 
    /// más clases que implementen la interfaz y asi poder tener varios tipos de impresión disponibles.
    /// 
    /// Por otro lado, es una clase que cumple con SRP, ya que tiene una única responsabilidad que es
    /// imprimir recipes, asi como también tiene una única razón para cambiar.
    /// </summary>
    public class ConsolePrinter: IPrinter
    {
        public ConsolePrinter()
        {
        }

        public void PrintRecipe(Recipe recipe)
        {
            System.Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}