
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Interfaz para que implementen las clases que quieran imprimir recipes, con esta interfaz generamos una abstracción
    /// que nos permite utilizar polimorfismo e implementar distintos tipos de impresión, lo que hace que nuestro programa
    /// quede abierto a la extensión, como nos sugiere el principio OCP.
    /// 
    /// Ademas esta interfaz nos deja preparados para cumplir con el principio DIP, ya que si en un futuro tuvieramos clases
    /// que necesitaran depender de una Printer, podrían depender de esta abstracción en lugar de depender de una clase específica.
    /// 
    /// Por otro lado, IPrinter cumple con el principio ISP, ya que no existe una implementación de la interfaz que no utilice 
    /// la responsabilidad definida en esta.
    /// </summary>
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}