//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /*
            Modificamos el método PrintRecipe y lo convertimos en GetTextToPrint, que en lugar de ya imprimir los datos de la Recipe, los retorna en un string.
            De esta manera podemos utilizar ese string para imprimirlo por distintos medios sin necesidad de modificar este método. De esta manera reducimos las
            razones de cambio de la clase como nos sugiere el principio SRP.
        */
        public string GetTextToPrint()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"Receta de {this.FinalProduct.Description}: \n");
            foreach (Step step in this.steps)
            {
                str.Append(step.GetTextToPrint());
            }
            return str.ToString();
        }
    }
}