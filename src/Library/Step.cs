//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        /*
            Añadimos este método basandonos en Expert ya que la clase Step es la experta en la información
            necesaria para ejecutar la operación, y también en SRP, para que la clase Recipe no
            tuviera la responsabilidad de obtener el texto a imprimir del Step, sino que fuera el Step
            quien se encargue de proporcionar su texto. De esta manera evitamos cargar a Recipe con
            una responsabilidad más, y a su vez con una razón de cambio más.
        */
        public string GetTextToPrint()
        {
            return $"{this.Quantity} de '{this.Input.Description}' " +
                $"usando '{this.Equipment.Description}' durante {this.Time} \n";
        }
    }
}